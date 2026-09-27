# OOP05 - Assignment 05

## Part 01: Theoretical Questions

### Q1 Object Copying
- **a) What happens when you assign one object variable to another object variable?**  
  Only the reference (memory address) is copied. Both variables now point to the exact same object in heap memory.
- **b) Does assigning one object to another create a new object? Explain.**  
  No. No new memory or instance is created in the heap; it is just two pointers pointing to the same single object.
- **c) What is the difference between copying an object and copying its reference?**  
  Copying a reference copies only the memory address (shared object). Copying an object creates a brand new instance in memory with duplicated data.

---

### Q2 Shallow Copy vs Deep Copy
- **a) What is a Shallow Copy?**  
  A copy where value-type fields are duplicated, but reference-type fields only copy their addresses (both point to the same nested objects).
- **b) What is a Deep Copy?**  
  A complete copy that duplicates the object and creates brand new copies of all nested reference objects inside it.
- **c) What happens to reference-type members when a Shallow Copy is created?**  
  Both original and copied objects share the same nested reference objects. Changing one affects the other.
- **d) What happens to reference-type members when a Deep Copy is created?**  
  Each object has its own separate nested objects. Changing one does not affect the other.
- **e) Give one situation where Deep Copy would be safer than Shallow Copy.**  
  When an object contains nested data (like `DeliveryAddress` or a list of items) that should be edited independently without accidentally corrupting the original.

---

### Q3 Static Members
- **a) What is a static field, and how is it different from an instance field?**  
  A static field belongs to the class itself and has one shared value for all objects. An instance field belongs to a specific object, so each instance has its own separate copy.
- **b) What is a static method? Can a static method directly access instance members?**  
  A method called directly on the class without creating an object. No, it cannot directly access instance members because it is not tied to any specific object instance (`this` does not exist).
- **c) What is a static constructor, and when is it executed?**  
  A parameterless constructor that initializes static data. It runs automatically once before the class is used for the first time or before any instance is created.
- **d) What is a static class? Can you create an object from a static class?**  
  A class that contains only static members and cannot be instantiated with `new` or inherited.

---

### Q4 Extension Methods
- **a) What is an Extension Method?**  
  A static method that allows you to "add" new methods to an existing type without modifying its original source code or inheriting from it.
- **b) What keyword must be used in the first parameter of an extension method?**  
  The `this` keyword before the type being extended (e.g., `this Shipment shipment`).
- **c) Where must an extension method be declared?**  
  Inside a non-nested, static class.
- **d) Can an extension method access private members of the class it extends?**  
  No. It can only access public and internal members, exactly like any regular external code.

---

### Q5 Partial Classes and Partial Methods
- **a) What is a Partial Class?**  
  A class split across multiple `.cs` files using the `partial` keyword. The compiler merges them into one single class at compile time.
- **b) Why would a developer split one class into multiple files?**  
  To organize large classes by feature/responsibility, or to separate auto-generated code from human-written code.
- **c) What is a Partial Method?**  
  A method declared in one part of a partial class and optionally implemented in another part of the same class.
- **d) What happens if a declared partial method has no implementation?**  
  The compiler completely removes the method declaration and any calls to it during compilation, with zero performance cost at runtime.
