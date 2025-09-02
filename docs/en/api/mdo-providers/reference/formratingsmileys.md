---
uid: formratingsmileys
title: formratingsmileys
keywords: mdoprovider mdo provider formratingsmileys
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "formratingsmileys" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.RatingSmileysProvider">RatingSmileysProvider</see> class.
The name of the MDO list is 'formratingsmileys'.




## Sample Request

```http!
GET /api/v1/MDOList/formratingsmileys
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("formratingsmileys", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|Sad|||
|1|Neutral|||
|2|Happy|||


## Related MDO Lists

* "formratingsmileysheadings"
* "formratingsmileysheadingswithallitem"
* "formratingsmileysheadingswithallitemwithnoselection"
* "formratingsmileysheadingswithnoselection"
* "formratingsmileyswithallitem"
* "formratingsmileyswithallitemwithnoselection"
* "formratingsmileyswithnoselection"
