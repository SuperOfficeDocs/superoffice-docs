---
uid: weekday
title: weekday
keywords: mdoprovider mdo provider weekday
description: MDO provider for the hard-coded list of week days.
generated: true
content_type: reference
envir: onsite, online
---

# "weekday" MDO List
MDO provider for the hard-coded list of week days.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.WeekdayProvider">WeekdayProvider</see> class.
The name of the MDO list is 'weekday'.




## Sample Request

```http!
GET /api/v1/MDOList/weekday
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("weekday", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|[SR_DATE_MONDAY]||Monday|
|2|[SR_DATE_TUESDAY]||Tuesday|
|3|[SR_DATE_WEDNESDAY]||Wednesday|
|4|[SR_DATE_THURSDAY]||Thursday|
|5|[SR_DATE_FRIDAY]||Friday|
|6|[SR_DATE_SATURDAY]||Saturday|
|7|[SR_DATE_SUNDAY]||Sunday|


## Related MDO Lists

* "weekdayheadings"
* "weekdayheadingswithallitem"
* "weekdayheadingswithallitemwithnoselection"
* "weekdayheadingswithnoselection"
* "weekdaywithallitem"
* "weekdaywithallitemwithnoselection"
* "weekdaywithnoselection"
