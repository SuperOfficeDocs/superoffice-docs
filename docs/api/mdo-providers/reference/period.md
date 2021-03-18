---
uid: period
title: period
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
so.generated: true
so.date: 18.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "period" MDO List
Period values: Day, Week, Month, Quarter, Year



Implemented by the <see cref="T:SuperOffice.CRM.Lists.PeriodProvider">PeriodProvider</see> class.
The name of the MDO list is 'period'.




## Sample Request

```http!
GET /api/v1/MDOList/period
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("period", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Day|||
|2|Week|||
|3|Month|||
|4|Quarter|||
|5|Half year|||
|6|Year|||


## Related MDO Lists

* "periodheadings"
* "periodheadingswithallitem"
* "periodheadingswithallitemwithnoselection"
* "periodheadingswithnoselection"
* "periodwithallitem"
* "periodwithallitemwithnoselection"
* "periodwithnoselection"
