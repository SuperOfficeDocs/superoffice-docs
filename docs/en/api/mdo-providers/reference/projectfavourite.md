---
uid: projectfavourite
title: projectfavourite
keywords: mdoprovider mdo provider projectfavourite
description: MDO list provider for Favourites
generated: true
content_type: reference
envir: onsite, online
---

# "projectfavourite" MDO List
MDO list provider for Favourites



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ProjectFavouriteListProvider">ProjectFavouriteListProvider</see> class.
The name of the MDO list is 'projectfavourite'.




## Sample Request

```http!
GET /api/v1/MDOList/projectfavourite
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("projectfavourite", forceFlatList: true);
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

* "projectfavouriteheadings"
* "projectfavouriteheadingswithallitem"
* "projectfavouriteheadingswithallitemwithnoselection"
* "projectfavouriteheadingswithnoselection"
* "projectfavouritewithallitem"
* "projectfavouritewithallitemwithnoselection"
* "projectfavouritewithnoselection"
