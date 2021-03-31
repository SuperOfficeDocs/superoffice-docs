---
title: crmscript_ref_NSSelectionAgent_AddContactSelectionMembersFromSearch
description: Integer AddContactSelectionMembersFromSearch(Integer selectionId, String storageKey)
intellisense: NSSelectionAgent.AddContactSelectionMembersFromSearch
keywords: NSSelectionAgent,AddContactSelectionMembersFromSearch
so.topic: reference
---

Adds members to the selection from the search result.

**Parameters:**
 - **selectionId** The id of the selection to add members
 - **storageKey** Storage key to be interpreted by the restriction storage provider, when it fetches criteria for the search

**Returns:** Number of members added

```crmscript
NSSelectionAgent agent;
Integer selectionId;
String storageKey;
Integer res = agent.AddContactSelectionMembersFromSearch(selectionId, storageKey);
```

