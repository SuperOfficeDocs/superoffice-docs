---
uid: currentudeffields
title: currentudeffields
keywords: mdoprovider mdo provider currentudeffields
description: Get a list of udef fields for a given type. Pass the type as AdditionalInfo. Optionally it is possible to exclude page one fields by adding extrainfo ( 'Contact,excludepageone' )
generated: true
content_type: reference
envir: onsite, online
---

# "currentudeffields" MDO List
Get a list of udef fields for a given type. Pass the type as AdditionalInfo.
Optionally it is possible to exclude page one fields by adding extrainfo ( 'Contact,excludepageone' )



Implemented by the <see cref="T:SuperOffice.CRM.Lists.CurrentUdefFieldsProvider">CurrentUdefFieldsProvider</see> class.
The name of the MDO list is 'currentudeffields'.




## Sample Request

```http!
GET /api/v1/MDOList/currentudeffields
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("currentudeffields", forceFlatList: true);
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

* "currentudeffieldsheadings"
* "currentudeffieldsheadingswithallitem"
* "currentudeffieldsheadingswithallitemwithnoselection"
* "currentudeffieldsheadingswithnoselection"
* "currentudeffieldswithallitem"
* "currentudeffieldswithallitemwithnoselection"
* "currentudeffieldswithnoselection"
