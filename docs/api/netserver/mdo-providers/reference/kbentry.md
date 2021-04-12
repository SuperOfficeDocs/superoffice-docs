---
uid: kbentry
title: kbentry
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "kbentry"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "kbentry" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.KbEntryListProvider">KbEntryListProvider</see> class.
The name of the MDO list is 'kbentry'.




## Sample Request

```http!
GET /api/v1/MDOList/kbentry
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("kbentry", forceFlatList: true);
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

* "kbentryheadings"
* "kbentryheadingswithallitem"
* "kbentryheadingswithallitemwithnoselection"
* "kbentryheadingswithnoselection"
* "kbentrywithallitem"
* "kbentrywithallitemwithnoselection"
* "kbentrywithnoselection"
