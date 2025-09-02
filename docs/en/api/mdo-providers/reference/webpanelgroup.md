---
uid: webpanelgroup
title: webpanelgroup
keywords: mdoprovider mdo provider webpanelgroup
description: List of WebPanels with visible for groups as commaseperated ids in extrainfo field. This list only makes sence if the setting use groups and heading are turned on for
generated: true
content_type: reference
envir: onsite, online
---

# "webpanelgroup" MDO List
List of WebPanels with visible for groups as commaseperated ids in extrainfo field.
This list only makes sence if the setting use groups and heading are turned on for



Implemented by the <see cref="T:SuperOffice.CRM.Lists.WebPanelGroupProvider">WebPanelGroupProvider</see> class.
The name of the MDO list is 'webpanelgroup'.




## Sample Request

```http!
GET /api/v1/MDOList/webpanelgroup
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("webpanelgroup", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|2|Echo||1,2,3,4,5|


## Related MDO Lists

* "webpanelgroupheadings"
* "webpanelgroupheadingswithallitem"
* "webpanelgroupheadingswithallitemwithnoselection"
* "webpanelgroupheadingswithnoselection"
* "webpanelgroupwithallitem"
* "webpanelgroupwithallitemwithnoselection"
* "webpanelgroupwithnoselection"
