---
uid: everymonth
title: everymonth
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "everymonth"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
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
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("everymonth", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|of every $month month(s)|replacekey=$month|1|
|2|of every $month month(s)|replacekey=$month|2|
|3|of every $month month(s)|replacekey=$month|3|
|4|of every $month month(s)|replacekey=$month|4|
|5|of every $month month(s)|replacekey=$month|5|
|6|of every $month month(s)|replacekey=$month|6|
|7|of every $month month(s)|replacekey=$month|7|
|8|of every $month month(s)|replacekey=$month|8|
|9|of every $month month(s)|replacekey=$month|9|
|10|of every $month month(s)|replacekey=$month|10|
|11|of every $month month(s)|replacekey=$month|11|
|12|of every $month month(s)|replacekey=$month|12|


## Related MDO Lists

* "everymonthheadings"
* "everymonthheadingswithallitem"
* "everymonthheadingswithallitemwithnoselection"
* "everymonthheadingswithnoselection"
* "everymonthwithallitem"
* "everymonthwithallitemwithnoselection"
* "everymonthwithnoselection"
