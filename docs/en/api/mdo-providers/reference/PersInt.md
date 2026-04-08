---
uid: persint
title: persint
keywords: mdoprovider mdo provider persint
description: GenericMDOProvider reads MDO lists with default settings
generated: true
content_type: reference
envir: onsite, online
---

# "persint" MDO List
GenericMDOProvider reads MDO lists with default settings



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericMDOProvider">GenericMDOProvider</see> class.
The name of the MDO list is 'persint'.




## Sample Request

```http!
GET /api/v1/MDOList/persint
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("persint", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|3|Administrativ kontakt|||
|4|Beslutningstaker|||
|7|Prislister|||
|6|Produkt nyheter|||
|1|Referanse person|||
|5|Salgskontakt|||
|2|Teknisk kontakt|||


## Related MDO Lists

* "persintheadings"
* "persintheadingswithallitem"
* "persintheadingswithallitemwithnoselection"
* "persintheadingswithnoselection"
* "persintwithallitem"
* "persintwithallitemwithnoselection"
* "persintwithnoselection"
