---
title: crmscript_ref_XMLNode_setChildren_XMLNode__children
description: XMLNode.setChildren(XMLNode[] children)
intellisense: XMLNode.setChildren
keywords: setChildren(XMLNode[])
so.topic: reference
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


