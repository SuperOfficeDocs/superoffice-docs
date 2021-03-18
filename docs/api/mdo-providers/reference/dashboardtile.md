---
uid: dashboardtile
title: dashboardtile
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
|1507|My companies by category|||
|1514|My companies by category and country|||
|1518|My companies by business|||
|1544|My companies by category and business|||
|1513|Active projects for my group, sorted by owner|||
|1543|My active projects by type|||
|1504|My Pipeline - weighted amount|||
|1506|Last won sales|||
|1508|Leads won by my group, sorted by source|||
|1509|Top sales reps this month|||
|1511|My pipeline - actual amount|||
|1512|My closing rate|||
|1515|My lost sales by reason|||
|1517|Lost sales by my group, sorted by competitor |||
|1521|Win/loss rate for my group, sorted by source|||
|1522|Largest upcoming sales|||
|1523|My forecast|||
|1524|Group revenue this month|||
|1526|Sales YTD compared to last year for my group|||
|1527|My pipeline in numbers|||
|1528|My sales in numbers|||


## Related MDO Lists

* "dashboardtileheadings"
* "dashboardtileheadingswithallitem"
* "dashboardtileheadingswithallitemwithnoselection"
* "dashboardtileheadingswithnoselection"
* "dashboardtilewithallitem"
* "dashboardtilewithallitemwithnoselection"
* "dashboardtilewithnoselection"
