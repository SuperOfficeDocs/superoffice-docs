---
uid: quoteconnectors
title: quoteconnectors
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "quoteconnectors"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "quoteconnectors" MDO List
Retrieve the list of all installed (i.e., loaded assemblies) Quote Connectors

Implementation relies on the <see cref="T:SuperOffice.CRM.ArchiveLists.QuoteConnectorProvider" /> archivelist, and simply reformats its data

Implemented by the <see cref="T:SuperOffice.CRM.Lists.QuoteConnectors">QuoteConnectors</see> class.
The name of the MDO list is 'quoteconnectors'.




## Sample Request

```http!
GET /api/v1/MDOList/quoteconnectors
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("quoteconnectors", forceFlatList: true);
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

* "quoteconnectorsheadings"
* "quoteconnectorsheadingswithallitem"
* "quoteconnectorsheadingswithallitemwithnoselection"
* "quoteconnectorsheadingswithnoselection"
* "quoteconnectorswithallitem"
* "quoteconnectorswithallitemwithnoselection"
* "quoteconnectorswithnoselection"
