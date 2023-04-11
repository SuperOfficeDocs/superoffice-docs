---
uid: salecategory
title: salecategory
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "salecategory"
so.generated: true
so.date: 03.31.2023
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "salecategory" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.SaleCategoryListProvider">SaleCategoryListProvider</see> class.
The name of the MDO list is 'salecategory'.




## Sample Request

```http!
GET /api/v1/MDOList/salecategory
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("salecategory", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Lost|||
|2|Open|||
|3|Sold|||
|4|Stalled|||


## Related MDO Lists

* "salecategoryheadings"
* "salecategoryheadingswithallitem"
* "salecategoryheadingswithallitemwithnoselection"
* "salecategoryheadingswithnoselection"
* "salecategorywithallitem"
* "salecategorywithallitemwithnoselection"
* "salecategorywithnoselection"
