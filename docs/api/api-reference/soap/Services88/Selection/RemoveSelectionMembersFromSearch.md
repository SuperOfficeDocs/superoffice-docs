---
uid: services88-selection-removeselectionmembersfromsearch
title: Services88.SelectionAgent.RemoveSelectionMembersFromSearch SOAP
Generated: true
---

# Services88 Selection RemoveSelectionMembersFromSearch SOAP

SOAP request and response examples **Remote/Services88/Selection.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ISelectionAgent.RemoveSelectionMembersFromSearch">SuperOffice.Services88.ISelectionAgent.RemoveSelectionMembersFromSearch</see> method.

## RemoveSelectionMembersFromSearch

Removes members from the selection using the search result.

* **selectionId:** The id of the selection to remove members.
* **storageKey:** Storage key to be interpreted by the restriction storage provider, when it fetches criteria for the search.

**Returns:** Number of members removed


[WSDL file for Services88/Selection](../Services88-Selection.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## RemoveSelectionMembersFromSearch Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Selection:ApplicationToken>1234567-1234-9876</Selection:ApplicationToken>
  <Selection:Credentials>
    <Selection:Ticket>7T:1234abcxyzExample==</Selection:Ticket>
  </Selection:Credentials>
 <SOAP-ENV:Body>
   <Selection:RemoveSelectionMembersFromSearch>
    <Selection:SelectionId xsi:type="xsd:int">0</Selection:SelectionId>
    <Selection:StorageKey xsi:type="xsd:string"></Selection:StorageKey>
   </Selection:RemoveSelectionMembersFromSearch>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## RemoveSelectionMembersFromSearch Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Selection:RemoveSelectionMembersFromSearchResponse>
   <Selection:Response xsi:type="xsd:int">0</Selection:Response>
  </Selection:RemoveSelectionMembersFromSearchResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

