---
uid: producttype
title: producttype
keywords: mdoprovider mdo provider producttype
description: GenericMDOProvider reads MDO lists with default settings
generated: true
content_type: reference
envir: onsite, online
---

# "producttype" MDO List
GenericMDOProvider reads MDO lists with default settings



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericMDOProvider">GenericMDOProvider</see> class.
The name of the MDO list is 'producttype'.




## Sample Request

```http!
GET /api/v1/MDOList/producttype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("producttype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|3|Bags|||
|2|Hats|||
|4|Socks|||
|1|T-Shirts|||


## Related MDO Lists

* "producttypeheadings"
* "producttypeheadingswithallitem"
* "producttypeheadingswithallitemwithnoselection"
* "producttypeheadingswithnoselection"
* "producttypewithallitem"
* "producttypewithallitemwithnoselection"
* "producttypewithnoselection"
