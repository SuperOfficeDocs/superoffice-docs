---
uid: visibleinmenu
title: visibleinmenu
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "visibleinmenu"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "visibleinmenu" MDO List
Visible in menu list: Toolbox menu, View menu



Implemented by the <see cref="T:SuperOffice.CRM.Lists.VisibleInMenuProvider">VisibleInMenuProvider</see> class.
The name of the MDO list is 'visibleinmenu'.




## Sample Request

```http!
GET /api/v1/MDOList/visibleinmenu
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("visibleinmenu", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Toolbox menu|||
|3|View menu|||


## Related MDO Lists

* "visibleinmenuheadings"
* "visibleinmenuheadingswithallitem"
* "visibleinmenuheadingswithallitemwithnoselection"
* "visibleinmenuheadingswithnoselection"
* "visibleinmenuwithallitem"
* "visibleinmenuwithallitemwithnoselection"
* "visibleinmenuwithnoselection"
