---
uid: personfavourite
title: personfavourite
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "personfavourite"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "personfavourite" MDO List
MDO list provider for Favourites



Implemented by the <see cref="T:SuperOffice.CRM.Lists.PersonFavouriteListProvider">PersonFavouriteListProvider</see> class.
The name of the MDO list is 'personfavourite'.




## Sample Request

```http!
GET /api/v1/MDOList/personfavourite
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("personfavourite", forceFlatList: true);
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

* "personfavouriteheadings"
* "personfavouriteheadingswithallitem"
* "personfavouriteheadingswithallitemwithnoselection"
* "personfavouriteheadingswithnoselection"
* "personfavouritewithallitem"
* "personfavouritewithallitemwithnoselection"
* "personfavouritewithnoselection"
