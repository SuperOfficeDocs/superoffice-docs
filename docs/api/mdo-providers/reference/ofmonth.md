---
uid: ofmonth
title: ofmonth
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "ofmonth"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
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
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("ofmonth", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|of $monthName|replacekey=$monthName|[SR_MONTH_JANUARY]|
|2|of $monthName|replacekey=$monthName|[SR_MONTH_FEBRUARY]|
|3|of $monthName|replacekey=$monthName|[SR_MONTH_MARCH]|
|4|of $monthName|replacekey=$monthName|[SR_MONTH_APRIL]|
|5|of $monthName|replacekey=$monthName|[SR_MONTH_MAY]|
|6|of $monthName|replacekey=$monthName|[SR_MONTH_JUNE]|
|7|of $monthName|replacekey=$monthName|[SR_MONTH_JULY]|
|8|of $monthName|replacekey=$monthName|[SR_MONTH_AUGUST]|
|9|of $monthName|replacekey=$monthName|[SR_MONTH_SEPTEMBER]|
|10|of $monthName|replacekey=$monthName|[SR_MONTH_OCTOBER]|
|11|of $monthName|replacekey=$monthName|[SR_MONTH_NOVEMBER]|
|12|of $monthName|replacekey=$monthName|[SR_MONTH_DECEMBER]|


## Related MDO Lists

* "ofmonthheadings"
* "ofmonthheadingswithallitem"
* "ofmonthheadingswithallitemwithnoselection"
* "ofmonthheadingswithnoselection"
* "ofmonthwithallitem"
* "ofmonthwithallitemwithnoselection"
* "ofmonthwithnoselection"
