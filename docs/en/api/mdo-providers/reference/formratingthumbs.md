---
uid: formratingthumbs
title: formratingthumbs
keywords: mdoprovider mdo provider formratingthumbs
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "formratingthumbs" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.RatingThumbsProvider">RatingThumbsProvider</see> class.
The name of the MDO list is 'formratingthumbs'.




## Sample Request

```http!
GET /api/v1/MDOList/formratingthumbs
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("formratingthumbs", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|Thumbs down|||
|1|Thumbs up|||


## Related MDO Lists

* "formratingthumbsheadings"
* "formratingthumbsheadingswithallitem"
* "formratingthumbsheadingswithallitemwithnoselection"
* "formratingthumbsheadingswithnoselection"
* "formratingthumbswithallitem"
* "formratingthumbswithallitemwithnoselection"
* "formratingthumbswithnoselection"
