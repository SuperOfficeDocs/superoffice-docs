---
uid: visibleintask
title: visibleintask
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

# "visibleintask" MDO List
Visible in list for tasks: places where task button can appear.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.VisibleInTaskProvider">VisibleInTaskProvider</see> class.
The name of the MDO list is 'visibleintask'.




## Sample Request

```http!
GET /api/v1/MDOList/visibleintask
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("visibleintask", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|14|Company selection|||
|59|Company selection (mailings)|||
|40|Company selection (external)|||
|16|Sale selection (Sales)|||
|31|Sale selection (Companies)|||
|61|Sale selection (mailings)|||
|42|Sale selection (external)|||
|18|Project selection (Projects)|||
|33|Project selection (Companies)|||
|63|Project selection (mailings)|||
|44|Project selection (external)|||
|15|Follow-up selection (Follow-ups)|||
|30|Follow-up selection  (Companies)|||
|60|Follow-up selection (mailings)|||
|41|Follow-up selection (external)|||
|17|Document selection (Documents)|||
|32|Document selection (Companies)|||
|62|Document selection (mailings)|||
|43|Document selection (external)|||
|53|Product selection (products)|||
|54|Product selection (companies)|||


## Related MDO Lists

* "visibleintaskheadings"
* "visibleintaskheadingswithallitem"
* "visibleintaskheadingswithallitemwithnoselection"
* "visibleintaskheadingswithnoselection"
* "visibleintaskwithallitem"
* "visibleintaskwithallitemwithnoselection"
* "visibleintaskwithnoselection"
