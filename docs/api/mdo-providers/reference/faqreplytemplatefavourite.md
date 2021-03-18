---
uid: faqreplytemplatefavourite
title: faqreplytemplatefavourite
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

# "faqreplytemplatefavourite" MDO List
MDO list provider for Favourites



Implemented by the <see cref="T:SuperOffice.CRM.Lists.FaqReplyTemplateFavouriteListProvider">FaqReplyTemplateFavouriteListProvider</see> class.
The name of the MDO list is 'faqreplytemplatefavourite'.




## Sample Request

```http!
GET /api/v1/MDOList/faqreplytemplatefavourite
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("faqreplytemplatefavourite", forceFlatList: true);
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

* "faqreplytemplatefavouriteheadings"
* "faqreplytemplatefavouriteheadingswithallitem"
* "faqreplytemplatefavouriteheadingswithallitemwithnoselection"
* "faqreplytemplatefavouriteheadingswithnoselection"
* "faqreplytemplatefavouritewithallitem"
* "faqreplytemplatefavouritewithallitemwithnoselection"
* "faqreplytemplatefavouritewithnoselection"
