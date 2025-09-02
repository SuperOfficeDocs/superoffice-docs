---
uid: documentmailing
title: documentmailing
keywords: mdoprovider mdo provider documentmailing
description: Document shipments (mail merges).
generated: true
content_type: reference
envir: onsite, online
---

# "documentmailing" MDO List
Document shipments (mail merges).



Implemented by the <see cref="T:SuperOffice.CRM.Lists.DocumentMailingProvider">DocumentMailingProvider</see> class.
The name of the MDO list is 'documentmailing'.




## Sample Request

```http!
GET /api/v1/MDOList/documentmailing
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("documentmailing", forceFlatList: true);
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

* "documentmailingheadings"
* "documentmailingheadingswithallitem"
* "documentmailingheadingswithallitemwithnoselection"
* "documentmailingheadingswithnoselection"
* "documentmailingwithallitem"
* "documentmailingwithallitemwithnoselection"
* "documentmailingwithnoselection"
