---
title: Void setParameter(String name, String value)
path: /EJScript/Classes/XMLNode/Member functions/Void setParameter(String name, String value)
intellisense: 1
classref: 1
sortOrder: 9305
keywords: setParameter(String,String)
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


