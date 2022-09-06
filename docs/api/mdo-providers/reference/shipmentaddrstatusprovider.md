---
uid: shipmentaddrstatusprovider
title: shipmentaddrstatusprovider
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "shipmentaddrstatusprovider"
so.generated: true
so.date: 08.26.2022
so.topic: reference
so.envir:
  - "onsite"
  - "online"
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
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("shipmentaddrstatusprovider", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|Undefined|||
|1|Ready to send|||
|2|Duplicate|||
|3|No consent|||
|4|Sent|||
|5|Bounced|||
|6|Read by recipient|||
|7|Test mailing|||
|8|Soft bounced|||
|9|No subscription|||
|10|Recipient complained|||
|11|Too many bounces|||

## Related MDO Lists

* "shipmentaddrstatusproviderheadings"
* "shipmentaddrstatusproviderheadingswithallitem"
* "shipmentaddrstatusproviderheadingswithallitemwithnoselection"
* "shipmentaddrstatusproviderheadingswithnoselection"
* "shipmentaddrstatusproviderwithallitem"
* "shipmentaddrstatusproviderwithallitemwithnoselection"
* "shipmentaddrstatusproviderwithnoselection"
