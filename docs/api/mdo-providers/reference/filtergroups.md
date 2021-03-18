---
uid: filtergroups
title: filtergroups
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

# "filtergroups" MDO List
User groups, filtered according to the usergroups selected in the filter dialog.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.FilterUserGroupProvider">FilterUserGroupProvider</see> class.
The name of the MDO list is 'filtergroups'.




## Sample Request

```http!
GET /api/v1/MDOList/filtergroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("filtergroups", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|2|Salg|||
|4|Tjenester|||
|3|Service|||
|5|Markedsføring|||
|1|Administrasjon|||
|6|Testgruppe1|||
|7|Testgruppe2|||


## Related MDO Lists

* "filtergroupsheadings"
* "filtergroupsheadingswithallitem"
* "filtergroupsheadingswithallitemwithnoselection"
* "filtergroupsheadingswithnoselection"
* "filtergroupswithallitem"
* "filtergroupswithallitemwithnoselection"
* "filtergroupswithnoselection"
