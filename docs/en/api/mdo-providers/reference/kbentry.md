---
uid: kbentry
title: kbentry
keywords: mdoprovider mdo provider kbentry
description: 
generated: true
content_type: reference
envir: onsite, online
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
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("kbentry", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Test FAQ|||


## Related MDO Lists

* "kbentryheadings"
* "kbentryheadingswithallitem"
* "kbentryheadingswithallitemwithnoselection"
* "kbentryheadingswithnoselection"
* "kbentrywithallitem"
* "kbentrywithallitemwithnoselection"
* "kbentrywithnoselection"
