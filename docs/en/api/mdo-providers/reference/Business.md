---
uid: business
title: business
keywords: mdoprovider mdo provider business
description: GenericMDOProvider reads MDO lists with default settings
generated: true
content_type: reference
envir: onsite, online
---

# "business" MDO List
GenericMDOProvider reads MDO lists with default settings



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericMDOProvider">GenericMDOProvider</see> class.
The name of the MDO list is 'business'.




## Sample Request

```http!
GET /api/v1/MDOList/business
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("business", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Advokater|||
|5|Grafisk|||
|9|Grosister|||
|6|Handel|||
|7|Hotell/Restaurant|||
|8|Industri|||
|4|IT / EDB|||
|10|Offentlig|||
|11|Service|||
|12|Transport|||
|2|Bank/Finance|||
|3|Insurance|||
|13|Other|||


## Related MDO Lists

* "businessheadings"
* "businessheadingswithallitem"
* "businessheadingswithallitemwithnoselection"
* "businessheadingswithnoselection"
* "businesswithallitem"
* "businesswithallitemwithnoselection"
* "businesswithnoselection"
