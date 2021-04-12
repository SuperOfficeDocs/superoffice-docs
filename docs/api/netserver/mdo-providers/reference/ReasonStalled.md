---
uid: reasonstalled
title: reasonstalled
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "reasonstalled"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "reasonstalled" MDO List
GenericMDOProvider reads MDO lists with default settings



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericMDOProvider">GenericMDOProvider</see> class.
The name of the MDO list is 'reasonstalled'.




## Sample Request

```http!
GET /api/v1/MDOList/reasonstalled
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("reasonstalled", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|2|Internal politics|||
|5|Internal review process|||
|6|Lack of interest|||
|3|Power sponsor left|||
|4|Power vacuum|||
|1|Price|||


## Related MDO Lists

* "reasonstalledheadings"
* "reasonstalledheadingswithallitem"
* "reasonstalledheadingswithallitemwithnoselection"
* "reasonstalledheadingswithnoselection"
* "reasonstalledwithallitem"
* "reasonstalledwithallitemwithnoselection"
* "reasonstalledwithnoselection"
