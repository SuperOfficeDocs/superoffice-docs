---
uid: nextavailabletime
title: nextavailabletime
keywords: mdoprovider mdo provider nextavailabletime
description: 
generated: true
topic: reference
envir: onsite, online
---

# "nextavailabletime" MDO List
The name of the MDO list is 'nextavailabletime'.




## Sample Request

```http!
GET /api/v1/MDOList/nextavailabletime
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("nextavailabletime", forceFlatList: true);
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

* "nextavailabletimeheadings"
* "nextavailabletimeheadingswithallitem"
* "nextavailabletimeheadingswithallitemwithnoselection"
* "nextavailabletimeheadingswithnoselection"
* "nextavailabletimewithallitem"
* "nextavailabletimewithallitemwithnoselection"
* "nextavailabletimewithnoselection"
