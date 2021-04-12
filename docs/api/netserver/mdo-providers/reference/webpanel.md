---
uid: webpanel
title: webpanel
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "webpanel"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
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
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("webpanel", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|2|Echo||navigation=5&encoding=0&Statusbar=true|


## Related MDO Lists

* "webpanelheadings"
* "webpanelheadingswithallitem"
* "webpanelheadingswithallitemwithnoselection"
* "webpanelheadingswithnoselection"
* "webpanelwithallitem"
* "webpanelwithallitemwithnoselection"
* "webpanelwithnoselection"
