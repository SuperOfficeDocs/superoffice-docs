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
|21|[SR_COMMON_PREFIX_CONTACT] [SR_LIST_BUSINESS]|||
|61|[SR_COMMON_PREFIX_CONTACT] companycheckbox||fieldType=company_SuperOffice:6|
|59|[SR_COMMON_PREFIX_CONTACT] companydate||fieldType=company_SuperOffice:4|
|63|[SR_COMMON_PREFIX_CONTACT] companydecimal||fieldType=company_SuperOffice:8|
|62|[SR_COMMON_PREFIX_CONTACT] companydropdownlistbox||fieldType=company_SuperOffice:7&listName=task|
|57|[SR_COMMON_PREFIX_CONTACT] companylongtext||textLength=40&fieldType=company_SuperOffice:2|
|58|[SR_COMMON_PREFIX_CONTACT] companynumber||fieldType=company_SuperOffice:3|
|56|[SR_COMMON_PREFIX_CONTACT] companyshorttext||textLength=20&fieldType=company_SuperOffice:1|
|60|[SR_COMMON_PREFIX_CONTACT] companyunlimiteddate||fieldType=company_SuperOffice:5|
|53|[SR_COMMON_PREFIX_CONTACT] Extra boolean||fieldType=company_x_contact_boolean|
|51|[SR_COMMON_PREFIX_CONTACT] Extra date||fieldType=company_x_contact_date|
|52|[SR_COMMON_PREFIX_CONTACT] Extra DateTime||fieldType=company_x_contact_datetime|
|47|[SR_COMMON_PREFIX_CONTACT] Extra Default Integer||fieldType=company_x_contact_default_integer|
|48|[SR_COMMON_PREFIX_CONTACT] Extra Float||fieldType=company_x_contact_float|
|46|[SR_COMMON_PREFIX_CONTACT] Extra Integer||fieldType=company_x_contact_integer|
|50|[SR_COMMON_PREFIX_CONTACT] Extra Long Dropdown||fieldType=company_x_contact_dropdown&listName=company_x_contact_dropdown|
|49|[SR_COMMON_PREFIX_CONTACT] Extra LongText||fieldType=company_x_contact_longtext|
|55|[SR_COMMON_PREFIX_CONTACT] Extra short dropdown||fieldType=company_x_contact_short_dropdown&listName=company_x_contact_short_dropdown|
|54|[SR_COMMON_PREFIX_CONTACT] Extra short text||fieldType=company_x_contact_shorttext|
|66|[SR_COMMON_PREFIX_CONTACT] page1adminonly||textLength=20&fieldType=company_SuperOffice:11|
|65|[SR_COMMON_PREFIX_CONTACT] page1marketingonly||textLength=20&fieldType=company_SuperOffice:10|


## Related MDO Lists

* "formfieldsheadings"
* "formfieldsheadingswithallitem"
* "formfieldsheadingswithallitemwithnoselection"
* "formfieldsheadingswithnoselection"
* "formfieldswithallitem"
* "formfieldswithallitemwithnoselection"
* "formfieldswithnoselection"
