# CSharp.Playground

[![](https://img.shields.io/badge/Author-jskyzero-brightgreen.svg?style=flat)]()
[![](https://img.shields.io/badge/Data-2017/12/31-brightgreen.svg?style=flat)]()

本倉庫將提供相當多C#語言相關的介紹與示例。

## Overview

<!-- ![C# language](https://docs.microsoft.com/zh-cn/dotnet/images/hub/csharp-icon.svg) -->


+ 什么是C#（编程语言），C#的特点。
  + C# is an elegant and type-safe object-oriented language.（C# 是类型安全的面向对象的精妙语言。）
  + C# syntax is highly expressive（C# 语法高度重视表达。）
  + C# programs run on the .NET Framework（C# 程序在 .NET Framework 上运行。~~严格上不只 .NET Framework~~）
+ 为什么我要学习C#
  + 个人意见，C#在性能、可维护性、编写成本的综合考虑上有很大优势。
  + 如果你为Windows编写程序，C#和Visual Studio为你提供了很好的解决方案。
  + .Net Core（和MONO等）打消了我对于跨平台方面的考虑。
  + 如果你使用Unity制作游戏，C#是你的首选语言。
+ C#与.Net之间的关系
  + C# 是 .NET 框架的一部分，且用于编写 .NET 应用程序。
  + .NET框架以通用语言运行库为基础，支持多种语言。 .NET框架包括称为公共语言运行时（CLR）的虚拟执行系统和统一的类库，CLR是微软对通用语言架构（CLI，Common Language Infrastructure）的实现。通用语言架构定义了一个语言无关的跨体系结构的运行环境。
+ 我应该如何开始
  + 建议阅读[C# 指南](https://docs.microsoft.com/zh-cn/dotnet/csharp/)和其他有效学习资源。
  + 本仓库适合有一定基础的人阅读，并用来记录一些不方便记忆的东西，提供一些可以运行的完整示例。
    + 具体来说，本仓库会有基础的语法示例、编码风格参考、项目布局参考、C#历史版本与最新版本回顾...。


<!-- ## Overview
+ C#是微软推出的一种基于.NET框架的、面向对象的高级编程语言。
+ 语言本身深受Visual Basic、Java、C和C++ 的影响。
+ C#旨在设计成为一种“简单、现代、通用”，以及面向对象的程序设计语言
+ C# 是 .NET 框架的一部分，且用于编写 .NET 应用程序。因而我们可能需要先了解下 .NET

![.NET 体系结构组件](https://docs.microsoft.com/zh-cn/dotnet/standard/media/components.png)

1. C#源代码被编译成符合CLI规范的中间语言（IL），IL代码与资源文件一起作为程序集文件存为.{exe|dll}文件。
2. 执行C#程序时候，程序集被加载到CLR中，如果符合安全要求，则CLR执行实时（JIT）编译将IL代码转化为本机机器指令，CLR还提供自动垃圾回收，异常处理和资源管理有关的其他服务。 -->

## Structure
```
.
├── LICENSE
├── README.md
├── docs            // 一些文档
│   ├── 0.csharp-guide-in-short.md                  // C#指南精粹
│   ├── 1.dotnet-and-csharp-version-and-history.md  // .NET版本與C#的版本与历史
│   └── 2.dotnet-and-csharp-api-overview.md         // .NET and C#: 引用程序接口概览
├── hardwork
│   ├── hardway     // C#指南教程实践
│   ├── helloworld  // “你好世界！”
│   ├── leetcode    // 一些题解
│   ├── runoob      // 菜鸟教程
│   └── tips        // 一些小语法点的示例
└── projects
    ├── dotnet-standard-2.0   // API测试项目
    ├── socket                // 套接字使用
    └── todolist              // 简单持续化存储的待办事项应用
```

## Naming Style

+ Namespace : Pascal Case (also called `UpperCamelCase`).
+ Classes and Structures : Pascal Case.
+ Interfaces : Follow class naming conventions, but start the name with `I` and capitalize the letter following the `I`.
+ Functions : Pascal Case.
+ Properties and Public Member Variables : Pascal Case.
+ Parameters and Procedure-level Variables : Camel Case (or `lowerCamelCase`).

> + Pascal case: writing compound words or phrases such that the first letter of each concatenated word is capitalized.
> + Camel case:  writing compound words or phrases such that each word or abbreviation in the middle of the phrase begins with a capital letter. 
>   + upper camel case (initial upper case letter, also known as Pascal Case).
>   + lower camel case (initial lower case letter).

## Reference
+ [Github Microsoft dotnet](https://github.com/Microsoft/dotnet)
+ [C# 参考](https://docs.microsoft.com/zh-cn/dotnet/csharp/language-reference/index)
