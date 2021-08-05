---
uid: functionrights
title: functionrights
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "functionrights"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
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
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("functionrights", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|General Administrator||admin-all|
|2|List Administrator||admin-lists|
|3|User Administrator||admin-users|
|8|Can override read-only fields||allow-readonly-override|
|9|Hide Company screen||hide-company|
|10|Hide Sale screen||hide-sale|
|11|Hide Project screen||hide-project|
|12|Hide Inbox screen||hide-inbox|
|13|Hide Selection screen||hide-selection|
|14|Hide Reports screen||hide-reporter|
|15|Can run Mail Merge||allow-bulk-mailmerge|
|16|Can export selections to file||allow-bulk-export|
|17|Can create tasks for a selection||allow-bulk-generate-activities|
|18|Can copy a selection||allow-bulk-copy-members|
|19|Allow bulk update||allow-bulk-edit|
|20|Can delete selection members||allow-bulk-delete|
|21|Can modify interests for selection members||allow-bulk-interests|
|22|Can send e-mail to selection members||allow-bulk-email|
|23|Can run custom tasks on selections||allow-bulk-user-applications|
|24|Can see users belonging to other companies||see-other-companies-associates|
|26|Status Monitor Administrator (counters)||admin-saint-regeneration|


## Related MDO Lists

* "functionrightsheadings"
* "functionrightsheadingswithallitem"
* "functionrightsheadingswithallitemwithnoselection"
* "functionrightsheadingswithnoselection"
* "functionrightswithallitem"
* "functionrightswithallitemwithnoselection"
* "functionrightswithnoselection"
