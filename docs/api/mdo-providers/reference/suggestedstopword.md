---
uid: suggestedstopword
title: suggestedstopword
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

# "suggestedstopword" MDO List
Analyze free text records and suggest stop words based on word frequency.
Return only words with more than 1000 instances.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.SuggestedStopWordProvider">SuggestedStopWordProvider</see> class.
The name of the MDO list is 'suggestedstopword'.




## Sample Request

```http!
GET /api/v1/MDOList/suggestedstopword
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("suggestedstopword", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|TEXT|||
|1|SOME|||
|2|TEST|||


## Related MDO Lists

* "suggestedstopwordheadings"
* "suggestedstopwordheadingswithallitem"
* "suggestedstopwordheadingswithallitemwithnoselection"
* "suggestedstopwordheadingswithnoselection"
* "suggestedstopwordwithallitem"
* "suggestedstopwordwithallitemwithnoselection"
* "suggestedstopwordwithnoselection"
