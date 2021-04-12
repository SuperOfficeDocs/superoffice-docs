---
uid: deliverytype
title: deliverytype
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "deliverytype"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "deliverytype" MDO List
GenericMDOProvider reads MDO lists with default settings



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericMDOProvider">GenericMDOProvider</see> class.
The name of the MDO list is 'deliverytype'.




## Sample Request

```http!
GET /api/v1/MDOList/deliverytype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("deliverytype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|All-at-once|||
|2|As ready|||


## Related MDO Lists

* "deliverytypeheadings"
* "deliverytypeheadingswithallitem"
* "deliverytypeheadingswithallitemwithnoselection"
* "deliverytypeheadingswithnoselection"
* "deliverytypewithallitem"
* "deliverytypewithallitemwithnoselection"
* "deliverytypewithnoselection"
