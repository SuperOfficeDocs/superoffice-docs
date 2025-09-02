---
uid: typegroup
title: typegroup
keywords: mdoprovider mdo provider typegroup
description: Type Group - Task, Activity, Document, Sale
generated: true
content_type: reference
envir: onsite, online
---

# "typegroup" MDO List
Type Group: Task, Activity, Document, Sale



Implemented by the <see cref="T:SuperOffice.CRM.Lists.TypeGroupProvider">TypeGroupProvider</see> class.
The name of the MDO list is 'typegroup'.




## Sample Request

```http!
GET /api/v1/MDOList/typegroup
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("typegroup", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|SR_SINGULAR_SELECTION_TASK|||
|2|SR_SINGULAR_ACTIVITY|||
|4|SR_AA_DOCUMENTS|||
|8|SR_AA_SALES|||


## Related MDO Lists

* "typegroupheadings"
* "typegroupheadingswithallitem"
* "typegroupheadingswithallitemwithnoselection"
* "typegroupheadingswithnoselection"
* "typegroupwithallitem"
* "typegroupwithallitemwithnoselection"
* "typegroupwithnoselection"
