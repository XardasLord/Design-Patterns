# Design-Patterns
Many different Design Pattern examples with specific descriptions in C#.

### Solution contains following design patterns:
- **Adapter**
- **Bridge**
- **Builder**
  - Fluent Builder
- **Command**
  - With Undo Operations
- **Composite**
  - Geometric Shapes example
  - Neural Networks example
- **Decorator**
  - Decorator-Adapter
- **Factory**
  - Factory method
  - Abstract factory
- **Façade**
  - [External MdxConsole (a console written in Managed DirectX)](https://github.com/ActiveMesa/MdxConsole)
- **Flyweight**
  - Repeating User Names
  - Text Formatting
- **Mediator**
  - Chat Room
  - Event Broker
- **Null Object**
- **Prototype**
  - IClonable (not recommended)
  - Copy Constructors (better than IClonable)
  - Explicit Deep Copy (using our own generic interface - better than IClonable)
  - Serialization (best way to deep copy objects)
- **Singleton**
  - Tests and Dependency Injection using the Singleton
  - Monostate
- **Strategy**
  - Dynamic (at runtime)
  - Static (at compile time)
- **Template Method**


# Motivation of using each of the design pattern:

## Builder
*When construction gets a little bit too complicated.*
- object requires a lot of ceremony to create (object with 10 constructor parameters is not productive)
- provides an API to for constructing an object step-by-step (e.g. fluent API)

## Factory
*A component responsible solely for the wholesale (not piecewise) creation of objects.*
- object creation logic becomes too convoluted
- constructor is not really a great way to describe how to construct an object
- cannot overload with same sets of arguments with different names

## Prototype
*When it's easier to copy an existing object to fully initialize a new one.*
- complicated object (e.g., cars) aren't designed from scratch
- an existing (partially or fully constructed) design is a Prototype
- we make a copy (clone) the prototype and customize it (requires 'deep copy')
- we make the cloning convenient (e.g., via a Factory)

## Singleton
*A component which is instantiated only once.*
- for some components it only makes sense to have one in the system (e.g., database repository, object factory)
- when the constructor call is expensive
- want to prevent anyone creating additional copies
- need to take care of lazy instantiation and thread safety

## Adapter
*Getting the interface you want from the interface you have.*

## Bridge
*Connecting components together through abstraction.*
- bridge prevents 'Cartesian products' complexity explosion

## Composite
*Treating individual and aggregate objects uniformly.*
- composition lets us make compoind objects
  - E.g., a mathematical expression composed of simple expressions; or
  - A Grouping of shapes that consists of several shapes
- this pattern is used to treat both single (scalar) and composite objects uniformly
  - E.g., Foo and Collection<Foo> have common APIs

## Decorator
*Adding behavior without altering the class itself.*
- want to augment an object with additional functionality
- do not want to rewrite or alter existing code (OCP)
- want to keep new functionality separe (SRP)
- need to be able to interact with existing structures
- two options:
  - Inherit from required object if possible (some object are sealed and you just can't)
  - build a Decorator, which simply references the decorated object(s)

## Façade
*Exposing several components through a single interface. Provides a simple, easy to understand/user interface over a large and sophisticated body of code.*

## Flyweight
*A space optimization technique that lets us use less memory by storing externally the data associated with similar objects.*
- Avoid redundancy when storing data
- E.g., MMORPG game
  - Plenty of users with identical first/last names
  - No sense in storing same first/last name over and over again
  - Store a list of names and pointers to them
- .NET performs string interning, so an identical string is stored only once (because string are immutable)
- E.g., bold or italic text in the console
  - Don't want each character to have a formatting character
  - Operate on ranges (e.g., line number, start/end positions)
  
## Strategy
*Enables the exact behavior of a system to be selected either at run-time (dynamic) or compile-time (static).*

## Command
*An object which represents an instruction to perform a particular action. Contains all the information necessary for the action to be taken.*

## Null Object
*An object which represents an instruction to perform a particular action. Contains all the information necessary for the action to be taken.*
- To implement this pattern you have to:
  - Implement the required interface
  - Rewrite the methods with empty bodied
    - If methods is non-void, return `default<T>`
    - If these values are ever used, you are in trouble
  - Supply an instance of Null Object in place of actual object
  - Dynamic construction possible
    - With associated performance implications
    
## Template Method
*Allows us to define the 'skeleton' of the algorithm, with concrete implementations defined in subclasses.*
- Algorithm can be decomposed into commont parts + specifics
- Strategy pattern does this throught composition
  - High-level algorithm uses an interface
  - Concrete implementations implement the interface
- Template Method does the same thing through inheritance
  - Overall algorithm makes use of abstract member
  - Inheritors override the abstract members
  - Parent template method invoked
  
## Mediator
*Facilitates communication between components.*
- Components may go in and out of a system at any time
  - Chat room participants
  - Players in an MMORPG game
- It makes no sense for them to have direct references to one another
  - Those references may go dead
- Solution: have then all refer to some central component that facilitates communication (that component happens to be the mediator).

**Description is regularly updated**
