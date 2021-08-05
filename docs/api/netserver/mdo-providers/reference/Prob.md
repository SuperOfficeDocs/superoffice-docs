---
uid: prob
title: prob
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "prob"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "prob" MDO List
GenericMDOProvider reads MDO lists with default settings



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericMDOProvider">GenericMDOProvider</see> class.
The name of the MDO list is 'prob'.




## Sample Request

```http!
GET /api/v1/MDOList/prob
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("prob", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|5|Andre møte|||
|4|Første møte|||
|3|Muntlig aksept|||
|1|Sendt tilbud|||
|2|Sluttforhandlinger|||


## Related MDO Lists

* "probheadings"
* "probheadingswithallitem"
* "probheadingswithallitemwithnoselection"
* "probheadingswithnoselection"
* "probwithallitem"
* "probwithallitemwithnoselection"
* "probwithnoselection"
