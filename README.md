# Auto Mapper in C#

### What is AutoMapper in C#?
The AutoMapper in C# is a mapper between two objects. That is AutoMapper is an object-object mapper. It maps the properties of two different objects by transforming the input object of one type to the output object of another type.

### Where can I get it?
First, install NuGet. Then, install AutoMapper from the package manager console:
```
PM> Install-Package AutoMapper
```
### What is AutoMapper Complex Mapping in C#?
When both the type involved in the mapping contains properties of the complex type then in such scenarios we need to use the AutoMapper Complex Mapping in C#.

### When to map Complex type to Primitive Type using AutoMapper in C#?
When one class contains primitive types or you can say the simple types and the other class contains complex type involved in the mapping then in such scenarios we need to Map the Complex Type to the Primitive Types.

### How to map Complex type to Primitive Type using AutoMapper in C#?
In order to map the complex type to the primitive types we need to use the ForMember and need to specify the source and target properties.

### What is AutoMapper Reverse Mapping in C#?
The Automapper Reverse Mapping is nothing but the two-way mapping which is also called as bidirectional mapping.

### What is AutoMapper Conditional Mapping?
The AutoMapper in C# allows us to add conditions to the properties of the source object that must be met before that property going to be mapped to the property of the destination object.  For example, if we want to map a property only if its value is greater than 0, then in such a situation we need to use C# AutoMapper Conditional Mapping. 

### Why do we need AutoMapper Ignore Property in C#?
By default, AutoMapper tries to map all the properties from the source type to the destination type when both source and destination type property names are same. If you want some of the properties not to map with the destination type property then you need to use the AutoMapper Ignore Property in C#

### Understanding the AutoMapper UseValue() and ResolveUsing() methods
The AutoMapper UseValue() method is used to retrieve a value on the first-run and stores it in the mapping whereas the ResolveUsing() method resolves at run-time.
