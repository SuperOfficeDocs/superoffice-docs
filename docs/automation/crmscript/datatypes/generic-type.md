---
title: crmscript_datatypes_generic
description: Generic data type
author:
so.date:
keywords:
so.topic:
---

# Generic data type

Generic is the base type of all other intrinsic CRMScript data types. Any variable can be up-casted to Generic.

There's a close connection between Generic and [structs][1]:

* simpler iteration of variables (struct members)
* easier to access and set new variables in structs
* possible to change which variables are members without having to hard-code each field

By using this datatype, especially with structs, you can limit the amount of code. You won't have to create as many duplicate functions to handle different types - simply place all logic inside 1 function and let it act accordingly to the type.

## Type and value

### String getTypeName(Generic generic)

`getTypeName()` returns the type of a variable.

```crmscript!
printLine(getTypeName(getCurrentDateTime()));
```

### Generic getGenericValue(String name)

`getGenericValue()` returns a variable from the run-time environment given its name and independent of its type.

```crmscript!
Integer age = 42;
Generic g = getGenericValue("age");
printLine(GenericToInteger(g).toString());
```

> [!NOTE]
> If the variable name is unknown, an [exceptions][2] is thrown.

## Down-casting

You can convert a Generic variable to these basic types.

* Bool GenericToBool(Generic generic)
* Integer GenericToInteger(Generic generic)
* Float GenericToFloat(Generic generic)
* String GenericToString(Generic generic)
* DateTime GenericToDateTime(Generic generic)
* Date GenericToDate(Generic generic)
* Time GenericToTime(Generic generic)
* TimeSpan GenericToTimeSpan(Generic generic)
* Byte GenericToByte(Generic generic)
* Generic[] GenericToArray(Generic generic)

Together with `getTypeName()`, these methods can be used to create an explicit typed variable.

```crmscript
Generic g = getCurrentDateTime();
if (getTypeName(g) == "DateTime") {
  DateTime dt = GenericToDateTime(g);
}

```

## Generic and arrays

### Integer getTypeDimensions(Generic generic)

`getTypeDimensions()` returns the number of array dimensions for a variable. The argument is automatically up-casted to a Generic.

```crmscript!
Integer[][] i;
printLine(getTypeDimensions(i).toString());

```

> [!NOTE]
> This is the number of dimensions in, **not the length** of, the array!

## Generic and structs

The following examples build on this Person struct:

```crmscript
struct Person {
  String name;
  Integer age;
};
```

### Bool typeIsStruct(Generic generic)

`typeIsStruct()` checks whether a variable is a struct.

Check whether a variable is a struct or not. The argument is automatically be up-casted to a Generic.

```crmscript!
struct Person {
  String name;
  Integer age;
};

Person p;
if (typeIsStruct(p)) {
  printLine("10-4");
}
```

### String[] getStructMembers(String name)

`getStructMembers()` returns the variable names of a struct given its name.

> [!NOTE]
> This is the names, **not the actual values**. To get those, call `getGenericValue()` using the member names.

```crmscript!
struct Person {
  String name;
  Integer age;
};

Person p;

String[] members = getStructMembers(getTypeName(p));

foreach (String s in members) {
  printLine(s);
}
```

### Generic getGenericValue(Generic struct, String name)

A variant of `getGenericValue()` that returns a variable from the run-time environment **inside a struct** given its name and independent of its type.

```crmscript
Person p;
p.age = 42;
Generic g = getGenericValue(p, "age");

```

> [!NOTE]
> If the variable name is unknown or you're not referencing a struct, an [exceptions][2] is thrown.

### String convertGenericToString(Generic generic)

`convertGenericToString()` returns the string representation of a variable.  The argument is automatically be up-casted to a Generic.

This works for all **basic** types. Complex types might can't be serialized as easy, and might not support this conversion. In that case, they'll return “[complex]”.

```crmscript!
Integer age = 42;
String s = convertGenericToString(age);
printLine(s);
```

### Void setGenericFromString(Generic generic, String value)

`setGenericFromString()` sets the value of a variable from a string.

It supports only basic types. Attempting to set an array or a complex type will throw an exception.

The value **must be formatted** according to the constructor of that type. Specifically, Date, DateTime, and Time must be on the YYYY-MM-DD HH:MI:SS format.

> [!TIP]
> In combination with `getStructMembers()` and `getGenericValue()`, this function can be used to iterate a struct and set all its members programmatically instead of having to explicit hard-code each of them.

### Print contents of struct for extra table

In this scenario, we've created an extra table called **Building**. It has multiple extra fields of different types.

```crmscript
Struct Building {
  Integer id;
  String name;
  String address;
  Date acquired;
  Date next_service;
  Integer floors;
  Bool has_janitor;
  Bool is_rented;
  Float value;
  Time opens;
  Time closes;
};
```

So instead of defining a `print()` method in the struct, with 1 printLine() for every member, and manually converting each value to a string like this:

```crmscript
Void print() {
  printLine("id: " + this.id.toString());
  printLine("name: " + this.name);
  //...
  printLine("value: " + this.value.toString(2));
  //...
}
```

You can define a `printGeneric()` method and leverage the Generic struct methods:

```crmscript
Void printGeneric() {
  String[] members = getStructMembers("Building");
  foreach(String field in members) {
    Generic g = getGenericValue(this, field);
    printLine(field + ": " + convertGenericToString(g));
  }
}
```

### Parse from Json to Struct

In this scenario, still using our **Building** extra table, we'd like to to parse from Json into a struct.

**Without Generic:**

```crmscript
Building Building(String json) {
  Building b;
  XMLNode root = parseJSON(json);

  b.id = root.getValueFromPath("id").toInteger();
  b.name = root.getValueFromPath("name");
  //...
  b.is_rented = root.getValueFromPath("is_rented").toBool();
  b.value = root.getValueFromPath("id").toFloat();
  //...
  return b;
}
```

**With Generic:**

```crmscript
Building BuildingGeneric(String json) {
  Building b;
  XMLNode root = parseJSON(json);

  String[] members = getStructMembers("Building");

  foreach(String field in members) {
    Generic g = getGenericValue(b, field);
    String value = root.getValueFromPath(field);
    setGenericFromString(g, value);
  }
  
  return b;
}
```

Notice how this method doesn't have to know anything about the Building table. No variable names, no data types, and not even how many there are.

### Load from database to Struct

In this scenario, still using our **Building** extra table, we'd like to load data from the database into a struct.

**Without Generic:**

```crmscript
Building Building(Integer id) {
  Building b;
  
  SearchEngine se;
  se.addField("y_building.id");
  //...
  
  se.addCriteria("y_building.id", "Equals", id.toString());
  se.execute();
  
  if(!se.eof()) {
    b.id = se.getField("y_building.id").toInteger();
    //...
  }
  
  return b;
}
```

**With Generic:**

```crmscript
Building BuildingGeneric(Integer id) {
  Building b;
  SearchEngine se;
  String[] members = getStructMembers("Building");
  
  foreach(String field in members) {
    se.addField("y_building." + extraFieldName(field));
    se.addCriteria("y_building.id", "Equals", id.toString());
    se.execute();
  }  
  
  if(!se.eof()) {
    foreach(String field in members) {
      Generic g = getGenericValue(b, field);
      String value = se.getField("y_building." + extraFieldName(field));
      setGenericFromString(g, value);  
    }
  }
  return b;
}
```

<!-- Referenced links -->
[1]: ../fundamentals/structs.md
[2]: ../fundamentals/try-catch.md
