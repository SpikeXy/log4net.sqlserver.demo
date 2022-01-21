# log4net.sqlserver.demo
log4net connection sqlserver demo

环境：net.core 3.1,win10

参考文档：
[https://github.com/microknights/Log4NetAdoNetAppender](https://github.com/microknights/Log4NetAdoNetAppender)

### 安装Microsoft.Data.SqlClient

### 找到Microsoft.Data.SqlClient.dll的PublicKeyToken，用dnspy

<connectionType value="Microsoft.Data.SqlClient.SqlConnection, Microsoft.Data.SqlClient,Version=4.0.0.0,Culture=neutral,PublicKeyToken=23ec7fc2d6eaa4a5" />   

修改log4net.config中的配置即可

## 遇到的问题 


#### sqlserver ssl证书 不是受信任机构颁发的

``` bash
Encrypt=false;TrustServerCertificate=false;  连接字符串加上这个
```
#### 如何设置证书
虽然设置了，重启了，但是没有生效，不清楚原因，sqlserver 在本机，测试环境也在本机
[连接到远程服务器时，从远程服务器收到的证书由不受信任的证书颁发机构错误SQL Server](https://docs.microsoft.com/zh-cn/troubleshoot/sql/connect/error-message-when-you-connect)

