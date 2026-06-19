---
uid: ticketslevel
title: ticketslevel
keywords: mdoprovider mdo provider ticketslevel
description: Ticket Security Level
generated: true
content_type: reference
envir: onsite, online
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
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("ticketslevel", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|[SR_ORIGIN_UNKNOWN]||Unknown|
|1|[SR_SLEVEL_INTERNAL]||Internal|
|2|[SR_SLEVEL_EXTERNAL]||External|


## Related MDO Lists

* "ticketslevelheadings"
* "ticketslevelheadingswithallitem"
* "ticketslevelheadingswithallitemwithnoselection"
* "ticketslevelheadingswithnoselection"
* "ticketslevelwithallitem"
* "ticketslevelwithallitemwithnoselection"
* "ticketslevelwithnoselection"
