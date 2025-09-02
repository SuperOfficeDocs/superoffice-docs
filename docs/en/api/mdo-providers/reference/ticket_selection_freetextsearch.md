---
uid: ticket_selection_freetextsearch
title: ticket_selection_freetextsearch
keywords: mdoprovider mdo provider ticket_selection_freetextsearch
description: Provider for selecting Ticket Selection or a Ticket. Does keyword matching and scoring. Searches selection table and ticket table.
generated: true
content_type: reference
envir: onsite, online
---

# "ticket_selection_freetextsearch" MDO List
Provider for selecting Ticket Selection or a Ticket.
Does keyword matching and scoring. Searches selection table and ticket table.

User's own selections, recently added + modified selections, selections modified or created by user.
Matches on word boundaries or at start of field are scored extra highly.


Returns selection and ticket items:
Selection: Id = selection-id, Name = Selection name, Type = "Selection", IconHint="selection", ExtraInfo= static/dynamic
Ticket: Id = ticket-id, Name = Ticket title, Type = "Ticket", IconHint="ticket", ExtraInfo=


Completed/Done selections are marked with stylehint = "deleted_item" (but item.deleted = false)

Implemented by the <see cref="T:SuperOffice.CRM.Lists.TicketSelectionListFreetextProvider">TicketSelectionListFreetextProvider</see> class.
The name of the MDO list is 'ticket_selection_freetextsearch'.




## Sample Request

```http!
GET /api/v1/MDOList/ticket_selection_freetextsearch
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("ticket_selection_freetextsearch", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
| 2 | Example | | |


## Related MDO Lists

* "ticket_selection_freetextsearchheadings"
* "ticket_selection_freetextsearchheadingswithallitem"
* "ticket_selection_freetextsearchheadingswithallitemwithnoselection"
* "ticket_selection_freetextsearchheadingswithnoselection"
* "ticket_selection_freetextsearchwithallitem"
* "ticket_selection_freetextsearchwithallitemwithnoselection"
* "ticket_selection_freetextsearchwithnoselection"
