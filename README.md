# C \# Concepts :slightly_smiling_face: 

> **Difference between Abstract and interface**

| Abstract              | Interface                        |
|:---------------------- |:------------------------|
|Abstract uses `abstract` Keyword | Interface uses `interface` keyword |
| Abstract class contains both declaration and definition of methods | Interface should contain declaration of methods |
| Abstract classes do not support multiple inheritance| Interface support multiple inheritance|
|Abstract class can have a constructor | Interface cannot have a constructor |

 >**Types of classes**
 ```
 public abstract class ClassName { }
 public static class ClassName { }
 public partial class ClassName { }
 public sealed class ClassName { }
 ```
 
>**Is it possible to prevent object creation of a class in C#?**

Yes. It is possible by declaring class as abstract / private / static
 ```public abstract class ClassName { }```
 ```private class ClassName { }```
 ```public static class ClassName { }```

>**How to prevent a class from being inherited**
<font size="2">It is possible by declaring a class with ```sealed``` keyword</font>\
```
public sealed class Employee
{
    public void GetSalary()
    {
        Console.WriteLine("");
    }
}
//Inheriting Employee below will give compile time error
public class PermanentEmployee : Employee
```

>**Effective Coding Principles**
<font size="2">
\- Don't Repeat Yourself (DRY)
\- Keep It Simple, Stupid (KISS)
\- You Ain't Gonna Need It (YAGNI)
</font>

>**Difference between property and function**
<font size="2">
- Property is a specialized function
- Property syntax is slightly  diferent than function but internally property and function are same
</font>

```
public int MyProperty { get; set; }
public int MyProperty() { }
```
>**What is a Property?**
```
public class MyClass
{
    private int myProperty;

    public int MyProperty
    {
        get { return myProperty; }
        set { myProperty = value; }
    }
}
```
<font size="2"> A property is a class member that provides a flexible mechanism to **read** and **write** private field </font>


> **Does C# support multiple inheritance?**
<font size="2">No
Alternative way is via multiple interfaces </font>

>**What are Namespaces?**
```
using System.Text;

namespace myNamespace
{
    public class myClass
    {
        StringBuilder sb = new StringBuilder();
    }
}
```
<font size="2"> A namespace is a container for a set of related classes an other types. In above example, StringBuilder is defined within the namespace System.Text. </font>

>**Difference between Encapsulation and Abstraction**

|Encapsulation|Abstraction|
|:--------------|:----------|
|Abstrafction means showing only required things and hide the background details | Encapsulation means wraping of data and method into a single unit|
|Abstraction is a broader concept of hiding |Encapsulation is like proper implementation of where you wrap methods and data|
