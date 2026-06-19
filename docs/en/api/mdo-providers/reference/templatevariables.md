---
uid: templatevariables
title: templatevariables
keywords: mdoprovider mdo provider templatevariables
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "templatevariables" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.TemplateVariablesProvider">TemplateVariablesProvider</see> class.
The name of the MDO list is 'templatevariables'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Include company variables. Default = true| includeCompanies|True|





## Sample Request

```http!
GET /api/v1/MDOList/templatevariables
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("templatevariables", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|[SR_EJPARSER_FIRSTNAME]||{atfn}|
|2|[SR_EJPARSER_LASTNAME]||{atln}|
|3|[SR_ARCHIVE_SALUTATION]||{atsa}|
|4|[SR_EJPARSER_EMAIL]||{amai}|
|5|[SR_PERSON_TITLE]||{atti}|
|6|[SR_RELATIONARCHIVE_PERSONMOBILEPHONE]||{atpc}|
|7|[SR_RELATIONARCHIVE_PERSONDIRECTPHONE]||{phon}|
|8|[SR_ARCHIVE_CATEGORY]||{acat}|
|9|[SR_LIST_BUSINESS]||{abus}|
|10|[SR_PERSONARCHIVE_NUMBER]||{anum}|
|11|[SR_PERSONARCHIVE_POSITION]||{atpo}|
|12|[SR_EJPARSER_NAME]||{name}|
|13|[SR_PERSONARCHIVE_DEPARTMENT]||{dept}|
|14|[SR_PERSONARCHIVE_COUNTRYNAME]||{cntr}|
|15|[SR_PHONE]||{cpho}|
|16|[SR_WEB_PAGE]||{cwww}|
|17|[SR_ARCHIVE_CATEGORY]||{cate}|
|18|[SR_LIST_BUSINESS]||{busi}|
|19|[SR_PERSONARCHIVE_NUMBER]||{numb}|
|20|[SR_PERSONARCHIVE_CITY]||{city}|


## Related MDO Lists

* "templatevariablesheadings"
* "templatevariablesheadingswithallitem"
* "templatevariablesheadingswithallitemwithnoselection"
* "templatevariablesheadingswithnoselection"
* "templatevariableswithallitem"
* "templatevariableswithallitemwithnoselection"
* "templatevariableswithnoselection"
