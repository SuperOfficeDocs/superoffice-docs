---
title: crmscript_ref_NSTooltipsAgent_GetTooltip
description: String GetTooltip(String tooltipHint)
intellisense: NSTooltipsAgent.GetTooltip
keywords: NSTooltipsAgent,GetTooltip
so.topic: reference
---

Parse a tooltip hint and return a tooltip. The returned tooltip string may contain resource string identifiers (in square brackets), to be processed by the resource manager.<para />The tooltip hint is either a literal text, representing itself, or a set of key/value pairs enclosed in curly braces. Each key is separated from its value by an equals sign, and each pair from the next by an ampersand, according to usual conventions.<para />A typical tooltip hint could be {contact_id=123} or {appointment_id=222&amp;mode=simple}

**Parameters:**
 - **tooltipHint** 
