---
description: String encodeSHA256(String key, String value)
path: /EJScript/Global functions/String encodeSHA256(String key, String value)
intellisense: 1
langref: 1
keywords: encodeSHA256(String,String)
---

This function generates and returns a hash from a specified key-value pair using the SHA256 encoding algorithm. This can be used to ensure data integrity. (The hash cannot be decrypted back)



###Example code:###


    String s = "Hello world!";
    
    printLine(encodeSHA256("test", "Hello there!")); // Prints "39bf407008986fa79eac9cb0b3c8da3fb46acdd6f71721e38e6c4bbf1d14c222"
    printLine(encodeSHA256("test", "Hello world!")); // Prints "1700f488c1e47cf1a8e8337c0a51d176291a5b4a200fe9bab866765a86edc0a4"
    printLine(encodeSHA256("test", s));              // Prints "1700f488c1e47cf1a8e8337c0a51d176291a5b4a200fe9bab866765a86edc0a4"
    
    // Notice that the same key-value pair always returns the same hash (formatted as hex)


