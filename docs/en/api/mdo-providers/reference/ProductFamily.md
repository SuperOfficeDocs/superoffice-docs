---
uid: productfamily
title: productfamily
keywords: mdoprovider mdo provider productfamily
description: GenericMDOProvider reads MDO lists with default settings
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "productfamily" MDO List
GenericMDOProvider reads MDO lists with default settings



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericMDOProvider">GenericMDOProvider</see> class.
The name of the MDO list is 'productfamily'.




## Sample Request

```http!
GET /api/v1/MDOList/productfamily
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("productfamily", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|3|Kids wear|||
|1|Mens wear|||
|2|Womens wear|||


## Related MDO Lists

* "productfamilyheadings"
* "productfamilyheadingswithallitem"
* "productfamilyheadingswithallitemwithnoselection"
* "productfamilyheadingswithnoselection"
* "productfamilywithallitem"
* "productfamilywithallitemwithnoselection"
* "productfamilywithnoselection"
