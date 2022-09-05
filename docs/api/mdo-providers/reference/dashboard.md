---
uid: dashboard
title: dashboard
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "dashboard"
so.generated: true
so.date: 08.26.2022
so.topic: reference
so.envir:
  - "onsite"
  - "online"
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
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("dashboard", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Status|||


## Related MDO Lists

* "dashboardheadings"
* "dashboardheadingswithallitem"
* "dashboardheadingswithallitemwithnoselection"
* "dashboardheadingswithnoselection"
* "dashboardwithallitem"
* "dashboardwithallitemwithnoselection"
* "dashboardwithnoselection"
