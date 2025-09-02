---
uid: usergroupwithhistoryall
title: usergroupwithhistoryall
keywords: mdoprovider mdo provider usergroupwithhistoryall
description: List provider for the UserGroup table. While this table looks like an MDO table, it lacks the standardized grouplink and headinglink companion tables (for good reason, since it is the group table itself). This provider includes the 'History' and 'All' choices, with id's -1 and -2. The <see cref="T:SuperOffice.CRM.ArchiveLists.ParticipantsProvider" /> (actually, the <see cref="T:SuperOffice.CRM.ArchiveLists.ExplicitParticipantsAssociateProvider" /> subchannel), used in the Assign To dialog, has a groupRestrictionId restriction that correctly decodes these special values.
generated: true
content_type: reference
envir: onsite, online
---

# "usergroupwithhistoryall" MDO List
List provider for the UserGroup table. While this table looks like an MDO table,
it lacks the standardized grouplink and headinglink companion tables (for good reason,
since it is the group table itself).


This provider includes the 'History' and 'All' choices, with id's -1 and -2. The
<see cref="T:SuperOffice.CRM.ArchiveLists.ParticipantsProvider" /> (actually, the
<see cref="T:SuperOffice.CRM.ArchiveLists.ExplicitParticipantsAssociateProvider" /> subchannel), used in the Assign To dialog,
has a groupRestrictionId restriction that correctly decodes these special values.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.UserGroupWithHistoryAllProvider">UserGroupWithHistoryAllProvider</see> class.
The name of the MDO list is 'usergroupwithhistoryall'.




## Sample Request

```http!
GET /api/v1/MDOList/usergroupwithhistoryall
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("usergroupwithhistoryall", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|-1|History|||
|-2|All users|||
|0||||
|2|Salg|||
|4|Tjenester|||
|3|Service|||
|5|Markedsføring|||
|1|Administrasjon|||
|6|Testgruppe1|||
|7|Testgruppe2|||


## Related MDO Lists

* "usergroupwithhistoryallheadings"
* "usergroupwithhistoryallheadingswithallitem"
* "usergroupwithhistoryallheadingswithallitemwithnoselection"
* "usergroupwithhistoryallheadingswithnoselection"
* "usergroupwithhistoryallwithallitem"
* "usergroupwithhistoryallwithallitemwithnoselection"
* "usergroupwithhistoryallwithnoselection"
