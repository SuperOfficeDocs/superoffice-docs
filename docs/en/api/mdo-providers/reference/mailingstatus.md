---
uid: mailingstatus
title: mailingstatus
keywords: mdoprovider mdo provider mailingstatus
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "mailingstatus" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.MailingStatusProvider">MailingStatusProvider</see> class.
The name of the MDO list is 'mailingstatus'.




## Sample Request

```http!
GET /api/v1/MDOList/mailingstatus
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("mailingstatus", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|[SR_SHIPMENT_STATUS_NONE]|||
|1|[SR_SHIPMENT_STATUS_OK]|||
|2|[SR_SHIPMENT_STATUS_CANCELED]|||
|3|[SR_SHIPMENT_STATUS_WAITING]|||
|4|[SR_SHIPMENT_STATUS_STARTED]|||
|5|[SR_SHIPMENT_STATUS_STATUSFAILED]|||
|6|[SR_SHIPMENT_STATUS_RETRY]|||
|7|[SR_SHIPMENT_STATUS_POPULATING]|||
|8|[SR_SHIPMENT_STATUS_DELETED]|||
|9|[SR_SHIPMENT_STATUS_AWAITPOPULATE]|||
|10|[SR_SHIPMENT_STATUS_POPULATINGONLY]|||
|11|[SR_SHIPMENT_STATUS_POPULATEABORTED]|||
|12|[SR_SHIPMENT_STATUS_POPULATEERROR]|||
|13|[SR_SHIPMENT_STATUS_TOOMANYRECIPIENTS]|||


## Related MDO Lists

* "mailingstatusheadings"
* "mailingstatusheadingswithallitem"
* "mailingstatusheadingswithallitemwithnoselection"
* "mailingstatusheadingswithnoselection"
* "mailingstatuswithallitem"
* "mailingstatuswithallitemwithnoselection"
* "mailingstatuswithnoselection"
