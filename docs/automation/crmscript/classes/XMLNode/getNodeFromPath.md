---
title: XMLNode getNodeFromPath(String)
path: /EJScript/Classes/XMLNode/Member functions/XMLNode getNodeFromPath(String)
intellisense: 1
classref: 1
keywords: getNodeFromPath(String)
---

This function will return the XMLNode for the given path. The path should be a dot-separated string containing either names of nodes or indices. E.g. given the following structure: "{ persons: [{name: "John"},{name: "Peter"}]}" , you can get the node containing "Peter" by asking for "persons.1.name". If your path does not lead to a node, you will get an empty XMLNode back.


