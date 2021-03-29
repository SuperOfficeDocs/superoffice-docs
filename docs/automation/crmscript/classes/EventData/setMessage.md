---
title: crmscript_ref_EventData_setMessage_String_message
description: EventData.setMessage(String message)
intellisense: EventData.setMessage
sortOrder: 296
keywords: setMessage(String)
so.topic: reference
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
