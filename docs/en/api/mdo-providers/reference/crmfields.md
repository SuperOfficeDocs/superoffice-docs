---
uid: crmfields
title: crmfields
keywords: mdoprovider mdo provider crmfields
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "crmfields" MDO List




Implemented by the <see cref="T:SuperOffice.ErpSync.CrmFieldMdoProvider">CrmFieldMdoProvider</see> class.
The name of the MDO list is 'crmfields'.




## Sample Request

```http!
GET /api/v1/MDOList/crmfields
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("crmfields", forceFlatList: true);
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

* "crmfieldsheadings"
* "crmfieldsheadingswithallitem"
* "crmfieldsheadingswithallitemwithnoselection"
* "crmfieldsheadingswithnoselection"
* "crmfieldswithallitem"
* "crmfieldswithallitemwithnoselection"
* "crmfieldswithnoselection"
