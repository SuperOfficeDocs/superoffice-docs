---
uid: crmscript_ref_NSTrayAppAgent_ExecuteRequest_String_p_0_String_p_1_String_p_2_String_p_3_String_p_4_String_p_5_String_p_6
title: NSTrayAppAgent.ExecuteRequest(String p_0, String p_1, String p_2, String p_3, String p_4, String p_5, String p_6)
intellisense: NSTrayAppAgent.ExecuteRequest
keywords: ExecuteRequest(String,String,String,String,String,String,String)
so.topic: reference
---

# NSTrayAppAgent.ExecuteRequest(String p_0, String p_1, String p_2, String p_3, String p_4, String p_5, String p_6)

Execute a request that gives an immediate, reasonably sized response. Use the Stream operations for large responses.

* **taskId:** Unique identifier of the current task.
* **parentModuleName:** Module name of the client module that initiated the request.
* **parentModuleVersion:** Module version of the client module that initiated the request.
* **parentModuleData
\param** p4 communicationModuleName: Module name of the client communication module that initiated the request. This is sent to make sure the correct version of the communication server module is loaded.
* **communicationModuleVersion:** Module version of the client communication module that initiated the request. This is sent to make sure the correct version of the communication server module is loaded.
* **communicationModuleData:** Serialized data from the communiction client module that initiated this operation.
* **Returns:** Returns a RequestResponseData object serialized to a string

