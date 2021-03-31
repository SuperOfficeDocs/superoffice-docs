---
uid: crmscript_ref_NSSelectionAgent_RemoveContactSelectionMembersFromSearch
title: Integer RemoveContactSelectionMembersFromSearch(Integer selectionId, String storageKey)
intellisense: NSSelectionAgent.RemoveContactSelectionMembersFromSearch
keywords: NSSelectionAgent, RemoveContactSelectionMembersFromSearch
so.topic: reference
---

Removes members from the selection using the search result.

**Parameters:**
 - **selectionId** The id of the selection to remove members.
 - **storageKey** Storage key to be interpreted by the restriction storage provider, when it fetches criteria for the search.

**Returns:** Number of members removed

```crmscript
NSSelectionAgent agent;
Integer selectionId;
String storageKey;
Integer res = agent.RemoveContactSelectionMembersFromSearch(selectionId, storageKey);
```

