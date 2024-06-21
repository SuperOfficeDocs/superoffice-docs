---
uid: customobjectrelation
title: customobjectrelation
keywords: mdoprovider mdo provider customobjectrelation
description: 
generated: true
topic: reference
envir: onsite, online
---

# "customobjectrelation" MDO List
The name of the MDO list is 'customobjectrelation'.




## Sample Request

```http!
GET /api/v1/MDOList/customobjectrelation
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("customobjectrelation", forceFlatList: true);
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

* "customobjectrelationheadings"
* "customobjectrelationheadingswithallitem"
* "customobjectrelationheadingswithallitemwithnoselection"
* "customobjectrelationheadingswithnoselection"
* "customobjectrelationwithallitem"
* "customobjectrelationwithallitemwithnoselection"
* "customobjectrelationwithnoselection"
