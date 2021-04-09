---
uid: crmscript_ref_XMLNode_getParameter_String_name
title: XMLNode.getParameter(String name)
intellisense: XMLNode.getParameter
keywords: getParameter(String)
so.topic: reference
---

Get a parameter (attribute) from the node with a given name.



## Parameters


 - name: the key to get value of





## Example
    
    XMLNode xml = XMLNode("root");
    xml.setName("Root");
    xml.setParameter("type", "object");
    
    print(xml.getParameter("type"));
    
    Prints "object".


