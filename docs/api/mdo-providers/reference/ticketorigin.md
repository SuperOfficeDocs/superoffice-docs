---
uid: ticketorigin
title: ticketorigin
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "ticketorigin"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "ticketorigin" MDO List
Ticket Origin



Implemented by the <see cref="T:SuperOffice.CRM.Lists.TicketOriginProvider">TicketOriginProvider</see> class.
The name of the MDO list is 'ticketorigin'.




## Sample Request

```http!
GET /api/v1/MDOList/ticketorigin
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("ticketorigin", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|Unknown|||
|1|E-mail|||
|2|SMS|||
|3|Fax|||
|4|Phone|||
|5|Facebook|||
|6|Twitter|||
|7|Internal|||
|8|Customer Centre|||
|9|eMarketing|||
|10|Automatic|||
|11|Chat|||


## Related MDO Lists

* "ticketoriginheadings"
* "ticketoriginheadingswithallitem"
* "ticketoriginheadingswithallitemwithnoselection"
* "ticketoriginheadingswithnoselection"
* "ticketoriginwithallitem"
* "ticketoriginwithallitemwithnoselection"
* "ticketoriginwithnoselection"
