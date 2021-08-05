---
uid: mrmrs
title: mrmrs
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "mrmrs"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "mrmrs" MDO List
GenericMDOProvider reads MDO lists with default settings



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericMDOProvider">GenericMDOProvider</see> class.
The name of the MDO list is 'mrmrs'.




## Sample Request

```http!
GET /api/v1/MDOList/mrmrs
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("mrmrs", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|3|Fru|||
|4|Herr|||
|1|Mr.|||
|2|Mrs.|||


## Related MDO Lists

* "mrmrsheadings"
* "mrmrsheadingswithallitem"
* "mrmrsheadingswithallitemwithnoselection"
* "mrmrsheadingswithnoselection"
* "mrmrswithallitem"
* "mrmrswithallitemwithnoselection"
* "mrmrswithnoselection"
