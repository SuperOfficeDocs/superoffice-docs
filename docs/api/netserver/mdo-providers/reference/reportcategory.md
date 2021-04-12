---
uid: reportcategory
title: reportcategory
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "reportcategory"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "reportcategory" MDO List
ReportCategoryProvider creates an MDO list that consists of the values in <see cref="T:SuperOffice.Data.ReportCategory" />.
In the MDO list the following enumeration values are omitted: All, Person and Diary.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ReportCategoryProvider">ReportCategoryProvider</see> class.
The name of the MDO list is 'reportcategory'.




## Sample Request

```http!
GET /api/v1/MDOList/reportcategory
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("reportcategory", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|9|Favourites||Favorites|
|2|Company/contact||Contact|
|3|Project||Project|
|4|Sale||Sale|
|5|Activities||activity|
|6|Selection||Selection|


## Related MDO Lists

* "reportcategoryheadings"
* "reportcategoryheadingswithallitem"
* "reportcategoryheadingswithallitemwithnoselection"
* "reportcategoryheadingswithnoselection"
* "reportcategorywithallitem"
* "reportcategorywithallitemwithnoselection"
* "reportcategorywithnoselection"
