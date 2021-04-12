---
uid: culture
title: culture
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "culture"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "culture" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.CultureProvider">CultureProvider</see> class.
The name of the MDO list is 'culture'.




## Sample Request

```http!
GET /api/v1/MDOList/culture
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("culture", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|2052|Chinese ||zh-cn|
|1029|Czech ||cs|
|1030|Danish ||da|
|1043|Dutch ||nl|
|1033|English ||en|
|1035|Finnish ||fi|
|1036|French ||fr|
|1031|German ||de|
|1040|Italian ||it|
|1041|Japanese ||ja|
|1044|Norwegian, Bokmål ||no|
|1045|Polish ||pl|
|1049|Russian ||ru|
|1034|Spanish ||es|
|1053|Swedish ||sv|
|1058|Ukrainian ||uk|


## Related MDO Lists

* "cultureheadings"
* "cultureheadingswithallitem"
* "cultureheadingswithallitemwithnoselection"
* "cultureheadingswithnoselection"
* "culturewithallitem"
* "culturewithallitemwithnoselection"
* "culturewithnoselection"
