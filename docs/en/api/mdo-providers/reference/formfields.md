---
uid: formfields
title: formfields
keywords: mdoprovider mdo provider formfields
description: List of customizable fields for forms
generated: true
content_type: reference
envir: onsite, online
---

# "formfields" MDO List
List of customizable fields for forms



Implemented by the <see cref="T:SuperOffice.CRM.Lists.FormFieldsProvider">FormFieldsProvider</see> class.
The name of the MDO list is 'formfields'.




## Sample Request

```http!
GET /api/v1/MDOList/formfields
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("formfields", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|24|Company - Department|||
|22|Company - Interests|||
|16|Company - Name|||
|17|Company - VAT no.|||
|15|Company - Phone|||
|13|Contact - Consent|||
|11|Contact - Academic title|||
|26|Contact - Birthday |||
|9|Contact - Country|||
|8|Contact - Direct phone|||
|5|Contact - E-mail|||
|2|Contact - First name|||
|23|Contact - Interests |||
|25|Contact - Preferred language|||
|4|Contact - Last name|||
|3|Contact - Middle name|||
|7|Contact - Mobile|||
|10|Contact - Mr/Mrs|||
|1|Contact - Name|||
|12|Contact - Position|||
|6|Contact - Title|||


## Related MDO Lists

* "formfieldsheadings"
* "formfieldsheadingswithallitem"
* "formfieldsheadingswithallitemwithnoselection"
* "formfieldsheadingswithnoselection"
* "formfieldswithallitem"
* "formfieldswithallitemwithnoselection"
* "formfieldswithnoselection"
