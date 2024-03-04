# Animals (C#)

---

### Introduction

This project is a simple demonstration of abstract classes and polymorphism.

When we create an abstract class and then extend from it, we MUST implement 
all of the abstract functions in it. 


---

### Abstract Class vs Interface

It's useful to remember, we use an abstract class, when we want to create a 
base class, which will be extended by similar classes.

We use an interface when we want to establish common functionality, but in 
the classes which implement our interface, they don't necessarily need to be 
directly related. They just need to implement the common functionality.


In our case, it's better to use an Abstract Class, because our subclasses
are related. A Cat is an Animal. A Dog is an Animal... etc. 

--- 
 

