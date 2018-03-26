# Design-Patterns
Many different Design Pattern examples with specific descriptions in C#.

### Solution contains following design patterns:
- **Adapter**
- **Builder**
  - Fluent Builder
- **Factory**
  - Factory method
  - Abstract factory
- **Prototype**
  - IClonable (not recommended)
  - Copy Constructors (better than IClonable)
  - Explicit Deep Copy (using our own generic interface - better than IClonable)
  - Serialization (best way to deep copy objects)
- **Singleton**
  - Tests and Dependency Injection using the Singleton
  - Monostate
- **Composite**
- **Decorator**
- **Flyweight**
- **Strategy**

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

**Description is regularly updated**
