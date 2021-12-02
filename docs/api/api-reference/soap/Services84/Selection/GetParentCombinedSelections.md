---
title: Services84.SelectionAgent.GetParentCombinedSelections SOAP
generated: 1
uid: Services84-Selection-GetParentCombinedSelections
---

# Services84 Selection GetParentCombinedSelections

SOAP request and response examples **Remote/Services84/Selection.svc**
Implemented by the <see cref="M:SuperOffice.Services84.ISelectionAgent.GetParentCombinedSelections">SuperOffice.Services84.ISelectionAgent.GetParentCombinedSelections</see> method.

## GetParentCombinedSelections

Get a list of all selection ids where the given selection is used to create a combined selection.

* **selectionId:** The selectionId to query for.

**Returns:** Array of selectionIds.


[WSDL file for Services84/Selection](../Services84-Selection.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetParentCombinedSelections Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <Selection:ApplicationToken>1234567-1234-9876</Selection:ApplicationToken>
  <Selection:Credentials>
    <Selection:Ticket>7T:1234abcxyzExample==</Selection:Ticket>
  </Selection:Credentials>
 <SOAP-ENV:Body>
   <Selection:GetParentCombinedSelections>
    <Selection:SelectionId xsi:type="xsd:int">0</Selection:SelectionId>
   </Selection:GetParentCombinedSelections>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetParentCombinedSelections Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Selection:GetParentCombinedSelectionsResponse>
   <Selection:Response xsi:type="NetServerServices842:ArrayOfint">
    <NetServerServices842:int xsi:type="xsd:int">0</NetServerServices842:int>
   </Selection:Response>
  </Selection:GetParentCombinedSelectionsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

