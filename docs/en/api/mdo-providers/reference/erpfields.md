---
uid: erpfields
title: erpfields
keywords: mdoprovider mdo provider erpfields
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "erpfields" MDO List




Implemented by the <see cref="T:SuperOffice.ErpSync.ErpFieldMdoProvider">ErpFieldMdoProvider</see> class.
The name of the MDO list is 'erpfields'.




## Sample Request

```http!
GET /api/v1/MDOList/erpfields
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("erpfields", forceFlatList: true);
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

* "erpfieldsheadings"
* "erpfieldsheadingswithallitem"
* "erpfieldsheadingswithallitemwithnoselection"
* "erpfieldsheadingswithnoselection"
* "erpfieldswithallitem"
* "erpfieldswithallitemwithnoselection"
* "erpfieldswithnoselection"
