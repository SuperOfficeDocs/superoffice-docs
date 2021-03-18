---
uid: language
title: language
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

# "language" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.LanguageProvider">LanguageProvider</see> class.
The name of the MDO list is 'language'.




## Sample Request

```http!
GET /api/v1/MDOList/language
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("language", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Norwegian||no|
|2|English||en|
|3|Swedish||sv|
|4|Danish||da|
|5|German||de|
|6|Dutch||nl|
|7|Czech||cs|
|8|French||fr|
|9|Italian||it|
|10|Spanish||es|
|11|Finnish||fi|
|12|Polish||pl|
|13|Russian||ru|


## Related MDO Lists

* "languageheadings"
* "languageheadingswithallitem"
* "languageheadingswithallitemwithnoselection"
* "languageheadingswithnoselection"
* "languagewithallitem"
* "languagewithallitemwithnoselection"
* "languagewithnoselection"
