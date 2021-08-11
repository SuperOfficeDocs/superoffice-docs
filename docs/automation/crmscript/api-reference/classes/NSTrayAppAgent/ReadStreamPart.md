---
uid: crmscript_ref_NSTrayAppAgent_ReadStreamPart_String_p_0_String_p_1_String_p_2_String_p_3_Integer_p_4
title: NSTrayAppAgent.ReadStreamPart(String p_0, String p_1, String p_2, String p_3, Integer p_4)
intellisense: NSTrayAppAgent.ReadStreamPart
keywords: ReadStreamPart(String,String,String,String,Integer)
so.topic: reference
---

# NSTrayAppAgent.ReadStreamPart(String p_0, String p_1, String p_2, String p_3, Integer p_4)

Read and return a part of a stream.

* **streamId:** Unique identifier of the stream.
* **communicationModuleName:** Module name of the client communication module that initiated the request. This is sent to make sure the correct version of the communication server module is loaded.
* **communicationModuleVersion:** Module version of the client communication module that initiated the request. This is sent to make sure the correct version of the communication server module is loaded.
* **communicationModuleData:** Serialized data from the communiction client module that initiated this operation.
* **offset:** The position in the file to start reading.
* **Returns:** Returns a StreamData object serialized to a string.

