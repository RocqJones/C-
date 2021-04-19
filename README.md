# C#
C# is a general-purpose, multi-paradigm programming language encompassing static typing, strong typing, lexically scoped, imperative, declarative, functional, generic, object-oriented, and component-oriented programming disciplines.

## Classes and objects.
Everything in C# is associated with classes and objects, along with its attributes and methods. 
### For example: 
* In real life, a **car is an object**. The car has **attributes**, such as *weight and color, and methods, such as drive and brake*.
* **A Class** is like an object `constructor`, or a "blueprint" for creating objects.
![classes objects](imgs/classesNobjects.PNG)

## Modifiers.
![modifiers](imgs/modifiers.PNG)
## Properties and Encapsulation.
**Encapsulation**, is to make sure that *"sensitive" data is hidden from users*. To achieve this, you must:
* declare fields/variables as `private`
* provide `public` `get` and `set` methods, through **properties**, to access and update the value of a `private` field

A **property** is like a combination of a variable and a method, and it has two methods: a get and a set method:
### Example.
```c#
class Person
{
  private string name; // field

  public string Name   // property
  {
    get { return name; }   // get method
    set { name = value; }  // set method
  }
}
```
### Explained...
* The `Name` property is associated with the `name` field. It is a good practice to use the same name for both the property and the `private` field, but with an uppercase first letter.
* The `get` method returns the value of the variable name.
* The `set` method assigns a value to the name variable. The value keyword represents the value we assign to the property.

## Why Encapsulation?
* **Better control of class members** (reduce the possibility of yourself (or others) to mess up the code)
* **Fields can be made read-only** (if you only use the get method), or **write-only** (if you only use the set method)
* **Flexible**: the programmer can change one part of the code without affecting other parts
* Increased security of data
