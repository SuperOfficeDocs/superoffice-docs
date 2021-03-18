---
uid: serviceassociate
title: serviceassociate
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
so.generated: true
so.date: 18.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "serviceassociate" MDO List
MDO provider for associates that are allowed to approve a quote.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ServiceAssociateMDOProvider">ServiceAssociateMDOProvider</see> class.
The name of the MDO list is 'serviceassociate'.




## Sample Request

```http!
GET /api/v1/MDOList/serviceassociate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("serviceassociate", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|106|Adm6|||
|17|Sal0|||
|29|Ser0|||
|30|Ser1|||
|31|Ser2|||
|32|Ser3|||
|33|Ser4|||
|34|Ser5|||
|64|SerNS03 NetServer|||
|23|Tje0|||
|24|Tje1|||
|25|Tje2|||
|26|Tje3|||
|27|Tje4|||
|28|Tje5|||
|99|Tjeneste Sjef|||
|65|TjeNS04 NetServer|||


## Related MDO Lists

* "serviceassociateheadings"
* "serviceassociateheadingswithallitem"
* "serviceassociateheadingswithallitemwithnoselection"
* "serviceassociateheadingswithnoselection"
* "serviceassociatewithallitem"
* "serviceassociatewithallitemwithnoselection"
* "serviceassociatewithnoselection"
