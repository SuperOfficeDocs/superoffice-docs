---
description: Void enableDebug(String debugId)
intellisense: Void.enableDebug
langref: 1
keywords: enableDebug(String)
so.topic: reference
---


Enable debugging for the current script, with the given debugId. If the executing environment contains the same debugId, then this script will enter debug mode. To set the debugId in a browser, use the "?action=debug" parameter. This functionality is designed to allow for debugging scripts which are operative. I.e. it is possible to debug a script, while it will continue to run as normal for other users.



* **debugId:** A string which will be compared with the debugId in the executing environment.


