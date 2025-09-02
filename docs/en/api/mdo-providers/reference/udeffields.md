---
uid: udeffields
title: udeffields
keywords: mdoprovider mdo provider udeffields
description: Get a list of udef fields for a given type. Optionally it is possible to exclude page one fields by adding extrainfo ( 'Contact,excludepageone' )
generated: true
content_type: reference
envir: onsite, online
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
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("udeffields", forceFlatList: true);
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
