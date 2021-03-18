---
uid: stakeholderrole
title: stakeholderrole
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

# "stakeholderrole" MDO List
GenericMDOProvider reads MDO lists with default settings



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericMDOProvider">GenericMDOProvider</see> class.
The name of the MDO list is 'stakeholderrole'.




## Sample Request

```http!
GET /api/v1/MDOList/stakeholderrole
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("stakeholderrole", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Decision maker|||


## Related MDO Lists

* "stakeholderroleheadings"
* "stakeholderroleheadingswithallitem"
* "stakeholderroleheadingswithallitemwithnoselection"
* "stakeholderroleheadingswithnoselection"
* "stakeholderrolewithallitem"
* "stakeholderrolewithallitemwithnoselection"
* "stakeholderrolewithnoselection"
