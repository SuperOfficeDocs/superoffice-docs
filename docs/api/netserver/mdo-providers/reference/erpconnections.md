---
uid: erpconnections
title: erpconnections
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "erpconnections"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "erpconnections" MDO List
Retrieve the list of all defined Erp Connections (not Connectors, that's another list)

Implementation relies on the <see cref="T:SuperOffice.CRM.ArchiveLists.ErpConnectionProvider" /> archivelist, and simply reformats its data.

The items contain the GUID (ErpId) used by the connection, in the ExtraInfo field

Implemented by the <see cref="T:SuperOffice.CRM.Lists.ErpConnections">ErpConnections</see> class.
The name of the MDO list is 'erpconnections'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Sort by rank| useRank|true|
|Add connector name to names| prefixwithconnector|true|





## Sample Request

```http!
GET /api/v1/MDOList/erpconnections
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("erpconnections", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|SuperOffice Test||889BF882-C6DA-4AC5-B3C7-A5A650625D90|
|2|Limited access Test||95002C41-9EFA-449B-B47B-BA7D092A6411|
|3|QA-BUILD\ErpSync\Client.xlsm||57cefbea-059b-4047-a303-e481b37c76e4|


## Related MDO Lists

* "erpconnectionsheadings"
* "erpconnectionsheadingswithallitem"
* "erpconnectionsheadingswithallitemwithnoselection"
* "erpconnectionsheadingswithnoselection"
* "erpconnectionswithallitem"
* "erpconnectionswithallitemwithnoselection"
* "erpconnectionswithnoselection"
