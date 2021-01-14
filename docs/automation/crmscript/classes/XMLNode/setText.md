---
title: Void setText(String text)
path: /EJScript/Classes/XMLNode/Member functions/Void setText(String text)
intellisense: 1
classref: 1
keywords: setText(String)
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


