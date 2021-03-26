---
uid: services81-selection-removeselectionmembers
title: Services81.SelectionAgent.RemoveSelectionMembers SOAP
Generated: true
---

# Services81 Selection RemoveSelectionMembers SOAP

SOAP request and response examples **Remote/Services81/Selection.svc**
Implemented by the <see cref="M:SuperOffice.Services81.ISelectionAgent.RemoveSelectionMembers">SuperOffice.Services81.ISelectionAgent.RemoveSelectionMembers</see> method.

## RemoveSelectionMembers

Removes members from the selection as  specified in the collection of entity ids. The ids can be a collection of sale ids, or other supported types.

* **selectionId:** The id of the selection where to members will be removed.
* **ids:** A collection of ids to remove from the selection. The ids can be a collection of sale ids, or other supported types.



[WSDL file for Services81/Selection](../Services81-Selection.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## RemoveSelectionMembers Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services81">
  <Selection:ApplicationToken>1234567-1234-9876</Selection:ApplicationToken>
  <Selection:Credentials>
    <Selection:Ticket>7T:1234abcxyzExample==</Selection:Ticket>
  </Selection:Credentials>
 <SOAP-ENV:Body>
   <Selection:RemoveSelectionMembers>
    <Selection:SelectionId xsi:type="xsd:int">0</Selection:SelectionId>
    <Selection:Ids xsi:type="NetServerServices812:ArrayOfint">
     <NetServerServices812:int xsi:type="xsd:int">0</NetServerServices812:int>
    </Selection:Ids>
   </Selection:RemoveSelectionMembers>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## RemoveSelectionMembers Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services81">
 <SOAP-ENV:Body>
  <Selection:RemoveSelectionMembersResponse>
  </Selection:RemoveSelectionMembersResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

