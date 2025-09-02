---
uid: saledone
title: saledone
keywords: mdoprovider mdo provider saledone
description: Sale Done status - SaleDone.Done or NotDone.
generated: true
content_type: reference
envir: onsite, online
---

# "saledone" MDO List
Sale Done status: SaleDone.Done or NotDone.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.SaleDoneProvider">SaleDoneProvider</see> class.
The name of the MDO list is 'saledone'.




## Sample Request

```http!
GET /api/v1/MDOList/saledone
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("saledone", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Not done|||
|2|Completed|||


## Related MDO Lists

* "saledoneheadings"
* "saledoneheadingswithallitem"
* "saledoneheadingswithallitemwithnoselection"
* "saledoneheadingswithnoselection"
* "saledonewithallitem"
* "saledonewithallitemwithnoselection"
* "saledonewithnoselection"
