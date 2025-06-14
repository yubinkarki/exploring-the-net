## [Exploring The Net](https://yubinkarki.notion.site/DotNet-Technology-d680949c8c4c41d69bbef87ea84a4354)

This is a simple .NET console application comprising various core concepts  
Part of the **DotNet Technology** course for BCA 5th semester

## Units

-   [Unit 1 - Introducing C# and the .NET Framework](#unit-1---introducing-c-and-the-net-framework)
-   [Unit 2 - The C# Language Basics](#unit-2---the-c-language-basics)
-   [Unit 3 - Creating Types in C#](#unit-3---creating-types-in-c)
-   [Unit 4 - Advanced C#](#unit-4---advanced-c)

## Development Setup

```
- .NET SDK
- IDE (VSCode | Visual Studio | Rider)
```

## Unit 1 - Introducing C# and the .NET Framework

.NET is a free, cross-platform, open-source developer platform for building many kinds of
applications  
It can run programs written in multiple languages, with C# being the most popular  
It relies on a high-performance runtime that is used in production by many high-scale apps

### Unit Coverage

```
Introduction to C# and its features
Overview of .NET Framework
Comparison between different frameworks
.NET Standard
The CLR and Core framework
Features of Object-Oriented Programming (OOP)
Procedural vs OOP
```

|          | Functional Decomposition                   | Object-Oriented Programming                           |
| -------- | ------------------------------------------ | ----------------------------------------------------- |
| Approach | Divides system into smaller functions      | Divides system into objects that represent entities   |
| Focus    | Emphasis on functions that operate on data | Emphasis on objects that hold data and their behavior |

## Unit 2 - The C# Language Basics

When compiling to managed code, the C# compiler translates your source code into Intermediate
Language (IL)  
The IL is a CPU-independent set of instructions that can be efficiently converted to native code  
JIT compilation converts IL to native code on demand at application run time

### Unit Coverage

```
New .NET Console app
Compilation process
Identifiers, Keywords, and Literals
Value types vs Reference types
Operators and Parameters
Control flow statements and Namespaces
```

## Unit 3 - Creating Types in C#

C# is a strongly typed language  
Every variable and constant has a type, as does every expression that evaluates to a value  
Every method declaration specifies a name, the type for each input parameter and for the return
value  
The .NET class library defines built-in numeric types and complex types that represent a wide
variety of constructs

### Unit Coverage

```
Constructor/Destructor
Static classes, Finalizers, Struct
Inheritance and Interface
Upcasting/Downcasting, Operator Overloading
Sealed functions and classes
Enums and Generics
```

## Unit 4 - Advanced C#

.NET is a developer platform made up of tools, programming languages, and libraries  
The base platform provides components that apply to all different types of apps  
Additional frameworks, such as ASP.NET, extend .NET with components for building specific types of
apps

### Unit Coverage

```
Delegates, Events
Lambda expressions
Exception Handling
Introduction to LINQ
Working with database
Web app using ASP.NET
```

### Connected VS Disconnected Architecture

| Feature             | Connected (`DataReader`)      | Disconnected (`DataAdapter` + `DataTable`) |
| ------------------- | ----------------------------- | ------------------------------------------ |
| Connection lifetime | Long (until data is read)     | Short (only during fill)                   |
| Data accessibility  | Only during connection        | Persisted in memory                        |
| Performance         | Faster for large, quick reads | Better for flexibility and offline use     |
| Memory usage        | Low                           | Higher                                     |
| Usability           | Simple reads only             | Editable, bindable, sortable               |
