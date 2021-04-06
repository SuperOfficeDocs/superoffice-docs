---
uid: crmscript_ref_NSCheckoutInfo_SetAssociateId
title: SetAssociateId(Integer associateId)
intellisense: NSCheckoutInfo.SetAssociateId
keywords: NSCheckoutInfo, GetAssociateId
so.topic: reference
---

Id of associate who has currently checked out the document; 0 if it is not checked out,  or is checked out by someone who is not a SuperOffice user

**Parameter:** 
 - **associateId** Integer

```crmscript
NSCheckoutInfo thing;
Integer associateId;
thing.SetAssociateId(associateId);
```

