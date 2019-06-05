using Microsoft.Win32.SafeHandles;
// about handle(abstract derivatins of safe handle class)
using System;
// contain fundamental classes and base classes that define commonly-used value
// and referene data types, events, and event hanlers, interfaces, attributes,
// processing exceptions
using System.CodeDom.Compiler;
// contain types for manage the geration and compilation of source code in
// supported programming languages
using System.Collections;
// contain interfaces and classes that define various colletion of objects
using System.Collections.Concurrent;
// provide several thread-safe collection classes
using System.Collections.Generic;
// contain interface sand classes that define generic collections
using System.Collections.ObjectModel;
// contain classes that can be used as collections in the object model of a
// reusable library
using System.Collections.Specialized;
// contain specialized and strongly-typed collections
using System.ComponentModel;
// procide classes that are used to implement the run-time and design-time
// behavior of components and controls
using System.ComponentModel.Design;
// contains classes that developers can used to build custom designed-time
// behavior of compotents and controls
using System.ComponentModel.Design.Serialization;
// provide types that support cusomization and control of serialzation as design
// time
using System.Configuration.Assemblies;
// contain classes that are used to configure an assembly
using System.Data;
// provide access to classes represent the ADO.NET architecture
using System.Data.Common;
// contain classes shared by .NET framework data provider
using System.Data.SqlTypes;
// provide classes for native data types in SQL Server
using System.Diagnostics;
// provide classes allow you to interact with system process, event logs and
// performance counters
using System.Diagnostics.CodeAnalysis;
// contain static class for interaction with code analysis tools
using System.Diagnostics.Contracts;
// contain static class for representing program contracts such as
// preconditions, postconditions, and invariants
using System.Diagnostics.SymbolStore;
// provide classes that allow you to read and write debug symbol information
using System.Diagnostics.Tracing;
// provide types and members that enable you to create strongly typed event to
// be captured by event tracing for Windows(ETW)
using System.Drawing;
// provide asscess to GDI+ basic grphics functionality, more advanced
// functionily is provided in System.Drawing.Drawing2D, System.Drawing.Imaging,
// and System.Drawing.Text namespcaes
using System.Dynamic;
// provide classes and interfaces that support Dynamic Language Runtime
using System.Globalization;
// contain classes that define culture-related information, include language,
// country/region, calendars in use, format patterns for dates, currency, and
// numbers and sort order for string
using System.IO;
// contain types that allow reading and writing to files and data streams, and
// types that provide basic basic file and directory support
using System.IO.Compression;
// contain classes that provide basic compression and decompression services for
// strams
using System.IO.IsolatedStorage;
// contail types that allow creation and use of isolated stores
using System.IO.MemoryMappedFiles;
// provide classes for using a memory-mapped file, which maps the content of a
// file to application's logical space address
using System.IO.Pipes;
// provide a means for interprocess communication througn anonymous and/or named
// pipes
using System.Linq;
// provde classes and interfaces that support queries that use
// Language-Interaged Query(LINQ)
using System.Linq.Expressions;
// contain classes, interfaces and enumerations that enable language-level code
// expressions to be represented as objects in the form of expression tree
using System.Net;
// provide a simple programming interface of many of the protrols used on
// networks today
using System.Net.Cache;
// define types and enumerations used define cache policies for resources
// obtained using System.Net.WebRequest and System.Net.HttpWebRequest classes
using System.Net.Http;
// provide a programming interface for modern http applications
using System.Net.Http.Headers;
// provode support for collections of HTTP headers used by System.Net.Http
// namespce
using System.Net.Mail;
// used to send electronic mail to a Simple Mail Tranfer Protocol(SMTP) server
// for delivery
using System.Net.Mime;
// holds types that are used to represent Multipurpose Internet Mail Exchange
// (MIME) headers
using System.Net.NetworkInformation;
// provide access to network traffic data, network address information, and
// notification of address changes for the local computer
using System.Net.Security;
// provide net streams for secure commiunications between hosts
using System.Net.Sockets;
// provide a managed implementation of the Windows Sockets(Winsock) interface
// for devlopers who need tightly control access to the internet
using System.Net.WebSockets;
// provide a managed implementation of the WebSocket interface for developers
using System.Numerics;
// contains numeric types that complement the numeric primitives, such as
// System.Byte, System.Double, System.Int32, that are define by .NET
using System.Reflection;
// contain types that retrieve information about assemblies, modules, members,
// parameters, and other entities in managed code by examining their metadata
using System.Reflection.Emit;
// contail classes that allow a compiler or tool to emit metadata and Microsoft
// intermediate language(MSIL) and optional generate a PE file on disk
using System.Resources;
// provide classes and interfaces that allow developers to create, store, and
// manage various culture-specific resources used in an application
using System.Runtime;
// contain advanced types that support deverse namespaces such as System,
// Runtime, and the Security namespcaes
using System.Runtime.CompilerServices;
// procide functionality for compiler writers who use managed code to specify
// arrtibutes in metadata that affect the run-time behavior of the common
// language runtime
using System.Runtime.ConstrainedExecution;
// define a set of types that enumerate and define a contract for reliability
// between the author of some code, and the developer who take a dependency on
// that code
using System.Runtime.ExceptionServices;
// provide classes for advanced exception handling
using System.Runtime.InteropServices;
// procide a wide variety of mumbers that support COM interop and platform
// invoke services
using System.Runtime.InteropServices.ComTypes;
// contain managed types that correspond to types used by COM interop
using System.Runtime.Serialization;
// contain classes that can be used for serializing  and deserializing objects
using System.Runtime.Serialization.Formatters;
// provide common enumerations, interfaces, and classes that are used by
// serialization formatters
using System.Runtime.Serialization.Formatters.Binary;
// contains the BinaryFormatter class which can be used to serialize and
// deserialize objects in binaty format
using System.Runtime.Serialization.Json;
// provide class related to Json serialization
using System.Runtime.Versioning;
// contain advanced types that support versining in side by side
// implementations of the .NET Framework
using System.Security;
// provides the undelying structure of common language runtime security system,
// include base classes for permissions
using System.Security.Authentication;
// provide a set of enumerations that describe the securiry of a connection
using System.Security.Authentication.ExtendedProtection;
// provide support for authentication using extended protection for application
using System.Security.Claims;
// contain classes that implement claims-based identity in the .NET Framework,
// include classes that represent claims, claims-based identities, and
// claims-based principles
using System.Security.Cryptography;
// provide cryptographic services, includeing secure encoding of data, as well
// as many other operations, such as hashing, random number generation, and
// message authentication
using System.Security.Cryptography.X509Certificates;
// contain the common language runtime implementation of the Authenticode X.509
// v.3 certificate
using System.Security.Permissions;
// define classes that control assess to operations and resources based on
// policy
using System.Security.Principal;
// define a principle object that represents the security context under which
// code is running
using System.Text;
// contain classes represent ASCII and Unicode character encodings
using System.Text.RegularExpressions;
// contain classes that provide access to .NET Framework regulat expression
// engine
using System.Threading;
// provide classes and interfaces that enable multithreaded programming
using System.Threading.Tasks;
// provides types that simplify the work of writing concurrent and asynchronous
// code
using System.Timers;
// provide the Timer component which allows you to raise an event on a specified
// interval
using System.Transactions;
// contains classes that allow you to write your own transactional application
// and resource manager
using System.Web;
// supply classes and interfaces that enable brower-server communication
using System.Windows.Input;
// provide types to support the Windows Presentation Fundation(WPF) input system
using System.Xml;
// provide standards-based support for procsssing XML
using System.Xml.Linq;
// contain the classes for LINQ to XML
using System.Xml.Resolvers;
// provide support for prepopulating the cache with DTDs or XML streams
using System.Xml.Schema;
// contain the XML classes that provide srtandards-based support for XML schema
// definition language(XSD) schemas
using System.Xml.Serialization;
// contain classes that are used to serialize objects into XML format documents
// or streams
using System.Xml.XPath;
// contain the classes htat define a cursor model for navigating and editing XML
// information items as instances of the XQuery 1.0 and XPath 2.0 Data Model
using System.Xml.Xsl;
// provide support for Extensible Stylesheet Transformation(XSLT) transforms

namespace dotnet_standard_2_0 {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Hello World!");
    }
  }
}