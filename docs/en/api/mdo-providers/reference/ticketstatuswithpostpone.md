---
uid: ticketstatuswithpostpone
title: ticketstatuswithpostpone
keywords: mdoprovider mdo provider ticketstatuswithpostpone
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "ticketstatuswithpostpone" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.TicketStatusWithPostponeProvider">TicketStatusWithPostponeProvider</see> class.
The name of the MDO list is 'ticketstatuswithpostpone'.




## Sample Request

```http!
GET /api/v1/MDOList/ticketstatuswithpostpone
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("ticketstatuswithpostpone", forceFlatList: true);
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
|3|Postponed||3|


## Related MDO Lists

* "ticketstatuswithpostponeheadings"
* "ticketstatuswithpostponeheadingswithallitem"
* "ticketstatuswithpostponeheadingswithallitemwithnoselection"
* "ticketstatuswithpostponeheadingswithnoselection"
* "ticketstatuswithpostponewithallitem"
* "ticketstatuswithpostponewithallitemwithnoselection"
* "ticketstatuswithpostponewithnoselection"
