---
uid: mailingfavourite
title: mailingfavourite
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "mailingfavourite"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "mailingfavourite" MDO List
MDO list provider for Favourites



Implemented by the <see cref="T:SuperOffice.CRM.Lists.MailingFavouriteListProvider">MailingFavouriteListProvider</see> class.
The name of the MDO list is 'mailingfavourite'.




## Sample Request

```http!
GET /api/v1/MDOList/mailingfavourite
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("mailingfavourite", forceFlatList: true);
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

* "mailingfavouriteheadings"
* "mailingfavouriteheadingswithallitem"
* "mailingfavouriteheadingswithallitemwithnoselection"
* "mailingfavouriteheadingswithnoselection"
* "mailingfavouritewithallitem"
* "mailingfavouritewithallitemwithnoselection"
* "mailingfavouritewithnoselection"
