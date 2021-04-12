---
uid: relationssearchlistproviderpersoncontactpassive
title: relationssearchlistproviderpersoncontactpassive
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "relationssearchlistproviderpersoncontactpassive"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "relationssearchlistproviderpersoncontactpassive" MDO List
Serve the active and passive texts of relations, with a given table as source (active)
or destination (passive).

To facilitate relation searching, we need to provide a way to choose <b>which</b> relation we
would like to find. This provider supplies one list (dynamically named) for each table that
is used as a source or destination (relationdefinition --&gt; relationtarget).
<para />
Each relation target combination supplied by relationtarget causes the relationdefinition to
appear in the correct direction, in the list for a table. Each such list is always flat.

Implemented by the <see cref="T:SuperOffice.CRM.Lists.RelationsSearchListProvider">RelationsSearchListProvider</see> class.
The name of the MDO list is 'relationssearchlistproviderpersoncontactpassive'.




## Sample Request

```http!
GET /api/v1/MDOList/relationssearchlistproviderpersoncontactpassive
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("relationssearchlistproviderpersoncontactpassive", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|3|leies inn av|||
|7|kjenner|||


## Related MDO Lists

* "relationssearchlistproviderpersoncontactpassiveheadings"
* "relationssearchlistproviderpersoncontactpassiveheadingswithallitem"
* "relationssearchlistproviderpersoncontactpassiveheadingswithallitemwithnoselection"
* "relationssearchlistproviderpersoncontactpassiveheadingswithnoselection"
* "relationssearchlistproviderpersoncontactpassivewithallitem"
* "relationssearchlistproviderpersoncontactpassivewithallitemwithnoselection"
* "relationssearchlistproviderpersoncontactpassivewithnoselection"
