---
title: crmscript_ref_StatResult_saveAsResult_Integer_column_Integer_ownerId_Integer_maxRows
description: StatResult.saveAsResult(Integer column, Integer ownerId, Integer maxRows)
intellisense: StatResult.saveAsResult
keywords: saveAsResult(Integer,Integer,Integer)
so.topic: reference
---


* **column:** What column to use as id field
* **ownerId:** Id of the owner of the result set (so it can be deleted at logout time)
* **maxRows:** Maximum number wanted in the result set
* **Returns:** A reference to the result set:


The result set reference can be used like this to display tickets in the result set (if the result set references tickets):

    setVariable("url", getProgram(1) + "&action=listTickets&special=11&resultKey=" + resKey .toString());


