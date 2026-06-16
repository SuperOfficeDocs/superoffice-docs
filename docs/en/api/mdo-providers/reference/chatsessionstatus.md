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
|0|[SR_CHAT_STATUSVAL_0]||Invalid|
|1|[SR_CHAT_STATUSVAL_1]||PreChatForm|
|2|[SR_CHAT_STATUSVAL_2]||Faq|
|3|[SR_CHAT_STATUSVAL_3]||OfflineForm|
|4|[SR_CHAT_STATUSVAL_4]||InQueue|
|5|[SR_CHAT_STATUSVAL_5]||CustomerLast|
|6|[SR_CHAT_STATUSVAL_6]||UserLast|
|7|[SR_CHAT_STATUSVAL_7]||Finished|
|8|[SR_CHAT_STATUSVAL_8]||Deleted|
|9|[SR_CHAT_STATUSVAL_9]||Closed|
|10|[SR_CHAT_STATUSVAL_10]||RequestPosted|
|11|[SR_CHAT_STATUSVAL_11]||ClosedFromQueue|


## Related MDO Lists

* "chatsessionstatusheadings"
* "chatsessionstatusheadingswithallitem"
* "chatsessionstatusheadingswithallitemwithnoselection"
* "chatsessionstatusheadingswithnoselection"
* "chatsessionstatuswithallitem"
* "chatsessionstatuswithallitemwithnoselection"
* "chatsessionstatuswithnoselection"
