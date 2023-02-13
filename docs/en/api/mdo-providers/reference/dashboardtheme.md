---
uid: dashboardtheme
title: dashboardtheme
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "dashboardtheme"
so.generated: true
so.date: 01.23.2023
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "dashboardtheme" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.DashboardThemeListProvider">DashboardThemeListProvider</see> class.
The name of the MDO list is 'dashboardtheme'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Return dashboard themes| DashboardTheme||
|Return dashboard themes associated with the client name| client||
|Return dashboard themes with this style value| style||





## Sample Request

```http!
GET /api/v1/MDOList/dashboardtheme
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("dashboardtheme", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|SR_DASHBOARD_THEME_DEFAULT||client=sales&style=light|
|2|SR_DASHBOARD_THEME_CALM||client=sales&style=light|
|3|SR_DASHBOARD_THEME_DARK||client=sales&style=light|
|4|SR_DASHBOARD_THEME_DARKMODE||client=sales&style=dark|
|5|SR_DASHBOARD_THEME_DARKMODE||client=mobile&style=dark|


## Related MDO Lists

* "dashboardthemeheadings"
* "dashboardthemeheadingswithallitem"
* "dashboardthemeheadingswithallitemwithnoselection"
* "dashboardthemeheadingswithnoselection"
* "dashboardthemewithallitem"
* "dashboardthemewithallitemwithnoselection"
* "dashboardthemewithnoselection"
