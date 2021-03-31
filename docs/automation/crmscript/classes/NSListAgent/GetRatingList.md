---
title: crmscript_ref_NSListAgent_GetRatingList
description: NSRating[] GetRatingList(Integer[]  ratingIds);
intellisense: NSListAgent.GetRatingList
keywords: NSListAgent,GetRatingList
so.topic: reference
---

Gets a vector of Rating objects.

**Parameters:**
 - **ratingIds** The identifiers of the NSRating objects

**Returns:** Vector of NSRating objects

```crmscript
Integer[] ids;
NSListAgent agent;
agent.GetRatingList(ids);
```

