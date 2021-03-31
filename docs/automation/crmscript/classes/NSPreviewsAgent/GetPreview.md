---
title: crmscript_ref_NSPreviewsAgent_GetPreview
description: String GetPreview(String previewHint)
intellisense: NSPreviewsAgent.GetPreview
keywords: NSPreviewsAgent,GetPreview
so.topic: reference
---

Parse a Preview hint and return a Preview. The returned Preview string may contain resource string identifiers (in square brackets), to be processed by the resource manager.<para />The Preview hint is either a literal text, representing itself, or a set of key/value pairs enclosed in curly braces. Each key is separated from its value by an equals sign, and each pair from the next by an ampersand, according to usual conventions.<para />A typical Preview hint could be {contact_id=123} or {appointment_id=222&amp;mode=simple}

**Parameters:**
 - **previewHint** 
