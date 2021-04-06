---
uid: crmscript_ref_NSArchiveRestrictionInfo_GetInterParenthesis
title: Integer GetInterParenthesis()
intellisense: NSArchiveRestrictionInfo.GetInterParenthesis
keywords: NSArchiveRestrictionInfo, GetInterParenthesis
so.topic: reference
---

Get or set the parenthesis (if any) associated with this restriction. Positive values indicate a number of opening parentheses (deepening nesting level), while negative numbers indicate closing parentheses. Zero means no change in nesting level (no parentheses).

**Returns:** Integer


```crmscript
NSArchiveRestrictionInfo thing;
Integer interParenthesis  = thing.GetInterParenthesis();
```


