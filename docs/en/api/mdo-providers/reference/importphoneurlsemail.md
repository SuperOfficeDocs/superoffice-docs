---
uid: importphoneurlsemail
title: importphoneurlsemail
keywords: mdoprovider mdo provider importphoneurlsemail
description: Import phone/url/email values - Add, Replace, Skip
generated: true
content_type: reference
envir: onsite, online
---

# "importphoneurlsemail" MDO List
Import phone/url/email values: Add, Replace, Skip



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ImportPhoneUrlsEmailProvider">ImportPhoneUrlsEmailProvider</see> class.
The name of the MDO list is 'importphoneurlsemail'.




## Sample Request

```http!
GET /api/v1/MDOList/importphoneurlsemail
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("importphoneurlsemail", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Add new - keep existing|||
|2|Replace - overwrite existing|||
|3|Ignore - keep existing|||


## Related MDO Lists

* "importphoneurlsemailheadings"
* "importphoneurlsemailheadingswithallitem"
* "importphoneurlsemailheadingswithallitemwithnoselection"
* "importphoneurlsemailheadingswithnoselection"
* "importphoneurlsemailwithallitem"
* "importphoneurlsemailwithallitemwithnoselection"
* "importphoneurlsemailwithnoselection"
