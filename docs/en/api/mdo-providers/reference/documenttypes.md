---
uid: documenttypes
title: documenttypes
keywords: mdoprovider mdo provider documenttypes
description: List of document types for the given plugin. ExtraInfo = document plugin-id.
generated: true
content_type: reference
envir: onsite, online
---

# "documenttypes" MDO List
List of document types for the given plugin.
ExtraInfo = document plugin-id.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.DocumentTypesListProvider">DocumentTypesListProvider</see> class.
The name of the MDO list is 'documenttypes'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Document plugin id to get types from| |0|





## Sample Request

```http!
GET /api/v1/MDOList/documenttypes
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("documenttypes", forceFlatList: true);
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

* "documenttypesheadings"
* "documenttypesheadingswithallitem"
* "documenttypesheadingswithallitemwithnoselection"
* "documenttypesheadingswithnoselection"
* "documenttypeswithallitem"
* "documenttypeswithallitemwithnoselection"
* "documenttypeswithnoselection"
