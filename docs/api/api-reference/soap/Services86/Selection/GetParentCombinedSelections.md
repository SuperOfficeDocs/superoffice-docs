---
uid: services86-selection-getparentcombinedselections
title: Services86.SelectionAgent.GetParentCombinedSelections SOAP
Generated: true
---

# Services86 Selection GetParentCombinedSelections SOAP

SOAP request and response examples **Remote/Services86/Selection.svc**
Implemented by the <see cref="M:SuperOffice.Services86.ISelectionAgent.GetParentCombinedSelections">SuperOffice.Services86.ISelectionAgent.GetParentCombinedSelections</see> method.

## GetParentCombinedSelections

Get a list of all selection ids where the given selection is used to create a combined selection.

* **selectionId:** The selectionId to query for.

**Returns:** Array of selectionIds.


[WSDL file for Services86/Selection](../Services86-Selection.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetParentCombinedSelections Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services86">
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
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Selection:GetParentCombinedSelectionsResponse>
   <Selection:Response xsi:type="NetServerServices862:ArrayOfint">
    <NetServerServices862:int xsi:type="xsd:int">0</NetServerServices862:int>
   </Selection:Response>
  </Selection:GetParentCombinedSelectionsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

