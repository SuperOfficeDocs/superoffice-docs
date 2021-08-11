---
uid: crmscript_ref_NSTimeZoneRule_SetStartRulePattern
title: SetStartRulePattern(String startRulePattern)
intellisense: NSTimeZoneRule.SetStartRulePattern
keywords: NSTimeZoneRule, GetStartRulePattern
so.topic: reference
---

# SetStartRulePattern(String startRulePattern)

DST start rule, such as 0200 1ST-SUN-APR; limited to rules that we have parse code for; use dayOfMonth etc for custom rules

**Parameter:** 
 - **startRulePattern** String

```crmscript
NSTimeZoneRule thing;
String startRulePattern;
thing.SetStartRulePattern(startRulePattern);
```

