---
uid: importduplicateactionwithoutadd
title: importduplicateactionwithoutadd
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "importduplicateactionwithoutadd"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "importduplicateactionwithoutadd" MDO List
Import duplicate; Merge, Replace, Skip



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ImportDuplicateActionWithoutAddProvider">ImportDuplicateActionWithoutAddProvider</see> class.
The name of the MDO list is 'importduplicateactionwithoutadd'.




## Sample Request

```http!
GET /api/v1/MDOList/importduplicateactionwithoutadd
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("importduplicateactionwithoutadd", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|2|Merge - update empty fields|||
|3|Replace - overwrite existing|||
|4|Skip - do not import|||


## Related MDO Lists

* "importduplicateactionwithoutaddheadings"
* "importduplicateactionwithoutaddheadingswithallitem"
* "importduplicateactionwithoutaddheadingswithallitemwithnoselection"
* "importduplicateactionwithoutaddheadingswithnoselection"
* "importduplicateactionwithoutaddwithallitem"
* "importduplicateactionwithoutaddwithallitemwithnoselection"
* "importduplicateactionwithoutaddwithnoselection"
