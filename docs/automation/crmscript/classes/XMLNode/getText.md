---
title: String getText()
path: /EJScript/Classes/XMLNode/Member functions/String getText()
intellisense: 1
classref: 1
keywords: getText()
---

Get the text between two tags. For example \<TAG>Returns this text\</TAG>




###Example:###
    
    XMLNode xml = XMLNode("root");
    xml.setName("Root");
    xml.setParameter("type", "object");
    xml.setText("Example text");
    
    print(xml.getText());


