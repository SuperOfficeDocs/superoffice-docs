---
title: triggerscripts
description: Trigger scripts
so.author: Christian Mogensen
so.date: 11.11.2020
keywords:
---

# CompactModeInjection (200)

## Input values

none

## Output values:
|Variable|Description|
|---|---|
| `injection`|Output string to inject into parser as variable|

## Sample code

```crmscript
#setLanguageLevel 3;
print("window.alert('foo!');");
```
