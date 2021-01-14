---
title: Parser
path: /EJScript/Classes/Parser
intellisense: 1
classref: 1
sortOrder: 8955
---


The Parser class is a template engine. A Parser instance can set template variable values, then parse a formatted string containing template variable placeholders to replace their values.





###Parser example:###
    
    Parser p;
    p.setVariable("firstName", "Jack");
    p.setVariable("lastName", "Black");
    
    String output = p.parseString("Hello [[firstName]] [[lastName]]!");
    
    printLine(output);
    
    //prints Hello Jack Black!




1. autolist

