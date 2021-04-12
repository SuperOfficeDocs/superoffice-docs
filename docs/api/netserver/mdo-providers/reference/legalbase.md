---
uid: legalbase
title: legalbase
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "legalbase"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "legalbase" MDO List
MDO list provider for Legal base



Implemented by the <see cref="T:SuperOffice.CRM.Lists.LegalBaseListProvider">LegalBaseListProvider</see> class.
The name of the MDO list is 'legalbase'.




## Sample Request

```http!
GET /api/v1/MDOList/legalbase
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("legalbase", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Consent|||
|2|Contract|||
|3|Required by law|||
|4|Protect vital interests|||
|5|Public interest|||
|6|Legitimate interest|||
|7|Withdrawn|||


## Related MDO Lists

* "legalbaseheadings"
* "legalbaseheadingswithallitem"
* "legalbaseheadingswithallitemwithnoselection"
* "legalbaseheadingswithnoselection"
* "legalbasewithallitem"
* "legalbasewithallitemwithnoselection"
* "legalbasewithnoselection"
