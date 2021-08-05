---
uid: tags
title: tags
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "tags"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "tags" MDO List
GenericMDOProvider reads MDO lists with default settings



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericMDOProvider">GenericMDOProvider</see> class.
The name of the MDO list is 'tags'.




## Sample Request

```http!
GET /api/v1/MDOList/tags
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("tags", forceFlatList: true);
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

* "tagsheadings"
* "tagsheadingswithallitem"
* "tagsheadingswithallitemwithnoselection"
* "tagsheadingswithnoselection"
* "tagswithallitem"
* "tagswithallitemwithnoselection"
* "tagswithnoselection"
