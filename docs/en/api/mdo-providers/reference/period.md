---
uid: period
title: period
keywords: mdoprovider mdo provider period
description: Period values - Day, Week, Month, Quarter, Year
generated: true
content_type: reference
envir: onsite, online
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
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("period", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|[SR_CRITERION_PERIOD_DAY]|||
|2|[SR_CRITERION_PERIOD_WEEK]|||
|3|[SR_CRITERION_PERIOD_MONTH]|||
|4|[SR_CRITERION_PERIOD_QUARTER]|||
|5|[SR_CRITERION_PERIOD_HALF_YEAR]|||
|6|[SR_CRITERION_PERIOD_YEAR]|||


## Related MDO Lists

* "periodheadings"
* "periodheadingswithallitem"
* "periodheadingswithallitemwithnoselection"
* "periodheadingswithnoselection"
* "periodwithallitem"
* "periodwithallitemwithnoselection"
* "periodwithnoselection"
