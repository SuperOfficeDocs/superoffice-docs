---
uid: crmscript_ref_NSCustomerServiceAgent_CheckSymmetricEncryption
title: String CheckSymmetricEncryption(String encryptedString)
intellisense: NSCustomerServiceAgent.CheckSymmetricEncryption
keywords: NSCustomerServiceAgent, CheckSymmetricEncryption
so.topic: reference
---

Do a test to check that we are using the same encryption keys

**Parameters:**
 - **encryptedString** An encrypted version of the string

**Returns:** String

```crmscript
NSCustomerServiceAgent agent;
String encryptedString;
String res = agent.CheckSymmetricEncryption(encryptedString);
```

