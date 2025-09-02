---
uid: dashboardtheme
title: dashboardtheme
keywords: mdoprovider mdo provider dashboardtheme
description: 
generated: true
content_type: reference
envir: onsite, online
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
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("dashboardtheme", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Default||client=sales&style=light|
|2|Calm||client=sales&style=light|
|3|Dark||client=sales&style=light|
|4|Dark mode||client=sales&style=dark|
|5|Dark mode||client=mobile&style=dark|


## Related MDO Lists

* "dashboardthemeheadings"
* "dashboardthemeheadingswithallitem"
* "dashboardthemeheadingswithallitemwithnoselection"
* "dashboardthemeheadingswithnoselection"
* "dashboardthemewithallitem"
* "dashboardthemewithallitemwithnoselection"
* "dashboardthemewithnoselection"
