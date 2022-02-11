---
uid: periods
title: periods
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "periods"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "periods" MDO List
Period values: Day, Week, Month, Quarter, Year



Implemented by the <see cref="T:SuperOffice.CRM.Lists.PeriodsProvider">PeriodsProvider</see> class.
The name of the MDO list is 'periods'.




## Sample Request

```http!
GET /api/v1/MDOList/periods
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("periods", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Day(s)|||
|2|Week(s)|||
|3|Month(s)|||
|4|Quarter(s)|||
|5|Half year(s)|||
|6|Year(s)|||


## Related MDO Lists

* "periodsheadings"
* "periodsheadingswithallitem"
* "periodsheadingswithallitemwithnoselection"
* "periodsheadingswithnoselection"
* "periodswithallitem"
* "periodswithallitemwithnoselection"
* "periodswithnoselection"
