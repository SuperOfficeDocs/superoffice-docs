---
title: triggerscripts
description: Trigger scripts
so.author: Christian Mogensen
so.date: 11.11.2020
keywords:
---

# NewTicketFromForm (106)

Called when a form submission creates a new ticket.

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
| `categoryId` | the new ticket category ID|
| `title` | the new ticket title|
| `message` | the new ticket body text|
| Additional form specific fields||

## Sample code

```crmscript
#setLanguageLevel 3;
EventData ed = getEventData();
String param1 = ed.getInputValue("entryId");
```
