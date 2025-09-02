---
uid: chatservice
title: chatservice
keywords: mdoprovider mdo provider chatservice
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "chatservice" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.ChatServiceProvider">ChatServiceProvider</see> class.
The name of the MDO list is 'chatservice'.




## Sample Request

```http!
GET /api/v1/MDOList/chatservice
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("chatservice", forceFlatList: true);
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

* "chatserviceheadings"
* "chatserviceheadingswithallitem"
* "chatserviceheadingswithallitemwithnoselection"
* "chatserviceheadingswithnoselection"
* "chatservicewithallitem"
* "chatservicewithallitemwithnoselection"
* "chatservicewithnoselection"
