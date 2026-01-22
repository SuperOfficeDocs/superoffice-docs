---
uid: font
title: font
keywords: mdoprovider mdo provider font
description: List provider for availablefonts table.
generated: true
content_type: reference
envir: onsite, online
---

# "font" MDO List
List provider for availablefonts table.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.FontProvider">FontProvider</see> class.
The name of the MDO list is 'font'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Include deleted fonts| showDeleted|true|





## Sample Request

```http!
GET /api/v1/MDOList/font
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("font", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|44|Arial|||
|45|Arial Black|||
|46|Arial Narrow|||
|47|Arvo||/fonts/arvo/arvo.css|
|48|Bodoni|||
|49|Bookman Old Style|||
|50|Bradley Hand ITC|||
|51|Brush Script MT|||
|52|Calibri|||
|53|Century Schoolbook|||
|54|Comic Sans MS|||
|55|Consolas|||
|56|Courier New|||
|57|Crimson Pro||/fonts/crimsonpro/crimsonpro.css|
|58|Edwardian Script|||
|59|Franklin Gothic Book|||
|60|Georgia|||
|61|Gill Sans|||
|62|Impact|||
|63|Inter||/fonts/inter/inter.css|
|64|Lato||/fonts/lato/lato.css|


## Related MDO Lists

* "fontheadings"
* "fontheadingswithallitem"
* "fontheadingswithallitemwithnoselection"
* "fontheadingswithnoselection"
* "fontwithallitem"
* "fontwithallitemwithnoselection"
* "fontwithnoselection"
