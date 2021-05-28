---
uid: crmscript_class_generic_getgenericvalue
title: Generic.getGenericValue(Generic struct, String name)
description: CRMScript method in the Generic class that retrieves a variable
intellisense: Generic.getGenericValue
langref: 1
sortOrder: 70
keywords: getGenericValue(String), getGenericValue(Generic,String)
so.topic: reference
---

# getGenericValue()

Retrieves a variable from the run-time environment given its name. You can optionally provide a struct to scope the variable.

An exception is thrown if the name is unknown, or the struct is not a struct.

The variable is returned as a `Generic`, independent of its type.

## Methods

* Generic.getGenericValue(String name)
* Generic.getGenericValue(Generic struct, String name)

## Parameters

| Parameter | Type | Description |
|---|---|---|
| struct | String | Generic Struct to get variable in |
| name | String | Name of variable to get |

## Examples

```crmscript
Integer age = 42;
Generic g = getGenericValue("age");
```

```crmscript
struct Person {
  String name;
  Integer age;
};

Person person;
person.age = 42;
Generic g = getGenericValue(person, "age");
```

```crmscript
String[] fields = getStructMembers("Building");
for(Integer i = 0; i < fields.length(); i++) {
  Generic g = getGenericValue(this, fields[i]);
  printLine(fields[i] + ": " + convertGenericToString(g));
}
```
