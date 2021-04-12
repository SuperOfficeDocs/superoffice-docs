---
uid: ticketslevel
title: ticketslevel
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "ticketslevel"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "ticketslevel" MDO List
Ticket Security Level



Implemented by the <see cref="T:SuperOffice.CRM.Lists.TicketSLevelProvider">TicketSLevelProvider</see> class.
The name of the MDO list is 'ticketslevel'.




## Sample Request

```http!
GET /api/v1/MDOList/ticketslevel
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("ticketslevel", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|Unknown|||
|1|Internal|||
|2|External|||


## Related MDO Lists

* "ticketslevelheadings"
* "ticketslevelheadingswithallitem"
* "ticketslevelheadingswithallitemwithnoselection"
* "ticketslevelheadingswithnoselection"
* "ticketslevelwithallitem"
* "ticketslevelwithallitemwithnoselection"
* "ticketslevelwithnoselection"
