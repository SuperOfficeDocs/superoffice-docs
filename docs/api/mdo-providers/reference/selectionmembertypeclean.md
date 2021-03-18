---
uid: selectionmembertypeclean
title: selectionmembertypeclean
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

# "selectionmembertypeclean" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.SelectionMemberTypeClean">SelectionMemberTypeClean</see> class.
The name of the MDO list is 'selectionmembertypeclean'.




## Sample Request

```http!
GET /api/v1/MDOList/selectionmembertypeclean
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("selectionmembertypeclean", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|5|Company/contact||contact|
|6|Company/contact||person|
|9|Follow-ups||appointment|
|13|Sales||sale|
|11|Projects||project|
|23|Selections||selection|
|10|Documents||document|
|127|Products||QuoteLine|
|262|Requests||ticket|


## Related MDO Lists

* "selectionmembertypecleanheadings"
* "selectionmembertypecleanheadingswithallitem"
* "selectionmembertypecleanheadingswithallitemwithnoselection"
* "selectionmembertypecleanheadingswithnoselection"
* "selectionmembertypecleanwithallitem"
* "selectionmembertypecleanwithallitemwithnoselection"
* "selectionmembertypecleanwithnoselection"
