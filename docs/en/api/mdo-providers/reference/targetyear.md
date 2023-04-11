---
uid: targetyear
title: targetyear
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "targetyear"
so.generated: true
so.date: 03.31.2023
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "targetyear" MDO List
Year MDO list. Includes the two coming years, this year, and previous 5 years



Implemented by the <see cref="T:SuperOffice.CRM.Lists.TargetYearProvider">TargetYearProvider</see> class.
The name of the MDO list is 'targetyear'.




## Sample Request

```http!
GET /api/v1/MDOList/targetyear
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("targetyear", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|2025|2025|||
|2024|2024|||
|2023|2023|||
|2022|2022|||
|2021|2021|||
|2020|2020|||
|2019|2019|||
|2018|2018|||


## Related MDO Lists

* "targetyearheadings"
* "targetyearheadingswithallitem"
* "targetyearheadingswithallitemwithnoselection"
* "targetyearheadingswithnoselection"
* "targetyearwithallitem"
* "targetyearwithallitemwithnoselection"
* "targetyearwithnoselection"
