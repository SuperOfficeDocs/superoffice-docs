---
title: crmscript_ref_XMLNode_setParameter_String_name_String_value
description: XMLNode.setParameter(String name, String value)
intellisense: XMLNode.setParameter
keywords: setParameter(String,String)
so.topic: reference
---

Sets a parameter with name and value. A node can have any number of parameters but all names must be unique.



###Parameters:###


 - name: Parameter name
 - value: Parameter value





###Example:###
    
    XMLNode xml = XMLNode("root");
    xml.setName("Root");
    xml.setParameter("type", "object");
    xml.setParameter("type1", "object1");


