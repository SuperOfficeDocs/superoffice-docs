---
uid: importduplicateaction
title: importduplicateaction
keywords: mdoprovider mdo provider importduplicateaction
description: Import Duplicate actions - Add, Merge, Replace, Skip
generated: true
content_type: reference
envir: onsite, online
---

# "importduplicateaction" MDO List
Import Duplicate actions: Add, Merge, Replace, Skip



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ImportDuplicateActionProvider">ImportDuplicateActionProvider</see> class.
The name of the MDO list is 'importduplicateaction'.




## Sample Request

```http!
GET /api/v1/MDOList/importduplicateaction
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("importduplicateaction", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Add always|||
|2|Merge - update empty fields|||
|3|Replace - overwrite existing|||
|4|Skip - do not import|||


## Related MDO Lists

* "importduplicateactionheadings"
* "importduplicateactionheadingswithallitem"
* "importduplicateactionheadingswithallitemwithnoselection"
* "importduplicateactionheadingswithnoselection"
* "importduplicateactionwithallitem"
* "importduplicateactionwithallitemwithnoselection"
* "importduplicateactionwithnoselection"
