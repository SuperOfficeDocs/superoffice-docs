---
title: String getValueFromPath(String path)
path: /EJScript/Classes/XMLNode/Member functions/String getValueFromPath(String path)
intellisense: 1
classref: 1
keywords: getValueFromPath(String)
---

This function will return the value for the given path. The path should be a dot-separated string containing either names of nodes or indices. E.g. given the following structure: "{ persons: [{name: "John"},{name: "Peter"}]}" , you can get "Peter" by asking for "persons.1.name". If your path does not lead to a node, you will get an String with a null value back (can be checked with .isNull()).


