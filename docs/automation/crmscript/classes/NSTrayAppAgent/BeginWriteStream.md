---
title: String BeginWriteStream(String taskId, String communicationModuleName, String communicationModuleVersion, String communicationModuleData)
path: /EJScript/Classes/NSTrayAppAgent/Member functions/String BeginWriteStream(String p_0, String p_1, String p_2, String p_3)
intellisense: 1
classref: 1
sortOrder: 8387
keywords: BeginWriteStream(String,String,String,String)
---


Initiate a stream writing operation.



* **taskId:** Unique identifier of the current task.
* **communicationModuleName:** Module name of the client communication module that initiated the request. This is sent to make sure the correct version of the communication server module is loaded.
* **communicationModuleVersion:** Module version of the client communication module that initiated the request. This is sent to make sure the correct version of the communication server module is loaded.
* **communicationModuleData:** Serialized data from the communiction client module that initiated this operation.
* **Returns:** Returns a StreamData object serialized to a string. StreamData for this method contains a streamId that will be used on writepart and endwrite.


