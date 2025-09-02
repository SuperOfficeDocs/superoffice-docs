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
|1|Monday||Monday|
|2|Tuesday||Tuesday|
|3|Wednesday||Wednesday|
|4|Thursday||Thursday|
|5|Friday||Friday|
|6|Saturday||Saturday|
|7|Sunday||Sunday|


## Related MDO Lists

* "weekdayheadings"
* "weekdayheadingswithallitem"
* "weekdayheadingswithallitemwithnoselection"
* "weekdayheadingswithnoselection"
* "weekdaywithallitem"
* "weekdaywithallitemwithnoselection"
* "weekdaywithnoselection"
