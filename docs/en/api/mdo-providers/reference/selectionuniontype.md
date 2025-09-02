---
uid: selectionuniontype
title: selectionuniontype
keywords: mdoprovider mdo provider selectionuniontype
description: Different ways to combine selections - Union, Intersect, Disjoin, Left or Right Subtraction.
generated: true
content_type: reference
envir: onsite, online
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
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("selectionuniontype", forceFlatList: true);
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
