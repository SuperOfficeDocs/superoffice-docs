---
uid: crmscript_ref_NSEMailAgent_SendEMails
title: EMailEntity[] SendEMails(EMailConnectionInfo outgoingConnectionInfo, EMailEntity[] emails, EMailConnectionInfo sentItemsConnectionInfo)
intellisense: NSEMailAgent.SendEMails
keywords: NSEMailAgent, SendEMails
so.topic: reference
---

Send the provided e-mails

**Parameters:**
 - **outgoingConnectionInfo** All information needed to connect to the mailserver
 - **emails** The e-mails to send
 - **sentItemsConnectionInfo** If provided, save sent item(s) in the folder specified.  May be null.

**Returns:** The sent e-mails (updated with message id etc.)

```crmscript
NSEMailAgent agent;
EMailConnectionInfo outgoingConnectionInfo;
EMailEntity[] emails;
EMailConnectionInfo sentItemsConnectionInfo;
EMailEntity[] res = agent.SendEMails(outgoingConnectionInfo, emails, sentItemsConnectionInfo);
```

