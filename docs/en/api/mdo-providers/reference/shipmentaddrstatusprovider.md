---
uid: shipmentaddrstatusprovider
title: shipmentaddrstatusprovider
keywords: mdoprovider mdo provider shipmentaddrstatusprovider
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "shipmentaddrstatusprovider" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.ShipmentAddrStatusProvider">ShipmentAddrStatusProvider</see> class.
The name of the MDO list is 'shipmentaddrstatusprovider'.




## Sample Request

```http!
GET /api/v1/MDOList/shipmentaddrstatusprovider
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("shipmentaddrstatusprovider", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|[SR_SHIPMENT_ADDR_STATUS_UNKNOWN]|||
|1|[SR_SHIPMENT_ADDR_STATUS_READY]|||
|2|[SR_SHIPMENT_ADDR_STATUS_DUPLICATE]|||
|3|[SR_SHIPMENT_ADDR_STATUS_BLOCKED]|||
|4|[SR_SHIPMENT_ADDR_STATUS_SENT]|||
|5|[SR_SHIPMENT_ADDR_STATUS_BOUNCED]|||
|6|[SR_SHIPMENT_ADDR_STATUS_OPENED]|||
|7|[SR_SHIPMENT_ADDR_STATUS_CLICKED]|||
|8|[SR_SHIPMENT_ADDR_STATUS_SOFTBOUNCED]|||
|9|[SR_SHIPMENT_ADDR_STATUS_NOSUBSCRIPTION]|||
|10|[SR_SHIPMENT_ADDR_STATUS_COMPLAINED]|||
|11|[SR_SHIPMENT_ADDR_STATUS_TOOMANYBOUNCES]|||


## Related MDO Lists

* "shipmentaddrstatusproviderheadings"
* "shipmentaddrstatusproviderheadingswithallitem"
* "shipmentaddrstatusproviderheadingswithallitemwithnoselection"
* "shipmentaddrstatusproviderheadingswithnoselection"
* "shipmentaddrstatusproviderwithallitem"
* "shipmentaddrstatusproviderwithallitemwithnoselection"
* "shipmentaddrstatusproviderwithnoselection"
