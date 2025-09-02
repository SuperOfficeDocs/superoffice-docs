---
uid: formratingdice
title: formratingdice
keywords: mdoprovider mdo provider formratingdice
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "formratingdice" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.RatingDiceProvider">RatingDiceProvider</see> class.
The name of the MDO list is 'formratingdice'.




## Sample Request

```http!
GET /api/v1/MDOList/formratingdice
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("formratingdice", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|Dice 1|||
|1|Dice 2|||
|2|Dice 3|||
|3|Dice 4|||
|4|Dice 5|||
|5|Dice 6|||


## Related MDO Lists

* "formratingdiceheadings"
* "formratingdiceheadingswithallitem"
* "formratingdiceheadingswithallitemwithnoselection"
* "formratingdiceheadingswithnoselection"
* "formratingdicewithallitem"
* "formratingdicewithallitemwithnoselection"
* "formratingdicewithnoselection"
