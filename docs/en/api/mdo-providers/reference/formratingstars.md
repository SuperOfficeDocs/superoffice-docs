---
uid: formratingstars
title: formratingstars
keywords: mdoprovider mdo provider formratingstars
description: MDO provider for the Ratings as used in forms
generated: true
content_type: reference
envir: onsite, online
---

# "formratingstars" MDO List
MDO provider for the Ratings as used in forms



Implemented by the <see cref="T:SuperOffice.CRM.Lists.RatingStarsProvider">RatingStarsProvider</see> class.
The name of the MDO list is 'formratingstars'.




## Sample Request

```http!
GET /api/v1/MDOList/formratingstars
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("formratingstars", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|1 Star|||
|1|2 Star|||
|2|3 Star|||
|3|4 Star|||
|4|5 Star|||


## Related MDO Lists

* "formratingstarsheadings"
* "formratingstarsheadingswithallitem"
* "formratingstarsheadingswithallitemwithnoselection"
* "formratingstarsheadingswithnoselection"
* "formratingstarswithallitem"
* "formratingstarswithallitemwithnoselection"
* "formratingstarswithnoselection"
