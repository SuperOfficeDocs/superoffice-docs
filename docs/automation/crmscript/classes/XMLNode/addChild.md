---
title: Void addChild(XMLNode node)
path: /EJScript/Classes/XMLNode/Member functions/Void addChild(XMLNode node)
intellisense: 1
classref: 1
keywords: addChild(XMLNode)
---


Add one node as a child node of the current node.




###Parameter:###


 - node: The node to be added





###Example:###
    
    XMLNode xml = XMLNode("root");
    xml.setName("Root");
    xml.setParameter("type", "object");
    xml.setText("Example text");
    
    XMLNode xMenu = XMLNode("menu");
    xMenu.setParameter("type", "string");
    xml.addChild(xMenu);


