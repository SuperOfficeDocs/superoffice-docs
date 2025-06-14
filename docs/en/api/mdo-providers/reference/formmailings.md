---
uid: formmailings
title: formmailings
keywords: mdoprovider mdo provider formmailings
description: 
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "formmailings" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.FormMailingsProvider">FormMailingsProvider</see> class.
The name of the MDO list is 'formmailings'.




## Sample Request

```http!
GET /api/v1/MDOList/formmailings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("formmailings", forceFlatList: true);
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

* "formmailingsheadings"
* "formmailingsheadingswithallitem"
* "formmailingsheadingswithallitemwithnoselection"
* "formmailingsheadingswithnoselection"
* "formmailingswithallitem"
* "formmailingswithallitemwithnoselection"
* "formmailingswithnoselection"
