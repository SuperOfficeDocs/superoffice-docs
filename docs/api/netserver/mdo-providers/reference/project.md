---
uid: project
title: project
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "project"
so.generated: true
so.date: 03.19.2021
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
|2782|Abbott and Sons|||
|3617|Abbott and Sons|||
|2903|Abbott Group|||
|2849|Abbott, Jacobi and Reynolds|||
|2672|Abbott, Kirlin and Rau|||
|2160|Abbott-Abernathy|||
|3209|Abernathy Group|||
|3114|Abernathy Inc|||
|2383|Abernathy Inc|||
|3257|Abernathy LLC|||
|2638|Abernathy, Jenkins and Vandervort|||


## Related MDO Lists

* "projectheadings"
* "projectheadingswithallitem"
* "projectheadingswithallitemwithnoselection"
* "projectheadingswithnoselection"
* "projectwithallitem"
* "projectwithallitemwithnoselection"
* "projectwithnoselection"
