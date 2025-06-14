---
uid: priceunit
title: priceunit
keywords: mdoprovider mdo provider priceunit
description: GenericMDOProvider reads MDO lists with default settings
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "priceunit" MDO List
GenericMDOProvider reads MDO lists with default settings



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericMDOProvider">GenericMDOProvider</see> class.
The name of the MDO list is 'priceunit'.




## Sample Request

```http!
GET /api/v1/MDOList/priceunit
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("priceunit", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|3|FlOz|||
|1|kg|||
|2|Mt|||
|4|τρυβλίον|||


## Related MDO Lists

* "priceunitheadings"
* "priceunitheadingswithallitem"
* "priceunitheadingswithallitemwithnoselection"
* "priceunitheadingswithnoselection"
* "priceunitwithallitem"
* "priceunitwithallitemwithnoselection"
* "priceunitwithnoselection"
