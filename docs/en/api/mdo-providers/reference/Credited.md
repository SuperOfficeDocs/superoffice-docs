---
uid: credited
title: credited
keywords: mdoprovider mdo provider credited
description: GenericMDOProvider reads MDO lists with default settings
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "credited" MDO List
GenericMDOProvider reads MDO lists with default settings



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericMDOProvider">GenericMDOProvider</see> class.
The name of the MDO list is 'credited'.




## Sample Request

```http!
GET /api/v1/MDOList/credited
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("credited", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Prosjekt salg|||
|3|Selger|||
|2|Tjeneste avdeling|||


## Related MDO Lists

* "creditedheadings"
* "creditedheadingswithallitem"
* "creditedheadingswithallitemwithnoselection"
* "creditedheadingswithnoselection"
* "creditedwithallitem"
* "creditedwithallitemwithnoselection"
* "creditedwithnoselection"
