---
uid: culturesolanguage
title: culturesolanguage
keywords: mdoprovider mdo provider culturesolanguage
description: List of SuperOffice cultures with old-style SO Culture name in ExtraInfo. ( 1031, "German","GE" )
generated: true
content_type: reference
envir: onsite, online
---

# "culturesolanguage" MDO List
List of SuperOffice cultures with old-style SO Culture name in ExtraInfo.
( 1031, "German","GE" )



Implemented by the <see cref="T:SuperOffice.CRM.Lists.CultureSoLanguageProvider">CultureSoLanguageProvider</see> class.
The name of the MDO list is 'culturesolanguage'.




## Sample Request

```http!
GET /api/v1/MDOList/culturesolanguage
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("culturesolanguage", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|2052|Chinese ||CN|
|1029|Czech ||CZ|
|1030|Danish ||DA|
|1043|Dutch ||NL|
|1033|English ||US|
|1035|Finnish ||FI|
|1036|French ||FR|
|1031|German ||GE|
|2055|German ||CH|
|1040|Italian ||IT|
|1041|Japanese ||JP|
|1042|Korean ||KO|
|1044|Norwegian, Bokmål ||NO|
|1045|Polish ||PL|
|1046|Portuguese ||BR|
|1049|Russian ||RU|
|1034|Spanish ||SP|
|1053|Swedish ||SW|
|1058|Ukrainian ||UK|
|1066|Vietnamese ||VI|


## Related MDO Lists

* "culturesolanguageheadings"
* "culturesolanguageheadingswithallitem"
* "culturesolanguageheadingswithallitemwithnoselection"
* "culturesolanguageheadingswithnoselection"
* "culturesolanguagewithallitem"
* "culturesolanguagewithallitemwithnoselection"
* "culturesolanguagewithnoselection"
