---
uid: serviceassociate
title: serviceassociate
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "serviceassociate"
so.generated: true
so.date: 19.03.2021
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
|17|Sal0|||
|23|Tje0|||
|24|Tje1|||
|25|Tje2|||
|26|Tje3|||
|27|Tje4|||
|28|Tje5|||


## Related MDO Lists

* "serviceassociateheadings"
* "serviceassociateheadingswithallitem"
* "serviceassociateheadingswithallitemwithnoselection"
* "serviceassociateheadingswithnoselection"
* "serviceassociatewithallitem"
* "serviceassociatewithallitemwithnoselection"
* "serviceassociatewithnoselection"
