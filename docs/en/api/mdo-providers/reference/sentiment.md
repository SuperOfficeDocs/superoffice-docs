---
uid: sentiment
title: sentiment
keywords: mdoprovider mdo provider sentiment
description: 
generated: true
content_type: reference
envir: onsite, online
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
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("sentiment", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|[SR_TICKET_SENTIMENT_POSITIVE]|||
|2|[SR_TICKET_SENTIMENT_NEGATIVE]|||
|3|[SR_TICKET_SENTIMENT_NEUTRAL]|||
|4|[SR_TICKET_SENTIMENT_UNKNOWN]|||


## Related MDO Lists

* "sentimentheadings"
* "sentimentheadingswithallitem"
* "sentimentheadingswithallitemwithnoselection"
* "sentimentheadingswithnoselection"
* "sentimentwithallitem"
* "sentimentwithallitemwithnoselection"
* "sentimentwithnoselection"
