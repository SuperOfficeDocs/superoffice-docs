---
uid: kbaccesslevel
title: kbaccesslevel
keywords: mdoprovider mdo provider kbaccesslevel
description: MDO provider for the KbAccessLevel enum
generated: true
content_type: reference
envir: onsite, online
---

# "kbaccesslevel" MDO List
MDO provider for the KbAccessLevel enum



Implemented by the <see cref="T:SuperOffice.CRM.Lists.KbAccessLevelProvider">KbAccessLevelProvider</see> class.
The name of the MDO list is 'kbaccesslevel'.




## Sample Request

```http!
GET /api/v1/MDOList/kbaccesslevel
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("kbaccesslevel", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|[SR_ENUM_KB_ACCESS_PRIVATE]||Private|
|2|[SR_ENUM_KB_ACCESS_INTERNAL]||Internal|
|3|[SR_ENUM_KB_ACCESS_PUBLIC_AUTHENTICATED]||PublicAuthenticated|
|4|[SR_ENUM_KB_ACCESS_PUBLIC]||Public|


## Related MDO Lists

* "kbaccesslevelheadings"
* "kbaccesslevelheadingswithallitem"
* "kbaccesslevelheadingswithallitemwithnoselection"
* "kbaccesslevelheadingswithnoselection"
* "kbaccesslevelwithallitem"
* "kbaccesslevelwithallitemwithnoselection"
* "kbaccesslevelwithnoselection"
