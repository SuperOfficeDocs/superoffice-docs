---
uid: crmscript_ref_XMLNode_getName
title: XMLNode.getName()
intellisense: XMLNode.getName
keywords: getName()
so.topic: reference
---

# XMLNode.getName()

Gets the name of the xml tag.

## Example
    
    XMLNode xml = XMLNode("root");
    xml.setName("Root");
    xml.setParameter("type", "object");
    
    print(xml.getName());
    
    Prints "Root".

