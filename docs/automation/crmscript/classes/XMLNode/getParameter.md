---
title: String getParameter(String name)
path: /EJScript/Classes/XMLNode/Member functions/String getParameter(String name)
intellisense: 1
classref: 1
keywords: getParameter(String)
---

Get a parameter (attribute) from the node with a given name.



###Parameter:###


 - name: the key to get value of





###Example:###
    
    XMLNode xml = XMLNode("root");
    xml.setName("Root");
    xml.setParameter("type", "object");
    
    print(xml.getParameter("type"));
    
    Prints "object".


