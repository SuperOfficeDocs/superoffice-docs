---
uid: dayofmonth
title: dayofmonth
keywords: mdoprovider mdo provider dayofmonth
description: MDO provider for the hard-coded list of day alternatives in the recurrence dialog.
generated: true
content_type: reference
envir: onsite, online
---

# "dayofmonth" MDO List
MDO provider for the hard-coded list of day alternatives in the recurrence dialog.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.DayOfMonthProvider">DayOfMonthProvider</see> class.
The name of the MDO list is 'dayofmonth'.




## Sample Request

```http!
GET /api/v1/MDOList/dayofmonth
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("dayofmonth", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|[SR_RECDLG_DAY_NR]|replacekey=%d|1|
|2|[SR_RECDLG_DAY_NR]|replacekey=%d|2|
|3|[SR_RECDLG_DAY_NR]|replacekey=%d|3|
|4|[SR_RECDLG_DAY_NR]|replacekey=%d|4|
|5|[SR_RECDLG_DAY_NR]|replacekey=%d|5|
|6|[SR_RECDLG_DAY_NR]|replacekey=%d|6|
|7|[SR_RECDLG_DAY_NR]|replacekey=%d|7|
|8|[SR_RECDLG_DAY_NR]|replacekey=%d|8|
|9|[SR_RECDLG_DAY_NR]|replacekey=%d|9|
|10|[SR_RECDLG_DAY_NR]|replacekey=%d|10|
|11|[SR_RECDLG_DAY_NR]|replacekey=%d|11|
|12|[SR_RECDLG_DAY_NR]|replacekey=%d|12|
|13|[SR_RECDLG_DAY_NR]|replacekey=%d|13|
|14|[SR_RECDLG_DAY_NR]|replacekey=%d|14|
|15|[SR_RECDLG_DAY_NR]|replacekey=%d|15|
|16|[SR_RECDLG_DAY_NR]|replacekey=%d|16|
|17|[SR_RECDLG_DAY_NR]|replacekey=%d|17|
|18|[SR_RECDLG_DAY_NR]|replacekey=%d|18|
|19|[SR_RECDLG_DAY_NR]|replacekey=%d|19|
|20|[SR_RECDLG_DAY_NR]|replacekey=%d|20|
|21|[SR_RECDLG_DAY_NR]|replacekey=%d|21|


## Related MDO Lists

* "dayofmonthheadings"
* "dayofmonthheadingswithallitem"
* "dayofmonthheadingswithallitemwithnoselection"
* "dayofmonthheadingswithnoselection"
* "dayofmonthwithallitem"
* "dayofmonthwithallitemwithnoselection"
* "dayofmonthwithnoselection"
