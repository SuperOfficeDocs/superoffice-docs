---
uid: targetentitytype
title: targetentitytype
keywords: mdoprovider mdo provider targetentitytype
description: TargetEntities
generated: true
content_type: reference
envir: onsite, online
---

# "targetentitytype" MDO List
TargetEntities



Implemented by the <see cref="T:SuperOffice.CRM.Lists.TargetEntityTypeProvider">TargetEntityTypeProvider</see> class.
The name of the MDO list is 'targetentitytype'.




## Sample Request

```http!
GET /api/v1/MDOList/targetentitytype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("targetentitytype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Sale|||


## Related MDO Lists

* "targetentitytypeheadings"
* "targetentitytypeheadingswithallitem"
* "targetentitytypeheadingswithallitemwithnoselection"
* "targetentitytypeheadingswithnoselection"
* "targetentitytypewithallitem"
* "targetentitytypewithallitemwithnoselection"
* "targetentitytypewithnoselection"
