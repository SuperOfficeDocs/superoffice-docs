---
title: crmscript_fundamentals_structs
description: Structs
author:
so.date:
keywords:
so.topic: concept
---

# Structs

A **struct** defines the kinds of data and the functionality their objects will have. This data structure enables you to create your own custom types by grouping together variables of other types and methods.

You can think of a struct as a variable that can contain many values. Unlike arrays, which are limited to a single datatype, the struct can contain different data types and also methods.

Structs can also contain other structs, but not their own type. For example, you can't define a *node* struct and build a recursive tree of *nodes*.

## Defining structs

CRMScripts use immediate allocation. As with variables, methods must be declared before they are used.

The definition has 3 parts:

* keyword **struct**
* the name of the struct
* 1 or more statements enclosed in curly brackets, followed by a semi-colon

```crmscript
struct Car {
  String brand;
  String model;
  Integer modelYear;

  Void print() {
    print( this.brand + " " + this.model + ", " + this.modelYear.toString());
  }
};
```

The keyword **this** refers to ownership. Here, the print statement targets the variable values of a specific instance of the struct. We also need to call the **toString** method because **modelYear** is a number.

## Using structs

From the outside, you create an instance of the struct and then you can use **dot notation** to access its variables and methods.

* structName.methodName
* structName.variableName

```crmscript
Car myCar;
myCar.brand = "Volvo";
myCar.model = "XC60";
myCar.modelYear = 2019;
myCar.print();
```

This will output: Volvo XC60, 2019

### Function chaining

Method chaining is a pattern where multiple functions are called on the same object consecutively. Using the same object reference, multiple functions can be invoked. It increases the readability of the code and means less redundancy.

```crmscript!
struct Car {
  String brand;
  String model;

  Car brand(String carBrand) {
    this.brand = carBrand;
    return this;
  }
  
  Car model(String carModel) {
    this.model = carModel;
    return this;
  }
  
  Void print() {
    printLine(this.brand + ", " + this.model);
  }
};

Car car;
car.brand("Tesla")
   .model("S");
car.print();
```

You can achieve the same functionality in CRMScript by returning the current instance back from the executing function. Once the function executes on an object, the same object is returned, so that other functions of the object can be called and the process repeated.

In the code above, the function `brand` returns the current executing context back from the function call. The next function then executes on this context (referring to the same instance), and invokes the other functions associated with the struct.

Each of the functions returns the current execution context. The functions can be chained together because the previous execution returns results that can be processed further.

## Built-in Methods

### fromXMLNode

Populates a struct from an XMLNode.

Only supports the following element datatypes:

* Bool
* Float
* Integer
* String
* struct

Date and DateTime is not supported. JSON does not support these either.

Example:

```crmscript!
struct Hello {
  String who;
  Void setWho(String who) {
    this.who = who;
  }
  Void print() {
    printLine("Hello " + this.who);
  }
};

XMLNode xml = parseXML("<root><who>World</who></root>");

Hello h;
h.fromXMLNode(xml);
h.print();

//prints Hello World

```

Common Patterns:

As JSON has become the preferred transfer representation, it's common for structs to implement ways to be populated by a JSON string, and to write itself out as a JSON string.

Below are a couple common methods structs implement to facilitate reading and writing a struct using JSON.

```crmscript
struct Hello {
  String who;
  Void setWho(String who) {
    this.who = who;
  }
  Void print() {
    printLine("Hello " + this.who);
  }
  Void fromJson(String json) {
    this.fromXMLNode(parseJSON(json));
  }
  String toJson() {
    JSONBuilder jb;
    this.toJson(jb);
    return jb.getString();
  }
};
```

### toJson

Populates a JSONBuilder from a struct.

Only supports the following item datatypes:

* Bool
* Float
* Integer
* String
* struct

Date and DateTime is not supported. JSON does not support these either.

Example:
```crmscript!
struct Hello {
  String who;
  Void setWho(String who) {
    this.who = who;
  }
  Void print() {
    printLine("Hello " + this.who);
  }
};

JSONBuilder jsBuilder;
Hello h;

h.setWho("World");
h.toJson(jsBuilder);

print(jsBuilder.getString());

//prints {"who": "World"}
```

Common Patterns:

As JSON has become the preferred transfer representation, it's common for structs to implement ways to be populated by a JSON string, and to write itself out as a JSON string.

Below are a couple common methods structs implement to facilitate reading and writing a struct using JSON.

```crmscript
struct Hello {
  String who;
  Void setWho(String who) {
    this.who = who;
  }
  Void print() {
    printLine("Hello " + this.who);
  }
  Void fromJson(String json) {
    this.fromXMLNode(parseJSON(json));
  }
  String toJson() {
    JSONBuilder jb;
    this.toJson(jb);
    return jb.getString();
  }
};

Hello h;
h.setWho("John");

printLine(h.toJson());

// prints {"who": "John"}
```
