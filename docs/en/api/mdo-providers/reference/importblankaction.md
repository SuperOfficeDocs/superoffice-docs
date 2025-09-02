---
uid: importblankaction
title: importblankaction
keywords: mdoprovider mdo provider importblankaction
description: Import actions for blank values - Use Person Name, Skip
generated: true
content_type: reference
envir: onsite, online
---

# "importblankaction" MDO List
Import actions for blank values: Use Person Name, Skip



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ImportBlankActionProvider">ImportBlankActionProvider</see> class.
The name of the MDO list is 'importblankaction'.




## Sample Request

```http!
GET /api/v1/MDOList/importblankaction
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("importblankaction", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Create company using contact name|||
|2|Skip – do not create company or contact|||


## Related MDO Lists

* "importblankactionheadings"
* "importblankactionheadingswithallitem"
* "importblankactionheadingswithallitemwithnoselection"
* "importblankactionheadingswithnoselection"
* "importblankactionwithallitem"
* "importblankactionwithallitemwithnoselection"
* "importblankactionwithnoselection"
