---
uid: erpconnectors
title: erpconnectors
keywords: mdoprovider mdo provider erpconnectors
description: Retrieve the list of all defined Erp Connectors (not Connections, that's another list)
generated: true
content_type: reference
envir: onsite, online
---

# "erpconnectors" MDO List
Retrieve the list of all defined Erp Connectors (not Connections, that's another list)

Implementation relies on the <see cref="T:SuperOffice.CRM.ArchiveLists.ErpConnectorProvider" /> archivelist, and simply reformats its data.


The items contain the Url pointing to the connector, in the ExtraInfo field; note that this does not
<b>have</b> to be unique for each connector... though it should be...

Implemented by the <see cref="T:SuperOffice.CRM.Lists.ErpConnectors">ErpConnectors</see> class.
The name of the MDO list is 'erpconnectors'.




## Sample Request

```http!
GET /api/v1/MDOList/erpconnectors
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("erpconnectors", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|2|QA-BUILD Excel Test||http://qa-build/ExcelErpSyncConnector/Service.svc|


## Related MDO Lists

* "erpconnectorsheadings"
* "erpconnectorsheadingswithallitem"
* "erpconnectorsheadingswithallitemwithnoselection"
* "erpconnectorsheadingswithnoselection"
* "erpconnectorswithallitem"
* "erpconnectorswithallitemwithnoselection"
* "erpconnectorswithnoselection"
