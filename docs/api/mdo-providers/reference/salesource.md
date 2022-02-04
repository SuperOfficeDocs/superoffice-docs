---
uid: salesource
title: salesource
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "salesource"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "salesource" MDO List
MDO list provider for the source list of the Sale dialog.
This list extends the basic <see cref="!:SourceRow" /> list with icons



Implemented by the <see cref="T:SuperOffice.CRM.Lists.SaleSource">SaleSource</see> class.
The name of the MDO list is 'salesource'.




## Sample Request

```http!
GET /api/v1/MDOList/salesource
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("salesource", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Aktivt salg|||
|4|Annbefaling|||
|3|Internet|||
|2|Kampanje|||


## Related MDO Lists

* "salesourceheadings"
* "salesourceheadingswithallitem"
* "salesourceheadingswithallitemwithnoselection"
* "salesourceheadingswithnoselection"
* "salesourcewithallitem"
* "salesourcewithallitemwithnoselection"
* "salesourcewithnoselection"
