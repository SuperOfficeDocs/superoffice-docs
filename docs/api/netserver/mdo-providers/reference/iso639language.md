---
uid: iso639language
title: iso639language
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "iso639language"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "iso639language" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.Iso6391LanguageProvider">Iso6391LanguageProvider</see> class.
The name of the MDO list is 'iso639language'.




## Sample Request

```http!
GET /api/v1/MDOList/iso639language
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("iso639language", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Abkhazian||ab|
|2|Afar||aa|
|3|Afrikaans||af|
|4|Akan||ak|
|5|Albanian||sq|
|6|Amharic||am|
|7|Arabic||ar|
|8|Aragonese||an|
|9|Armenian||hy|
|10|Assamese||as|
|11|Avaric||av|
|12|Avestan||ae|
|13|Aymara||ay|
|14|Azerbaijani||az|
|15|Bambara||bm|
|16|Bashkir||ba|
|17|Basque||eu|
|18|Belarusian||be|
|19|Bengali||bn|
|20|Bihari languages||bh|
|21|Bislama||bi|


## Related MDO Lists

* "iso639languageheadings"
* "iso639languageheadingswithallitem"
* "iso639languageheadingswithallitemwithnoselection"
* "iso639languageheadingswithnoselection"
* "iso639languagewithallitem"
* "iso639languagewithallitemwithnoselection"
* "iso639languagewithnoselection"
