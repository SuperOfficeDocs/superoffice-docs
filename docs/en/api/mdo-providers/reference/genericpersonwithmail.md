---
uid: genericpersonwithmail
title: genericpersonwithmail
keywords: mdoprovider mdo provider genericpersonwithmail
description: List of persons with mail. Supports Selection(any type), project and associate. Uses an inner provider <see cref="T:SuperOffice.CRM.Lists.PersonWithMailListProvider" />.
generated: true
content_type: reference
envir: onsite, online
---

# "genericpersonwithmail" MDO List
List of persons with mail. Supports Selection(any type), project and associate.
Uses an inner provider <see cref="T:SuperOffice.CRM.Lists.PersonWithMailListProvider" />.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericPersonWithMailListProvider">GenericPersonWithMailListProvider</see> class.
The name of the MDO list is 'genericpersonwithmail'.




## Sample Request

```http!
GET /api/v1/MDOList/genericpersonwithmail
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("genericpersonwithmail", forceFlatList: true);
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

* "genericpersonwithmailheadings"
* "genericpersonwithmailheadingswithallitem"
* "genericpersonwithmailheadingswithallitemwithnoselection"
* "genericpersonwithmailheadingswithnoselection"
* "genericpersonwithmailwithallitem"
* "genericpersonwithmailwithallitemwithnoselection"
* "genericpersonwithmailwithnoselection"
