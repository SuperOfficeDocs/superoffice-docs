---
uid: erpfields
title: erpfields
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "erpfields"
so.generated: true
so.date: 03.31.2023
so.topic: reference
so.envir:
  - "onsite"
  - "online"
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
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("erpfields", forceFlatList: true);
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
