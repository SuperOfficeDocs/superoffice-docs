---
uid: crmscript_ref_NSSelectionAgent_AddSelectionMembersFromSearch
title: Integer AddSelectionMembersFromSearch(Integer selectionId, String storageKey)
intellisense: NSSelectionAgent.AddSelectionMembersFromSearch
keywords: NSSelectionAgent, AddSelectionMembersFromSearch
so.topic: reference
---

Adds members from the selection using the search result.

**Parameters:**
 - **selectionId** The id of the selection to add members
 - **storageKey** Storage key to be interpreted by the restriction storage provider, when it fetches criteria for the search

**Returns:** Number of members added.

```crmscript
NSSelectionAgent agent;
Integer selectionId;
String storageKey;
Integer res = agent.AddSelectionMembersFromSearch(selectionId, storageKey);
```

