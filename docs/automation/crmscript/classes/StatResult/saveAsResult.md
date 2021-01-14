---
title: Integer saveAsResult(Integer column, Integer ownerId, Integer maxRows)
path: /EJScript/Classes/StatResult/Member functions/Integer saveAsResult(Integer column, Integer ownerId, Integer maxRows)
intellisense: 1
classref: 1
sortOrder: 9090
keywords: saveAsResult(Integer,Integer,Integer)
---


* **column:** What column to use as id field
* **ownerId:** Id of the owner of the result set (so it can be deleted at logout time)
* **maxRows:** Maximum number wanted in the result set
* **Returns:** A reference to the result set:


The result set reference can be used like this to display tickets in the result set (if the result set references tickets):

    setVariable("url", getProgram(1) + "&action=listTickets&special=11&resultKey=" + resKey .toString());


