---
uid: crmscript_ref_XMLNode_addChild_XMLNode_node
title: XMLNode.addChild(XMLNode node)
intellisense: XMLNode.addChild
keywords: addChild(XMLNode)
so.topic: reference
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


