---
uid: activelanguage
title: activelanguage
keywords: mdoprovider mdo provider activelanguage
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "activelanguage" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.ActiveLanguageProvider">ActiveLanguageProvider</see> class.
The name of the MDO list is 'activelanguage'.




## Sample Request

```http!
GET /api/v1/MDOList/activelanguage
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("activelanguage", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1029|Čeština |||
|1030|Dansk |||
|1031|Deutsch |||
|2055|Deutsch (Schweiz)|||
|1033|English |||
|1034|Español |||
|1036|Français |||
|1040|Italiano |||
|1043|Nederlands |||
|1044|Norsk bokmål |||
|1045|Polski |||
|1046|Português (Brasil)|||
|1035|Suomi |||
|1053|Svenska |||
|1066|Tiếng Việt |||
|1049|Русский |||
|1058|Українська |||
|1042|한국어|||
|2052|中文|||
|1041|日本語 |||


## Related MDO Lists

* "activelanguageheadings"
* "activelanguageheadingswithallitem"
* "activelanguageheadingswithallitemwithnoselection"
* "activelanguageheadingswithnoselection"
* "activelanguagewithallitem"
* "activelanguagewithallitemwithnoselection"
* "activelanguagewithnoselection"
