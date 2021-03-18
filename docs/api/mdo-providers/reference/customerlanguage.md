---
uid: customerlanguage
title: customerlanguage
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
so.generated: true
so.date: 18.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "customerlanguage" MDO List
Customer Languages list. From the CustLang table.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.CustLangListProvider">CustLangListProvider</see> class.
The name of the MDO list is 'customerlanguage'.




## Sample Request

```http!
GET /api/v1/MDOList/customerlanguage
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("customerlanguage", forceFlatList: true);
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

* "customerlanguageheadings"
* "customerlanguageheadingswithallitem"
* "customerlanguageheadingswithallitemwithnoselection"
* "customerlanguageheadingswithnoselection"
* "customerlanguagewithallitem"
* "customerlanguagewithallitemwithnoselection"
* "customerlanguagewithnoselection"
