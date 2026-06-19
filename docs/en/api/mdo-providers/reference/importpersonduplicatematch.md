---
uid: importpersonduplicatematch
title: importpersonduplicatematch
keywords: mdoprovider mdo provider importpersonduplicatematch
description: Import Person Fields to match on - Name, E-mail, phone, number, id, None
generated: true
content_type: reference
envir: onsite, online
---

# "importpersonduplicatematch" MDO List
Import Person Fields to match on: Name, E-mail, phone, number, id, None



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ImportPersonDuplicateMatchProvider">ImportPersonDuplicateMatchProvider</see> class.
The name of the MDO list is 'importpersonduplicatematch'.




## Sample Request

```http!
GET /api/v1/MDOList/importpersonduplicatematch
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("importpersonduplicatematch", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|[SR_IMPORT_NAME]|||
|2|[SR_IMPORT_EMAIL_ADDRESS]|||
|3|[SR_IMPORT_MOBILE_PHONE]|||
|4|[SR_IMPORT_NUMBER]|||
|5|[SR_IMPORT_NONE]|||
|6|[SR_ADMIN_IMPORT_COLUMN_ID]|||


## Related MDO Lists

* "importpersonduplicatematchheadings"
* "importpersonduplicatematchheadingswithallitem"
* "importpersonduplicatematchheadingswithallitemwithnoselection"
* "importpersonduplicatematchheadingswithnoselection"
* "importpersonduplicatematchwithallitem"
* "importpersonduplicatematchwithallitemwithnoselection"
* "importpersonduplicatematchwithnoselection"
