---
uid: selectionuniontype
title: selectionuniontype
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

# "selectionuniontype" MDO List
Different ways to combine selections: Union, Intersect, Disjoin, Left or Right Subtraction.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.SelectionUnionTypeList">SelectionUnionTypeList</see> class.
The name of the MDO list is 'selectionuniontype'.




## Sample Request

```http!
GET /api/v1/MDOList/selectionuniontype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("selectionuniontype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Only in Selection 1|||
|2|Only in Selection 2|||
|3|Common|||
|4|Difference|||
|5|All|||


## Related MDO Lists

* "selectionuniontypeheadings"
* "selectionuniontypeheadingswithallitem"
* "selectionuniontypeheadingswithallitemwithnoselection"
* "selectionuniontypeheadingswithnoselection"
* "selectionuniontypewithallitem"
* "selectionuniontypewithallitemwithnoselection"
* "selectionuniontypewithnoselection"
