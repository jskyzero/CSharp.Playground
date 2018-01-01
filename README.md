# C#-Study
`jskyzero` `2017/12/31`
## Overview
+ C#是微软推出的一种基于.NET框架的、面向对象的高级编程语言。
+ 语言本身深受Visual Basic、Java、C和C++ 的影响。
+ C#旨在设计成为一种“简单、现代、通用”，以及面向对象的程序设计语言
+ C# 是 .Net 框架的一部分，且用于编写 .Net 应用程序。因而我们可能需要先了解下 .NET

![.NET 体系结构组件](https://docs.microsoft.com/zh-cn/dotnet/standard/media/components.png)

[.NET框架](https://docs.microsoft.com/zh-cn/dotnet/standard/components)是以通用语言运行库为基础，支持多种语言。.NET框架包括称为公共语言运行时（CLR）的虚拟执行系统和统一的类库，CLR是微软对通用语言基础架构（CLI）的实现.Common Language Infrastructure定义了一个语言无关的跨体系结构的运行环境。

1. C#源代码被编译成符合CLI规范的中间语言（IL），IL代码与资源文件一起作为程序集文件存为.{exe|dll}文件。
2. 执行C#程序时候，程序集被加载到CLR中，如果符合安全要求，则CLR执行实时（JIT）编译将IL代码转化为本机机器指令，CLR还提供自动垃圾回收，异常处理和资源管理有关的其他服务。

## Structure
```
.
├── docs              //documents
├── hardwork
│   ├── hardway       // practice code
│   └── runoob        // runoob practice code
├── projects
│   └── todolist      // A simpile todolist
└── README.md
```

## Naming Style

+ Namespace : Pascal Case (also called `UpperCamelCase`).
+ Classes and Structures : Pascal Case.
+ Interfaces : Follow class naming conventions, but start the name with `I` and capitalize the letter following the `I`.
+ Functions : Pascal Case.
+ Properties and Public Member Variables : Pascal Case.
+ Parameters and Procedure-level Variables : Camel Case (or `lowerCamelCase`).
c
> + Pascal case: writing compound words or phrases such that the first letter of each concatenated word is capitalized.
> + Camel case:  writing compound words or phrases such that each word or abbreviation in the middle of the phrase begins with a capital letter. 
>   + upper camel case (initial upper case letter, also known as Pascal Case).
>   + lower camel case (initial lower case letter).
## Reference 

+ [Wikipedia C#](https://zh.wikipedia.org/wiki/C%E2%99%AF)
+ [MSDN C# 教程](https://msdn.microsoft.com/zh-cn/library/aa288463(v=vs.71).aspx)
+ [RUNOOB C# 教程](http://www.runoob.com/csharp/csharp-tutorial.html)