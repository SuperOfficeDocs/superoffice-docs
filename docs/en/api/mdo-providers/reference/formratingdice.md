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
|0|[SR_FORMS_RATING_1_DICE]|||
|1|[SR_FORMS_RATING_2_DICE]|||
|2|[SR_FORMS_RATING_3_DICE]|||
|3|[SR_FORMS_RATING_4_DICE]|||
|4|[SR_FORMS_RATING_5_DICE]|||
|5|[SR_FORMS_RATING_6_DICE]|||


## Related MDO Lists

* "formratingdiceheadings"
* "formratingdiceheadingswithallitem"
* "formratingdiceheadingswithallitemwithnoselection"
* "formratingdiceheadingswithnoselection"
* "formratingdicewithallitem"
* "formratingdicewithallitemwithnoselection"
* "formratingdicewithnoselection"
