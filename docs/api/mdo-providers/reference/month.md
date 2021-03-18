---
uid: month
title: month
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
so.generated: true
so.date: 18.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "month" MDO List
MDO provider for the hard-coded list of "of" months in the recurrence dialog.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.MonthProvider">MonthProvider</see> class.
The name of the MDO list is 'month'.




## Sample Request

```http!
GET /api/v1/MDOList/month
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("month", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|January|||
|2|February|||
|3|March|||
|4|April|||
|5|May|||
|6|June|||
|7|July|||
|8|August|||
|9|September|||
|10|October|||
|11|November|||
|12|December|||


## Related MDO Lists

* "monthheadings"
* "monthheadingswithallitem"
* "monthheadingswithallitemwithnoselection"
* "monthheadingswithnoselection"
* "monthwithallitem"
* "monthwithallitemwithnoselection"
* "monthwithnoselection"
