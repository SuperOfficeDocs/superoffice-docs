---
uid: crmscript_ref_EventData_setValidationMessage_String_message
title: EventData.setValidationMessage(String message)
intellisense: EventData.setValidationMessage
sortOrder: 300
keywords: setValidationMessage(String)
so.topic: reference
---

# Void setValidationMessage(String message)

A shorthand for calling `setBlockExecution(true)` and `setMessage(message)`.

It allows you to block a save and set a response message in a single function call.

## Example: check if a field is empty, and block execution

```crmscript
EventData ed = getEventData();
if(ed.getInputValue("x_invoice_no.value") == "") {
  getHtmlElement("x_invoice_no").setErrorMessage("Error");
  ed.setBlockExecution(true);
}

String orgNr = ed.getInputValue("ContactEntity.OrgNr");
if(orgNr.isEmpty()) {
  ed.setValidationMessage("Please type in a Org.Nr");
}
else if(!orgNr.isDigit() || orgNr.getLength() != 9) {
  // ...
}
```
