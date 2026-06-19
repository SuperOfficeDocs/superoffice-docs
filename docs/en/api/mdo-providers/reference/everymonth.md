---
uid: everymonth
title: everymonth
keywords: mdoprovider mdo provider everymonth
description: MDO provider for the hard-coded list of day month in the recurrence dialog.
generated: true
content_type: reference
envir: onsite, online
---

# "everymonth" MDO List
MDO provider for the hard-coded list of day month in the recurrence dialog.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.RecurrenceEveryMonthProvider">RecurrenceEveryMonthProvider</see> class.
The name of the MDO list is 'everymonth'.




## Sample Request

```http!
GET /api/v1/MDOList/everymonth
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("everymonth", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|[SR_RECDLG_OF_EVERY_X_MONTHS]|replacekey=$month|1|
|2|[SR_RECDLG_OF_EVERY_X_MONTHS]|replacekey=$month|2|
|3|[SR_RECDLG_OF_EVERY_X_MONTHS]|replacekey=$month|3|
|4|[SR_RECDLG_OF_EVERY_X_MONTHS]|replacekey=$month|4|
|5|[SR_RECDLG_OF_EVERY_X_MONTHS]|replacekey=$month|5|
|6|[SR_RECDLG_OF_EVERY_X_MONTHS]|replacekey=$month|6|
|7|[SR_RECDLG_OF_EVERY_X_MONTHS]|replacekey=$month|7|
|8|[SR_RECDLG_OF_EVERY_X_MONTHS]|replacekey=$month|8|
|9|[SR_RECDLG_OF_EVERY_X_MONTHS]|replacekey=$month|9|
|10|[SR_RECDLG_OF_EVERY_X_MONTHS]|replacekey=$month|10|
|11|[SR_RECDLG_OF_EVERY_X_MONTHS]|replacekey=$month|11|
|12|[SR_RECDLG_OF_EVERY_X_MONTHS]|replacekey=$month|12|


## Related MDO Lists

* "everymonthheadings"
* "everymonthheadingswithallitem"
* "everymonthheadingswithallitemwithnoselection"
* "everymonthheadingswithnoselection"
* "everymonthwithallitem"
* "everymonthwithallitemwithnoselection"
* "everymonthwithnoselection"
