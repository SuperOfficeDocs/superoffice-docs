---
title: String[] regexp(String pattern)
path: /EJScript/Classes/String/Member functions/String[] regexp(String pattern)
intellisense: 1
classref: 1
keywords: regexp(String)
---


Uses regexp pattern on the String object. Support for subexpressions are also present.
The regexp is caseinsensitiv.




###For instance:###


    String s;
    s="blabla 1234-4567-7890-1111 asdfasdfasdf";
    String[] res = s.regexp("(\\d{4})-(\\d{4})-(\\d{4})-(\\d{4})");
    for (Integer i=0;i<res.length(); i++)
    {
      print("Result: " + res[i] + "\n");
    }
    



###Interpretation of the returned array:###
No matches will result an array with 0 length.
res[0] will point to the entire matched string.
res[1 ... n-1] will point to the matches of the subexpressions.


