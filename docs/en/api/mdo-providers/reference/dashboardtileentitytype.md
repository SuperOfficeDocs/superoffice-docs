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
|1|[SR_CONTACT]|||
|2|[SR_PROJECT]|||
|3|[SR_COMMON_SALE]|||
|4|[SR_SINGULAR_PRODUCT]|||
|5|[SR_ACTIVITY]|||
|7|[SR_COMMON_WEB_PANEL]|||


## Related MDO Lists

* "dashboardtileentitytypeheadings"
* "dashboardtileentitytypeheadingswithallitem"
* "dashboardtileentitytypeheadingswithallitemwithnoselection"
* "dashboardtileentitytypeheadingswithnoselection"
* "dashboardtileentitytypewithallitem"
* "dashboardtileentitytypewithallitemwithnoselection"
* "dashboardtileentitytypewithnoselection"
