---
uid: fonttype
title: fonttype
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

# "fonttype" MDO List
List of font types



Implemented by the <see cref="T:SuperOffice.CRM.Lists.FontTypeProvider">FontTypeProvider</see> class.
The name of the MDO list is 'fonttype'.




## Sample Request

```http!
GET /api/v1/MDOList/fonttype
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("fonttype", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|Arial|||
|15|Arial Black|||
|16|Arial Narrow |||
|9|Bodoni|||
|10|Bookman Old Style |||
|24|Bradley Hand ITC|||
|23|Brush Script MT|||
|13|Calibri|||
|8|Century Schoolbook|||
|1|Comic Sans MS|||
|25|Consolas|||
|2|Courier New|||
|21|Edwardian Script|||
|19|Franklin Gothic Book|||
|3|Georgia|||
|18|Gill Sans|||
|4|Impact|||
|26|Lucida Console|||
|22|Lucida Handwriting|||
|20|Lucida Sans Unicode|||
|27|OCR A Extended|||


## Related MDO Lists

* "fonttypeheadings"
* "fonttypeheadingswithallitem"
* "fonttypeheadingswithallitemwithnoselection"
* "fonttypeheadingswithnoselection"
* "fonttypewithallitem"
* "fonttypewithallitemwithnoselection"
* "fonttypewithnoselection"
