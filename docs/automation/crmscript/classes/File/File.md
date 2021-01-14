---
title: File
path: /EJScript/Classes/File
intellisense: 1
classref: 1
sortOrder: 340
---

This represents a file.

Use open before you call any other methods.



###Example code:###


    File f;
    
    f.open("test.txt", "a+"); // Opening file appending (and creating)
    f.write("test");
    f.close(); // Closing the file when done writing
    
    File g;
    
    g.open("test.txt", "r"); // Opening file for reading only
    print(g.readAll());
    g.close();




1. autolist

