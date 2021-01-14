---
title: Generic getGenericValue(String name)
path: /EJScript/Classes/Generic/Member functions/Generic getGenericValue(String name)
intellisense: 1
langref: 1
sortOrder: 80
keywords: getGenericValue(String)
---


Get a variable from the run-time environment given its name. The variable is returned as a Generic, independent of its type. If the name is unknown, an exception is thrown.


For example:

    Integer age = 42;
    Generic g = getGenericValue("age");
    



* **name:** String Name of variable to get
* **Returns:** Generic The generic variable
