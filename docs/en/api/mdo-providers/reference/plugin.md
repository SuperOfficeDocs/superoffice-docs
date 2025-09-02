---
uid: plugin
title: plugin
keywords: mdoprovider mdo provider plugin
description: List of installed and available Document plugins
generated: true
content_type: reference
envir: onsite, online
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
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("plugin", forceFlatList: true);
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
