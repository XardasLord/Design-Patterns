# Design-Patterns
Many different Design Pattern examples with specific descriptions in C#.

### Solution contains following design patterns:
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

**Description is regularly updated**
