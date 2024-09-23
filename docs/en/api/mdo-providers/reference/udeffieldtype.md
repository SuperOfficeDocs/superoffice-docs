---
uid: udeffieldtype
title: udeffieldtype
keywords: mdoprovider mdo provider udeffieldtype
description: List of UDef field types for a given owner table, and possibly restricted based on the current field type
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "udeffieldtype" MDO List
List of UDef field types for a given owner table, and possibly restricted based on the current field type

ExtraInfo = "UDefType,UDefFieldType,hasBeenPublished"


For example: "Contact"



"Contact,Number,true"




Implemented by the <see cref="T:SuperOffice.CRM.Lists.UdefFieldTypeProvider">UdefFieldTypeProvider</see> class.
The name of the MDO list is 'udeffieldtype'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|UDefType,UDefFieldType,hasBeenPublished| |Contact,Number,true|

Separator: ,





## Sample Request

```http!
GET /api/v1/MDOList/udeffieldtype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("udeffieldtype", forceFlatList: true);
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

* "udeffieldtypeheadings"
* "udeffieldtypeheadingswithallitem"
* "udeffieldtypeheadingswithallitemwithnoselection"
* "udeffieldtypeheadingswithnoselection"
* "udeffieldtypewithallitem"
* "udeffieldtypewithallitemwithnoselection"
* "udeffieldtypewithnoselection"
