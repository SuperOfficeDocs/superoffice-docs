---
uid: udlist29
title: udlist29
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "udlist29"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "udlist29" MDO List
Dynamic MDO provider that will create a list with the name udlist&lt;id&gt; for each user-defined list in the UDListDefinition table.
The actual fetching is done by an inner <see cref="T:SuperOffice.CRM.Lists.UdListMDOProvider" /> for whatever list is implicitly specified by the
id suffix of the dynamic list name



Implemented by the <see cref="T:SuperOffice.CRM.Lists.UdListIndividualProvider">UdListIndividualProvider</see> class.
The name of the MDO list is 'udlist29'.




## Sample Request

```http!
GET /api/v1/MDOList/udlist29
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("udlist29", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|10|UdList two Heading one item one|||
|11|UdList two Heading one item two|||
|7|UdList two only Administrasjon|||
|8|UdList two Salg and Administrasjon|||


## Related MDO Lists

* "udlist29headings"
* "udlist29headingswithallitem"
* "udlist29headingswithallitemwithnoselection"
* "udlist29headingswithnoselection"
* "udlist29withallitem"
* "udlist29withallitemwithnoselection"
* "udlist29withnoselection"
