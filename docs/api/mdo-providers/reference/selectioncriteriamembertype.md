---
uid: selectioncriteriamembertype
title: selectioncriteriamembertype
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "selectioncriteriamembertype"
so.generated: true
so.date: 08.26.2022
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "selectioncriteriamembertype" MDO List

Implemented by the <see cref="T:SuperOffice.CRM.Lists.SelectionCriteriaMemberType">SelectionCriteriaMemberType</see> class.
The name of the MDO list is 'selectioncriteriamembertype'.

## Sample Request

```http!
GET /api/v1/MDOList/selectioncriteriamembertype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code

```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("selectioncriteriamembertype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|5|Company||contact|
|6|Contact||person|
|9|Follow-up||appointment|
|13|Sale||sale|
|11|Project||project|
|23|Selection||selection|
|10|Document||document|
|127|Product||QuoteLine|
|262|Request||ticket|

## Related MDO Lists

* "selectioncriteriamembertypeheadings"
* "selectioncriteriamembertypeheadingswithallitem"
* "selectioncriteriamembertypeheadingswithallitemwithnoselection"
* "selectioncriteriamembertypeheadingswithnoselection"
* "selectioncriteriamembertypewithallitem"
* "selectioncriteriamembertypewithallitemwithnoselection"
* "selectioncriteriamembertypewithnoselection"
