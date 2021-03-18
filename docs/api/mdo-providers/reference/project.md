---
uid: project
title: project
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

# "project" MDO List
Provider for selecting a project.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ProjectListProviderOrg">ProjectListProviderOrg</see> class.
The name of the MDO list is 'project'.




## Sample Request

```http!
GET /api/v1/MDOList/project
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("project", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|58|00o00ee00|||
|59|11o11ee11|||
|60|22o22ee22|||
|57|33o33ee33|||
|61|44o44ee44|||
|62|55o55ee55|||
|63|66o66ee66|||
|64|77o77ee77|||
|65|88o88ee88|||
|66|99o99ee99|||
|16|BBoBBeeBB|||
|78|Cat project|||
|73|Cats sale one|||
|17|Ccocceecc|||
|18|ddoddeedd|||
|20|ffoffeeff|||
|77|Fish project 1|||
|21|ggoggeegg|||
|70|Guided Project|||
|71|Guided Project With Progress|||
|22|hhohheehh|||


## Related MDO Lists

* "projectheadings"
* "projectheadingswithallitem"
* "projectheadingswithallitemwithnoselection"
* "projectheadingswithnoselection"
* "projectwithallitem"
* "projectwithallitemwithnoselection"
* "projectwithnoselection"
