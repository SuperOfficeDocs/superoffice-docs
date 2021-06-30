---
uid: crmscript_ref_NSEMailAgent_SyncEmailAccounts
title: Void SyncEmailAccounts(SyncUserAccount[] syncUserAccounts)
intellisense: NSEMailAgent.SyncEmailAccounts
keywords: NSEMailAgent, SyncEmailAccounts
so.topic: reference
---

Start syncing of the given accounts

**Parameters:**
 - **syncUserAccounts** Accounts to sync

**Returns:** A void return

```crmscript
NSEMailAgent agent;
SyncUserAccount[] syncUserAccounts;
Void res = agent.SyncEmailAccounts(syncUserAccounts);
```

