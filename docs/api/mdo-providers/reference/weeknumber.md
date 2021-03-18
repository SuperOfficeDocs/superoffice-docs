---
uid: weeknumber
title: weeknumber
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

# "weeknumber" MDO List
MDO provider for the hard-coded list of numbered weeks in the recurrence dialog.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.WeekNumberProvider">WeekNumberProvider</see> class.
The name of the MDO list is 'weeknumber'.




## Sample Request

```http!
GET /api/v1/MDOList/weeknumber
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("weeknumber", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|The First||First|
|2|The Second||Second|
|3|The Third||Third|
|4|The Fourth||Fourth|
|5|The Last||Last|


## Related MDO Lists

* "weeknumberheadings"
* "weeknumberheadingswithallitem"
* "weeknumberheadingswithallitemwithnoselection"
* "weeknumberheadingswithnoselection"
* "weeknumberwithallitem"
* "weeknumberwithallitemwithnoselection"
* "weeknumberwithnoselection"
