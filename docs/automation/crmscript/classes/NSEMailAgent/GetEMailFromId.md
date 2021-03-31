---
uid: crmscript_ref_NSEMailAgent_GetEMailFromId
title: EMailEntity GetEMailFromId(EMailConnectionInfo connectionInfo, Integer messageServerId, Bool lookupAddresses, Integer flags, Bool includeAttachments)
intellisense: NSEMailAgent.GetEMailFromId
keywords: NSEMailAgent, GetEMailFromId
so.topic: reference
---

Get en e-mail based on its unique id

**Parameters:**
 - **connectionInfo** All information needed to connect to the mailserver
 - **messageServerId** Unique ID for the e-mail to retrieve
 - **lookupAddresses** If true try to look up e-mail addresses in from/to/cc/bcc fields against superoffice contacts
 - **flags** Any flags to apply to the fetched item. Ex: Seen/Answered
     - Enum: 0 = None 
     - Enum: 1 = Seen 
     - Enum: 2 = Deleted 
     - Enum: 4 = Recent 
     - Enum: 8 = Flagged 
     - Enum: 16 = Draft 
     - Enum: 32 = Answered 
 - **includeAttachments** Should we retrieve attachments embedded in the e-mail from the server

**Returns:** The e-mail

```crmscript
NSEMailAgent agent;
EMailConnectionInfo connectionInfo;
Integer messageServerId;
Bool lookupAddresses;
Integer flags;
Bool includeAttachments;
EMailEntity res = agent.GetEMailFromId(connectionInfo, messageServerId, lookupAddresses, flags, includeAttachments);
```

