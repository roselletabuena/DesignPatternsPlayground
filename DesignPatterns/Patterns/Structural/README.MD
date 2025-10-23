# Structural Design Patterns in C#

A comprehensive guide to the seven structural design patterns with practical examples and interview-focused explanations.

## 📚 Table of Contents
- [What Are Structural Patterns?](#what-are-structural-patterns)
- [Quick Reference Guide](#quick-reference-guide)
- [Adapter](#adapter)
- [Bridge](#bridge)
- [Composite](#composite)
- [Decorator](#decorator)
- [Facade](#facade)
- [Flyweight](#flyweight)
- [Proxy](#proxy)
- [Pattern Comparison](#pattern-comparison)
- [Common Interview Questions](#common-interview-questions)

---

## What Are Structural Patterns?

Structural patterns deal with object composition and relationships between entities. They explain how to assemble objects and classes into larger structures while keeping these structures flexible and efficient. These patterns focus on **how classes and objects are composed** to form larger structures.

**Key Benefits:**
- Simplify structure by identifying relationships
- Provide flexibility in composing interfaces and implementations
- Enable functionality extension without modifying existing code
- Promote loose coupling between components
- Support composition over inheritance

---

## Quick Reference Guide

| Pattern | Purpose | Use When |
|---------|---------|----------|
| **Adapter** | Convert interface to another interface | You need incompatible interfaces to work together |
| **Bridge** | Separate abstraction from implementation | Both abstraction and implementation should vary independently |
| **Composite** | Treat individuals and compositions uniformly | You need to represent part-whole hierarchies |
| **Decorator** | Add responsibilities dynamically | You need to add behavior without subclassing |
| **Facade** | Provide simplified interface to complex system | You need to simplify complex subsystem interactions |
| **Flyweight** | Share objects to support large numbers efficiently | You have many similar objects consuming memory |
| **Proxy** | Control access to objects | You need a placeholder or access control for objects |

---

## Adapter

### 📋 Intent
Convert the interface of a class into another interface clients expect. Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.

### 🎯 Real-World Analogy
A power adapter (travel adapter) allows you to plug your US device into European outlets. The adapter converts one interface (US plug) to another (European socket) without changing the device or the outlet.

### 🏗️ Structure
```
Client → Target (interface)
         ↑
         Adapter → Adaptee (existing class)
```

**Two Approaches:**
- **Class Adapter**: Uses multiple inheritance (not supported in C#)
- **Object Adapter**: Uses composition (preferred in C#)

**Key Participants:**
- **Target**: Interface the client expects
- **Adapter**: Converts Adaptee interface to Target interface
- **Adaptee**: Existing interface that needs adapting
- **Client**: Works with Target interface

### ✅ When to Use
- You want to use an existing class but its interface doesn't match what you need
- You need to create a reusable class that cooperates with unrelated classes
- You need to use several existing subclasses but it's impractical to adapt their interface by subclassing
- Third-party library integration with incompatible interfaces
- Legacy code integration without modifying the original code

### ❌ When NOT to Use
- You can modify the source code directly
- Interface differences are minimal (just rename methods)
- Creating adapter adds unnecessary complexity
- Performance overhead of delegation is unacceptable

### 💪 Advantages
- **Open/Closed Principle**: Can introduce new adapters without changing existing code
- **Single Responsibility Principle**: Separates interface conversion from business logic
- **Flexibility**: Can work with multiple adaptees through different adapters
- **Reusability**: Adapter can work with any compatible adaptee
- **Legacy Integration**: Integrate old code without modification

### ⚠️ Disadvantages
- **Increased Complexity**: Additional classes and indirection
- **Performance Overhead**: Extra layer of delegation
- **Too Many Adapters**: Can lead to adapter proliferation
- **Limited Adaptation**: Can only adapt public interfaces

### 🔍 Implementation Notes
- Prefer composition over inheritance (Object Adapter)
- Adapter can adapt multiple adaptees if needed
- Can implement two-way adapters for bidirectional conversion
- Consider using extension methods in C# for simple adaptations
- Can combine with Factory pattern for adapter selection

---

## Bridge

### 📋 Intent
Decouple an abstraction from its implementation so that the two can vary independently. This pattern creates a bridge between the abstraction hierarchy and the implementation hierarchy.

### 🎯 Real-World Analogy
A remote control (abstraction) works with various TV brands (implementations). You can have different remote types (basic, advanced) that work with different TV brands (Sony, Samsung). Both can evolve independently.

### 🏗️ Structure
```
Abstraction → Implementor (interface)
    ↑              ↑
RefinedAbstraction  ConcreteImplementor
```

**Key Participants:**
- **Abstraction**: Defines high-level control interface, maintains reference to Implementor
- **RefinedAbstraction**: Extends abstraction interface
- **Implementor**: Interface for implementation classes
- **ConcreteImplementor**: Concrete implementation of Implementor interface

### ✅ When to Use
- You want to avoid permanent binding between abstraction and implementation
- Both abstraction and implementation should be extensible by subclassing
- Changes in implementation shouldn't affect clients
- You have a proliferation of classes from coupled abstractions and implementations
- You want to share implementation among multiple objects
- Platform-independent code (e.g., cross-platform UI frameworks)

### ❌ When NOT to Use
- Only one implementation exists and won't change
- Abstraction and implementation are tightly coupled by design
- Simple one-to-one relationship exists
- Additional abstraction layer adds unnecessary complexity

### 💪 Advantages
- **Independent Variation**: Abstraction and implementation can vary independently
- **Open/Closed Principle**: Can extend abstractions and implementations independently
- **Platform Independence**: Can switch implementations at runtime
- **Reduced Coupling**: Client code independent of implementation details
- **Improved Extensibility**: Easy to add new abstractions or implementations
- **Single Responsibility**: Separates high-level logic from platform details

### ⚠️ Disadvantages
- **Increased Complexity**: More classes and interfaces
- **Harder to Understand**: Indirection makes code harder to follow
- **Design Overhead**: Requires careful planning upfront
- **Potential Overkill**: Too complex for simple scenarios

### 🔍 Implementation Notes
- Implementor can be an abstract class or interface
- Abstraction delegates work to Implementor
- Can pass Implementor through constructor or setter
- Consider using dependency injection for Implementor
- Bridge is about design-time separation, not runtime adaptation
- Often confused with Adapter (Adapter fixes incompatibility, Bridge prevents it)

---

## Composite

### 📋 Intent
Compose objects into tree structures to represent part-whole hierarchies. Composite lets clients treat individual objects and compositions of objects uniformly.

### 🎯 Real-World Analogy
A military hierarchy: an army consists of divisions, divisions consist of brigades, brigades consist of platoons, and platoons consist of soldiers. You can give an order to a soldier or to an entire army; the structure handles it appropriately.

### 🏗️ Structure
```
Component (interface)
    ↑
    ├── Leaf (individual object)
    └── Composite (container)
            └── contains Component[]
```

**Key Participants:**
- **Component**: Interface for objects in composition, declares common operations
- **Leaf**: Represents individual objects (no children)
- **Composite**: Stores child components, implements child-related operations
- **Client**: Manipulates objects through Component interface

### ✅ When to Use
- You want to represent part-whole hierarchies of objects
- You want clients to treat individual and composite objects uniformly
- You need tree structures (file systems, organizational charts, UI components)
- Operations should be applied recursively through the tree
- You want to ignore the difference between compositions and individual objects

### ❌ When NOT to Use
- Tree structure is not needed
- Components have very different interfaces
- You need type safety (hard to restrict child types)
- Leaf and Composite operations are significantly different
- Performance cost of recursive operations is too high

### 💪 Advantages
- **Uniform Treatment**: Clients treat individual and composite objects the same way
- **Easier to Add New Components**: New leaf or composite types work automatically
- **Simplified Client Code**: Clients don't need conditional logic for different types
- **Recursive Composition**: Can create complex trees from simple parts
- **Open/Closed Principle**: New component types without changing existing code

### ⚠️ Disadvantages
- **Overly General Design**: Hard to restrict component types
- **Type Safety Issues**: Difficult to enforce child type constraints
- **Complexity**: Can make design overly general
- **Performance**: Recursive operations can be expensive for deep hierarchies

### 🔍 Implementation Notes
- Component interface should define operations common to both leaf and composite
- Composite stores collection of child components
- Consider where to define child management operations (Component or Composite)
- Handle edge cases: what happens with operations on leaf vs composite
- Consider using Iterator pattern for traversing the tree
- Parent references can help with navigation but add coupling
- Consider caching for performance in deep hierarchies

---

## Decorator

### 📋 Intent
Attach additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.

### 🎯 Real-World Analogy
Wearing clothes: you can wear a t-shirt, add a jacket, add a raincoat. Each layer adds functionality (warmth, water resistance) without changing the person underneath. You can add or remove layers dynamically.

### 🏗️ Structure
```
Component (interface)
    ↑
    ├── ConcreteComponent
    └── Decorator (has Component)
            └── ConcreteDecorators
```

**Key Participants:**
- **Component**: Interface for objects that can have responsibilities added
- **ConcreteComponent**: Object to which additional responsibilities can be attached
- **Decorator**: Maintains reference to Component, conforms to Component interface
- **ConcreteDecorator**: Adds responsibilities to the component

### ✅ When to Use
- You need to add responsibilities to individual objects dynamically and transparently
- You need to add responsibilities that can be withdrawn
- Extension by subclassing is impractical (class explosion)
- You need to add functionality in a flexible, reusable way
- You want to combine behaviors in different ways
- You can't use inheritance (sealed classes)

### ❌ When NOT to Use
- Only one additional responsibility is needed (use subclassing)
- Order of decoration doesn't matter and you need type safety
- Decorator chain becomes too complex
- Performance overhead of multiple decorators is unacceptable
- Object identity is important (decorators change object identity)

### 💪 Advantages
- **More Flexible Than Inheritance**: Can add/remove responsibilities at runtime
- **Avoids Feature-Laden Classes**: Functionality divided into simple decorators
- **Composable**: Can combine decorators in different ways
- **Single Responsibility Principle**: Each decorator has one concern
- **Open/Closed Principle**: Extend behavior without modifying existing code
- **Pay-as-you-go**: Add only needed functionality

### ⚠️ Disadvantages
- **Many Small Objects**: Can result in many small, similar-looking objects
- **Complexity**: Harder to understand and debug
- **Order Matters**: Decorator application order affects behavior
- **Identity Issues**: Decorated object isn't identical to original
- **Configuration**: Can be complex to configure multiple decorators

### 🔍 Implementation Notes
- Decorator interface should match Component interface exactly
- Can use abstract Decorator base class for common functionality
- Consider decorator ordering carefully
- Can use dependency injection to configure decorators
- Keep decorators focused on single responsibility
- Consider using fluent interface for decorator chaining
- Be aware of issues with equality and identity comparisons

---

## Facade

### 📋 Intent
Provide a unified interface to a set of interfaces in a subsystem. Facade defines a higher-level interface that makes the subsystem easier to use.

### 🎯 Real-World Analogy
Ordering food at a restaurant: you tell the waiter what you want (simple interface), and the waiter coordinates with kitchen, chef, inventory, and billing (complex subsystem). You don't need to know about the kitchen's internal organization.

### 🏗️ Structure
```
Client → Facade → SubsystemClasses
                  ├── ClassA
                  ├── ClassB
                  └── ClassC
```

**Key Participants:**
- **Facade**: Knows which subsystem classes handle requests, delegates client requests to appropriate subsystem objects
- **Subsystem Classes**: Implement subsystem functionality, handle work assigned by Facade
- **Client**: Uses Facade instead of subsystem classes directly

### ✅ When to Use
- You want to provide a simple interface to a complex subsystem
- There are many dependencies between clients and implementation classes
- You want to layer your subsystems
- You need to decouple subsystem from clients and other subsystems
- You want to wrap a poorly designed API with a better interface
- Complex initialization or configuration is needed

### ❌ When NOT to Use
- Subsystem is already simple
- You need access to all subsystem features (Facade may limit access)
- Subsystem will change frequently (Facade becomes maintenance burden)
- Creating an additional layer adds no value

### 💪 Advantages
- **Simplified Interface**: Shields clients from subsystem complexity
- **Loose Coupling**: Reduces dependencies between subsystems and clients
- **Layering**: Promotes layering and defines entry points
- **Flexibility**: Clients can still use subsystem classes directly if needed
- **Easier to Use**: Provides convenient methods for common tasks
- **Better Organization**: Provides a clear entry point to subsystem

### ⚠️ Disadvantages
- **God Object Risk**: Facade can become coupled to all subsystem classes
- **Limited Functionality**: May not expose all subsystem features
- **Additional Layer**: Another class to maintain
- **Not a Strict Encapsulation**: Clients can bypass Facade

### 🔍 Implementation Notes
- Facade doesn't prevent direct access to subsystem
- Can have multiple facades for the same subsystem
- Facade is typically a singleton but doesn't have to be
- Consider creating facades for different use cases
- Keep facade focused on coordination, not business logic
- Facade can be combined with Abstract Factory for subsystem creation
- In C#, consider using extension methods for lightweight facades

---

## Flyweight

### 📋 Intent
Use sharing to support large numbers of fine-grained objects efficiently. Flyweight minimizes memory use by sharing as much data as possible with similar objects.

### 🎯 Real-World Analogy
A text editor doesn't create a separate object for each character; instead, it reuses character objects (font, size, color) and stores only the position (extrinsic state). One 'A' object with particular formatting is shared by all occurrences.

### 🏗️ Structure
```
Client → FlyweightFactory → Flyweight (interface)
                                ↑
                          ConcreteFlyweight
                          (stores intrinsic state)
```

**Key Participants:**
- **Flyweight**: Interface through which flyweights receive and act on extrinsic state
- **ConcreteFlyweight**: Stores intrinsic state (sharable), must be independent of context
- **FlyweightFactory**: Creates and manages flyweight objects, ensures sharing
- **Client**: Maintains reference to flyweights, computes/stores extrinsic state

### ✅ When to Use
- Application uses a large number of objects
- Storage costs are high because of the quantity of objects
- Most object state can be made extrinsic
- Many groups of objects can be replaced by relatively few shared objects
- Application doesn't depend on object identity
- Memory optimization is critical

### ❌ When NOT to Use
- Few objects exist (overhead not justified)
- No shared state exists between objects
- Object identity is important
- Extrinsic state is costly to compute or transfer
- Code complexity outweighs memory savings

### 💪 Advantages
- **Memory Savings**: Significantly reduces memory usage
- **Performance**: Can improve performance by reducing object creation
- **Centralized Management**: Flyweight factory manages shared instances
- **Scalability**: Enables applications to support many more objects

### ⚠️ Disadvantages
- **Complexity**: Separating intrinsic and extrinsic state adds complexity
- **Runtime Costs**: Computing/transferring extrinsic state can be expensive
- **Design Overhead**: Requires careful analysis of object state
- **Thread Safety**: Shared objects must be immutable or thread-safe
- **Debugging**: Shared state makes debugging harder

### 🔍 Implementation Notes
- **Intrinsic State**: Stored in flyweight, shared, context-independent
- **Extrinsic State**: Depends on context, stored by client
- Flyweight objects must be immutable
- Use factory to manage flyweight pool (typically with dictionary/cache)
- Consider using weak references for flyweight cleanup
- Thread safety is critical for shared flyweights
- In C#, consider using `ConditionalWeakTable<,>` for automatic cleanup
- String interning in .NET is an example of Flyweight pattern

---

## Proxy

### 📋 Intent
Provide a surrogate or placeholder for another object to control access to it. Proxy creates a representative object that controls access to another object.

### 🎯 Real-World Analogy
A credit card is a proxy for a bank account. It provides the same interface (payment) but adds access control, logging, and doesn't require carrying cash. The card controls access to your actual funds.

### 🏗️ Structure
```
Client → Subject (interface)
           ↑
           ├── RealSubject
           └── Proxy → RealSubject
```

**Key Participants:**
- **Subject**: Common interface for RealSubject and Proxy
- **RealSubject**: Real object that proxy represents
- **Proxy**: Maintains reference to RealSubject, controls access to it

### ✅ When to Use
- **Virtual Proxy**: Lazy initialization for expensive objects
- **Protection Proxy**: Control access based on permissions
- **Remote Proxy**: Represent object in different address space
- **Cache Proxy**: Cache expensive operation results
- **Smart Reference**: Additional actions when object accessed (reference counting, logging)
- **Logging Proxy**: Log method calls

### ❌ When NOT to Use
- Direct access is simpler and sufficient
- Overhead of proxy is unacceptable
- Real object is simple and inexpensive
- No need for access control or lazy initialization

### 💪 Advantages
- **Lazy Initialization**: Create expensive objects only when needed
- **Access Control**: Control access to real object
- **Remote Communication**: Handle network communication details
- **Performance**: Cache results, reduce redundant operations
- **Additional Logic**: Add logging, security, validation without changing real object
- **Open/Closed Principle**: Introduce proxies without changing real object

### ⚠️ Disadvantages
- **Response Delay**: Additional layer adds latency
- **Increased Complexity**: More classes and indirection
- **Overhead**: Extra object in memory
- **Maintenance**: Need to keep proxy and real object synchronized

### 🔍 Implementation Notes

**Proxy Types:**

1. **Virtual Proxy**
   - Delays object creation until actually needed
   - Common for large objects like images

2. **Protection Proxy**
   - Controls access based on permissions
   - Checks authorization before delegating

3. **Remote Proxy**
   - Represents object in different address space
   - Handles serialization and network communication

4. **Cache Proxy**
   - Caches results of expensive operations
   - Returns cached result when possible

5. **Smart Reference**
   - Adds additional actions (reference counting, locking)

**Implementation Tips:**
- Proxy should implement same interface as real object
- Consider using `Lazy<T>` in C# for virtual proxy
- Can use attributes and AOP frameworks for proxy generation
- In C#, consider `DispatchProxy` or Castle DynamicProxy for runtime proxies
- Keep proxy transparent to client

---

## Pattern Comparison

| Pattern | Intent | Structure | Key Difference |
|---------|--------|-----------|----------------|
| **Adapter** | Make incompatible interfaces compatible | Wrapper | Changes interface (converts) |
| **Bridge** | Separate abstraction from implementation | Two hierarchies | Prevents explosion (design-time) |
| **Composite** | Part-whole hierarchies | Tree structure | Treats individual and group uniformly |
| **Decorator** | Add responsibilities dynamically | Nested wrappers | Adds behavior (runtime) |
| **Facade** | Simplify complex subsystem | Simplified interface | Provides easier interface |
| **Flyweight** | Share objects efficiently | Object pool | Reduces memory (shares state) |
| **Proxy** | Control access to object | Placeholder | Controls access (same interface) |

### Commonly Confused Patterns

#### Adapter vs Bridge vs Facade
- **Adapter**: Fixes incompatibility (after classes designed)
- **Bridge**: Prevents incompatibility (during design)
- **Facade**: Simplifies complexity (doesn't change interface)

#### Decorator vs Proxy
- **Decorator**: Focus on adding responsibilities (enhancement)
- **Proxy**: Focus on controlling access (protection, lazy loading)
- Both have similar structure but different intent

#### Composite vs Decorator
- **Composite**: About hierarchy and treating uniformly
- **Decorator**: About adding responsibilities
- Composite can use Decorator, Decorator can wrap Composite

---

## Common Interview Questions

### Adapter
**Q: Adapter vs Bridge pattern?**
A: Adapter makes existing interfaces work together (reactive/post-design). Bridge separates abstraction from implementation to prevent coupling (proactive/during-design).

**Q: When would you use Adapter over directly modifying the class?**
A: When you can't modify source (third-party libraries), need to adapt multiple incompatible classes, or want to avoid coupling.

### Bridge
**Q: How is Bridge different from Strategy pattern?**
A: Bridge separates abstraction from implementation (both can vary). Strategy focuses on algorithm variation (swappable algorithms at runtime).

**Q: Can you give real-world usage of Bridge?**
A: Cross-platform UI frameworks (abstraction: Button, implementations: WindowsButton, MacButton), database drivers, graphics rendering systems.

### Composite
**Q: How do you handle operations that only make sense for Composite or Leaf?**
A: Define default implementations in Component (Leaf throws exception or does nothing for add/remove), or check type (breaks uniform treatment).

**Q: Composite vs Decorator?**
A: Composite is about hierarchy (part-whole), Decorator is about responsibilities. Composite can contain many children, Decorator usually wraps one object.

### Decorator
**Q: Decorator vs Inheritance?**
A: Decorator adds behavior at runtime dynamically and can be combined. Inheritance is static at compile-time and can lead to class explosion.

**Q: Disadvantages of Decorator?**
A: Many small objects, order matters, identity issues, harder to understand and debug.

### Facade
**Q: Is Facade the same as Adapter?**
A: No. Facade simplifies complex subsystem (many classes). Adapter makes two incompatible interfaces compatible (usually two classes).

**Q: Can clients access subsystem directly?**
A: Yes, Facade doesn't prevent direct access. It just provides a convenient interface.

### Flyweight
**Q: Explain intrinsic vs extrinsic state?**
A: Intrinsic state is shared, context-independent, stored in flyweight. Extrinsic state is context-dependent, varies per usage, stored by client.

**Q: When is Flyweight worth the complexity?**
A: When you have many objects (thousands+), most state can be shared, and memory is a concern.

### Proxy
**Q: What are the different types of Proxy?**
A: Virtual (lazy loading), Protection (access control), Remote (different address space), Cache (store results), Smart Reference (additional actions).

**Q: Proxy vs Decorator?**
A: Proxy controls access (same interface, adds control). Decorator adds responsibilities (enhances object). Intent differs though structure is similar.

---

## Pattern Selection Guide

**Need to make incompatible interfaces work together?**
→ **Adapter**

**Need to separate abstraction from implementation?**
→ **Bridge**

**Need to represent part-whole hierarchies?**
→ **Composite**

**Need to add responsibilities dynamically without subclassing?**
→ **Decorator**

**Need to simplify complex subsystem interactions?**
→ **Facade**

**Need to support many objects efficiently (memory)?**
→ **Flyweight**

**Need to control access or add lazy loading?**
→ **Proxy**

---

## Additional Resources

- Review the code examples in each pattern folder
- Each folder contains practical implementations demonstrating real-world scenarios
- Practice implementing these patterns from scratch
- Consider combinations: Composite + Iterator, Facade + Abstract Factory, etc.

