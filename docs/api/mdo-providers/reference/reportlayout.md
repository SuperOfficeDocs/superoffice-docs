---
uid: reportlayout
title: reportlayout
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "reportlayout"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "reportlayout" MDO List
ReportCategoryProvider creates an MDO list that consists of the values in <see cref="T:SuperOffice.Data.ReportCategory" />.
In the MDO list the following enumeration values are omitted: All, Person and Diary.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ReportLayoutProvider">ReportLayoutProvider</see> class.
The name of the MDO list is 'reportlayout'.




## Sample Request

```http!
GET /api/v1/MDOList/reportlayout
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("reportlayout", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|List|||
|2|Label|||
|3|Group List|||
|4|Cross Table|||
|5|Calendar week-5|||
|6|Calendar week-7|||
|7|Calendar month|||
|8|Text|||


## Related MDO Lists

* "reportlayoutheadings"
* "reportlayoutheadingswithallitem"
* "reportlayoutheadingswithallitemwithnoselection"
* "reportlayoutheadingswithnoselection"
* "reportlayoutwithallitem"
* "reportlayoutwithallitemwithnoselection"
* "reportlayoutwithnoselection"
