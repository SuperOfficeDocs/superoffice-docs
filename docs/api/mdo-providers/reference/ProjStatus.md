---
uid: projstatus
title: projstatus
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "projstatus"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "projstatus" MDO List
GenericMDOProvider reads MDO lists with default settings



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericMDOProvider">GenericMDOProvider</see> class.
The name of the MDO list is 'projstatus'.




## Sample Request

```http!
GET /api/v1/MDOList/projstatus
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("projstatus", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|3|Avsluttet|||
|7|Completion|||
|6|Implementation|||
|1|Planlagt|||
|5|Project planning|||
|4|Stoppet|||
|2|Under arbeid|||


## Related MDO Lists

* "projstatusheadings"
* "projstatusheadingswithallitem"
* "projstatusheadingswithallitemwithnoselection"
* "projstatusheadingswithnoselection"
* "projstatuswithallitem"
* "projstatuswithallitemwithnoselection"
* "projstatuswithnoselection"
