---
uid: relationssearchlistprovidersalepassive
title: relationssearchlistprovidersalepassive
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "relationssearchlistprovidersalepassive"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "relationssearchlistprovidersalepassive" MDO List

Serve the active and passive texts of relations, with a given table as source (active)
or destination (passive).

To facilitate relation searching, we need to provide a way to choose **which** relation we
would like to find. This provider supplies one list (dynamically named) for each table that
is used as a source or destination (relationdefinition --&gt; relationtarget).

Each relation target combination supplied by relationtarget causes the relationdefinition to
appear in the correct direction, in the list for a table. Each such list is always flat.

Implemented by the <see cref="T:SuperOffice.CRM.Lists.RelationsSearchListProvider">RelationsSearchListProvider</see> class.
The name of the MDO list is 'relationssearchlistprovidersalepassive'.

## Sample Request

```http!
GET /api/v1/MDOList/relationssearchlistprovidersalepassive
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code

```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("relationssearchlistprovidersalepassive", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|10||||

## Related MDO Lists

* "relationssearchlistprovidersalepassiveheadings"
* "relationssearchlistprovidersalepassiveheadingswithallitem"
* "relationssearchlistprovidersalepassiveheadingswithallitemwithnoselection"
* "relationssearchlistprovidersalepassiveheadingswithnoselection"
* "relationssearchlistprovidersalepassivewithallitem"
* "relationssearchlistprovidersalepassivewithallitemwithnoselection"
* "relationssearchlistprovidersalepassivewithnoselection"
