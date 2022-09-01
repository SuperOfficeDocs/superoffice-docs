---
uid: selectionfavourite
title: selectionfavourite
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "selectionfavourite"
so.generated: true
so.date: 08.26.2022
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "selectionfavourite" MDO List
MDO list provider for selection favourites.
Supported additionalInfo:
membertype=[tablename] to restrict to one kind of entities.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.SelectionFavouriteListProvider">SelectionFavouriteListProvider</see> class.
The name of the MDO list is 'selectionfavourite'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Filter according to type of selection members (table name)| membertype|ticket|





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
