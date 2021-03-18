---
uid: projectassociate
title: projectassociate
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

# "projectassociate" MDO List
MDO provider for associates that are members of a project



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ProjectAssociateMDOProvider">ProjectAssociateMDOProvider</see> class.
The name of the MDO list is 'projectassociate'.




## Sample Request

```http!
GET /api/v1/MDOList/projectassociate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("projectassociate", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|15|Adm4|||
|2|Arne Arnesen|||
|3|Brede Bredesen|||
|4|Cato Carlsson|||
|5|Donald Duck|||
|7|Frode Freestad|||
|8|Geir Grønbeck|||
|9|Hans Hansen|||
|10|Ingrid Istad|||
|81|Listadm Listadm|||
|96|Niels Jensen|||


## Related MDO Lists

* "projectassociateheadings"
* "projectassociateheadingswithallitem"
* "projectassociateheadingswithallitemwithnoselection"
* "projectassociateheadingswithnoselection"
* "projectassociatewithallitem"
* "projectassociatewithallitemwithnoselection"
* "projectassociatewithnoselection"
