---
uid: crmscript_ref_XMLNode_getNodeFromPath_String
title: XMLNode.getNodeFromPath(String)
intellisense: XMLNode.getNodeFromPath
keywords: getNodeFromPath(String)
so.topic: reference
---

This function will return the XMLNode for the given path. The path should be a dot-separated string containing either names of nodes or indices. E.g. given the following structure: "{ persons: [{name: "John"},{name: "Peter"}]}" , you can get the node containing "Peter" by asking for "persons.1.name". If your path does not lead to a node, you will get an empty XMLNode back.


