---
uid: shipmentlinks
title: shipmentlinks
keywords: mdoprovider mdo provider shipmentlinks
description: Create a list of specified mailings (flow, form, regular mailing/shipment...), hierarchy optional
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "shipmentlinks" MDO List
Create a list of specified mailings (flow, form, regular mailing/shipment...), hierarchy optional



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ShipmentLinksListProvider">ShipmentLinksListProvider</see> class.
The name of the MDO list is 'shipmentlinks'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Local links| local|false|
|Global links| global|true|
|Shipment to search for links| shipmentId|0|

Separator: &





## Sample Request

```http!
GET /api/v1/MDOList/shipmentlinks
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("shipmentlinks", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
| 2 | Example | | |


## Related MDO Lists

* "shipmentlinksheadings"
* "shipmentlinksheadingswithallitem"
* "shipmentlinksheadingswithallitemwithnoselection"
* "shipmentlinksheadingswithnoselection"
* "shipmentlinkswithallitem"
* "shipmentlinkswithallitemwithnoselection"
* "shipmentlinkswithnoselection"
