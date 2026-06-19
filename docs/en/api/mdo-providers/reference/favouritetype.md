---
uid: favouritetype
title: favouritetype
keywords: mdoprovider mdo provider favouritetype
description: MDO list provider for Favourite types
generated: true
content_type: reference
envir: onsite, online
---

# "favouritetype" MDO List
MDO list provider for Favourite types



Implemented by the <see cref="T:SuperOffice.CRM.Lists.FavouriteTypeListProvider">FavouriteTypeListProvider</see> class.
The name of the MDO list is 'favouritetype'.




## Sample Request

```http!
GET /api/v1/MDOList/favouritetype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("favouritetype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|[SR_COMMON_SHOW_ALL]|||
|1|[SR_FAVOURITE_CONTACTPERSONS_ONLY]|||
|3|[SR_FAVOURITE_PROJECTS_ONLY]|||
|4|[SR_FAVOURITE_SELECTIONS_ONLY]|||
|5|[SR_FAVOURITE_ACTIVITIES_ONLY]|||
|9|[SR_FAVOURITE_SALES_ONLY]|||


## Related MDO Lists

* "favouritetypeheadings"
* "favouritetypeheadingswithallitem"
* "favouritetypeheadingswithallitemwithnoselection"
* "favouritetypeheadingswithnoselection"
* "favouritetypewithallitem"
* "favouritetypewithallitemwithnoselection"
* "favouritetypewithnoselection"
