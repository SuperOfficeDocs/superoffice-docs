---
uid: projectmemberwithmail
title: projectmemberwithmail
keywords: mdoprovider mdo provider projectmemberwithmail
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "projectmemberwithmail" MDO List
The name of the MDO list is 'projectmemberwithmail'.




## Sample Request

```http!
GET /api/v1/MDOList/projectmemberwithmail
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("projectmemberwithmail", forceFlatList: true);
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

* "projectmemberwithmailheadings"
* "projectmemberwithmailheadingswithallitem"
* "projectmemberwithmailheadingswithallitemwithnoselection"
* "projectmemberwithmailheadingswithnoselection"
* "projectmemberwithmailwithallitem"
* "projectmemberwithmailwithallitemwithnoselection"
* "projectmemberwithmailwithnoselection"
