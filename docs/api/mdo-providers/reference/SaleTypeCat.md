---
uid: saletypecat
title: saletypecat
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "saletypecat"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "saletypecat" MDO List
GenericMDOProvider reads MDO lists with default settings



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericMDOProvider">GenericMDOProvider</see> class.
The name of the MDO list is 'saletypecat'.




## Sample Request

```http!
GET /api/v1/MDOList/saletypecat
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("saletypecat", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|General sales|||


## Related MDO Lists

* "saletypecatheadings"
* "saletypecatheadingswithallitem"
* "saletypecatheadingswithallitemwithnoselection"
* "saletypecatheadingswithnoselection"
* "saletypecatwithallitem"
* "saletypecatwithallitemwithnoselection"
* "saletypecatwithnoselection"
