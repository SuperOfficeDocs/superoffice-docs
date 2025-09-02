---
uid: udeffieldtype
title: udeffieldtype
keywords: mdoprovider mdo provider udeffieldtype
description: List of UDef field types for a given owner table, and possibly restricted based on the current field type
generated: true
content_type: reference
envir: onsite, online
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
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("udeffieldtype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Number|||
|2|Short text|||
|3|Long text|||
|4|Date|||
|5|Unlimited date|||
|6|Checkbox|||
|7|List|||
|8|Decimal|||


## Related MDO Lists

* "udeffieldtypeheadings"
* "udeffieldtypeheadingswithallitem"
* "udeffieldtypeheadingswithallitemwithnoselection"
* "udeffieldtypeheadingswithnoselection"
* "udeffieldtypewithallitem"
* "udeffieldtypewithallitemwithnoselection"
* "udeffieldtypewithnoselection"
