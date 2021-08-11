---
uid: crmscript_ref_NSSelectionAgent_AddContactSelectionMembersFromSearch
title: Integer AddContactSelectionMembersFromSearch(Integer selectionId, String storageKey)
intellisense: NSSelectionAgent.AddContactSelectionMembersFromSearch
keywords: NSSelectionAgent, AddContactSelectionMembersFromSearch
so.topic: reference
---

# Integer AddContactSelectionMembersFromSearch(Integer selectionId, String storageKey)

Adds members to the selection from the search result.

**Parameters:**
 - **selectionId** The id of the selection to add members
 - **storageKey** Storage key to be interpreted by the restriction storage provider, when it fetches criteria for the search

**Returns:** Integer

```crmscript
NSSelectionAgent agent;
Integer selectionId;
String storageKey;
Integer res = agent.AddContactSelectionMembersFromSearch(selectionId, storageKey);
```

