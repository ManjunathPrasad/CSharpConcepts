# C# Concepts :slightly_smiling_face: 

#### Difference between Abstract and interface

| Abstract              | Interface                        |
|:---------------------- |:------------------------|
|Abstract uses `abstract` Keyword | Interface uses `interface` keyword |
| Abstract class contains both declaration and definition of methods | Interface should contain declaration of methods |
| Abstract classes do not support multiple inheritance| Interface support multiple inheritance|
|Abstract class can have a constructor | Interface cannot have a constructor |

#### Types of classes
Classes can be ```abstract```, ```static```, ```partial``` and ```sealed```
 ```
 public abstract class ClassName { }
 public static class ClassName { }
 public partial class ClassName { }
 public sealed class ClassName { }
 ```
 
#### Is it possible to prevent object creation of a class in C#?

Yes. It is possible by declaring class as abstract / private / static
 ```public abstract class ClassName { }
 public abstract class ClassName { }
 private class ClassName { }
 public static class ClassName { }
 ```

#### How to prevent a class from being inherited
It is possible by declaring a class with ```sealed``` keyword
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

#### Effective Coding Principles

* Don't Repeat Yourself (DRY)
* Keep It Simple, Stupid (KISS)
* You Ain't Gonna Need It (YAGNI)

#### Difference between property and function

- Property is a specialized function
- Property syntax is slightly  diferent than function but internally property and function are same
```
public int MyProperty { get; set; }
public int MyProperty() { }
```
#### What is a Property?
A property is a class member that provides a flexible mechanism to **read** and **write** private field
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



#### Does C# support multiple inheritance?
No. Alternative way is via multiple interfaces

#### What are Namespaces?
A namespace is a container for a set of related classes an other types. In above example, StringBuilder is defined within the namespace System.Text.
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


#### Difference between Encapsulation and Abstraction

|Encapsulation|Abstraction|
|:--------------|:----------|
|Abstrafction means showing only required things and hide the background details | Encapsulation means wraping of data and method into a single unit|
|Abstraction is a broader concept of hiding |Encapsulation is like proper implementation of where you wrap methods and data|

#### When Should I override the methods?

&nbsp;&nbsp;&nbsp;&nbsp; In below example, We have ```Author class``` with ```WriteBooks()``` and ```WriteArticle()``` methods. Some day, I want to add another ```class Poet``` which inherits ```Author class``` and need to keep the ```WriteBook()``` method with the same functionality, but change the functionality of the ```WriteArticle()```. Here in this situation we need to override the ```WriteArticle()``` method in the ```class Poet``` with a new definition.

&nbsp;&nbsp;&nbsp;&nbsp; Note that ```Poet``` class is inheriting the ```Author``` class, that means all the methods of the ```Author``` class can be accessed by the child class ```Poet```. Here, we're just changing the definitioon of the ```WriteArticle()``` method, but ```WriteBook()``` method remain same in the ```Poet``` class since it's not overriden.

&nbsp;&nbsp;&nbsp;&nbsp; In parent class ```Author```, any methods can be declared as ```virtual```. It is **not** mandatory that all the ```virtual``` methods should ```override``` the methods in child class.



```
public class Author
{
    public virtual void WriteBook()
    {
        Console.WriteLine("Writing a Book);
    }
    public virtual void WriteArticle()
    {
        Console.WriteLine("Writing an article for him");
    }
}

public class Poet : Author
{
    public ovverride void WriteArticle()
    {
        COnsole.WriteLine("Write an article for a Newspaper");
    }
}
```