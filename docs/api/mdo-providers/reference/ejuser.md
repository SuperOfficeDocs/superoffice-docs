---
uid: ejuser
title: ejuser
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
so.generated: true
so.date: 18.03.2021
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
|67|Sal0|||
|66|Adm6|||
|29|Ser0|||
|30|Ser1|||
|31|Ser2|||
|32|Ser3|||
|33|Ser4|||
|34|Ser5|||
|42|SerNS03 NetServer|||
|2|Tje0|||
|4|Tje1|||
|9|Tje2|||
|10|Tje3|||
|11|Tje4|||
|12|Tje5|||
|43|TjeNS04 NetServer|||
|61|Tjeneste Sjef|||


## Related MDO Lists

* "ejuserheadings"
* "ejuserheadingswithallitem"
* "ejuserheadingswithallitemwithnoselection"
* "ejuserheadingswithnoselection"
* "ejuserwithallitem"
* "ejuserwithallitemwithnoselection"
* "ejuserwithnoselection"
