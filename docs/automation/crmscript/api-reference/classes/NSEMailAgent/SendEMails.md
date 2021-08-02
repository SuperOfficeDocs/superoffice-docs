---
uid: crmscript_ref_NSEMailAgent_SendEMails
title: NSEMailEntity[] SendEMails(NSEMailConnectionInfo outgoingConnectionInfo, NSEMailEntity[] emails, NSEMailConnectionInfo sentItemsConnectionInfo)
intellisense: NSEMailAgent.SendEMails
keywords: NSEMailAgent, SendEMails
so.topic: reference
---

Send the provided e-mails

**Parameters:**
 - **outgoingConnectionInfo** All information needed to connect to the mailserver
 - **emails** The e-mails to send
 - **sentItemsConnectionInfo** If provided, save sent item(s) in the folder specified.  May be null.

**Returns:** NSEMailEntity[]

```crmscript
NSEMailAgent agent;
NSEMailConnectionInfo outgoingConnectionInfo;
NSEMailEntity[] emails;
NSEMailConnectionInfo sentItemsConnectionInfo;
NSEMailEntity[] res = agent.SendEMails(outgoingConnectionInfo, emails, sentItemsConnectionInfo);
```

