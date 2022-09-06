---
uid: relationssearchlistproviderpersonactive
title: relationssearchlistproviderpersonactive
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "relationssearchlistproviderpersonactive"
so.generated: true
so.date: 08.26.2022
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "relationssearchlistproviderpersonactive" MDO List

Serve the active and passive texts of relations, with a given table as source (active)
or destination (passive).

To facilitate relation searching, we need to provide a way to choose <b>which</b> relation we
would like to find. This provider supplies one list (dynamically named) for each table that
is used as a source or destination (relationdefinition --&gt; relationtarget).
<para />
Each relation target combination supplied by relationtarget causes the relationdefinition to
appear in the correct direction, in the list for a table. Each such list is always flat.

Implemented by the <see cref="T:SuperOffice.CRM.Lists.RelationsSearchListProvider">RelationsSearchListProvider</see> class.
The name of the MDO list is 'relationssearchlistproviderpersonactive'.

## Sample Request

```http!
GET /api/v1/MDOList/relationssearchlistproviderpersonactive
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code

```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("relationssearchlistproviderpersonactive", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|2|er en personlig venn av|||
|4|arbeidet før for|||
|5|sitter i styret hos|||
|6|er i familie med|||
|7|kjenner|||

## Related MDO Lists

* "relationssearchlistproviderpersonactiveheadings"
* "relationssearchlistproviderpersonactiveheadingswithallitem"
* "relationssearchlistproviderpersonactiveheadingswithallitemwithnoselection"
* "relationssearchlistproviderpersonactiveheadingswithnoselection"
* "relationssearchlistproviderpersonactivewithallitem"
* "relationssearchlistproviderpersonactivewithallitemwithnoselection"
* "relationssearchlistproviderpersonactivewithnoselection"
