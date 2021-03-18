---
uid: relationssearchlistproviderdocumentdocumentpassive
title: relationssearchlistproviderdocumentdocumentpassive
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
so.generated: true
so.date: 18.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "relationssearchlistproviderdocumentdocumentpassive" MDO List
Serve the active and passive texts of relations, with a given table as source (active)
or destination (passive).

To facilitate relation searching, we need to provide a way to choose <b>which</b> relation we
would like to find. This provider supplies one list (dynamically named) for each table that
is used as a source or destination (relationdefinition --&gt; relationtarget).
<para />
Each relation target combination supplied by relationtarget causes the relationdefinition to
appear in the correct direction, in the list for a table. Each such list is always flat.

Implemented by the <see cref="T:SuperOffice.CRM.Lists.RelationsSearchListProvider">RelationsSearchListProvider</see> class.
The name of the MDO list is 'relationssearchlistproviderdocumentdocumentpassive'.




## Sample Request

```http!
GET /api/v1/MDOList/relationssearchlistproviderdocumentdocumentpassive
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("relationssearchlistproviderdocumentdocumentpassive", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|9||||


## Related MDO Lists

* "relationssearchlistproviderdocumentdocumentpassiveheadings"
* "relationssearchlistproviderdocumentdocumentpassiveheadingswithallitem"
* "relationssearchlistproviderdocumentdocumentpassiveheadingswithallitemwithnoselection"
* "relationssearchlistproviderdocumentdocumentpassiveheadingswithnoselection"
* "relationssearchlistproviderdocumentdocumentpassivewithallitem"
* "relationssearchlistproviderdocumentdocumentpassivewithallitemwithnoselection"
* "relationssearchlistproviderdocumentdocumentpassivewithnoselection"
