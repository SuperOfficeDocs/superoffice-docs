---
uid: relationssearchlistprovidercontactactive
title: relationssearchlistprovidercontactactive
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "relationssearchlistprovidercontactactive"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "relationssearchlistprovidercontactactive" MDO List

Serve the active and passive texts of relations, with a given table as source (active)
or destination (passive).

To facilitate relation searching, we need to provide a way to choose **which** relation we
would like to find. This provider supplies one list (dynamically named) for each table that
is used as a source or destination (relationdefinition --&gt; relationtarget).

Each relation target combination supplied by relationtarget causes the relationdefinition to
appear in the correct direction, in the list for a table. Each such list is always flat.

Implemented by the <see cref="T:SuperOffice.CRM.Lists.RelationsSearchListProvider">RelationsSearchListProvider</see> class.
The name of the MDO list is 'relationssearchlistprovidercontactactive'.

## Sample Request

```http!
GET /api/v1/MDOList/relationssearchlistprovidercontactactive
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code

```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("relationssearchlistprovidercontactactive", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|eier|||
|3|leier inn|||
|7|kjenner|||

## Related MDO Lists

* "relationssearchlistprovidercontactactiveheadings"
* "relationssearchlistprovidercontactactiveheadingswithallitem"
* "relationssearchlistprovidercontactactiveheadingswithallitemwithnoselection"
* "relationssearchlistprovidercontactactiveheadingswithnoselection"
* "relationssearchlistprovidercontactactivewithallitem"
* "relationssearchlistprovidercontactactivewithallitemwithnoselection"
* "relationssearchlistprovidercontactactivewithnoselection"
