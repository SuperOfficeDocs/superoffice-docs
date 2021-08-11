---
uid: crmscript_ref_NSListAgent_GetRatingList
title: NSRating[] GetRatingList(Integer[]  ratingIds);
intellisense: NSListAgent.GetRatingList
keywords: NSListAgent, GetRatingList
so.topic: reference
---

# NSRating[] GetRatingList(Integer[]  ratingIds);

Gets a vector of NSRating objects.

**Parameters:**
 - **ratingIds** The identifiers of the NSRating objects

**Returns:** NSRating[]

```crmscript
Integer[] ids;
NSListAgent agent;
NSRating[] res = agent.GetRatingList(ids);
```

