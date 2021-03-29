---
title: crmscript_ref_XMLNode_setName_String_name
description: XMLNode.setName(String name)
intellisense: XMLNode.setName
keywords: setName(String)
so.topic: reference
---

Sets the tag name of the node.




###Example:###
    
    XMLNode xml = XMLNode("root");
    xml.setName("Root");
    xml.setParameter("type", "object");
    
    print(xml.getName());


