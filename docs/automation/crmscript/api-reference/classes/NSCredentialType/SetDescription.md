---
uid: crmscript_ref_NSCredentialType_SetDescription
title: SetDescription(String description)
intellisense: NSCredentialType.SetDescription
keywords: NSCredentialType, GetDescription
so.topic: reference
---

Description of the authentication type.  This value is used in a list of authentication providers that can be choosen by an end user and should be a fairly describtive text.  This will typically be SuperOffice is responsible for username and password for a password scenario.

**Parameter:** 
 - **description** String

```crmscript
NSCredentialType thing;
String description;
thing.SetDescription(description);
```

