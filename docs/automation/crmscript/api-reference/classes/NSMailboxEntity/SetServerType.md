---
uid: crmscript_ref_NSMailboxEntity_SetServerType
title: SetServerType(MailboxType serverType)
intellisense: NSMailboxEntity.SetServerType
keywords: NSMailboxEntity, GetServerType
so.topic: reference
---

Enum indicating the protocol to use (POP/IMAP).

**Parameter:** 
 - **serverType** MailboxType
     - Enum: 0 = Unknown 
     - Enum: 1 = Pop 
     - Enum: 2 = Imap 
     - Enum: 3 = Mapi 
     - Enum: 4 = Facebook 
     - Enum: 5 = Pops 
     - Enum: 6 = Imaps 
     - Enum: 7 = SmsPlugin 
     - Enum: 8 = Mailgun 
     - Enum: 9 = ImapOAuth 

```crmscript
NSMailboxEntity thing;
MailboxType serverType;
thing.SetServerType(serverType);
```

