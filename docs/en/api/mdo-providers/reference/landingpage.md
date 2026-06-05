---
uid: landingpage
title: landingpage
keywords: mdoprovider mdo provider landingpage
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "landingpage" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.LandingpageProvider">LandingpageProvider</see> class.
The name of the MDO list is 'landingpage'.




## Sample Request

```http!
GET /api/v1/MDOList/landingpage
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("landingpage", forceFlatList: true);
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

* "landingpageheadings"
* "landingpageheadingswithallitem"
* "landingpageheadingswithallitemwithnoselection"
* "landingpageheadingswithnoselection"
* "landingpagewithallitem"
* "landingpagewithallitemwithnoselection"
* "landingpagewithnoselection"
