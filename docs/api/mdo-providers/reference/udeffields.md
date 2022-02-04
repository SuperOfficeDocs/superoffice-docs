---
uid: udeffields
title: udeffields
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "udeffields"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "udeffields" MDO List
Get a list of udef fields for a given type.
Optionally it is possible to exclude page one fields by adding extrainfo ( 'Contact,excludepageone' )



Implemented by the <see cref="T:SuperOffice.CRM.Lists.AdminUdefFieldsProvider">AdminUdefFieldsProvider</see> class.
The name of the MDO list is 'udeffields'.




## Sample Request

```http!
GET /api/v1/MDOList/udeffields
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("udeffields", forceFlatList: true);
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

* "udeffieldsheadings"
* "udeffieldsheadingswithallitem"
* "udeffieldsheadingswithallitemwithnoselection"
* "udeffieldsheadingswithnoselection"
* "udeffieldswithallitem"
* "udeffieldswithallitemwithnoselection"
* "udeffieldswithnoselection"
