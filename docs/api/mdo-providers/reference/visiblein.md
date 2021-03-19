---
uid: visiblein
title: visiblein
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "visiblein"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "visiblein" MDO List
Visible in list for web panels.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.VisibleInProvider">VisibleInProvider</see> class.
The name of the MDO list is 'visiblein'.




## Sample Request

```http!
GET /api/v1/MDOList/visiblein
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("visiblein", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|19|Side panel|||
|23|Toolbar|||
|2|Navigator button|||
|5|Company card|||
|10|Contact card|||
|7|Project card|||
|9|Sale card|||
|46|Selection card|||
|13|Web panel on SuperOffice button|||
|6|Company screen section tab|||
|67|Contact screen section tab|||
|8|Project screen section tab|||
|29|Sale screen section tab|||
|11|Dialog for follow-ups|||
|12|Document dialog|||
|48|Quote dialog|||
|52|Product dialog|||
|24|Dialog for follow-ups|||
|26|Document dialog|||
|49|Quote dialog|||
|25|Sale dialog|||


## Related MDO Lists

* "visibleinheadings"
* "visibleinheadingswithallitem"
* "visibleinheadingswithallitemwithnoselection"
* "visibleinheadingswithnoselection"
* "visibleinwithallitem"
* "visibleinwithallitemwithnoselection"
* "visibleinwithnoselection"
