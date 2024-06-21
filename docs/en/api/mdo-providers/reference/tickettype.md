---
uid: tickettype
title: tickettype
keywords: mdoprovider mdo provider tickettype
description: TicketTypeProvider creates a flat list based on the table - TICKET_TYPE
generated: true
topic: reference
envir: onsite, online
---

# "tickettype" MDO List
TicketTypeProvider creates a flat list based on the table: TICKET_TYPE



Implemented by the <see cref="T:SuperOffice.CRM.Lists.TicketTypeProvider">TicketTypeProvider</see> class.
The name of the MDO list is 'tickettype'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|onlyForMenu| |false|
|Describes if call is coming from admin system| admin|false|





## Sample Request

```http!
GET /api/v1/MDOList/tickettype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("tickettype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Request||isDefault=1&description=&defaultStatus=0&defaultPriority=0&showInNew=0&excludeSignature=0&excludeEmailRecipients=0&externalAsDefault=0|


## Related MDO Lists

* "tickettypeheadings"
* "tickettypeheadingswithallitem"
* "tickettypeheadingswithallitemwithnoselection"
* "tickettypeheadingswithnoselection"
* "tickettypewithallitem"
* "tickettypewithallitemwithnoselection"
* "tickettypewithnoselection"
