---
uid: ticketstatustimecounter
title: ticketstatustimecounter
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "ticketstatustimecounter"
so.generated: true
so.date: 08.26.2022
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "ticketstatustimecounter" MDO List
Ticket status timer count values: None, Internall, Externally, Queue



Implemented by the <see cref="T:SuperOffice.CRM.Lists.TicketStatusTimeCounterProvider">TicketStatusTimeCounterProvider</see> class.
The name of the MDO list is 'ticketstatustimecounter'.




## Sample Request

```http!
GET /api/v1/MDOList/ticketstatustimecounter
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("ticketstatustimecounter", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|(None)||None|
|1|Internally||Internally|
|2|Externally||Externally|
|3|In queue||Queue|


## Related MDO Lists

* "ticketstatustimecounterheadings"
* "ticketstatustimecounterheadingswithallitem"
* "ticketstatustimecounterheadingswithallitemwithnoselection"
* "ticketstatustimecounterheadingswithnoselection"
* "ticketstatustimecounterwithallitem"
* "ticketstatustimecounterwithallitemwithnoselection"
* "ticketstatustimecounterwithnoselection"
