---
uid: selectiontype
title: selectiontype
keywords: mdoprovider mdo provider selectiontype
description: MDO provider for the hard-coded list of selection kinds - Static, Dynamic, Combined. Combined requires the Combined Selection CAL license.
generated: true
content_type: reference
envir: onsite, online
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
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("selectiontype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|[SR_SELECTION_STATIC]|||
|1|[SR_SELECTION_DYNAMIC]|||
|2|[SR_SELECTION_UNION]|||


## Related MDO Lists

* "selectiontypeheadings"
* "selectiontypeheadingswithallitem"
* "selectiontypeheadingswithallitemwithnoselection"
* "selectiontypeheadingswithnoselection"
* "selectiontypewithallitem"
* "selectiontypewithallitemwithnoselection"
* "selectiontypewithnoselection"
