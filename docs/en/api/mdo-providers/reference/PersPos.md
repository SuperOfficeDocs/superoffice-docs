---
uid: perspos
title: perspos
keywords: mdoprovider mdo provider perspos
description: GenericMDOProvider reads MDO lists with default settings
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "perspos" MDO List
GenericMDOProvider reads MDO lists with default settings



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericMDOProvider">GenericMDOProvider</see> class.
The name of the MDO list is 'perspos'.




## Sample Request

```http!
GET /api/v1/MDOList/perspos
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("perspos", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|3|Administrasjon|||
|5|Markedsføring|||
|4|Salg|||
|6|Teknisk person|||
|2|Toppledelse|||
|1|Ukjent|||


## Related MDO Lists

* "persposheadings"
* "persposheadingswithallitem"
* "persposheadingswithallitemwithnoselection"
* "persposheadingswithnoselection"
* "persposwithallitem"
* "persposwithallitemwithnoselection"
* "persposwithnoselection"
