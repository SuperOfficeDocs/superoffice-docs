---
uid: selectionfavourite
title: selectionfavourite
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "selectionfavourite"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "selectionfavourite" MDO List
MDO list provider for Favourites



Implemented by the <see cref="T:SuperOffice.CRM.Lists.SelectionFavouriteListProvider">SelectionFavouriteListProvider</see> class.
The name of the MDO list is 'selectionfavourite'.




## Sample Request

```http!
GET /api/v1/MDOList/selectionfavourite
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("selectionfavourite", forceFlatList: true);
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

* "selectionfavouriteheadings"
* "selectionfavouriteheadingswithallitem"
* "selectionfavouriteheadingswithallitemwithnoselection"
* "selectionfavouriteheadingswithnoselection"
* "selectionfavouritewithallitem"
* "selectionfavouritewithallitemwithnoselection"
* "selectionfavouritewithnoselection"
