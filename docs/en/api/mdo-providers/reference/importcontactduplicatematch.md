---
uid: importcontactduplicatematch
title: importcontactduplicatematch
keywords: mdoprovider mdo provider importcontactduplicatematch
description: List of fields to match contact imports.
generated: true
content_type: reference
envir: onsite, online
---

# "importcontactduplicatematch" MDO List
List of fields to match contact imports.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ImportContactDuplicateMatchProvider">ImportContactDuplicateMatchProvider</see> class.
The name of the MDO list is 'importcontactduplicatematch'.




## Sample Request

```http!
GET /api/v1/MDOList/importcontactduplicatematch
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("importcontactduplicatematch", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Name:|||
|2|Name + Department|||
|3|Number|||
|4|Code|||
|5|VAT number|||
|6|ID|||


## Related MDO Lists

* "importcontactduplicatematchheadings"
* "importcontactduplicatematchheadingswithallitem"
* "importcontactduplicatematchheadingswithallitemwithnoselection"
* "importcontactduplicatematchheadingswithnoselection"
* "importcontactduplicatematchwithallitem"
* "importcontactduplicatematchwithallitemwithnoselection"
* "importcontactduplicatematchwithnoselection"
