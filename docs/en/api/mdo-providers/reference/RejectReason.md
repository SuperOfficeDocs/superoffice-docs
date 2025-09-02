---
uid: rejectreason
title: rejectreason
keywords: mdoprovider mdo provider rejectreason
description: GenericMDOProvider reads MDO lists with default settings
generated: true
content_type: reference
envir: onsite, online
---

# "rejectreason" MDO List
GenericMDOProvider reads MDO lists with default settings



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericMDOProvider">GenericMDOProvider</see> class.
The name of the MDO list is 'rejectreason'.




## Sample Request

```http!
GET /api/v1/MDOList/rejectreason
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("rejectreason", forceFlatList: true);
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

* "rejectreasonheadings"
* "rejectreasonheadingswithallitem"
* "rejectreasonheadingswithallitemwithnoselection"
* "rejectreasonheadingswithnoselection"
* "rejectreasonwithallitem"
* "rejectreasonwithallitemwithnoselection"
* "rejectreasonwithnoselection"
