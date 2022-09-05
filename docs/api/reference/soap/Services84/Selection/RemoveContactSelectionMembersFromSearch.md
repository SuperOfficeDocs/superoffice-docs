---
title: Services84.SelectionAgent.RemoveContactSelectionMembersFromSearch SOAP
generated: 1
uid: Services84-Selection-RemoveContactSelectionMembersFromSearch
---

# Services84 Selection RemoveContactSelectionMembersFromSearch

SOAP request and response examples **Remote/Services84/Selection.svc**
Implemented by the <see cref="M:SuperOffice.Services84.ISelectionAgent.RemoveContactSelectionMembersFromSearch">SuperOffice.Services84.ISelectionAgent.RemoveContactSelectionMembersFromSearch</see> method.

## RemoveContactSelectionMembersFromSearch

Removes members from the selection using the search result.

* **selectionId:** The id of the selection to remove members.
* **storageKey:** Storage key to be interpreted by the restriction storage provider, when it fetches criteria for the search.

**Returns:** Number of members removed


[WSDL file for Services84/Selection](../Services84-Selection.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## RemoveContactSelectionMembersFromSearch Request

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
   <Selection:RemoveContactSelectionMembersFromSearch>
    <Selection:SelectionId xsi:type="xsd:int">0</Selection:SelectionId>
    <Selection:StorageKey xsi:type="xsd:string"></Selection:StorageKey>
   </Selection:RemoveContactSelectionMembersFromSearch>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## RemoveContactSelectionMembersFromSearch Response

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
  <Selection:RemoveContactSelectionMembersFromSearchResponse>
   <Selection:Response xsi:type="xsd:int">0</Selection:Response>
  </Selection:RemoveContactSelectionMembersFromSearchResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

