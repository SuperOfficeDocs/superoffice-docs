---
title: NSResolvedUser ResolveUserFromInfo(Integer contactId, String personName, String[] phoneNumbers, String[] emails, Integer userType, NSCredential credential)
path: /EJScript/Classes/NSUserAgent/Member functions/NSResolvedUser ResolveUserFromInfo(Integer p_0, String p_1, String[] p_2, String[] p_3, Integer p_4, NSCredential p_5)
intellisense: 1
classref: 1
sortOrder: 8478
keywords: ResolveUserFromInfo(Integer,String,String[],String[],Integer,NSCredential)
---


Get a user from the provided information. If the user or associated person does not exist, it will be created on demand.



* **contactId:** The contact Id of the contact which the person belongs to. Cannot be 0.
* **personName:** The full name of the person to be resolved. Optional.
* **phoneNumbers:** Phone numbers registered on the person. Optional.
* **emails:** Email-addresses registered on the person. Optional.
* **userType:** The type of user to look up or create.
* **credential:** The credentials to be used for the user. Required.
* **Returns:** The results of the resolve-operation.


