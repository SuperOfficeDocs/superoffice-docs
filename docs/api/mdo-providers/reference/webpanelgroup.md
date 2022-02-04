---
uid: webpanelgroup
title: webpanelgroup
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "webpanelgroup"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
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
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("webpanelgroup", forceFlatList: true);
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
