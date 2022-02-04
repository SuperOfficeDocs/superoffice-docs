---
uid: contint
title: contint
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "contint"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "contint" MDO List
GenericMDOProvider reads MDO lists with default settings



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericMDOProvider">GenericMDOProvider</see> class.
The name of the MDO list is 'contint'.




## Sample Request

```http!
GET /api/v1/MDOList/contint
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("contint", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|2|Prestisjekunde|||
|1|Referansekunde|||
|3|Storkunde|||


## Related MDO Lists

* "contintheadings"
* "contintheadingswithallitem"
* "contintheadingswithallitemwithnoselection"
* "contintheadingswithnoselection"
* "contintwithallitem"
* "contintwithallitemwithnoselection"
* "contintwithnoselection"
