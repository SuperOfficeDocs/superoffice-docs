---
uid: language
title: language
keywords: mdoprovider mdo provider language
description: 
generated: true
content_type: reference
envir: onsite, online
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
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("language", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|[SR_NORWEGIAN]||no|
|2|[SR_ENGLISH]||en|
|3|[SR_SWEDISH]||sv|
|4|[SR_DANISH]||da|
|5|[SR_GERMAN]||de|
|6|[SR_DUTCH]||nl|
|7|[SR_CZECH]||cs|
|8|[SR_FRENCH]||fr|
|9|[SR_ITALIAN]||it|
|10|[SR_SPANISH]||es|
|11|[SR_FINNISH]||fi|
|12|[SR_POLISH]||pl|
|13|[SR_RUSSIAN]||ru|
|14|[SR_CHINESE]||zh|
|15|[SR_UKRAINIAN]||uk|
|16|[SR_KOREAN]||ko|
|17|[SR_PORTOGUESEBRAZILIAN]||br|
|18|[SR_VIETNAMESE]||vi|
|19|[SR_SWISSGERMAN]||ch|


## Related MDO Lists

* "languageheadings"
* "languageheadingswithallitem"
* "languageheadingswithallitemwithnoselection"
* "languageheadingswithnoselection"
* "languagewithallitem"
* "languagewithallitemwithnoselection"
* "languagewithnoselection"
