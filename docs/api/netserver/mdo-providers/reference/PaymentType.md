---
uid: paymenttype
title: paymenttype
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "paymenttype"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "paymenttype" MDO List
GenericMDOProvider reads MDO lists with default settings



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericMDOProvider">GenericMDOProvider</see> class.
The name of the MDO list is 'paymenttype'.




## Sample Request

```http!
GET /api/v1/MDOList/paymenttype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("paymenttype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Credit Card|||
|2|Invoice|||


## Related MDO Lists

* "paymenttypeheadings"
* "paymenttypeheadingswithallitem"
* "paymenttypeheadingswithallitemwithnoselection"
* "paymenttypeheadingswithnoselection"
* "paymenttypewithallitem"
* "paymenttypewithallitemwithnoselection"
* "paymenttypewithnoselection"
