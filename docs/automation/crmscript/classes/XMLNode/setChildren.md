---
title: Void setChildren(XMLNode[] children)
path: /EJScript/Classes/XMLNode/Member functions/Void setChildren(XMLNode[] children)
intellisense: 1
classref: 1
sortOrder: 9303
keywords: setChildren(XMLNode[])
---

Set an array of XMLNodes as the children of the current node.



###Parameter:###


 - children: Array of child nodes.





###Example:###
    
    XMLNode xml = XMLNode("root");
    xml.setName("Root");
    xml.setParameter("type", "object");
    
    XMLNode xMenu = XMLNode("menu");
    xMenu.setParameter("type", "string");
    xMenu.setText("truls");
    
    XMLNode xFoo = XMLNode("foo");
    xFoo.setParameter("type", "number");
    xFoo.setText("1.23456");
    
    XMLNode[2] array;
    array[0] = xMenu;
    array[1] = xFoo;
    xml.setChildren(array);


