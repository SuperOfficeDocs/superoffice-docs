---
uid: relationssearchlistproviderappointmentactive
title: relationssearchlistproviderappointmentactive
keywords: mdoprovider mdo provider relationssearchlistproviderappointmentactive
description: Serve the active and passive texts of relations, with a given table as source (active) or destination (passive).
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "relationssearchlistproviderappointmentactive" MDO List
Serve the active and passive texts of relations, with a given table as source (active)
or destination (passive).

To facilitate relation searching, we need to provide a way to choose <b>which</b> relation we
would like to find. This provider supplies one list (dynamically named) for each table that
is used as a source or destination (relationdefinition --&gt; relationtarget).


Each relation target combination supplied by relationtarget causes the relationdefinition to
appear in the correct direction, in the list for a table. Each such list is always flat.

Implemented by the <see cref="T:SuperOffice.CRM.Lists.RelationsSearchListProvider">RelationsSearchListProvider</see> class.
The name of the MDO list is 'relationssearchlistproviderappointmentactive'.




## Sample Request

```http!
GET /api/v1/MDOList/relationssearchlistproviderappointmentactive
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("relationssearchlistproviderappointmentactive", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|8|Link to follow-up|||
|9|Link to document|||
|10|Link to sale|||


## Related MDO Lists

* "relationssearchlistproviderappointmentactiveheadings"
* "relationssearchlistproviderappointmentactiveheadingswithallitem"
* "relationssearchlistproviderappointmentactiveheadingswithallitemwithnoselection"
* "relationssearchlistproviderappointmentactiveheadingswithnoselection"
* "relationssearchlistproviderappointmentactivewithallitem"
* "relationssearchlistproviderappointmentactivewithallitemwithnoselection"
* "relationssearchlistproviderappointmentactivewithnoselection"
