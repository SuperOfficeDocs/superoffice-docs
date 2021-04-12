---
uid: dashboardtile
title: dashboardtile
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "dashboardtile"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "dashboardtile" MDO List
MDO list provider for Dashboard tiles
If the DashboardTileEntityType parameter is given in the ExtraInfo, only this type will be shown in list, so no tree view in that case.
Example: DashboardTileEntityType=Company



Implemented by the <see cref="T:SuperOffice.CRM.Lists.DashboardTileListProvider">DashboardTileListProvider</see> class.
The name of the MDO list is 'dashboardtile'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|DashboardTileEntityType Enum type to filter tiles on| DashboardTileEntityType|Document|

Separator: &





## Sample Request

```http!
GET /api/v1/MDOList/dashboardtile
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("dashboardtile", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
| 2 | Example | | |


## Related MDO Lists

* "dashboardtileheadings"
* "dashboardtileheadingswithallitem"
* "dashboardtileheadingswithallitemwithnoselection"
* "dashboardtileheadingswithnoselection"
* "dashboardtilewithallitem"
* "dashboardtilewithallitemwithnoselection"
* "dashboardtilewithnoselection"
