## C Sharp概览

### 什么是C Sharp

> **C#**是[微软](https://zh.wikipedia.org/wiki/%E5%BE%AE%E8%BD%AF)推出的一种基于[.NET框架](https://zh.wikipedia.org/wiki/.NET%E6%A1%86%E6%9E%B6)的、[面向对象](https://zh.wikipedia.org/wiki/%E9%9D%A2%E5%90%91%E5%AF%B9%E8%B1%A1%E7%A8%8B%E5%BA%8F%E8%AE%BE%E8%AE%A1)的高级[编程语言](https://zh.wikipedia.org/wiki/%E7%BC%96%E7%A8%8B%E8%AF%AD%E8%A8%80)。**C#**的发音为“C sharp”，模仿音乐上的音名“[C♯](https://zh.wikipedia.org/wiki/C%E2%99%AF_(%E9%9F%B3%E5%90%8D))”（C调升），是C语言的升级的意思。其正确写法应和音名一样为“C♯”[[来源请求\]](https://zh.wikipedia.org/wiki/Wikipedia:%E5%88%97%E6%98%8E%E6%9D%A5%E6%BA%90)，但大多数情况下“♯”符号被[井号](https://zh.wikipedia.org/wiki/%E4%BA%95%E8%99%9F)“#”所混用；两者差别是：“♯”的笔画是上下偏斜的，而“#”的笔画是左右偏斜。C♯由[C语言](https://zh.wikipedia.org/wiki/C%E8%AF%AD%E8%A8%80)和[C++](https://zh.wikipedia.org/wiki/C%2B%2B)派生而来，继承了其强大的性能，同时又以.NET框架类库作为基础，拥有类似[Visual Basic](https://zh.wikipedia.org/wiki/Visual_Basic)的快速开发能力。C#由[安德斯·海尔斯伯格](https://zh.wikipedia.org/wiki/%E5%AE%89%E5%BE%B7%E6%96%AF%C2%B7%E6%B5%B7%E5%B0%94%E6%96%AF%E4%BC%AF%E6%A0%BC)主持开发，微软在2000年发布了这种语言。

### Tips

+ 语言本身深受Visual Basic、Java、C和C++ 的影响。
+ C#旨在设计成为一种“简单、现代、通用”，以及面向对象的程序设计语言



## .NET Framework 平台体系结构

### 什么是.NET Framework

.NET框架是以一种采用系统虚拟机运行的编程平台，以[通用语言运行库](https://zh.wikipedia.org/wiki/%E5%85%AC%E5%85%B1%E8%AF%AD%E8%A8%80%E8%BF%90%E8%A1%8C%E5%BA%93)（Common Language Runtime）为基础，支持多种语言（[C#](https://zh.wikipedia.org/wiki/C%EF%BC%83)、[F#](https://zh.wikipedia.org/wiki/F%EF%BC%83)、[VB.NET](https://zh.wikipedia.org/wiki/Visual_Basic_.NET)、[C++](https://zh.wikipedia.org/wiki/C%2B%2B)、[Python](https://zh.wikipedia.org/wiki/Python)等）的开发。

.NET Framework 包括一个称为公共语言运行时（CLR）的虚拟执行系统和统一的类库，CLR是微软对Common Language Infrastructure（CLI）的实现.

CLI，[通用语言基础架构](https://zh.wikipedia.org/wiki/%E9%80%9A%E7%94%A8%E8%AF%AD%E8%A8%80%E6%9E%B6%E6%9E%84)，定义了一个语言无关的[跨体系结构](https://zh.wikipedia.org/w/index.php?title=%E8%B7%A8%E4%BD%93%E7%B3%BB%E7%BB%93%E6%9E%84&action=edit&redlink=1)的运行环境，这使得开发者可以用规范内定义的各种[高级语言](https://zh.wikipedia.org/wiki/%E9%AB%98%E7%BA%A7%E8%AF%AD%E8%A8%80)来开发软件，并且无需修正即可将软件运行在不同的[计算机体系结构](https://zh.wikipedia.org/wiki/%E8%AE%A1%E7%AE%97%E6%9C%BA%E7%B3%BB%E7%BB%9F%E7%BB%93%E6%9E%84)上。

### 运行细节

1. C#源代码被编译成符合CLI规范的中间语言（IL），IL代码与资源文件一起作为程序集文件存为.{exe|dll}文件。
2. 执行C#程序时候，程序集被加载到CLR中，如果符合安全要求，则CLR执行实时（JIT）编译将IL代码转化为本机机器指令，CLR还提供自动垃圾回收，异常处理和资源管理有关的其他服务。

## C Sharp 上手
## Reference 

[Wikipedia C#](https://zh.wikipedia.org/wiki/C%E2%99%AF)

