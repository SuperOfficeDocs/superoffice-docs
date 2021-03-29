---
title: crmscript_ref_XMLNode_setText_String_text
description: XMLNode.setText(String text)
intellisense: XMLNode.setText
keywords: setText(String)
so.topic: reference
---

Set the text between two tags.



###Parameter:###


 - text: The text between two tags





###Example:###
    
    XMLNode xml = XMLNode("root");
    xml.setName("Root");
    xml.setParameter("type", "object");
    xml.setText("Example text");
    
    print(xml.getText());


