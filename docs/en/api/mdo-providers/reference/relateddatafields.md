---
uid: relateddatafields
title: relateddatafields
keywords: mdoprovider mdo provider relateddatafields
description: 
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "relateddatafields" MDO List
The name of the MDO list is 'relateddatafields'.




## Sample Request

```http!
GET /api/v1/MDOList/relateddatafields
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("relateddatafields", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
| 2 | Example | | |

