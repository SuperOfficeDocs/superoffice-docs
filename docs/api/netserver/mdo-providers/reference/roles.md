---
uid: roles
title: roles
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "roles"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "roles" MDO List
RoleListProvider creates a MDO list of roles in the database.
Default list are the employee roles.
Use ExtraInfo to get other RoleTypes.
ExtraInfo : "0" Default, to get employee roles
ExtraInfo : "1" to get external users roles
ExtraInfo : "2" to get anonymous roles.
ExtraInfo : "3" to get system user roles.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.RolesListProvider">RolesListProvider</see> class.
The name of the MDO list is 'roles'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Role type (0=employees, 1=ext users, 2=anon, 3=system)| |0|

Separator: ;





## Sample Request

```http!
GET /api/v1/MDOList/roles
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("roles", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|User level 0|||
|2|User level 1|||
|3|User level 2|||
|4|User level 3|||
|5|User level 4|||
|6|User level 5|||
|7|List Administrator|||
|8|User Administrator|||
|9|Local User|||
|13|eJournal Administrator|||
|14|eJournal User|||
|15|CRM Administrator|||
|16|CRM User|||


## Related MDO Lists

* "rolesheadings"
* "rolesheadingswithallitem"
* "rolesheadingswithallitemwithnoselection"
* "rolesheadingswithnoselection"
* "roleswithallitem"
* "roleswithallitemwithnoselection"
* "roleswithnoselection"
