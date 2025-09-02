---
uid: ticketselectionwithstaticmenu
title: ticketselectionwithstaticmenu
keywords: mdoprovider mdo provider ticketselectionwithstaticmenu
description: Provider for selecting ticket selections
generated: true
content_type: reference
envir: onsite, online
---

# "ticketselectionwithstaticmenu" MDO List
Provider for selecting ticket selections

Sentry rights are honoured; if you do not have Read acces the selection will not be listed here. Additionally,
selections with empty names are not listed; such selections are the result of bugs and are not visible anywhere else
either.

Implemented by the <see cref="T:SuperOffice.CRM.Lists.TicketSelectionWithStaticMenuProvider">TicketSelectionWithStaticMenuProvider</see> class.
The name of the MDO list is 'ticketselectionwithstaticmenu'.




## Sample Request

```http!
GET /api/v1/MDOList/ticketselectionwithstaticmenu
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("ticketselectionwithstaticmenu", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Last requests||soprotocol:last&provider:LastTickets|
|2|Own open requests||soprotocol:open&provider:UserOpenTickets|
|3|Unassigned requests||soprotocol:unassigned&provider:UnassignedTickets|
|4|My favourites||soprotocol:favourites&provider:FavouriteTickets|
|6||separatorLine||


## Related MDO Lists

* "ticketselectionwithstaticmenuheadings"
* "ticketselectionwithstaticmenuheadingswithallitem"
* "ticketselectionwithstaticmenuheadingswithallitemwithnoselection"
* "ticketselectionwithstaticmenuheadingswithnoselection"
* "ticketselectionwithstaticmenuwithallitem"
* "ticketselectionwithstaticmenuwithallitemwithnoselection"
* "ticketselectionwithstaticmenuwithnoselection"
