---
uid: usergroup
title: usergroup
keywords: mdoprovider mdo provider usergroup
description: List provider for the UserGroup table. While this table looks like an MDO table, it lacks the standardized grouplink and headinglink companion tables (for good reason, since it is the group table itself).
generated: true
content_type: reference
envir: onsite, online
---

# "usergroup" MDO List
List provider for the UserGroup table. While this table looks like an MDO table,
it lacks the standardized grouplink and headinglink companion tables (for good reason,
since it is the group table itself).



Implemented by the <see cref="T:SuperOffice.CRM.Lists.UserGroupProvider">UserGroupProvider</see> class.
The name of the MDO list is 'usergroup'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Exclude the given user-group id| exclude_id|1234|
|Exclude the given comma-separated user-group id| exclude_ids|12,34,69|
|Add a blank item| addblankstring|True|
|Add a root target item| addRootTarget|False|
|Use a search that works with multilanguage strings| useMultilanguageSearch|False|





## Sample Request

```http!
GET /api/v1/MDOList/usergroup
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("usergroup", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|2|Salg|||
|4|Tjenester|||
|3|Service|||
|5|Markedsføring|||
|1|Administrasjon|||
|6|Testgruppe1|||
|7|Testgruppe2|||


## Related MDO Lists

* "usergroupheadings"
* "usergroupheadingswithallitem"
* "usergroupheadingswithallitemwithnoselection"
* "usergroupheadingswithnoselection"
* "usergroupwithallitem"
* "usergroupwithallitemwithnoselection"
* "usergroupwithnoselection"
