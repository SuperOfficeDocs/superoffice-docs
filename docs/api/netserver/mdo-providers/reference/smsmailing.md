---
uid: smsmailing
title: smsmailing
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "smsmailing"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "smsmailing" MDO List
SMS Shipment names



Implemented by the <see cref="T:SuperOffice.CRM.Lists.SmsMailingProvider">SmsMailingProvider</see> class.
The name of the MDO list is 'smsmailing'.




## Sample Request

```http!
GET /api/v1/MDOList/smsmailing
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("smsmailing", forceFlatList: true);
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

* "smsmailingheadings"
* "smsmailingheadingswithallitem"
* "smsmailingheadingswithallitemwithnoselection"
* "smsmailingheadingswithnoselection"
* "smsmailingwithallitem"
* "smsmailingwithallitemwithnoselection"
* "smsmailingwithnoselection"
