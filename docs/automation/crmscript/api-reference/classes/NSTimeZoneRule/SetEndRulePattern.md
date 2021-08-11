---
uid: crmscript_ref_NSTimeZoneRule_SetEndRulePattern
title: SetEndRulePattern(String endRulePattern)
intellisense: NSTimeZoneRule.SetEndRulePattern
keywords: NSTimeZoneRule, GetEndRulePattern
so.topic: reference
---

# SetEndRulePattern(String endRulePattern)

DST end rule, such as 2300 LST-SAT-OCT; limited to rules that we have parse code for; use dayOfMonth etc for custom rules

**Parameter:** 
 - **endRulePattern** String

```crmscript
NSTimeZoneRule thing;
String endRulePattern;
thing.SetEndRulePattern(endRulePattern);
```

