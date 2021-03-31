---
title: crmscript_ref_NSSelectionAgent_RemoveSelectionMembersFromSearch
description: Integer RemoveSelectionMembersFromSearch(Integer selectionId, String storageKey)
intellisense: NSSelectionAgent.RemoveSelectionMembersFromSearch
keywords: NSSelectionAgent,RemoveSelectionMembersFromSearch
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
Integer res = agent.RemoveSelectionMembersFromSearch(selectionId, storageKey);
```

