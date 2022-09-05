---
uid: contactfavourite
title: contactfavourite
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "contactfavourite"
so.generated: true
so.date: 08.26.2022
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "contactfavourite" MDO List
MDO list provider for Favourites



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ContactFavouriteListProvider">ContactFavouriteListProvider</see> class.
The name of the MDO list is 'contactfavourite'.




## Sample Request

```http!
GET /api/v1/MDOList/contactfavourite
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("contactfavourite", forceFlatList: true);
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

* "contactfavouriteheadings"
* "contactfavouriteheadingswithallitem"
* "contactfavouriteheadingswithallitemwithnoselection"
* "contactfavouriteheadingswithnoselection"
* "contactfavouritewithallitem"
* "contactfavouritewithallitemwithnoselection"
* "contactfavouritewithnoselection"
