---
title: triggerscripts
description: Trigger scripts
so.author: Christian Mogensen
so.date: 11.11.2020
keywords:
---

# NewNotifyTicketFromForm (105)

Called when a new ticket was created from a form.

## Input values
|Variable|Description|
|---|---|
| `contactId` | the contact ID|
| `personId` | the person ID|
| `formId` | the new Form ID|
| `formDescription` | the form description|
| `formName` | the form name|
| `formSubmissionId` | the form submission ID|
| `projectId` | the project ID|
| `selectionId` | the selection ID|
| `entryId` | the new ticket ID|
| `ticketId` | the new ticket ID|
| Additional form specific fields||

## Sample code

```crmscript
#setLanguageLevel 3;
EventData ed = getEventData();
String param1 = ed.getInputValue("entryId");
```
