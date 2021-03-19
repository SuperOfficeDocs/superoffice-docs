---
uid: ejuser
title: ejuser
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "ejuser"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "ejuser" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.EjUserProvider">EjUserProvider</see> class.
The name of the MDO list is 'ejuser'.




## Sample Request

```http!
GET /api/v1/MDOList/ejuser
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("ejuser", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|65|Sal0|||
|2|Tje0|||
|4|Tje1|||
|9|Tje2|||
|10|Tje3|||
|11|Tje4|||
|12|Tje5|||


## Related MDO Lists

* "ejuserheadings"
* "ejuserheadingswithallitem"
* "ejuserheadingswithallitemwithnoselection"
* "ejuserheadingswithnoselection"
* "ejuserwithallitem"
* "ejuserwithallitemwithnoselection"
* "ejuserwithnoselection"
