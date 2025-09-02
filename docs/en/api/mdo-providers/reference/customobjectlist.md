---
uid: customobjectlist
title: customobjectlist
keywords: mdoprovider mdo provider customobjectlist
description: <see cref="T:SuperOffice.CRM.Lists.CustomObjectListProvider" /> creates tree list of the custom objects
generated: true
content_type: reference
envir: onsite, online
---

# "customobjectlist" MDO List
<see cref="T:SuperOffice.CRM.Lists.CustomObjectListProvider" /> creates tree list of the custom objects



Implemented by the <see cref="T:SuperOffice.CRM.Lists.CustomObjectListProvider">CustomObjectListProvider</see> class.
The name of the MDO list is 'customobjectlist'.




## Sample Request

```http!
GET /api/v1/MDOList/customobjectlist
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("customobjectlist", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|6|Extra tables||parentId=-1|
|2|Rental||parentId=-1&tableName=y_rental|
|1|Equipment||parentId=-1&tableName=y_equipment|


## Related MDO Lists

* "customobjectlistheadings"
* "customobjectlistheadingswithallitem"
* "customobjectlistheadingswithallitemwithnoselection"
* "customobjectlistheadingswithnoselection"
* "customobjectlistwithallitem"
* "customobjectlistwithallitemwithnoselection"
* "customobjectlistwithnoselection"
