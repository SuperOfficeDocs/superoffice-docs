---
title: crmscript_ref_XMLNode_getText
description: XMLNode.getText()
intellisense: XMLNode.getText
keywords: getText()
so.topic: reference
---

Get the text between two tags. For example \<TAG>Returns this text\</TAG>




###Example:###
    
    XMLNode xml = XMLNode("root");
    xml.setName("Root");
    xml.setParameter("type", "object");
    xml.setText("Example text");
    
    print(xml.getText());


