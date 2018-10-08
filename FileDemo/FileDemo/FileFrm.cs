using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FileDemo
{
    public partial class FileFrm : Form
    {
        public FileFrm()
        {
            InitializeComponent();

            //选择路径事件
            btnPath.Click += BtnPath_Click;
            //清理文件
            btnCLear.Click += BtnCLear_Click;
        }

        //清理文件
        private void BtnCLear_Click(object sender, EventArgs e)
        {
            DirectoryInfo dInfo = new DirectoryInfo(txtPath.Text);
            if (!dInfo.Exists) return;
            //deleteInfo(dInfo,txtFliter.Text);
            readFilePath(dInfo, txtFliter.Text);
            MessageBox.Show("删除完成！");
        }

        //遍历文件
        public void deleteInfo(DirectoryInfo dInfo , string fliter)
        {
            var fliters = fliter.Replace("，",",").Split(',');
            foreach(var file in dInfo.GetFiles())
            {
                foreach(var temp in fliters)
                {
                    int len1 = file.Name.Length;
                    int len2 = temp.Length;
                    if (len1>len2 && temp.Equals(file.Name.Substring(len1 - len2 , len2)))
                    {
                        if(file.Exists)
                            file.Delete();
                    }
                }
            }

            foreach(var dir in dInfo.GetDirectories())
            {
                deleteInfo(dir, fliter);
                if (chkEmptyFolder.Checked && dir.GetFiles().Length == 0 && dir.GetDirectories().Length == 0)
                    dir.Delete();
            }

        }

        //遍历文件--并输出所有子文件--添加程序集用
        public void readFilePath(DirectoryInfo dInfo, string fliter)
        {
            var fliters = fliter.Replace("，", ",").Split(',');
            string strStar = "gacutil -i ";
            string path = "";
            foreach (var file in dInfo.GetFiles())
            {
                path += strStar + file.FullName + Environment.NewLine;
            }

        }

        //选择路径事件
        private void BtnPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            folderBrowserDialog.Description = "打开要操作的文件夹";
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}
