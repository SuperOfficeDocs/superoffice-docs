---
title: crmscript_ref_NSPersonAgent_CreateTemporaryKey
description: String CreateTemporaryKey(Integer domain, Integer targetId, Integer personId, DateTime expires)
intellisense: NSPersonAgent.CreateTemporaryKey
keywords: NSPersonAgent,CreateTemporaryKey
so.topic: reference
---

Create a temporary key in the database from the given parameters and return the key string. Used for temporary keys for accessing customer centric functionality, such as UpdateSubscriptions.

**Parameters:**
 - **domain** The domain this key is for
     - Enum: 0 = Unknown 
     - Enum: 1 = MailingRecipient 
     - Enum: 2 = FormSubmitterRecipient 
     - Enum: 3 = ViewTicketInCustomerCenter 
     - Enum: 4 = LoginCustomerCenter 
     - Enum: 5 = PublicFaq 
     - Enum: 6 = ChangePasswordCustomerCenter 
 - **targetId** The primary key of the entity this is for. Depends on domain.
 - **personId** The person this key is for. May be null.
 - **expires** When the key will expire (servers local time)

**Returns:** The key as base64, ready to be used e.g. in a URL

```crmscript
NSPersonAgent agent;
Integer domain;
Integer targetId;
Integer personId;
DateTime expires;
String res = agent.CreateTemporaryKey(domain, targetId, personId, expires);
```

