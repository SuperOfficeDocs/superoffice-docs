---
uid: intent
title: intent
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "intent"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "intent" MDO List

GenericMDOProvider reads MDO lists with default settings

Implemented by the <see cref="T:SuperOffice.CRM.Lists.GenericMDOProvider">GenericMDOProvider</see> class.
The name of the MDO list is 'intent'.

## Sample Request

```http!
GET /api/v1/MDOList/intent
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code

```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("intent", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|2|Bad|||
|3|Evil|||
|1|Good|||
|5|Goodwill|||
|6|Marketing|||
|4|Sale|||

## Related MDO Lists

* "intentheadings"
* "intentheadingswithallitem"
* "intentheadingswithallitemwithnoselection"
* "intentheadingswithnoselection"
* "intentwithallitem"
* "intentwithallitemwithnoselection"
* "intentwithnoselection"
