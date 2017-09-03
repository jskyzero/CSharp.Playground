# C Sharp概览
> C#是微软推出的一种基于.NET框架的、面向对象的高级编程语言。C#的发音为“C sharp”，C#由C语言和C++派生而来，继承了其强大的性能，同时又以.NET框架类库作为基础，拥有类似Visual Basic的快速开发能力。

+ 语言本身深受Visual Basic、Java、C和C++ 的影响。
+ C#旨在设计成为一种“简单、现代、通用”，以及面向对象的程序设计语言

## .NET Framework 平台体系结构
> C# 是 .Net 框架的一部分，且用于编写 .Net 应用程序。因而我们可能需要先了解下 .NET

.NET框架是以一种采用系统虚拟机运行的编程平台，以通用语言运行库（Common Language Runtime）为基础，支持多种语言的开发。.NET Framework 包括一个称为公共语言运行时（CLR）的虚拟执行系统和统一的类库，CLR是微软对Common Language Infrastructure（CLI）的实现.通用语言基础架构（Common Language Infrastructure，简称CLI）定义了一个语言无关的跨体系结构的运行环境，这使得开发者可以用规范内定义的各种高级语言来开发软件，并且无需修正即可将软件运行在不同的计算机体系结构上。

1. C#源代码被编译成符合CLI规范的中间语言（IL），IL代码与资源文件一起作为程序集文件存为.{exe|dll}文件。
2. 执行C#程序时候，程序集被加载到CLR中，如果符合安全要求，则CLR执行实时（JIT）编译将IL代码转化为本机机器指令，CLR还提供自动垃圾回收，异常处理和资源管理有关的其他服务。

## Hardwork

+ 自己编译运行HelloWorld.cs，关于编译相关可以[参考](https://docs.microsoft.com/zh-cn/dotnet/csharp/language-reference/compiler-options/index)中间示例都给的很详细。在教程中也有涉及到，总之用上的时候再具体来学参数可能会比较有效率。记得学习编译成DLL文件和在编译中使用自己的DLL文件的基本套路。

+ 语法程序相关，请参考最下面的参考随意跟着一个教程跟着做完，如果有其他语言的经验的话，学习来不会难，注意把一些特异性的语法比如什么索引器/委托/事件学一下。

+ dotnet相关，请参考dotnet相关文档自行学习，不过还是请注意把握好dotnet和C#语言的关系，不要花太多时间在其上。

## Reference 

[Wikipedia C#](https://zh.wikipedia.org/wiki/C%E2%99%AF)

[MSDN C# 教程](https://msdn.microsoft.com/zh-cn/library/aa288463(v=vs.71).aspx)

[RUNOOB C# 教程](http://www.runoob.com/csharp/csharp-tutorial.html)

