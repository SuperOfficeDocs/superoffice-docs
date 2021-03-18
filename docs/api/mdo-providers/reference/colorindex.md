---
uid: colorindex
title: colorindex
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

# "colorindex" MDO List
List of named colors from the "ColorIndex" enum.

Steps to change the palette:
1. Add to the end of the ColorIndex enum (in Modelling)
2. Add to this provider. The color palette in SCIL uses the color code in the styleHint field
3. Update colors in fullcalendar.so.less so that css class colorX has the same color code returned by this list.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ColorIndexProvider">ColorIndexProvider</see> class.
The name of the MDO list is 'colorindex'.




## Sample Request

```http!
GET /api/v1/MDOList/colorindex
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("colorindex", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|8|Color 9|#f5c1ba||
|22|Color 23|#f8a69c||
|23|Color 24|#ff8777||
|24|Color 25|#f67664||
|9|Color 10|#d96554||
|4|Color 5|#a8dbd6||
|16|Color 17|#89cfc8||
|17|Color 18|#5ebdb4||
|18|Color 19|#36aca1||
|5|Color 6|#119c91||
|0|Color 1|#bae7f2||
|10|Color 11|#8cd7e9||
|11|Color 12|#3fbcda||
|12|Color 13|#09aed6||
|1|Color 2|#0097bd||
|6|Color 7|#ffebb7||
|19|Color 20|#ffdd87||
|20|Color 21|#ffc737||
|21|Color 22|#f8b100||
|7|Color 8|#c48b00||
|2|Color 3|#ececec||


## Related MDO Lists

* "colorindexheadings"
* "colorindexheadingswithallitem"
* "colorindexheadingswithallitemwithnoselection"
* "colorindexheadingswithnoselection"
* "colorindexwithallitem"
* "colorindexwithallitemwithnoselection"
* "colorindexwithnoselection"
