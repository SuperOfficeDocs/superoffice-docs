---
uid: ticketread
title: ticketread
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "ticketread"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
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
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("ticketread", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|Unknown|||
|1|Read by owner|||
|2|New information|||
|3|Not read by owner|||


## Related MDO Lists

* "ticketreadheadings"
* "ticketreadheadingswithallitem"
* "ticketreadheadingswithallitemwithnoselection"
* "ticketreadheadingswithnoselection"
* "ticketreadwithallitem"
* "ticketreadwithallitemwithnoselection"
* "ticketreadwithnoselection"
