# 编译成DLL文件
csc -target:library -out:myLibrary.dll Add.cs Mult.cs
# 编译成exe文件
csc -target:exe -out:MyClient.exe -R:myLibrary.dll MyClient.cs
# 运行
.\MyClient.exe