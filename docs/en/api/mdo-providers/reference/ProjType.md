---
uid: projtype
title: projtype
keywords: mdoprovider mdo provider projtype
description: GenericMDOProvider reads MDO lists with default settings
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "projtype" MDO List
GenericMDOProvider reads MDO lists with default settings



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericMDOProvider">GenericMDOProvider</see> class.
The name of the MDO list is 'projtype'.




## Sample Request

```http!
GET /api/v1/MDOList/projtype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("projtype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|3|Annet|||
|1|DM/Kampanje|||
|4|Guided project|||
|2|Internt|||


## Related MDO Lists

* "projtypeheadings"
* "projtypeheadingswithallitem"
* "projtypeheadingswithallitemwithnoselection"
* "projtypeheadingswithnoselection"
* "projtypewithallitem"
* "projtypewithallitemwithnoselection"
* "projtypewithnoselection"
