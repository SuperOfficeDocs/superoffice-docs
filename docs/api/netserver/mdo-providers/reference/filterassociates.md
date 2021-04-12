---
uid: filterassociates
title: filterassociates
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "filterassociates"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "filterassociates" MDO List
Associate list for the Filter dialog. This associate list differs from the standard list in two ways:
a) It contains even former employees (you may wnat to filter in our out their activites, even though they have gone);
and b) It is of type Selectable, with the currently selected
associates marked as such.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.FilterAssociateProvider">FilterAssociateProvider</see> class.
The name of the MDO list is 'filterassociates'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Associates linked to this heading| heading_id|2|
|Associates belonging to this user group (primary or secondary groups)| group_idx|2|
|Associates that are members of this project| project_id|231|

Separator: ;





## Sample Request

```http!
GET /api/v1/MDOList/filterassociates
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("filterassociates", forceFlatList: true);
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
|84|Localuser2 Localuser2|||


## Related MDO Lists

* "filterassociatesheadings"
* "filterassociatesheadingswithallitem"
* "filterassociatesheadingswithallitemwithnoselection"
* "filterassociatesheadingswithnoselection"
* "filterassociateswithallitem"
* "filterassociateswithallitemwithnoselection"
* "filterassociateswithnoselection"
