---
title: Void setMessage(String message)
path: /EJScript/Classes/EventData/member functions/Void setMessage(String message)
intellisense: 1
classref: 1
sortOrder: 296
keywords: setMessage(String)
---

# Void setMessage(String message)

Displays a dialog box containing the specified message.

```crmscript
EventData ed = getEventData();
String orgNr = ed.getInputValue("ContactEntity.OrgNr");
if(orgNr.isEmpty()) {
  ed.setMessage("Please type an Org.Nr");
}
```

> [!NOTE]
> Service screens are not compatible with the message box!
