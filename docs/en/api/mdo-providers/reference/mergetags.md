---
uid: mergetags
title: mergetags
keywords: mdoprovider mdo provider mergetags
description: 
generated: true
content_type: reference
envir: onsite, online
---

# "mergetags" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.MergeTagsProvider">MergeTagsProvider</see> class.
The name of the MDO list is 'mergetags'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Include ticket parser variables. Default = false| includeTicket|False|
|Include company variables. Default = true| includeCompanies|True|
|Include our contact variables. Default = true| includeOurContact|True|
|Include our service contact variables. Default = true| includeOurServiceContact|True|





## Sample Request

```http!
GET /api/v1/MDOList/mergetags
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("mergetags", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|[SR_EJPARSER_NAME]||[[customer.name]]|
|2|[SR_EJPARSER_FIRSTNAME]||[[customer.firstname]]|
|3|[SR_EJPARSER_LASTNAME]||[[customer.lastname]]|
|4|[SR_ARCHIVE_SALUTATION]||[[makeSalutation(customer.id)]]|
|5|[SR_EJPARSER_EMAIL]||[[customer.email]]|
|6|[SR_PERSON_TITLE]||[[customer.title]]|
|7|[SR_RELATIONARCHIVE_PERSONMOBILEPHONE]||[[customer.cellphone]]|
|8|[SR_RELATIONARCHIVE_PERSONDIRECTPHONE]||[[customer.direct]]|
|9|[SR_ARCHIVE_CATEGORY]||[[customer.category]]|
|10|[SR_LIST_BUSINESS]||[[customer.business]]|
|11|[SR_PERSONARCHIVE_NUMBER]||[[customer.number]]|
|12|[SR_PERSONARCHIVE_POSITION]||[[customer.position]]|
|13|[SR_EJPARSER_NAME]||[[company.name]]|
|14|[SR_PERSONARCHIVE_DEPARTMENT]||[[company.department]]|
|15|[SR_PERSONARCHIVE_COUNTRYNAME]||[[company.country]]|
|16|[SR_PHONE]||[[company.phone]]|
|17|[SR_WEB_PAGE]||[[company.url]]|
|18|[SR_ARCHIVE_CATEGORY]||[[company.category]]|
|19|[SR_LIST_BUSINESS]||[[company.business]]|
|20|[SR_PERSONARCHIVE_NUMBER]||[[company.number2]]|
|21|[SR_PERSONARCHIVE_CITY]||[[company.city]]|


## Related MDO Lists

* "mergetagsheadings"
* "mergetagsheadingswithallitem"
* "mergetagsheadingswithallitemwithnoselection"
* "mergetagsheadingswithnoselection"
* "mergetagswithallitem"
* "mergetagswithallitemwithnoselection"
* "mergetagswithnoselection"
