---
uid: favouritetype
title: favouritetype
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "favouritetype"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
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
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("favouritetype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|Show all|||
|1|Companies/Contacts only|||
|3|Projects only|||
|4|Selections only|||
|5|Activities only|||
|9|Sales only|||


## Related MDO Lists

* "favouritetypeheadings"
* "favouritetypeheadingswithallitem"
* "favouritetypeheadingswithallitemwithnoselection"
* "favouritetypeheadingswithnoselection"
* "favouritetypewithallitem"
* "favouritetypewithallitemwithnoselection"
* "favouritetypewithnoselection"
