---
uid: services81-selection-addselectionmembersfromsearch
title: Services81.SelectionAgent.AddSelectionMembersFromSearch SOAP
Generated: true
---

# Services81 Selection AddSelectionMembersFromSearch SOAP

SOAP request and response examples **Remote/Services81/Selection.svc**
Implemented by the <see cref="M:SuperOffice.Services81.ISelectionAgent.AddSelectionMembersFromSearch">SuperOffice.Services81.ISelectionAgent.AddSelectionMembersFromSearch</see> method.

## AddSelectionMembersFromSearch

Removes members from the selection using the search result.

* **selectionId:** The id of the selection to add members
* **storageKey:** Storage key to be interpreted by the restriction storage provider, when it fetches criteria for the search

**Returns:** Number of members added.


[WSDL file for Services81/Selection](../Services81-Selection.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## AddSelectionMembersFromSearch Request

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
   <Selection:AddSelectionMembersFromSearch>
    <Selection:SelectionId xsi:type="xsd:int">0</Selection:SelectionId>
    <Selection:StorageKey xsi:type="xsd:string"></Selection:StorageKey>
   </Selection:AddSelectionMembersFromSearch>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## AddSelectionMembersFromSearch Response

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
  <Selection:AddSelectionMembersFromSearchResponse>
   <Selection:Response xsi:type="xsd:int">0</Selection:Response>
  </Selection:AddSelectionMembersFromSearchResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

