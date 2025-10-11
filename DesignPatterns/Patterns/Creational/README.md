# Creational Design Patterns in C#

A comprehensive guide to the five creational design patterns with practical examples and interview-focused explanations.

## 📚 Table of Contents
- [What Are Creational Patterns?](#what-are-creational-patterns)
- [Quick Reference Guide](#quick-reference-guide)
- [Factory Method](#factory-method)
- [Abstract Factory](#abstract-factory)
- [Builder](#builder)
- [Prototype](#prototype)
- [Singleton](#singleton)
- [Pattern Comparison](#pattern-comparison)
- [Common Interview Questions](#common-interview-questions)

---

## What Are Creational Patterns?

Creational patterns deal with object creation mechanisms, providing flexibility in **what** gets created, **who** creates it, **how** it gets created, and **when** to create it. They abstract the instantiation process and make systems independent of how objects are created, composed, and represented.

**Key Benefits:**
- Encapsulate knowledge about concrete classes
- Hide complex creation logic
- Provide flexibility in object creation
- Promote loose coupling

---

## Quick Reference Guide

| Pattern | Purpose | Use When |
|---------|---------|----------|
| **Factory Method** | Delegate object creation to subclasses | You need different variants of a product |
| **Abstract Factory** | Create families of related objects | You need multiple related products that work together |
| **Builder** | Construct complex objects step-by-step | Object has many optional parameters or complex assembly |
| **Prototype** | Clone existing objects | Creating new instances is expensive or complex |
| **Singleton** | Ensure only one instance exists | You need exactly one instance accessible globally |

---

## Factory Method

### 📋 Intent
Define an interface for creating objects, but let subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.

### 🎯 Real-World Analogy
A logistics company has different types of transport (Truck, Ship, Plane). Each branch office decides which transport to use based on their location, but all follow the same delivery process.

### 🏗️ Structure
```
Creator (abstract)
├── FactoryMethod() : Product
└── ConcreteCreator
    └── FactoryMethod() : ConcreteProduct
```

**Key Participants:**
- **Creator**: Declares factory method that returns Product objects
- **ConcreteCreator**: Overrides factory method to return specific ConcreteProduct instances
- **Product**: Interface for objects the factory method creates
- **ConcreteProduct**: Implements the Product interface

### ✅ When to Use
- A class can't anticipate the type of objects it needs to create beforehand
- A class wants its subclasses to specify the objects it creates
- Classes delegate responsibility to one of several helper subclasses, and you want to localize the knowledge of which helper subclass is the delegate
- You want to provide a library of products without exposing implementation details

### ❌ When NOT to Use
- Only one type of product exists and won't change
- Object creation is straightforward and doesn't require variation
- The overhead of subclassing adds unnecessary complexity
- You need to create families of related objects (use Abstract Factory instead)

### 💪 Advantages
- **Open/Closed Principle**: Open for extension (new products), closed for modification
- **Single Responsibility Principle**: Product creation code in one place
- **Loose Coupling**: Code works with abstract interfaces, not concrete classes
- **Flexibility**: Easy to introduce new product types without breaking existing code
- **Parallel Class Hierarchies**: Creators and Products evolve independently

### ⚠️ Disadvantages
- Can result in a large number of subclasses
- Code becomes more complex due to multiple new classes
- Requires subclassing even when simple instantiation would suffice
- Not suitable when products don't share a common interface

### 🔍 Implementation Notes
- Can use parameters in factory method to determine which product to create
- Factory method can have a default implementation
- Consider using generics in C# for type-safe factory methods
- Can be combined with dependency injection for better testability

---

## Abstract Factory

### 📋 Intent
Provide an interface for creating families of related or dependent objects without specifying their concrete classes.

### 🎯 Real-World Analogy
A furniture store offers complete room sets in different styles (Modern, Victorian, Art Deco). Each style has matching chair, sofa, and coffee table. When you choose a style, all furniture pieces are consistent and work together aesthetically.

### 🏗️ Structure
```
AbstractFactory
├── CreateProductA() : AbstractProductA
├── CreateProductB() : AbstractProductB
└── ConcreteFactory1, ConcreteFactory2
    └── Create methods return ConcreteProducts
```

**Key Participants:**
- **AbstractFactory**: Interface declaring creation methods for abstract products
- **ConcreteFactory**: Implements creation operations to produce concrete product objects
- **AbstractProduct**: Interface for a type of product object
- **ConcreteProduct**: Product objects created by corresponding concrete factory
- **Client**: Works only with interfaces declared by AbstractFactory and AbstractProduct

### ✅ When to Use
- System needs to be independent of how its products are created, composed, and represented
- System should be configured with one of multiple families of products
- A family of related product objects must be used together (enforced consistency)
- You want to provide a class library of products, revealing only interfaces
- The product family is likely to change together (e.g., UI themes, database providers)

### ❌ When NOT to Use
- Only one product family exists
- Products don't need to be related or used together
- Adding new product types is frequent (requires changing all factory interfaces)
- Product variations are simple and don't justify the complexity
- You only need to create objects of one type (use Factory Method instead)

### 💪 Advantages
- **Product Consistency**: Ensures products from the same family work together
- **Isolation of Concrete Classes**: Clients are isolated from implementation classes
- **Easy Product Family Exchange**: Changing product family is easy (change factory)
- **Single Point of Product Creation**: All product creation in one place
- **Open/Closed Principle**: New product families can be introduced without changing client code

### ⚠️ Disadvantages
- **Difficult to Support New Products**: Adding new product types requires changing all factories
- **Increased Complexity**: Many interfaces and classes needed
- **Overkill for Simple Cases**: Too much structure for simple scenarios
- **Rigid Structure**: Hard to extend with new product types after initial design

### 🔍 Implementation Notes
- Often implemented with Factory Methods
- Can use Prototype pattern for product creation
- Concrete factories are often Singletons
- Consider using dependency injection to inject the appropriate factory
- In C#, can use generics to reduce the number of factory methods

---

## Builder

### 📋 Intent
Separate the construction of a complex object from its representation, allowing the same construction process to create different representations.

### 🎯 Real-World Analogy
Building a house follows the same construction process (foundation, walls, roof, interior) but produces different results (wooden cottage, brick mansion, glass modern home) based on materials, specifications, and choices made during construction.

### 🏗️ Structure
```
Director
└── Construct() : uses Builder interface

Builder (interface)
└── ConcreteBuilder
    ├── BuildPartA()
    ├── BuildPartB()
    ├── BuildPartC()
    └── GetResult() : Product
```

**Key Participants:**
- **Builder**: Abstract interface for creating parts of a Product
- **ConcreteBuilder**: Constructs and assembles parts, provides method to retrieve product
- **Director**: Constructs an object using the Builder interface (optional)
- **Product**: Complex object under construction

### ✅ When to Use
- Object construction has many optional parameters (telescoping constructor problem)
- Same construction process should create different representations
- Construction algorithm should be independent of the parts and their assembly
- Object creation involves multiple steps or complex logic
- You want immutable objects that require validation during construction
- Different representations of a product need the same construction steps

### ❌ When NOT to Use
- Object is simple with few required fields (use constructor)
- All fields are mandatory (constructor is clearer)
- Object structure rarely changes
- Construction logic is trivial
- Performance is critical (Builder adds overhead)

### 💪 Advantages
- **Step-by-Step Construction**: Build objects gradually, defer steps, or run recursively
- **Code Reuse**: Same construction code for different product representations
- **Single Responsibility Principle**: Isolate complex construction code from business logic
- **Fluent Interface**: Method chaining creates readable code
- **Immutability**: Can create immutable objects with validation
- **Fine Control**: More control over the construction process than with constructors

### ⚠️ Disadvantages
- **Increased Complexity**: Requires creating multiple new classes
- **More Code**: More verbose than simple constructors for simple objects
- **Mutable State**: Builder itself is typically mutable during construction
- **Not for Simple Objects**: Overkill when object has few fields

### 🔍 Implementation Notes
- Director is optional; client can control construction directly
- Builder can have fluent interface (return `this` from methods)
- Consider using method chaining for better readability
- Can provide default values for optional parameters
- In C#, can combine with object initializers for hybrid approach
- Use `Build()` method to return final immutable product
- Consider validation in `Build()` method before returning product

---

## Prototype

### 📋 Intent
Specify the kinds of objects to create using a prototypical instance, and create new objects by copying this prototype.

### 🎯 Real-World Analogy
Photocopying documents or biological cell division. Instead of creating a document from scratch (typing everything), you make a copy and modify only what needs to change. The original serves as a prototype for new instances.

### 🏗️ Structure
```
Prototype (interface)
└── Clone() : Prototype

ConcretePrototype
└── Clone() : creates deep/shallow copy of itself

Client
└── Uses Clone() to create new objects
```

**Key Participants:**
- **Prototype**: Interface declaring the cloning method
- **ConcretePrototype**: Implements cloning operation
- **Client**: Creates new objects by asking prototype to clone itself

### ✅ When to Use
- Object creation is expensive (database queries, network calls, complex computations)
- System should be independent of how products are created
- Classes to instantiate are specified at runtime (dynamic loading)
- Object has only a few different combinations of state
- You want to avoid building a class hierarchy of factories parallel to products
- Object initialization requires complex setup that you want to reuse

### ❌ When NOT to Use
- Object creation is simple and inexpensive
- Objects have many references to other objects (complex cloning)
- Objects contain circular references
- Deep copying is difficult to implement correctly
- Objects are immutable (just reuse the same instance)
- Small number of object configurations (use factory instead)

### 💪 Advantages
- **Reduced Initialization Cost**: Clone instead of reinitialize
- **Runtime Flexibility**: Add/remove objects at runtime
- **Reduced Subclassing**: Alternative to Factory Method's subclass explosion
- **Dynamic Product Configuration**: Configure objects dynamically
- **Hide Complexity**: Hide complex creation logic from client
- **Performance**: Can be faster than creating from scratch

### ⚠️ Disadvantages
- **Cloning Complexity**: Deep cloning complex objects with circular references is tricky
- **Clone vs Copy Constructor**: Requires careful implementation
- **Mutable State**: Cloning objects with mutable fields requires deep copying
- **Override Clone**: Each subclass must implement cloning
- **Circular References**: Difficult to handle properly

### 🔍 Implementation Notes
- **Shallow Copy**: Copies object fields; references point to same objects
- **Deep Copy**: Recursively copies all objects referenced by fields
- In C#, implement `ICloneable` interface or create custom `Clone()` method
- Consider using serialization for deep cloning (serialize/deserialize)
- Use copy constructors as alternative to clone methods
- Prototype Registry: Maintain a dictionary of prototypes for easy access
- Consider thread safety if prototypes are shared across threads
- MemberwiseClone() in C# provides shallow copy by default

---

## Singleton

### 📋 Intent
Ensure a class has only one instance and provide a global point of access to it.

### 🎯 Real-World Analogy
A government has one president at a time. No matter which department needs to communicate with the president, they all access the same person. There's only one instance, and everyone knows how to access it.

### 🏗️ Structure
```
Singleton
├── private static instance
├── private constructor
└── public static GetInstance() : Singleton
```

**Key Participants:**
- **Singleton**: Defines an Instance operation for accessing the unique instance, and is responsible for creating its own unique instance

### ✅ When to Use
- Exactly one instance of a class must exist
- Instance must be accessible from well-known access point
- The sole instance should be extensible by subclassing
- Controlling access to shared resources (database connections, file managers, loggers)
- Managing global application state (configuration, caching)
- Coordinating actions across the system

### ❌ When NOT to Use
- Multiple instances might be needed in the future
- Testing is important (Singletons are hard to mock)
- You're using it just to provide global access (use dependency injection)
- Concurrent access without proper synchronization is needed
- The object has state that changes frequently
- It introduces tight coupling between components

### 💪 Advantages
- **Controlled Access**: Controlled access to sole instance
- **Reduced Namespace Pollution**: Better than global variables
- **Permits Refinement**: Can be subclassed
- **Lazy Initialization**: Instance created only when needed
- **Global Access Point**: Accessible from anywhere in application
- **Memory Efficient**: Only one instance in memory

### ⚠️ Disadvantages
- **Violates Single Responsibility**: Controls its own creation and lifecycle
- **Tight Coupling**: Code becomes tightly coupled to Singleton
- **Testing Difficulty**: Hard to mock or replace in unit tests
- **Concurrency Issues**: Requires careful thread-safe implementation
- **Hidden Dependencies**: Dependencies not obvious in class constructors
- **Global State**: Can lead to unexpected side effects
- **Lifetime Management**: No explicit cleanup mechanism

### 🔍 Implementation Notes

**Thread-Safe Implementations in C#:**

1. **Lazy<T> (Recommended)**
   - Thread-safe by default
   - Lazy initialization
   - Cleanest implementation

2. **Static Constructor**
   - Thread-safe guaranteed by CLR
   - Eager initialization
   - No lazy initialization control

3. **Double-Check Locking**
   - Thread-safe with lazy initialization
   - More complex
   - Potential for subtle bugs

4. **Lock-Based**
   - Thread-safe but impacts performance
   - Simple but inefficient

**Best Practices:**
- Use `sealed` class to prevent inheritance issues
- Make constructor private
- Consider using dependency injection instead
- For testability, consider using an interface
- Be aware of serialization issues (implement `ISerializable` carefully)
- In multi-threaded environments, always use thread-safe implementation
- Consider using static class if no inheritance needed

**Alternatives to Consider:**
- Dependency Injection with singleton scope
- Monostate pattern (all members static)
- Static class (if no state needed)

---

## Pattern Comparison

| Aspect | Factory Method | Abstract Factory | Builder | Prototype | Singleton |
|--------|---------------|------------------|---------|-----------|-----------|
| **Focus** | Create one product | Create families | Step-by-step construction | Clone existing | Single instance |
| **Flexibility** | High | Medium | High | Medium | Low |
| **Complexity** | Low | High | Medium | Low | Low |
| **When Object Created** | Each call | Each call | After all steps | On clone | Once (lazy or eager) |
| **Number of Instances** | Many | Many | Many | Many | One |
| **Inheritance** | Yes | Yes | No (composition) | No (cloning) | No |
| **Use Case** | Variations of one product | Related product families | Complex objects | Expensive creation | Global access |

### Choosing the Right Pattern

**Use Factory Method when:**
- You have one product type with variations
- Subclassing is natural for your design

**Use Abstract Factory when:**
- You need to create families of related objects
- Product consistency is important

**Use Builder when:**
- Object has many optional parameters
- Construction is multi-step process

**Use Prototype when:**
- Creating new instance is expensive
- You have many similar objects

**Use Singleton when:**
- Exactly one instance must exist
- Global access is required

---

## Common Interview Questions

### Factory Method
**Q: What's the difference between Factory Method and Simple Factory?**
A: Simple Factory is not a GoF pattern. It's a method that encapsulates object creation. Factory Method uses inheritance and lets subclasses decide which class to instantiate.

**Q: Can Factory Method return different types?**
A: Yes, as long as they all implement the same interface or inherit from the same base class.

### Abstract Factory
**Q: Factory Method vs Abstract Factory?**
A: Factory Method creates one product through inheritance. Abstract Factory creates families of related products through object composition.

**Q: What's the main drawback of Abstract Factory?**
A: Adding new product types requires changing all factory interfaces and implementations.

### Builder
**Q: Builder vs Constructor with parameters?**
A: Builder is better when you have many optional parameters (telescoping constructor problem) or when construction requires multiple steps.

**Q: Is Director necessary?**
A: No, Director is optional. Client can call builder methods directly for more flexibility.

### Prototype
**Q: Shallow copy vs Deep copy?**
A: Shallow copy duplicates the object but references point to same objects. Deep copy recursively copies all referenced objects.

**Q: When is cloning better than instantiation?**
A: When object creation is expensive (database calls, network requests, complex initialization).

### Singleton
**Q: How do you make Singleton thread-safe in C#?**
A: Use `Lazy<T>`, static constructor, double-check locking, or lock-based approach. `Lazy<T>` is recommended.

**Q: What are alternatives to Singleton?**
A: Dependency Injection with singleton scope, Monostate pattern, or static classes.

**Q: Why are Singletons considered anti-pattern by some?**
A: They introduce global state, tight coupling, and make testing difficult. However, they're useful when used appropriately.

---

## Additional Resources

- Review the code examples in each pattern folder
- Each folder contains practical implementations demonstrating real-world scenarios
- Practice implementing these patterns from scratch
- Consider combinations: Abstract Factory with Factory Method, Builder with Prototype, etc.
