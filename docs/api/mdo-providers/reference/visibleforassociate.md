---
uid: visibleforassociate
title: visibleforassociate
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "visibleforassociate"
so.generated: true
so.date: 08.26.2022
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "visibleforassociate" MDO List

List provider that returns a list suitable for VisibleFor and PinTo (with groups and possibly some other special items like All).

Implemented by the <see cref="T:SuperOffice.CRM.Lists.VisibleForAssociateMDOProvider">VisibleForAssociateMDOProvider</see> class.
The name of the MDO list is 'visibleforassociate'.

## Sample Request

```http!
GET /api/v1/MDOList/visibleforassociate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code

```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("visibleforassociate", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|11|Adm0|||
|12|Adm1|||
|13|Adm2|||
|14|Adm3|||
|15|Adm4|||
|16|Adm5|||
|106|Adm6|||
|1|Admin Adminson|||
|63|AdmNS02 NetServer|||
|2|Arne Arnesen|||
|3|Brede Bredesen|||
|4|Cato Carlsson|||
|5|Donald Duck|||
|6|Erik Eide|||
|7|Frode Freestad|||
|8|Geir Grønbeck|||
|9|Hans Hansen|||
|10|Ingrid Istad|||
|86|Johan Jensen|||
|87|Kjell Jensen|||
|81|Listadm Listadm|||

## Related MDO Lists

* "visibleforassociateheadings"
* "visibleforassociateheadingswithallitem"
* "visibleforassociateheadingswithallitemwithnoselection"
* "visibleforassociateheadingswithnoselection"
* "visibleforassociatewithallitem"
* "visibleforassociatewithallitemwithnoselection"
* "visibleforassociatewithnoselection"
