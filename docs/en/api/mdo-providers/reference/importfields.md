---
uid: importfields
title: importfields
keywords: mdoprovider mdo provider importfields
description: MDO provider for column headers used in import
generated: true
content_type: reference
envir: onsite, online
---

# "importfields" MDO List
MDO provider for column headers used in import



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ImportFieldsProvider">ImportFieldsProvider</see> class.
The name of the MDO list is 'importfields'.




## Sample Request

```http!
GET /api/v1/MDOList/importfields
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("importfields", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|533|Company: companyshorttext||[SR_UDEF_TEXT_SHORT]|
|534|Company: companylongtext||[SR_UDEF_TEXT_LONG]|
|535|Company: companynumber||[SR_UDEF_NUMBER]|
|536|Company: companydate||[SR_UDEF_DATE]|
|537|Company: companyunlimiteddate||[SR_UDEF_UNLIMITEDDATE]|
|538|Company: companycheckbox||[SR_UDEF_CHECKBOX]|
|539|Company: companydropdownlistbox||[SR_UDEF_LIST]|
|540|Company: companydecimal||[SR_UDEF_FLOAT]|
|541|Company: page1saleonly||[SR_UDEF_TEXT_SHORT]|
|542|Company: page1marketingonly||[SR_UDEF_TEXT_SHORT]|
|543|Company: page1adminonly||[SR_UDEF_TEXT_SHORT]|
|544|Company: Udlist one||[SR_UDEF_LIST]|
|545|Company: Udlist two||[SR_UDEF_LIST]|
|0|Company: Business|||
|1|Company: Category|||
|2|Company: Country|||
|3|Company: Department|||
|4|Company: Info|||
|5|Company: Name|||
|6|Company: E-mail||multiple|
|7|Company: Telephone||multiple|


## Related MDO Lists

* "importfieldsheadings"
* "importfieldsheadingswithallitem"
* "importfieldsheadingswithallitemwithnoselection"
* "importfieldsheadingswithnoselection"
* "importfieldswithallitem"
* "importfieldswithallitemwithnoselection"
* "importfieldswithnoselection"
