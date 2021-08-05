---
uid: udlist28
title: udlist28
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "udlist28"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "udlist28" MDO List
Dynamic MDO provider that will create a list with the name udlist&lt;id&gt; for each user-defined list in the UDListDefinition table.
The actual fetching is done by an inner <see cref="T:SuperOffice.CRM.Lists.UdListMDOProvider" /> for whatever list is implicitly specified by the
id suffix of the dynamic list name



Implemented by the <see cref="T:SuperOffice.CRM.Lists.UdListIndividualProvider">UdListIndividualProvider</see> class.
The name of the MDO list is 'udlist28'.




## Sample Request

```http!
GET /api/v1/MDOList/udlist28
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("udlist28", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|3|UdList one flat item four|||
|1|UdList one flat item one|||
|4|UdList one flat item three|||
|2|UdList one flat item two|||


## Related MDO Lists

* "udlist28headings"
* "udlist28headingswithallitem"
* "udlist28headingswithallitemwithnoselection"
* "udlist28headingswithnoselection"
* "udlist28withallitem"
* "udlist28withallitemwithnoselection"
* "udlist28withnoselection"
