---
uid: targetyear
title: targetyear
keywords: mdoprovider mdo provider targetyear
description: Year MDO list. Includes the two coming years, this year, and previous 5 years
generated: true
content_type: reference
envir: onsite, online
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
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("targetyear", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|2027|2027|||
|2026|2026|||
|2025|2025|||
|2024|2024|||
|2023|2023|||
|2022|2022|||
|2021|2021|||
|2020|2020|||


## Related MDO Lists

* "targetyearheadings"
* "targetyearheadingswithallitem"
* "targetyearheadingswithallitemwithnoselection"
* "targetyearheadingswithnoselection"
* "targetyearwithallitem"
* "targetyearwithallitemwithnoselection"
* "targetyearwithnoselection"
