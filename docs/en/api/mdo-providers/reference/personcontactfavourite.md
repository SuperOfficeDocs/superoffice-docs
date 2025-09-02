---
uid: personcontactfavourite
title: personcontactfavourite
keywords: mdoprovider mdo provider personcontactfavourite
description: MDO list provider for Favourites
generated: true
content_type: reference
envir: onsite, online
---

# "personcontactfavourite" MDO List
MDO list provider for Favourites



Implemented by the <see cref="T:SuperOffice.CRM.Lists.PersonContactFavouriteListProvider">PersonContactFavouriteListProvider</see> class.
The name of the MDO list is 'personcontactfavourite'.




## Sample Request

```http!
GET /api/v1/MDOList/personcontactfavourite
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("personcontactfavourite", forceFlatList: true);
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

* "personcontactfavouriteheadings"
* "personcontactfavouriteheadingswithallitem"
* "personcontactfavouriteheadingswithallitemwithnoselection"
* "personcontactfavouriteheadingswithnoselection"
* "personcontactfavouritewithallitem"
* "personcontactfavouritewithallitemwithnoselection"
* "personcontactfavouritewithnoselection"
