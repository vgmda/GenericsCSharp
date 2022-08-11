# GenericsCSharp

> In C#, generic means not specific to a particular data type. C# allows you to define generic classes, interfaces, abstract classes, fields, methods, static methods, properties, events, delegates, and operators using the type parameter and without the specific data type. A type parameter is a placeholder for a particular type specified when creating an instance of the generic type. A generic type is declared by specifying a type parameter in an angle brackets after a type name, e.g. TypeName<T> where T is a type parameter.
  
### DRY Principle (Don't Repeat Yourself)
This is a principle of software development that aims at reducing the repetition of patters and code duplication in favor of abstractions and avoiding redundancy. DRY principle states that, “..every piece of knowledge must have a single, unambiguous, authoritative representation within a system.” Using the principle, logic or algorithms that have certain functionality should only appear once in an application. Generics helps to implement such principle.
  
#### Methods to resolve duplication by DRY
* Abstractions
* Automation
* Normalization

  
### SOLID
SOLID principles are the design principles that enable us to manage most of the software design issues when it comes to comprehensibility, flexibility, maintainability.

There are five SOLID principles:
1. Single Responsibility Principle (SRP)
    - A class should have only one reason to change. This means that a class should not be loaded with multiple responsibilities and a single responsibility should not be spread across multiple classes or mixed with other responsibilities. The reason for that is the more changes are requested in the future, the more changes the class need to apply. 
2. Open Closed Principle (OCP)
    - Software entities (classes, modules, functions, etc.) should be open for extension, but closed for modification. The application should be flexible to change. The OCP states that the behaviors of the system can be extended without having to modify its existing implementation i.e. New features should be implemented using the new code, but not by changing existing code.
3. Liskov Substitution Principle (LSP)
	- LSP states that the child class should be perfectly substitutable for their parent class. If class A is derived from B then A should substitutable for B. Using LSP it can be checked if inheritance is applied correctly or not in our code. LSP is a fundamental principle of SOLID Principles and states that if program or module is using base class then derived class should be able to extend their base class without changing their original implementation. 
4. Interface Segregation Principle (ISP)
	- Interface segregation principle is required to solve the design problem of the application. When all the tasks are done by a single class this becomes an issue. Inheriting such class will result in having sharing method which are not relevant to derived classes. Using ISP, it allows the creation of separate interfaces for each operation or requirement rather than having a single class to do the same work. 
5. Dependency Inversion Principle (DIP)


### Generic Class Characteristics
* A generic class increases the reusability. The more type parameters mean more reusable it becomes. However, too much generalization makes code difficult to understand and maintain.
* A generic class can be a base class to other generic or non-generic classes or abstract classes.
* A generic class can be derived from other generic or non-generic interfaces, classes, or abstract classes.
  


