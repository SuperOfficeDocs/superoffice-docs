---
uid: contint
title: contint
keywords: mdoprovider mdo provider contint
description: MDO list provider for Interests
generated: true
content_type: reference
envir: onsite, online
---

# "contint" MDO List
MDO list provider for Interests



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ContIntProvider">ContIntProvider</see> class.
The name of the MDO list is 'contint'.




## Sample Request

```http!
GET /api/v1/MDOList/contint
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("contint", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Referansekunde|||
|2|Prestisjekunde|||
|3|Storkunde|||


## Related MDO Lists

* "contintheadings"
* "contintheadingswithallitem"
* "contintheadingswithallitemwithnoselection"
* "contintheadingswithnoselection"
* "contintwithallitem"
* "contintwithallitemwithnoselection"
* "contintwithnoselection"
