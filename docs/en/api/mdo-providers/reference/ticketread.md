---
uid: ticketread
title: ticketread
keywords: mdoprovider mdo provider ticketread
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "ticketread" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.TicketReadStatusProvider">TicketReadStatusProvider</see> class.
The name of the MDO list is 'ticketread'.




## Sample Request

```http!
GET /api/v1/MDOList/ticketread
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("ticketread", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|Unknown|||
|1|Read|||
|2|Changed|||
|3|Unread|||


## Related MDO Lists

* "ticketreadheadings"
* "ticketreadheadingswithallitem"
* "ticketreadheadingswithallitemwithnoselection"
* "ticketreadheadingswithnoselection"
* "ticketreadwithallitem"
* "ticketreadwithallitemwithnoselection"
* "ticketreadwithnoselection"
