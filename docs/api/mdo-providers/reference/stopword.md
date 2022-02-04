---
uid: stopword
title: stopword
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "stopword"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "stopword" MDO List
List of stop words. i.e. words which will not be included in the free-text index.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.StopWordProvider">StopWordProvider</see> class.
The name of the MDO list is 'stopword'.




## Sample Request

```http!
GET /api/v1/MDOList/stopword
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("stopword", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|441|SMTP|||
|442|46|||
|443|AND|||
|444|HTTP|||
|445|HTTPS|||
|446|UNIVERSITY|||
|447|ENGINEER|||
|448|CA|||
|449|TX|||
|450|CORP|||
|451|CEDEX|||
|452|OF|||
|453|IN|||
|454|47|||
|455|INC|||
|456|COLLEGE|||
|457|FL|||
|458|33|||
|459|PARK|||
|460|HILL|||
|461|ASSISTANT|||


## Related MDO Lists

* "stopwordheadings"
* "stopwordheadingswithallitem"
* "stopwordheadingswithallitemwithnoselection"
* "stopwordheadingswithnoselection"
* "stopwordwithallitem"
* "stopwordwithallitemwithnoselection"
* "stopwordwithnoselection"
