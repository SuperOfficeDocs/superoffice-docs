---
uid: fontsize
title: fontsize
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

# "fontsize" MDO List
List of font types



Implemented by the <see cref="T:SuperOffice.CRM.Lists.FontSizeProvider">FontSizeProvider</see> class.
The name of the MDO list is 'fontsize'.




## Sample Request

```http!
GET /api/v1/MDOList/fontsize
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("fontsize", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|8px|||
|1|9px|||
|2|10px|||
|3|11px|||
|4|12px|||
|5|14px|||
|14|16px|||
|6|18px|||
|7|24px|||
|8|30px|||
|9|36px|||
|10|48px|||
|11|60px|||
|12|72px|||
|13|96px|||


## Related MDO Lists

* "fontsizeheadings"
* "fontsizeheadingswithallitem"
* "fontsizeheadingswithallitemwithnoselection"
* "fontsizeheadingswithnoselection"
* "fontsizewithallitem"
* "fontsizewithallitemwithnoselection"
* "fontsizewithnoselection"
