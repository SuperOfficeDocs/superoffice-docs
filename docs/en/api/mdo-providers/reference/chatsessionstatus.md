---
uid: chatsessionstatus
title: chatsessionstatus
keywords: mdoprovider mdo provider chatsessionstatus
description: Chat session status values
generated: true
content_type: reference
envir: onsite, online
---

# "chatsessionstatus" MDO List
Chat session status values



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ChatSessionStatusProvider">ChatSessionStatusProvider</see> class.
The name of the MDO list is 'chatsessionstatus'.




## Sample Request

```http!
GET /api/v1/MDOList/chatsessionstatus
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("chatsessionstatus", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|Invalid||Invalid|
|1|Pre-chat form||PreChatForm|
|2|FAQ link||Faq|
|3|Offline form||OfflineForm|
|4|Waiting||InQueue|
|5|Waiting for agent||CustomerLast|
|6|Waiting for customer||UserLast|
|7|Finished||Finished|
|8|Deleted||Deleted|
|9|Closed||Closed|
|10|Request posted||RequestPosted|
|11|Closed in queue||ClosedFromQueue|


## Related MDO Lists

* "chatsessionstatusheadings"
* "chatsessionstatusheadingswithallitem"
* "chatsessionstatusheadingswithallitemwithnoselection"
* "chatsessionstatusheadingswithnoselection"
* "chatsessionstatuswithallitem"
* "chatsessionstatuswithallitemwithnoselection"
* "chatsessionstatuswithnoselection"
