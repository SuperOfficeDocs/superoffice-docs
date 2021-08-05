---
uid: quoteconnections
title: quoteconnections
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "quoteconnections"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "quoteconnections" MDO List
Retrieve the list of all defined Quote Connections - i.e. not the connectors (DLLs).
ExtraInfo: "connectorname=Name-of-connector" - restricts results to connections defined by one particular connector.

Implementation relies on the <see cref="T:SuperOffice.CRM.ArchiveLists.QuoteConnectionProvider" /> archivelist, and simply reformats its data

Implemented by the <see cref="T:SuperOffice.CRM.Lists.QuoteConnections">QuoteConnections</see> class.
The name of the MDO list is 'quoteconnections'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Name of the connector to get connections for| connectorname|Custom Quote Connector Name|





## Sample Request

```http!
GET /api/v1/MDOList/quoteconnections
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("quoteconnections", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|2|Built-in||SuperOffice Standalone|
|3|TestClient SuperOffice test/debug connector A||Test.QuoteConnector|
|4|TestClient SuperOffice test/Debug connector B||Test.QuoteConnector|
|5|TestClient SuperOffice manipulating connector||Test.QuoteConnector|


## Related MDO Lists

* "quoteconnectionsheadings"
* "quoteconnectionsheadingswithallitem"
* "quoteconnectionsheadingswithallitemwithnoselection"
* "quoteconnectionsheadingswithnoselection"
* "quoteconnectionswithallitem"
* "quoteconnectionswithallitemwithnoselection"
* "quoteconnectionswithnoselection"
