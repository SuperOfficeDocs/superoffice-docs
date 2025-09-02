---
uid: webpanel
title: webpanel
keywords: mdoprovider mdo provider webpanel
description: List of WebPanels visible possible for use with groups and headings.
generated: true
content_type: reference
envir: onsite, online
---

# "webpanel" MDO List
List of WebPanels visible possible for use with groups and headings.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.WebPanelProvider">WebPanelProvider</see> class.
The name of the MDO list is 'webpanel'.




## Sample Request

```http!
GET /api/v1/MDOList/webpanel
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("webpanel", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|2|Echo||navigation=5&encoding=1&Statusbar=true|


## Related MDO Lists

* "webpanelheadings"
* "webpanelheadingswithallitem"
* "webpanelheadingswithallitemwithnoselection"
* "webpanelheadingswithnoselection"
* "webpanelwithallitem"
* "webpanelwithallitemwithnoselection"
* "webpanelwithnoselection"
