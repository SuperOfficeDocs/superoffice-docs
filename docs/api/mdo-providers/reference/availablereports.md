---
uid: availablereports
title: availablereports
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "availablereports"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "availablereports" MDO List
AvailableReportsProvider creates an MDO list containing the available reports.
The available reports are either the standard SuperOffice reports, the reports defined in ReporterStudio,
or the favorites for each user as defined in SuperOffice.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.AvailableReportsProvider">AvailableReportsProvider</see> class.
The name of the MDO list is 'availablereports'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Report category enum value. Contact=2, Sale reports=4, etc| |2|





## Sample Request

```http!
GET /api/v1/MDOList/availablereports
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("availablereports", forceFlatList: true);
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

* "availablereportsheadings"
* "availablereportsheadingswithallitem"
* "availablereportsheadingswithallitemwithnoselection"
* "availablereportsheadingswithnoselection"
* "availablereportswithallitem"
* "availablereportswithallitemwithnoselection"
* "availablereportswithnoselection"
