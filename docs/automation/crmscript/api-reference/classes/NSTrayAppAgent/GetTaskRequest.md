---
uid: crmscript_ref_NSTrayAppAgent_GetTaskRequest_String_p_0
title: NSTrayAppAgent.GetTaskRequest(String p_0)
intellisense: NSTrayAppAgent.GetTaskRequest
keywords: GetTaskRequest(String)
so.topic: reference
---

# NSTrayAppAgent.GetTaskRequest(String p_0)

GetTaskRequest will load a servermodule depending on the parameters in the parameter collection. It will use parameter collection key; 'module' and 'version' to load the server-side module.\<p/>The parameter is a query-string like representation of a name-value collection.

* **parameters:** A collection of parameters. Key 'module' and 'version' must exist in the collection.\<p/>The format key=value&key2=value2 etc is used for the parameter.
* **Returns:** Returns a XML document with the data from the invoked servermodule.

