---
uid: importproductduplicatematch
title: importproductduplicatematch
keywords: mdoprovider mdo provider importproductduplicatematch
description: Import product detect duplicates based on field - Name, Code, Name+Code
generated: true
content_type: reference
envir: onsite, online
---

# "importproductduplicatematch" MDO List
Import product detect duplicates based on field:  Name, Code, Name+Code



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ImportProductDuplicateMatchProvider">ImportProductDuplicateMatchProvider</see> class.
The name of the MDO list is 'importproductduplicatematch'.




## Sample Request

```http!
GET /api/v1/MDOList/importproductduplicatematch
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("importproductduplicatematch", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Name:|||
|2|Code|||
|3|Name + Code|||


## Related MDO Lists

* "importproductduplicatematchheadings"
* "importproductduplicatematchheadingswithallitem"
* "importproductduplicatematchheadingswithallitemwithnoselection"
* "importproductduplicatematchheadingswithnoselection"
* "importproductduplicatematchwithallitem"
* "importproductduplicatematchwithallitemwithnoselection"
* "importproductduplicatematchwithnoselection"
