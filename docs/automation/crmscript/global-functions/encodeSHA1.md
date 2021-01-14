---
title: String encodeSHA1(String value)
path: /EJScript/Global functions/String encodeSHA1(String value)
intellisense: 1
langref: 1
sortOrder: 9413
keywords: encodeSHA1(String)
---


This function generates and returns a hash from a specified value using the SHA1 encoding algorithm. This can be used to ensure data integrity. (The hash cannot be decrypted back)




###Example code:###


    String s = "Hello world!";
    
    printLine(encodeSHA1("Hello there!")); // Prints "6b19cb3790b6da8f7c34b4d8895d78a56d078624"
    printLine(encodeSHA1("Hello world!")); // Prints "d3486ae9136e7856bc42212385ea797094475802"
    printLine(encodeSHA1(s));              // Prints "d3486ae9136e7856bc42212385ea797094475802"
    
    // Notice that the same value always returns the same hash (formatted as hex)


