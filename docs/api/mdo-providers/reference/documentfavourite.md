---
uid: documentfavourite
title: documentfavourite
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "documentfavourite"
so.generated: true
so.date: 08.26.2022
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "documentfavourite" MDO List
MDO list provider for Favourites



Implemented by the <see cref="T:SuperOffice.CRM.Lists.DocumentFavouriteListProvider">DocumentFavouriteListProvider</see> class.
The name of the MDO list is 'documentfavourite'.




## Sample Request

```http!
GET /api/v1/MDOList/documentfavourite
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("documentfavourite", forceFlatList: true);
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

* "documentfavouriteheadings"
* "documentfavouriteheadingswithallitem"
* "documentfavouriteheadingswithallitemwithnoselection"
* "documentfavouriteheadingswithnoselection"
* "documentfavouritewithallitem"
* "documentfavouritewithallitemwithnoselection"
* "documentfavouritewithnoselection"
