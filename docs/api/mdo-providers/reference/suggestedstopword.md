---
uid: suggestedstopword
title: suggestedstopword
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "suggestedstopword"
so.generated: true
so.date: 19.03.2021
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
|0|SMTP|||
|1|46|||
|2|AND|||
|3|HTTP|||
|4|HTTPS|||
|5|UNIVERSITY|||
|6|ENGINEER|||
|7|CA|||
|8|TX|||
|9|CORP|||
|10|CEDEX|||
|11|OF|||
|12|IN|||
|13|47|||
|14|INC|||
|15|COLLEGE|||
|16|FL|||
|17|33|||
|18|PARK|||
|19|HILL|||
|20|ASSISTANT|||


## Related MDO Lists

* "suggestedstopwordheadings"
* "suggestedstopwordheadingswithallitem"
* "suggestedstopwordheadingswithallitemwithnoselection"
* "suggestedstopwordheadingswithnoselection"
* "suggestedstopwordwithallitem"
* "suggestedstopwordwithallitemwithnoselection"
* "suggestedstopwordwithnoselection"
