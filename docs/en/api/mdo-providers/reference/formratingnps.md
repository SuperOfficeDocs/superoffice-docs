---
uid: formratingnps
title: formratingnps
keywords: mdoprovider mdo provider formratingnps
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "formratingnps" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.RatingNpsProvider">RatingNpsProvider</see> class.
The name of the MDO list is 'formratingnps'.




## Sample Request

```http!
GET /api/v1/MDOList/formratingnps
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("formratingnps", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|NPS score 0|||
|1|NPS score 1|||
|2|NPS score 2|||
|3|NPS score 3|||
|4|NPS score 4|||
|5|NPS score 5|||
|6|NPS score 6|||
|7|NPS score 7|||
|8|NPS score 8|||
|9|NPS score 9|||
|10|NPS score 10|||


## Related MDO Lists

* "formratingnpsheadings"
* "formratingnpsheadingswithallitem"
* "formratingnpsheadingswithallitemwithnoselection"
* "formratingnpsheadingswithnoselection"
* "formratingnpswithallitem"
* "formratingnpswithallitemwithnoselection"
* "formratingnpswithnoselection"
