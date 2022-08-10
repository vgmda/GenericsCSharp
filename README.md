# GenericsCSharp

> In C#, generic means not specific to a particular data type. C# allows you to define generic classes, interfaces, abstract classes, fields, methods, static methods, properties, events, delegates, and operators using the type parameter and without the specific data type. A type parameter is a placeholder for a particular type specified when creating an instance of the generic type. A generic type is declared by specifying a type parameter in an angle brackets after a type name, e.g. TypeName<T> where T is a type parameter.
  
### DRY Principle (Don't Repeat Yourself)
This is a princple of software develpment that aims at reducing the repetition of patters and code duplication in favor of abstractions and avoiding redundancy. DRY principle states that, “..every piece of knowledge must have a single, unambiguous, authoritative representation within a system.” Using the principle, logic or algorithms that have certain functionality should only appear once in an application. Generics helps to implement such principle.
  
#### Methods to resolve duplication by DRY
* Abstractions
* Automation
* Normalization

  
### SOLID
SOLID principles are the design principles that enable us to manage most of the software design issues when it comes to comprehensibility, flexibility, maintainability.

There are five SOLID principles:
1. Single Responsibility Principle (SRP)
2. Open Closed Principle (OCP)
3. Liskov Substitution Principle (LSP)
4. Interface Segregation Principle (ISP)
5. Dependency Inversion Principle (DIP)


### Generic Class Characteristics
* A generic class increases the reusability. The more type parameters mean more reusable it becomes. However, too much generalization makes code difficult to understand and maintain.
* A generic class can be a base class to other generic or non-generic classes or abstract classes.
* A generic class can be derived from other generic or non-generic interfaces, classes, or abstract classes.
  


