---
uid: formratingnps
title: formratingnps
keywords: mdoprovider mdo provider formratingnps
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "formratingnps" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.RatingNpsProvider">RatingNpsProvider</see> class.
The name of the MDO list is 'formratingnps'.




## Sample Request

```http!
GET /api/v1/MDOList/formratingnps
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("formratingnps", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|[SR_FORMS_RATING_0_NPS]|||
|1|[SR_FORMS_RATING_1_NPS]|||
|2|[SR_FORMS_RATING_2_NPS]|||
|3|[SR_FORMS_RATING_3_NPS]|||
|4|[SR_FORMS_RATING_4_NPS]|||
|5|[SR_FORMS_RATING_5_NPS]|||
|6|[SR_FORMS_RATING_6_NPS]|||
|7|[SR_FORMS_RATING_7_NPS]|||
|8|[SR_FORMS_RATING_8_NPS]|||
|9|[SR_FORMS_RATING_9_NPS]|||
|10|[SR_FORMS_RATING_10_NPS]|||


## Related MDO Lists

* "formratingnpsheadings"
* "formratingnpsheadingswithallitem"
* "formratingnpsheadingswithallitemwithnoselection"
* "formratingnpsheadingswithnoselection"
* "formratingnpswithallitem"
* "formratingnpswithallitemwithnoselection"
* "formratingnpswithnoselection"
