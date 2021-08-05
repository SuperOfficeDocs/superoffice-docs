---
uid: selectiontype
title: selectiontype
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "selectiontype"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "selectiontype" MDO List
MDO provider for the hard-coded list of selection kinds: Static, Dynamic, Combined.
Combined requires the Combined Selection CAL license.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.SelectionTypeList">SelectionTypeList</see> class.
The name of the MDO list is 'selectiontype'.




## Sample Request

```http!
GET /api/v1/MDOList/selectiontype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("selectiontype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|Static|||
|1|Dynamic|||
|2|Combined|||


## Related MDO Lists

* "selectiontypeheadings"
* "selectiontypeheadingswithallitem"
* "selectiontypeheadingswithallitemwithnoselection"
* "selectiontypeheadingswithnoselection"
* "selectiontypewithallitem"
* "selectiontypewithallitemwithnoselection"
* "selectiontypewithnoselection"
