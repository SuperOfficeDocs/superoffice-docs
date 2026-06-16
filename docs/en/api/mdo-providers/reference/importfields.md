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
|520|[SR_SINGULAR_COMPANY]: companyshorttext||[SR_UDEF_TEXT_SHORT]|
|521|[SR_SINGULAR_COMPANY]: companylongtext||[SR_UDEF_TEXT_LONG]|
|522|[SR_SINGULAR_COMPANY]: companynumber||[SR_UDEF_NUMBER]|
|523|[SR_SINGULAR_COMPANY]: companydate||[SR_UDEF_DATE]|
|524|[SR_SINGULAR_COMPANY]: companyunlimiteddate||[SR_UDEF_UNLIMITEDDATE]|
|525|[SR_SINGULAR_COMPANY]: companycheckbox||[SR_UDEF_CHECKBOX]|
|526|[SR_SINGULAR_COMPANY]: companydropdownlistbox||[SR_UDEF_LIST]|
|527|[SR_SINGULAR_COMPANY]: companydecimal||[SR_UDEF_FLOAT]|
|528|[SR_SINGULAR_COMPANY]: page1saleonly||[SR_UDEF_TEXT_SHORT]|
|529|[SR_SINGULAR_COMPANY]: page1marketingonly||[SR_UDEF_TEXT_SHORT]|
|530|[SR_SINGULAR_COMPANY]: page1adminonly||[SR_UDEF_TEXT_SHORT]|
|531|[SR_SINGULAR_COMPANY]: Udlist one||[SR_UDEF_LIST]|
|532|[SR_SINGULAR_COMPANY]: Udlist two||[SR_UDEF_LIST]|
|0|[SR_SINGULAR_COMPANY]: [SR_ADMIN_IMPORT_COLUMN_BUSINESS]|||
|1|[SR_SINGULAR_COMPANY]: [SR_ADMIN_IMPORT_COLUMN_CATEGORY]|||
|2|[SR_SINGULAR_COMPANY]: [SR_ADMIN_IMPORT_COLUMN_COUNTRY]|||
|3|[SR_SINGULAR_COMPANY]: [SR_ADMIN_IMPORT_COLUMN_DEPARTEMENT]|||
|4|[SR_SINGULAR_COMPANY]: [SR_ADMIN_IMPORT_COLUMN_INFO]|||
|5|[SR_SINGULAR_COMPANY]: [SR_ADMIN_IMPORT_COLUMN_CONTACT_NAME]|||
|6|[SR_SINGULAR_COMPANY]: [SR_ADMIN_IMPORT_COLUMN_EMAIL]||multiple|
|7|[SR_SINGULAR_COMPANY]: [SR_ADMIN_IMPORT_COLUMN_TELEPHONE]||multiple|


## Related MDO Lists

* "importfieldsheadings"
* "importfieldsheadingswithallitem"
* "importfieldsheadingswithallitemwithnoselection"
* "importfieldsheadingswithnoselection"
* "importfieldswithallitem"
* "importfieldswithallitemwithnoselection"
* "importfieldswithnoselection"
