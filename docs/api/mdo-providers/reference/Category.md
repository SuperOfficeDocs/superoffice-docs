---
uid: category
title: category
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "category"
so.generated: true
so.date: 08.26.2022
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "category" MDO List
GenericMDOProvider reads MDO lists with default settings



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericMDOProvider">GenericMDOProvider</see> class.
The name of the MDO list is 'category'.




## Sample Request

```http!
GET /api/v1/MDOList/category
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("category", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|6|Konkurent|||
|10|MarketingItem 2|||
|2|Potensiell kunde|||
|8|SaleItem 2|||
|4|Samarbeidspartner|||
|1|Customer|||
|5|Lost Customer|||
|7|SaleItem 1|||


## Related MDO Lists

* "categoryheadings"
* "categoryheadingswithallitem"
* "categoryheadingswithallitemwithnoselection"
* "categoryheadingswithnoselection"
* "categorywithallitem"
* "categorywithallitemwithnoselection"
* "categorywithnoselection"
