---
uid: deliveryterms
title: deliveryterms
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
so.generated: true
so.date: 18.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "deliveryterms" MDO List
GenericMDOProvider reads MDO lists with default settings



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericMDOProvider">GenericMDOProvider</see> class.
The name of the MDO list is 'deliveryterms'.




## Sample Request

```http!
GET /api/v1/MDOList/deliveryterms
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("deliveryterms", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Fetch|||
|2|FOB|||


## Related MDO Lists

* "deliverytermsheadings"
* "deliverytermsheadingswithallitem"
* "deliverytermsheadingswithallitemwithnoselection"
* "deliverytermsheadingswithnoselection"
* "deliverytermswithallitem"
* "deliverytermswithallitemwithnoselection"
* "deliverytermswithnoselection"
