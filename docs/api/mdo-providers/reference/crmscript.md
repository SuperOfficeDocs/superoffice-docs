---
uid: crmscript
title: crmscript
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "crmscript"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "crmscript" MDO List
Archive of CRMScripts. Returns script id + name of script as hierarchy.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.CRMScriptProvider">CRMScriptProvider</see> class.
The name of the MDO list is 'crmscript'.




## Sample Request

```http!
GET /api/v1/MDOList/crmscript
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("crmscript", forceFlatList: true);
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

* "crmscriptheadings"
* "crmscriptheadingswithallitem"
* "crmscriptheadingswithallitemwithnoselection"
* "crmscriptheadingswithnoselection"
* "crmscriptwithallitem"
* "crmscriptwithallitemwithnoselection"
* "crmscriptwithnoselection"
