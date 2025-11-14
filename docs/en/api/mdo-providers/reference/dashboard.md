---
uid: dashboard
title: dashboard
keywords: mdoprovider mdo provider dashboard
description: MDO list provider for Dashboard, can be used by Navigator.
generated: true
content_type: reference
envir: onsite, online
---

# "dashboard" MDO List
MDO list provider for Dashboard, can be used by Navigator.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.DashboardProvider">DashboardProvider</see> class.
The name of the MDO list is 'dashboard'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Return only the current users dashboards| OnlyMine|False|
|Only return dashboards you are allowed to update| CanUpdate|False|
|Comma separated list of IDs to be omitted from the result| ExcludeIds|False|
|Include the Flow Report dashboard| IncludeFlowReport|False|

Separator: &





## Sample Request

```http!
GET /api/v1/MDOList/dashboard
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("dashboard", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Status|||
|2|Requests|||


## Related MDO Lists

* "dashboardheadings"
* "dashboardheadingswithallitem"
* "dashboardheadingswithallitemwithnoselection"
* "dashboardheadingswithnoselection"
* "dashboardwithallitem"
* "dashboardwithallitemwithnoselection"
* "dashboardwithnoselection"
