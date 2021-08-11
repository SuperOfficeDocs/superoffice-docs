---
uid: crmscript_ref_NSTrayAppAgent_BeginWriteStream_String_p_0_String_p_1_String_p_2_String_p_3
title: NSTrayAppAgent.BeginWriteStream(String p_0, String p_1, String p_2, String p_3)
intellisense: NSTrayAppAgent.BeginWriteStream
keywords: BeginWriteStream(String,String,String,String)
so.topic: reference
---

# NSTrayAppAgent.BeginWriteStream(String p_0, String p_1, String p_2, String p_3)

Initiate a stream writing operation.

* **taskId:** Unique identifier of the current task.
* **communicationModuleName:** Module name of the client communication module that initiated the request. This is sent to make sure the correct version of the communication server module is loaded.
* **communicationModuleVersion:** Module version of the client communication module that initiated the request. This is sent to make sure the correct version of the communication server module is loaded.
* **communicationModuleData:** Serialized data from the communiction client module that initiated this operation.
* **Returns:** Returns a StreamData object serialized to a string. StreamData for this method contains a streamId that will be used on writepart and endwrite.

