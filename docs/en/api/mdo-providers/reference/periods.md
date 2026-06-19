---
uid: periods
title: periods
keywords: mdoprovider mdo provider periods
description: Period values - Day, Week, Month, Quarter, Year
generated: true
content_type: reference
envir: onsite, online
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
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("periods", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|[SR_CRITERION_PERIOD_DAYS]|||
|2|[SR_CRITERION_PERIOD_WEEKS]|||
|3|[SR_CRITERION_PERIOD_MONTHS]|||
|4|[SR_CRITERION_PERIOD_QUARTERS]|||
|5|[SR_CRITERION_PERIOD_HALF_YEARS]|||
|6|[SR_CRITERION_PERIOD_YEARS]|||


## Related MDO Lists

* "periodsheadings"
* "periodsheadingswithallitem"
* "periodsheadingswithallitemwithnoselection"
* "periodsheadingswithnoselection"
* "periodswithallitem"
* "periodswithallitemwithnoselection"
* "periodswithnoselection"
