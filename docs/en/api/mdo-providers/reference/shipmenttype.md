---
uid: shipmenttype
title: shipmenttype
keywords: mdoprovider mdo provider shipmenttype
description: MDO list provider for ConsentPurpose
generated: true
content_type: reference
envir: onsite, online
---

# "shipmenttype" MDO List
MDO list provider for ConsentPurpose



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ShipmentTypeProvider">ShipmentTypeProvider</see> class.
The name of the MDO list is 'shipmenttype'.




## Sample Request

```http!
GET /api/v1/MDOList/shipmenttype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("shipmenttype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Invitations|||
|2|News|||
|3|Promotions|||
|4|Urgent messages|||


## Related MDO Lists

* "shipmenttypeheadings"
* "shipmenttypeheadingswithallitem"
* "shipmenttypeheadingswithallitemwithnoselection"
* "shipmenttypeheadingswithnoselection"
* "shipmenttypewithallitem"
* "shipmenttypewithallitemwithnoselection"
* "shipmenttypewithnoselection"
