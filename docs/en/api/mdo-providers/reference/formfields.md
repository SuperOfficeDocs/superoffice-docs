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
|21|Company -  Business|||
|61|Company -  companycheckbox||fieldType=company_SuperOffice:6|
|59|Company -  companydate||fieldType=company_SuperOffice:4|
|63|Company -  companydecimal||fieldType=company_SuperOffice:8|
|62|Company -  companydropdownlistbox||fieldType=company_SuperOffice:7&listName=task|
|57|Company -  companylongtext||textLength=40&fieldType=company_SuperOffice:2|
|58|Company -  companynumber||fieldType=company_SuperOffice:3|
|56|Company -  companyshorttext||textLength=20&fieldType=company_SuperOffice:1|
|60|Company -  companyunlimiteddate||fieldType=company_SuperOffice:5|
|53|Company -  Extra boolean||fieldType=company_x_contact_boolean|
|51|Company -  Extra date||fieldType=company_x_contact_date|
|52|Company -  Extra DateTime||fieldType=company_x_contact_datetime|
|47|Company -  Extra Default Integer||fieldType=company_x_contact_default_integer|
|48|Company -  Extra Float||fieldType=company_x_contact_float|
|46|Company -  Extra Integer||fieldType=company_x_contact_integer|
|50|Company -  Extra Long Dropdown||fieldType=company_x_contact_dropdown&listName=company_x_contact_dropdown|
|49|Company -  Extra LongText||fieldType=company_x_contact_longtext|
|55|Company -  Extra short dropdown||fieldType=company_x_contact_short_dropdown&listName=company_x_contact_short_dropdown|
|54|Company -  Extra short text||fieldType=company_x_contact_shorttext|
|66|Company -  page1adminonly||textLength=20&fieldType=company_SuperOffice:11|
|65|Company -  page1marketingonly||textLength=20&fieldType=company_SuperOffice:10|


## Related MDO Lists

* "formfieldsheadings"
* "formfieldsheadingswithallitem"
* "formfieldsheadingswithallitemwithnoselection"
* "formfieldsheadingswithnoselection"
* "formfieldswithallitem"
* "formfieldswithallitemwithnoselection"
* "formfieldswithnoselection"
