---
uid: simplemailingstatus
title: simplemailingstatus
keywords: mdoprovider mdo provider simplemailingstatus
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "simplemailingstatus" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.SimpleMailingStatusProvider">SimpleMailingStatusProvider</see> class.
The name of the MDO list is 'simplemailingstatus'.




## Sample Request

```http!
GET /api/v1/MDOList/simplemailingstatus
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("simplemailingstatus", forceFlatList: true);
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
|8|[SR_SHIPMENT_STATUS_DELETED]|||
|13|[SR_SHIPMENT_STATUS_TOOMANYRECIPIENTS]|||


## Related MDO Lists

* "simplemailingstatusheadings"
* "simplemailingstatusheadingswithallitem"
* "simplemailingstatusheadingswithallitemwithnoselection"
* "simplemailingstatusheadingswithnoselection"
* "simplemailingstatuswithallitem"
* "simplemailingstatuswithallitemwithnoselection"
* "simplemailingstatuswithnoselection"
