---
uid: dashboardtileentitytype
title: dashboardtileentitytype
keywords: mdoprovider mdo provider dashboardtileentitytype
description: List of dashboard tile types - Company, Project, Sale, Product, Activity, Web Panel
generated: true
content_type: reference
envir: onsite, online
---

# "dashboardtileentitytype" MDO List
List of dashboard tile types: Company, Project, Sale, Product, Activity, Web Panel



Implemented by the <see cref="T:SuperOffice.CRM.Lists.DashboardTileEntityTypeProvider">DashboardTileEntityTypeProvider</see> class.
The name of the MDO list is 'dashboardtileentitytype'.




## Sample Request

```http!
GET /api/v1/MDOList/dashboardtileentitytype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("dashboardtileentitytype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Company|||
|2|Project|||
|3|Sale|||
|4|Product|||
|5|Activity|||
|7|Web panel|||


## Related MDO Lists

* "dashboardtileentitytypeheadings"
* "dashboardtileentitytypeheadingswithallitem"
* "dashboardtileentitytypeheadingswithallitemwithnoselection"
* "dashboardtileentitytypeheadingswithnoselection"
* "dashboardtileentitytypewithallitem"
* "dashboardtileentitytypewithallitemwithnoselection"
* "dashboardtileentitytypewithnoselection"
