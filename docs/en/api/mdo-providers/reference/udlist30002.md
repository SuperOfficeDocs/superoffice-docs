---
uid: udlist30002
title: udlist30002
keywords: mdoprovider mdo provider udlist30002
description: MDO provider for the ChatService
generated: true
content_type: reference
envir: onsite, online
---

# "udlist30002" MDO List
MDO provider for the ChatService



Implemented by the <see cref="T:SuperOffice.CRM.Lists.udlist30002">udlist30002</see> class.
The name of the MDO list is 'udlist30002'.




## Sample Request

```http!
GET /api/v1/MDOList/udlist30002
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("udlist30002", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|25|AIM|||
|27|GaduGadu|||
|24|Google|||
|22|Microsoft|||
|28|QQ|||
|26|SameTime|||
|23|Yahoo|||


## Related MDO Lists

* "udlist30002headings"
* "udlist30002headingswithallitem"
* "udlist30002headingswithallitemwithnoselection"
* "udlist30002headingswithnoselection"
* "udlist30002withallitem"
* "udlist30002withallitemwithnoselection"
* "udlist30002withnoselection"
