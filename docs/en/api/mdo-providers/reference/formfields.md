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
|56|Company -  companycheckbox||fieldType=company_SuperOffice:6|
|54|Company -  companydate||fieldType=company_SuperOffice:4|
|58|Company -  companydecimal||fieldType=company_SuperOffice:8|
|57|Company -  companydropdownlistbox||fieldType=company_SuperOffice:7&listName=task|
|52|Company -  companylongtext||textLength=40&fieldType=company_SuperOffice:2|
|53|Company -  companynumber||fieldType=company_SuperOffice:3|
|51|Company -  companyshorttext||textLength=20&fieldType=company_SuperOffice:1|
|55|Company -  companyunlimiteddate||fieldType=company_SuperOffice:5|
|49|Company -  Extra boolean||fieldType=company_x_contact_boolean|
|47|Company -  Extra date||fieldType=company_x_contact_date|
|48|Company -  Extra DateTime||fieldType=company_x_contact_datetime|
|44|Company -  Extra Default Integer||fieldType=company_x_contact_default_integer|
|45|Company -  Extra Float||fieldType=company_x_contact_float|
|43|Company -  Extra Integer||fieldType=company_x_contact_integer|
|46|Company -  Extra LongText||fieldType=company_x_contact_longtext|
|50|Company -  Extra short text||fieldType=company_x_contact_shorttext|
|61|Company -  page1adminonly||textLength=20&fieldType=company_SuperOffice:11|
|60|Company -  page1marketingonly||textLength=20&fieldType=company_SuperOffice:10|
|59|Company -  page1saleonly||textLength=20&fieldType=company_SuperOffice:9|
|62|Company -  Udlist one||fieldType=company_SuperOffice:12&listName=udlist_28|


## Related MDO Lists

* "formfieldsheadings"
* "formfieldsheadingswithallitem"
* "formfieldsheadingswithallitemwithnoselection"
* "formfieldsheadingswithnoselection"
* "formfieldswithallitem"
* "formfieldswithallitemwithnoselection"
* "formfieldswithnoselection"
