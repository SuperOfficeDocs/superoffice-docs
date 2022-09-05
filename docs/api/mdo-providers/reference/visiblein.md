---
uid: visiblein
title: visiblein
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "visiblein"
so.generated: true
so.date: 08.26.2022
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
|5|Panel - Company card|||
|10|Panel - Contact card|||
|7|Panel - Project card|||
|9|Panel - Sale card|||
|46|Panel - Selection card|||
|13|Panel - Web panel on SuperOffice button|||
|6|Panel - Company screen section tab|||
|67|Panel - Contact screen section tab|||
|8|Panel - Project screen section tab|||
|29|Panel - Sale screen section tab|||
|11|Dialog - Dialog for follow-ups|||
|12|Dialog - Document dialog|||
|48|Dialog - Quote dialog|||
|52|Dialog - Product dialog|||
|24|Task - Dialog for follow-ups|||
|26|Task - Document dialog|||
|49|Task - Quote dialog|||
|25|Task - Sale dialog|||


## Related MDO Lists

* "visibleinheadings"
* "visibleinheadingswithallitem"
* "visibleinheadingswithallitemwithnoselection"
* "visibleinheadingswithnoselection"
* "visibleinwithallitem"
* "visibleinwithallitemwithnoselection"
* "visibleinwithnoselection"
