---
uid: htmlmailing
title: htmlmailing
keywords: mdoprovider mdo provider htmlmailing
description: MDO provider for the different types of Mailings
generated: true
content_type: reference
envir: onsite, online
---

# "htmlmailing" MDO List
MDO provider for the different types of Mailings



Implemented by the <see cref="T:SuperOffice.CRM.Lists.HtmlMailingProvider">HtmlMailingProvider</see> class.
The name of the MDO list is 'htmlmailing'.




## Sample Request

```http!
GET /api/v1/MDOList/htmlmailing
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("htmlmailing", forceFlatList: true);
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

* "htmlmailingheadings"
* "htmlmailingheadingswithallitem"
* "htmlmailingheadingswithallitemwithnoselection"
* "htmlmailingheadingswithnoselection"
* "htmlmailingwithallitem"
* "htmlmailingwithallitemwithnoselection"
* "htmlmailingwithnoselection"
