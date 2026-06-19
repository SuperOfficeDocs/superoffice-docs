---
uid: functionrights
title: functionrights
keywords: mdoprovider mdo provider functionrights
description: FunctionRightsListProvider returns a MDO list of function rights in the database. Additional Info = "role=123;languageId=1024;roleType=1"
generated: true
content_type: reference
envir: onsite, online
---

# "functionrights" MDO List
FunctionRightsListProvider returns a MDO list of function rights in the database.
Additional Info = "role=123;languageId=1024;roleType=1"



Implemented by the <see cref="T:SuperOffice.CRM.Lists.FunctionRightsListProvider">FunctionRightsListProvider</see> class.
The name of the MDO list is 'functionrights'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Restrict to a specific role| role|123|
|Restrict to rights for a given roleType| roleType|1|
|Language to return results in. English=1033| languageId|1033|

Separator: ;





## Sample Request

```http!
GET /api/v1/MDOList/functionrights
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("functionrights", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|13|Hide Selection screen||hide-selection|
|15|Can run Mail Merge||allow-bulk-mailmerge|
|16|Can export data to file||allow-bulk-export|
|17|Can create tasks for a selection||allow-bulk-generate-activities|
|18|Can copy a selection||allow-bulk-copy-members|
|19|Allow bulk update||allow-bulk-edit|
|20|Can delete selection members||allow-bulk-delete|
|21|Can modify interests for selection members||allow-bulk-interests|
|22|Can send e-mail to selection members||allow-bulk-email|
|23|Can run custom tasks on selections||allow-bulk-user-applications|
|24|Can see users belonging to other companies||see-other-companies-associates|
|26|Status Monitor Administrator (counters)||admin-saint-regeneration|
|27|Status Monitor Administrator (statuses)||admin-saint-definition|
|28|Can create and delete tables in the database||allow-dictionarySDK|
|29|Field Administrator||admin-udef|
|30|Import Administrator||admin-import|
|31|Show only published projects||ext-need-publish-to-see-project|
|32|Show only published follow-ups||ext-need-publish-to-see-appointment|
|33|Show only published documents||ext-need-publish-to-see-document|
|34|Show only published sales||ext-need-publish-to-see-sale|
|35|Show projects marked as events||ext-see-event-projects|


## Related MDO Lists

* "functionrightsheadings"
* "functionrightsheadingswithallitem"
* "functionrightsheadingswithallitemwithnoselection"
* "functionrightsheadingswithnoselection"
* "functionrightswithallitem"
* "functionrightswithallitemwithnoselection"
* "functionrightswithnoselection"
