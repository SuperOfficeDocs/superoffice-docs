---
uid: paymentterms
title: paymentterms
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "paymentterms"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "paymentterms" MDO List
GenericMDOProvider reads MDO lists with default settings



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericMDOProvider">GenericMDOProvider</see> class.
The name of the MDO list is 'paymentterms'.




## Sample Request

```http!
GET /api/v1/MDOList/paymentterms
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("paymentterms", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|2|30 days|||
|1|Cash|||


## Related MDO Lists

* "paymenttermsheadings"
* "paymenttermsheadingswithallitem"
* "paymenttermsheadingswithallitemwithnoselection"
* "paymenttermsheadingswithnoselection"
* "paymenttermswithallitem"
* "paymenttermswithallitemwithnoselection"
* "paymenttermswithnoselection"
