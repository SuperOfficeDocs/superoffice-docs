---
uid: chartselection
title: chartselection
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "chartselection"
so.generated: true
so.date: 08.26.2022
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "chartselection" MDO List

Implemented by the <see cref="T:SuperOffice.CRM.ArchiveLists.ChartSelectionProvider">ChartSelectionProvider</see> class.
The name of the MDO list is 'chartselection'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Return chart selections associated with the given selection provider| SelectionProvider||
|Return chart selections associated with the given table| tableName||
|Return chart selections associated with the given table| providerName||

Separator: &

## Sample Request

```http!
GET /api/v1/MDOList/chartselection
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code

```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("chartselection", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
| 2 | Example | | |

## Related MDO Lists

* "chartselectionheadings"
* "chartselectionheadingswithallitem"
* "chartselectionheadingswithallitemwithnoselection"
* "chartselectionheadingswithnoselection"
* "chartselectionwithallitem"
* "chartselectionwithallitemwithnoselection"
* "chartselectionwithnoselection"
