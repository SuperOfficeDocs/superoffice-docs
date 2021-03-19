---
uid: dayofmonth
title: dayofmonth
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "dayofmonth"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
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
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("dayofmonth", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Day %d|replacekey=%d|1|
|2|Day %d|replacekey=%d|2|
|3|Day %d|replacekey=%d|3|
|4|Day %d|replacekey=%d|4|
|5|Day %d|replacekey=%d|5|
|6|Day %d|replacekey=%d|6|
|7|Day %d|replacekey=%d|7|
|8|Day %d|replacekey=%d|8|
|9|Day %d|replacekey=%d|9|
|10|Day %d|replacekey=%d|10|
|11|Day %d|replacekey=%d|11|
|12|Day %d|replacekey=%d|12|
|13|Day %d|replacekey=%d|13|
|14|Day %d|replacekey=%d|14|
|15|Day %d|replacekey=%d|15|
|16|Day %d|replacekey=%d|16|
|17|Day %d|replacekey=%d|17|
|18|Day %d|replacekey=%d|18|
|19|Day %d|replacekey=%d|19|
|20|Day %d|replacekey=%d|20|
|21|Day %d|replacekey=%d|21|


## Related MDO Lists

* "dayofmonthheadings"
* "dayofmonthheadingswithallitem"
* "dayofmonthheadingswithallitemwithnoselection"
* "dayofmonthheadingswithnoselection"
* "dayofmonthwithallitem"
* "dayofmonthwithallitemwithnoselection"
* "dayofmonthwithnoselection"
