---
title: Generic getGenericValue(Generic struct, String name)
path: /EJScript/Classes/Generic/Member functions/Generic getGenericValue(Generic struct, String name)
intellisense: 1
langref: 1
sortOrder: 70
keywords: getGenericValue(Generic,String)
---


Get a variable from the run-time environment given its name, inside a given struct. The variable is returned as a Generic, independent of its type.

If the name is unknown, an exception is thrown.

If struct is not a struct, an exception is thrown.

For example:

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

* **struct:** Generic Struct to get variable in
* **name:** String Name of variable to get
* **Returns:** Generic The generic variable
