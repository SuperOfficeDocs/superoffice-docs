---
title: crmscript_ref_EventData_getInputValues
description: EventData.getInputValues()
intellisense: EventData.getInputValues
sortOrder: 289
keywords: getInputValues()
so.topic: reference
---

# Map getInputValues()

This method returns a Map containing all input values of the `EventData` object.

```crmscript
EventData ed = getEventData();
Map m = ed.getInputValues();

m.first();
while (!m.eof()){
  printLine(m.getKey() + " = " + m.getVal());
  m.next();
}
```
