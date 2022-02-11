---
uid: chatbot
title: chatbot
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "chatbot"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "chatbot" MDO List
List of all script folders that contain a script named like "%bot%register%".
Returns script id + folder name as flat list.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ChatbotProvider">ChatbotProvider</see> class.
The name of the MDO list is 'chatbot'.




## Sample Request

```http!
GET /api/v1/MDOList/chatbot
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("chatbot", forceFlatList: true);
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

* "chatbotheadings"
* "chatbotheadingswithallitem"
* "chatbotheadingswithallitemwithnoselection"
* "chatbotheadingswithnoselection"
* "chatbotwithallitem"
* "chatbotwithallitemwithnoselection"
* "chatbotwithnoselection"
