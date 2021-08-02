---
uid: crmscript_class_nsemailagent_getemailfromid
title: NSEMailEntity GetEMailFromId()
description: CRMScript method in the NSEMailAgent class that gets an email based on its unique ID
intellisense: NSEMailAgent.GetEMailFromId
keywords: NSEMailAgent, GetEMailFromId, GetEMailFromId(NSEMailConnectionInfo,Integer,Bool,NSEMailFlags,Bool)
so.topic: reference
---

# GetEMailFromId()

Gets an email based on its unique ID.

Returns the email.

`NSEMailEntity GetEMailFromId(NSEMailConnectionInfo connectionInfo, Integer messageServerId, Bool lookupAddresses, Integer flags, Bool includeAttachments)`

## Parameters

| Parameter | Type | Description |
|---|---|---|
| connectionInfo | NSEMailConnectionInfo | All information needed to connect to the mail server |
| messageServerId | Integer | Unique ID for the email to retrieve |
| lookupAddresses | Bool | If true, try to look up email addresses in from/to/cc/bcc fields against SuperOffice contacts |
| flags | Integer | Any flags to apply to the fetched item. For example, Seen/Answered |
| includeAttachments | Bool | Should we retrieve attachments embedded in the email from the server |

### Flags

| Enum | Flag |
|---|---|
| 0 | None |
| 1 | Seen |
| 2 | Deleted |
| 4 | Recent |
| 8 | Flagged |
| 16 | Draft |
| 32 | Answered |

## Example

```crmscript
NSEMailAgent agent;
NSEMailConnectionInfo connectionInfo;
Integer messageServerId;
Bool lookupAddresses;
Integer flags;
Bool includeAttachments;
NSEMailEntity res = agent.GetEMailFromId(connectionInfo, messageServerId, lookupAddresses, flags, includeAttachments);
```
