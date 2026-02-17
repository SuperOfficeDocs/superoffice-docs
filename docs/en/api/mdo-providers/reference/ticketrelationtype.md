---
uid: ticketrelationtype
title: ticketrelationtype
keywords: mdoprovider mdo provider ticketrelationtype
description: Ticket Relation Type
generated: true
content_type: reference
envir: onsite, online
---

# "ticketrelationtype" MDO List
Ticket Relation Type



Implemented by the <see cref="T:SuperOffice.CRM.Lists.TicketRelationTypeProvider">TicketRelationTypeProvider</see> class.
The name of the MDO list is 'ticketrelationtype'.




## Sample Request

```http!
GET /api/v1/MDOList/ticketrelationtype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("ticketrelationtype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|Related|||
|1|Parent|||
|2|Child|||


## Related MDO Lists

* "ticketrelationtypeheadings"
* "ticketrelationtypeheadingswithallitem"
* "ticketrelationtypeheadingswithallitemwithnoselection"
* "ticketrelationtypeheadingswithnoselection"
* "ticketrelationtypewithallitem"
* "ticketrelationtypewithallitemwithnoselection"
* "ticketrelationtypewithnoselection"
