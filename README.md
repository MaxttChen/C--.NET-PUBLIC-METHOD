# C-.NET-PUBLIC-METHOD
C#/.NET的一些代码;方便以后直接引用;不用重复写.

***

1.DAO层

2.EXCEL操作;读取EXCEL文件表
需要引用
```
using Excel = Microsoft.Office.Interop.Excel;
```
在VS上,右键项目--引用--COM上搜索EXCEL 选择 Mircosoft Excel xxx;
如果没有该文件,可能电脑是因为没有安装EXCEL的原因

3.在VS中，远程同步GIT的操作。
在仓库目录下执行
git pull origin master --allow-unrelated-histories
之后就可以成功的pull，push了
