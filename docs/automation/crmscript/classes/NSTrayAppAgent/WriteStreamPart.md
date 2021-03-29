---
title: crmscript_ref_NSTrayAppAgent_WriteStreamPart_String_p_0_String_p_1_String_p_2_String_p_3_String_p_4
description: NSTrayAppAgent.WriteStreamPart(String p_0, String p_1, String p_2, String p_3, String p_4)
intellisense: NSTrayAppAgent.WriteStreamPart
keywords: WriteStreamPart(String,String,String,String,String)
so.topic: reference
---


Write a part of a stream.



* **streamId:** Unique identifier of the stream.
* **communicationModuleName:** Module name of the client communication module that initiated the request. This is sent to make sure the correct version of the communication server module is loaded.
* **communicationModuleVersion:** Module version of the client communication module that initiated the request. This is sent to make sure the correct version of the communication server module is loaded.
* **communicationModuleData:** Serialized data from the communiction client module that initiated this operation.
* **streamData:** Serialized StreamData object containing data to write to the stream.
* **Returns:** Return an empty string, or a error message if something went wrong.


