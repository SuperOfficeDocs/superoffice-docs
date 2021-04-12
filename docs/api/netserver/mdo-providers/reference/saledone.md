---
uid: saledone
title: saledone
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "saledone"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "saledone" MDO List
Sale Done status: SaleDone.Done or NotDone.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.SaleDoneProvider">SaleDoneProvider</see> class.
The name of the MDO list is 'saledone'.




## Sample Request

```http!
GET /api/v1/MDOList/saledone
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("saledone", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Not done|||
|2|Completed|||


## Related MDO Lists

* "saledoneheadings"
* "saledoneheadingswithallitem"
* "saledoneheadingswithallitemwithnoselection"
* "saledoneheadingswithnoselection"
* "saledonewithallitem"
* "saledonewithallitemwithnoselection"
* "saledonewithnoselection"
