---
uid: categorygroup
title: categorygroup
keywords: mdoprovider mdo provider categorygroup
description: MDO provider for the WorkflowGoalType enum
generated: true
content_type: reference
envir: onsite, online
---

# "categorygroup" MDO List
MDO provider for the WorkflowGoalType enum



Implemented by the <see cref="T:SuperOffice.CRM.Lists.CategoryGroupProvider">CategoryGroupProvider</see> class.
The name of the MDO list is 'categorygroup'.




## Sample Request

```http!
GET /api/v1/MDOList/categorygroup
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("categorygroup", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|(No Selection)|||
|1|Customer|||
|2|Potential Customer|||
|3|Partner|||
|4|Lost|||
|5|Other|||


## Related MDO Lists

* "categorygroupheadings"
* "categorygroupheadingswithallitem"
* "categorygroupheadingswithallitemwithnoselection"
* "categorygroupheadingswithnoselection"
* "categorygroupwithallitem"
* "categorygroupwithallitemwithnoselection"
* "categorygroupwithnoselection"
