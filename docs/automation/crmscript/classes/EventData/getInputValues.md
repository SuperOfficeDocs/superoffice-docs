---
title: Map getInputValues()
path: /EJScript/Classes/EventData/member functions/Map getInputValues()
intellisense: 1
classref: 1
sortOrder: 289
keywords: getInputValues()
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
