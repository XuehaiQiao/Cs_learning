# Week2Day2Hw

1. **What are the six combinations of access modifier keywords and what do they do?** 

   1. [public](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/public): The type or member can be accessed by any other code in the same assembly or another assembly that references it. The accessibility level of public members of a type is controlled by the accessibility level of the type itself.
   2. [private](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/private): The type or member can be accessed only by code in the same `class` or `struct`.
   3. [protected](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/protected): The type or member can be accessed only by code in the same `class`, or in a `class` that is derived from that `class`.
   4. [internal](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/internal): The type or member can be accessed by any code in the same assembly, but not from another assembly. In other words, `internal` types or members can be accessed from code that is part of the same compilation.
   5. [protected internal](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/protected-internal): The type or member can be accessed by any code in the assembly in which it's declared, or from within a derived `class` in another assembly.
   6. [private protected](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/private-protected): The type or member can be accessed by types derived from the `class` that are declared within its containing assembly.

2. **What is the difference between the static, const, and readonly keywords when applied to a type member?**

   - Static: the member belongs to class itself but not instances
   - Const: the member field must be initialized with a value at the time it is declared
   - Readonly: can only be set once in field initializer or constructor

3. **What does a constructor do?**

   Constructor help init field values and other init setups

4. **Why is the partial keyword useful?**

   The `partial` keyword in C# allows a class, method, or struct to be defined in multiple source files.

5. **What is a tuple?**

   Tuple is a lightweight data type that can store different data types. It is used mostly to store the return value of a function 

6. **What does the C# record keyword do?**

   Record keyword is used to define a special class to store data.

7. **What does overloading and overriding mean?**

   Overloading: use same function name multiple times with different signature

   Overriding: define subclass methods with same signature with base class but with different realizations. 

8. **What is the difference between a field and a property?**

   - Fields are variable that store data
   - Properties are methods that provide access to data 

9. **How do you make a method parameter optional?**

   - You can make parameter optional by giving default number.

10. **What is an interface and how is it different from abstract class?**

    - an interface is a contract that defines a set of methods, properties, and events that a class must implement. An interface only defines the signature of the methods, properties, and events, but does not provide any implementation.
    - An abstract class, on the other hand, is a class that cannot be instantiated directly, but is used as a base class for other classes. Abstract classes can define both abstract and non-abstract members, and provide partial implementation for some or all of their members.

11. **What accessibility level are members of an interface?**

    All members of an interface are implicitly public

12. **True/False. Polymorphism allows derived classes to provide different implementations of the same method.**

    True

13. **True/False. The override keyword is used to indicate that a method in a derived class is providing its own implementation of a method.**

    True

14. **True/False. The new keyword is used to indicate that a method in a derived class is providing its own implementation of a method.**

    True

15. **True/False. Abstract methods can be used in a normal (non-abstract) class.** 

    False

16. **True/False. Normal (non-abstract) methods can be used in an abstract class.** 

    True

17. **True/False. Derived classes can override methods that were virtual in the base class.** 

    True

18. **True/False. Derived classes can override methods that were abstract in the base class.** 

    True

19. **True/False. In a derived class, you can override a method that was neither virtual non abstract in the base class.**

    False

20. **True/False. A class that implements an interface does not have to provide an implementation for all of the members of the interface.**

    False

21. **True/False. A class that implements an interface is allowed to have other members that aren’t defined in the interface.**

    True

22. **True/False. A class can have more than one base class.**

    False

23. **True/False. A class can implement more than one interface.What is meant by the terms managed resource and unmanaged resource in .NET**

    True

24. **What's the purpose of Garbage Collector in .NET?**

    To clean memory by removing data that without references anymore

Only One LeetCode Question: 15: in C# project