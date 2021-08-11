---
uid: crmscript_ref_NSArchiveColumnData_GetLinkHint
title: String GetLinkHint()
intellisense: NSArchiveColumnData.GetLinkHint
keywords: NSArchiveColumnData, GetLinkHint
so.topic: reference
---

# String GetLinkHint()

The link hint consists of information to construct an actual link; additional information (such as a view context) must be provided by the client, who is also responsible for building the link. The content of the link will generally be one or more ids, such as contact_id=123.

**Returns:** String

```crmscript
NSArchiveColumnData thing;
String linkHint  = thing.GetLinkHint();
```

