---
uid: htmlmailing
title: htmlmailing
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
so.generated: true
so.date: 18.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
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
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("htmlmailing", forceFlatList: true);
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
