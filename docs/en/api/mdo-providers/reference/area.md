---
uid: area
title: area
keywords: mdoprovider mdo provider area
description: List provider for the Heading table. While this table looks like an MDO table, it lacks the standardized grouplink and headinglink companion tables for good reason, since it is the heading table itself.
generated: true
content_type: reference
envir: onsite, online
---

# "area" MDO List
List provider for the Heading table. While this table looks like an MDO table,
it lacks the standardized grouplink and headinglink companion tables for good reason,
since it is the heading table itself.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.AreaProvider">AreaProvider</see> class.
The name of the MDO list is 'area'.




## Sample Request

```http!
GET /api/v1/MDOList/area
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("area", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|TestArea1|||
|2|TestArea2|||


## Related MDO Lists

* "areaheadings"
* "areaheadingswithallitem"
* "areaheadingswithallitemwithnoselection"
* "areaheadingswithnoselection"
* "areawithallitem"
* "areawithallitemwithnoselection"
* "areawithnoselection"
