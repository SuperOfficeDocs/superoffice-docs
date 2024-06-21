---
uid: crmscript_fundamentals_structs
title: Structs
author:
date:
keywords:
topic: concept
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

> [!NOTE]
> For the types not supported natively by JSON, we will require/produce the following formats:
>
> * Date: converted to/from string with format "YYYY-MM-DD"
> * DateTime: converted to/from string with format "YYYY-MM-DDTHH:MI:SS"
> * Time: converted to/from string with format "HH:MI:SS"
> * Byte: converted to/from number.

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

### String toJsonString()

This function will return a JSON formatted string of the struct's contents. Same functionality as toJson(JSONBuilder), but it will return a string directly without having to instantiate a JSONbuilder.

Introduced or updated in version: 10.1.4

```crmscript!
struct Person {
  String firstname;
  String lastname;
  Date dob;
};

Person p;
p.firstname = "John";
p.lastname = "Doe";
p.dob = Date("1975-11-28");

printLine(p.toJsonString());
```

### toJson

Populates a JSONBuilder from a struct.

Only supports the following item datatypes:

* Bool
* Float
* Integer
* String
* struct

> [!NOTE]
> For the types not supported natively by JSON, we will require/produce the following formats:
>
> * Date: converted to/from string with format "YYYY-MM-DD"
> * DateTime: converted to/from string with format "YYYY-MM-DDTHH:MI:SS"
> * Time: converted to/from string with format "HH:MI:SS"
> * Byte: converted to/from number.

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

### Void fromJsonString(String json)

This function will set the struct to the contents of the supplied JSON formatted string. Same functionality as fromXMLNode(XMLNode n), but it will parse the provided string directly without having to use parseJSON() yourself.

Introduced or updated in version: 10.1.4

```crmscript!
struct Person {
  String firstname;
  String lastname;
  Date dob;
};

Person p;
p.fromJsonString('{"firstname": "Jon", "lastname": "Doe", "dob": "1984-10-26"}');
printLine(p.toJsonString());
```

### String toString()

If a struct has a function with this exact signature, then the result of this function is what will be used when an instance of this struct is serialized to a string. Specifically, this applies to the array buildString(String separator) method, as well as what is shown as the variable for script debugging and tracing.

Introduced or updated in version: 10.1.4

```crmscript!
struct Person {
  String firstname;
  String lastname;
  
  String toString() {
    return this.firstname + " " + this.lastname;
  }
};
```

### Bool compare(\<SameStruct\> s)

If a struct  has a function with this exact signature, then this method will be used to compare two instances of the struct when sorting an array of struct instances.

Introduced or updated in version: 10.1.4

```crmscript!
struct Person {
  String firstname;
  String lastname;
  
  String toString() {
    return this.firstname + " " + this.lastname;
  }
  
  Bool compare(Person p) {
    return this.toString() > p.toString();
  }
};

Person Person(String firstname, String lastname) {
  Person p;
  p.firstname = firstname;
  p.lastname = lastname;
  return p;
}

Person[] persons;
persons.pushBack(Person("John", "Doe"));
persons.pushBack(Person("Mark", "Wahlberg"));
persons.pushBack(Person("Anthony", "Hopkins"));

printLine("Before sort: " + persons.buildString("|"));
persons.sort();
printLine("After sort: " + persons.buildString("|"));
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
