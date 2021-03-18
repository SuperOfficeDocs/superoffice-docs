---
uid: saintintention
title: saintintention
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

# "saintintention" MDO List
This SoList provider generates the Intent list for the Saint criteria. This list is an extension of the basic
Intent MDO list, with the addition of an ALL choice with ID 0.



Implemented by the <see cref="T:SuperOffice.CRM.ArchiveLists.SaintIntentionProvider">SaintIntentionProvider</see> class.
The name of the MDO list is 'saintintention'.




## Sample Request

```http!
GET /api/v1/MDOList/saintintention
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("saintintention", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|-1|All|||
|2|Bad|||
|3|Evil|||
|1|Good|||
|5|Goodwill|||
|6|Marketing|||
|4|Sale|||


## Related MDO Lists

* "saintintentionheadings"
* "saintintentionheadingswithallitem"
* "saintintentionheadingswithallitemwithnoselection"
* "saintintentionheadingswithnoselection"
* "saintintentionwithallitem"
* "saintintentionwithallitemwithnoselection"
* "saintintentionwithnoselection"
