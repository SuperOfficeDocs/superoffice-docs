---
uid: ofmonth
title: ofmonth
keywords: mdoprovider mdo provider ofmonth
description: MDO provider for the hard-coded list of "of" months in the recurrence dialog.
generated: true
content_type: reference
envir: onsite, online
---

# "ofmonth" MDO List
MDO provider for the hard-coded list of "of" months in the recurrence dialog.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.OfMonthProvider">OfMonthProvider</see> class.
The name of the MDO list is 'ofmonth'.




## Sample Request

```http!
GET /api/v1/MDOList/ofmonth
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("ofmonth", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|[SR_RECDLG_OF_X_MONTH_NAME]|replacekey=$monthName|[SR_MONTH_JANUARY]|
|2|[SR_RECDLG_OF_X_MONTH_NAME]|replacekey=$monthName|[SR_MONTH_FEBRUARY]|
|3|[SR_RECDLG_OF_X_MONTH_NAME]|replacekey=$monthName|[SR_MONTH_MARCH]|
|4|[SR_RECDLG_OF_X_MONTH_NAME]|replacekey=$monthName|[SR_MONTH_APRIL]|
|5|[SR_RECDLG_OF_X_MONTH_NAME]|replacekey=$monthName|[SR_MONTH_MAY]|
|6|[SR_RECDLG_OF_X_MONTH_NAME]|replacekey=$monthName|[SR_MONTH_JUNE]|
|7|[SR_RECDLG_OF_X_MONTH_NAME]|replacekey=$monthName|[SR_MONTH_JULY]|
|8|[SR_RECDLG_OF_X_MONTH_NAME]|replacekey=$monthName|[SR_MONTH_AUGUST]|
|9|[SR_RECDLG_OF_X_MONTH_NAME]|replacekey=$monthName|[SR_MONTH_SEPTEMBER]|
|10|[SR_RECDLG_OF_X_MONTH_NAME]|replacekey=$monthName|[SR_MONTH_OCTOBER]|
|11|[SR_RECDLG_OF_X_MONTH_NAME]|replacekey=$monthName|[SR_MONTH_NOVEMBER]|
|12|[SR_RECDLG_OF_X_MONTH_NAME]|replacekey=$monthName|[SR_MONTH_DECEMBER]|


## Related MDO Lists

* "ofmonthheadings"
* "ofmonthheadingswithallitem"
* "ofmonthheadingswithallitemwithnoselection"
* "ofmonthheadingswithnoselection"
* "ofmonthwithallitem"
* "ofmonthwithallitemwithnoselection"
* "ofmonthwithnoselection"
