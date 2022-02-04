---
uid: groupview
title: groupview
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "groupview"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "groupview" MDO List
GroupViewMDOProvider uses the AssociateMDOProvider + DiaryView to create the MDOlist for Groupview in Diary view.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.GroupViewMDOProvider">GroupViewMDOProvider</see> class.
The name of the MDO list is 'groupview'.




## Sample Request

```http!
GET /api/v1/MDOList/groupview
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("groupview", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
| 2 | Example | | |


## Related MDO Lists

* "groupviewheadings"
* "groupviewheadingswithallitem"
* "groupviewheadingswithallitemwithnoselection"
* "groupviewheadingswithnoselection"
* "groupviewwithallitem"
* "groupviewwithallitemwithnoselection"
* "groupviewwithnoselection"
