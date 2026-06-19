---
uid: ticketorigin
title: ticketorigin
keywords: mdoprovider mdo provider ticketorigin
description: Ticket Origin
generated: true
content_type: reference
envir: onsite, online
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
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("ticketorigin", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|[SR_ORIGIN_UNKNOWN]|||
|1|[SR_ORIGIN_EMAIL]|||
|2|[SR_ORIGIN_SMS]|||
|3|[SR_ORIGIN_FAX]|||
|4|[SR_ORIGIN_PHONE]|||
|5|[SR_ORIGIN_FACEBOOK]|||
|6|[SR_ORIGIN_TWITTER]|||
|7|[SR_ORIGIN_INTERNAL]|||
|8|[SR_ORIGIN_CUSTCTR]|||
|9|[SR_ORIGIN_EMARKETING]|||
|10|[SR_ORIGIN_AUTOMATIC]|||
|11|[SR_ORIGIN_CHAT]|||
|12|[SR_ORIGIN_FORM]|||


## Related MDO Lists

* "ticketoriginheadings"
* "ticketoriginheadingswithallitem"
* "ticketoriginheadingswithallitemwithnoselection"
* "ticketoriginheadingswithnoselection"
* "ticketoriginwithallitem"
* "ticketoriginwithallitemwithnoselection"
* "ticketoriginwithnoselection"
