---
uid: saletype
title: saletype
keywords: mdoprovider mdo provider saletype
description: List of sale types, with default sale duration in minutes in extra info.
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "saletype" MDO List
List of sale types, with default sale duration in minutes in extra info.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.SaleTypeProvider">SaleTypeProvider</see> class.
The name of the MDO list is 'saletype'.




## Sample Request

```http!
GET /api/v1/MDOList/saletype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("saletype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|General sale||43200|
|4|Staged Sale||43200|
|3|Stakeholders||132480|
|2|Guided Sale||43200|


## Related MDO Lists

* "saletypeheadings"
* "saletypeheadingswithallitem"
* "saletypeheadingswithallitemwithnoselection"
* "saletypeheadingswithnoselection"
* "saletypewithallitem"
* "saletypewithallitemwithnoselection"
* "saletypewithnoselection"
