---
uid: source
title: source
keywords: mdoprovider mdo provider source
description: GenericMDOProvider reads MDO lists with default settings
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "source" MDO List
GenericMDOProvider reads MDO lists with default settings



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericMDOProvider">GenericMDOProvider</see> class.
The name of the MDO list is 'source'.




## Sample Request

```http!
GET /api/v1/MDOList/source
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("source", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Aktivt salg|||
|4|Annbefaling|||
|3|Internet|||
|2|Campaign|||


## Related MDO Lists

* "sourceheadings"
* "sourceheadingswithallitem"
* "sourceheadingswithallitemwithnoselection"
* "sourceheadingswithnoselection"
* "sourcewithallitem"
* "sourcewithallitemwithnoselection"
* "sourcewithnoselection"
