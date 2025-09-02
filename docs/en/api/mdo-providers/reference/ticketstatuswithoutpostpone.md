---
uid: ticketstatuswithoutpostpone
title: ticketstatuswithoutpostpone
keywords: mdoprovider mdo provider ticketstatuswithoutpostpone
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "ticketstatuswithoutpostpone" MDO List




Implemented by the <see cref="T:TicketStatusWithoutPostponeProvider">TicketStatusWithoutPostponeProvider</see> class.
The name of the MDO list is 'ticketstatuswithoutpostpone'.




## Sample Request

```http!
GET /api/v1/MDOList/ticketstatuswithoutpostpone
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("ticketstatuswithoutpostpone", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|2|Closed||2|
|1|Open||1|


## Related MDO Lists

* "ticketstatuswithoutpostponeheadings"
* "ticketstatuswithoutpostponeheadingswithallitem"
* "ticketstatuswithoutpostponeheadingswithallitemwithnoselection"
* "ticketstatuswithoutpostponeheadingswithnoselection"
* "ticketstatuswithoutpostponewithallitem"
* "ticketstatuswithoutpostponewithallitemwithnoselection"
* "ticketstatuswithoutpostponewithnoselection"
