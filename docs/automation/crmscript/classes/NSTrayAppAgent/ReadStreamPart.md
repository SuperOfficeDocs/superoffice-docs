---
title: String ReadStreamPart(String streamId, String communicationModuleName, String communicationModuleVersion, String communicationModuleData, Integer offset)
path: /EJScript/Classes/NSTrayAppAgent/Member functions/String ReadStreamPart(String p_0, String p_1, String p_2, String p_3, Integer p_4)
intellisense: 1
classref: 1
keywords: ReadStreamPart(String,String,String,String,Integer)
---


Read and return a part of a stream.



* **streamId:** Unique identifier of the stream.
* **communicationModuleName:** Module name of the client communication module that initiated the request. This is sent to make sure the correct version of the communication server module is loaded.
* **communicationModuleVersion:** Module version of the client communication module that initiated the request. This is sent to make sure the correct version of the communication server module is loaded.
* **communicationModuleData:** Serialized data from the communiction client module that initiated this operation.
* **offset:** The position in the file to start reading.
* **Returns:** Returns a StreamData object serialized to a string.


