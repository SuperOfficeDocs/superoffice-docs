---
uid: sentiment
title: sentiment
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "sentiment"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "sentiment" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.SentimentScoreProvider">SentimentScoreProvider</see> class.
The name of the MDO list is 'sentiment'.




## Sample Request

```http!
GET /api/v1/MDOList/sentiment
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("sentiment", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Positive|||
|2|Negative|||
|3|Neutral|||
|4|Unknown|||


## Related MDO Lists

* "sentimentheadings"
* "sentimentheadingswithallitem"
* "sentimentheadingswithallitemwithnoselection"
* "sentimentheadingswithnoselection"
* "sentimentwithallitem"
* "sentimentwithallitemwithnoselection"
* "sentimentwithnoselection"
