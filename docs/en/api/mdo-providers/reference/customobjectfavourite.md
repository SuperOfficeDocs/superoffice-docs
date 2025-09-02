---
uid: customobjectfavourite
title: customobjectfavourite
keywords: mdoprovider mdo provider customobjectfavourite
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "customobjectfavourite" MDO List
The name of the MDO list is 'customobjectfavourite'.




## Sample Request

```http!
GET /api/v1/MDOList/customobjectfavourite
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("customobjectfavourite", forceFlatList: true);
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

* "customobjectfavouriteheadings"
* "customobjectfavouriteheadingswithallitem"
* "customobjectfavouriteheadingswithallitemwithnoselection"
* "customobjectfavouriteheadingswithnoselection"
* "customobjectfavouritewithallitem"
* "customobjectfavouritewithallitemwithnoselection"
* "customobjectfavouritewithnoselection"
