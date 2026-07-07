---
uid: newsfeeditemstatusprovider
title: newsfeeditemstatusprovider
keywords: mdoprovider mdo provider newsfeeditemstatusprovider
description: MDO List provider for news feed item status - Normal, Handling, Handled. Enum value in the extrainfo field.
generated: true
content_type: reference
envir: onsite, online
---

# "newsfeeditemstatusprovider" MDO List
MDO List provider for news feed item status: Normal, Handling, Handled.
Enum value in the extrainfo field.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.NewsFeedItemStatusProvider">NewsFeedItemStatusProvider</see> class.
The name of the MDO list is 'newsfeeditemstatusprovider'.




## Sample Request

```http!
GET /api/v1/MDOList/newsfeeditemstatusprovider
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("newsfeeditemstatusprovider", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|Normal||Normal|
|1|Handling||Handling|
|2|Handled||Handled|


## Related MDO Lists

* "newsfeeditemstatusproviderheadings"
* "newsfeeditemstatusproviderheadingswithallitem"
* "newsfeeditemstatusproviderheadingswithallitemwithnoselection"
* "newsfeeditemstatusproviderheadingswithnoselection"
* "newsfeeditemstatusproviderwithallitem"
* "newsfeeditemstatusproviderwithallitemwithnoselection"
* "newsfeeditemstatusproviderwithnoselection"
