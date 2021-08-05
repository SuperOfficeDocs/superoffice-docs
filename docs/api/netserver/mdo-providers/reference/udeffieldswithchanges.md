---
uid: udeffieldswithchanges
title: udeffieldswithchanges
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "udeffieldswithchanges"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "udeffieldswithchanges" MDO List
Get a list of udef fields for a given type.
Optionally it is possible to exclude page one fields by adding extrainfo ( 'Contact,excludepageone' )



Implemented by the <see cref="T:SuperOffice.CRM.Lists.UdefFieldsWithChangesProvider">UdefFieldsWithChangesProvider</see> class.
The name of the MDO list is 'udeffieldswithchanges'.




## Sample Request

```http!
GET /api/v1/MDOList/udeffieldswithchanges
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("udeffieldswithchanges", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
| 2 | Example | | |


## Related MDO Lists

* "udeffieldswithchangesheadings"
* "udeffieldswithchangesheadingswithallitem"
* "udeffieldswithchangesheadingswithallitemwithnoselection"
* "udeffieldswithchangesheadingswithnoselection"
* "udeffieldswithchangeswithallitem"
* "udeffieldswithchangeswithallitemwithnoselection"
* "udeffieldswithchangeswithnoselection"
