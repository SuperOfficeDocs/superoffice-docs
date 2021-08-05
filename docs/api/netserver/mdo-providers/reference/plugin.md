---
uid: plugin
title: plugin
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "plugin"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "plugin" MDO List
List of installed and available Document plugins



Implemented by the <see cref="T:SuperOffice.CRM.Lists.PluginProvider">PluginProvider</see> class.
The name of the MDO list is 'plugin'.




## Sample Request

```http!
GET /api/v1/MDOList/plugin
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("plugin", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|SO Archive|||


## Related MDO Lists

* "pluginheadings"
* "pluginheadingswithallitem"
* "pluginheadingswithallitemwithnoselection"
* "pluginheadingswithnoselection"
* "pluginwithallitem"
* "pluginwithallitemwithnoselection"
* "pluginwithnoselection"
