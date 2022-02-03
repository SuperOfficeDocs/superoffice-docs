---
uid: productcategory
title: productcategory
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "productcategory"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "productcategory" MDO List
GenericMDOProvider reads MDO lists with default settings



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericMDOProvider">GenericMDOProvider</see> class.
The name of the MDO list is 'productcategory'.




## Sample Request

```http!
GET /api/v1/MDOList/productcategory
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("productcategory", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|3|Demotivational|||
|1|Life is good|||
|2|Life is not so good|||


## Related MDO Lists

* "productcategoryheadings"
* "productcategoryheadingswithallitem"
* "productcategoryheadingswithallitemwithnoselection"
* "productcategoryheadingswithnoselection"
* "productcategorywithallitem"
* "productcategorywithallitemwithnoselection"
* "productcategorywithnoselection"
