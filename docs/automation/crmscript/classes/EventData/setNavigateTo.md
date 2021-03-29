---
title: crmscript_ref_EventData_setNavigateTo_String_navigateTo
description: EventData.setNavigateTo(String navigateTo)
intellisense: EventData.setNavigateTo
sortOrder: 297
keywords: setNavigateTo(String)
so.topic: reference
---

# Void setNavigateTo(String url)

Sets which page to load next. For example, "sale.main".

```crmscript
EventData ed = getEventData();
ed.setNavigateTo("soprotocol:sale.document?document_id=0");
```
