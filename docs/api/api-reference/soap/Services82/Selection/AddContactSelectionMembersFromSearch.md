---
uid: services82-selection-addcontactselectionmembersfromsearch
title: Services82.SelectionAgent.AddContactSelectionMembersFromSearch SOAP
Generated: true
---

# Services82 Selection AddContactSelectionMembersFromSearch SOAP

SOAP request and response examples **Remote/Services82/Selection.svc**
Implemented by the <see cref="M:SuperOffice.Services82.ISelectionAgent.AddContactSelectionMembersFromSearch">SuperOffice.Services82.ISelectionAgent.AddContactSelectionMembersFromSearch</see> method.

## AddContactSelectionMembersFromSearch

Adds members to the selection from the search result.

* **selectionId:** The id of the selection to add members
* **storageKey:** Storage key to be interpreted by the restriction storage provider, when it fetches criteria for the search

**Returns:** Number of members added


[WSDL file for Services82/Selection](../Services82-Selection.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## AddContactSelectionMembersFromSearch Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services82">
  <Selection:ApplicationToken>1234567-1234-9876</Selection:ApplicationToken>
  <Selection:Credentials>
    <Selection:Ticket>7T:1234abcxyzExample==</Selection:Ticket>
  </Selection:Credentials>
 <SOAP-ENV:Body>
   <Selection:AddContactSelectionMembersFromSearch>
    <Selection:SelectionId xsi:type="xsd:int">0</Selection:SelectionId>
    <Selection:StorageKey xsi:type="xsd:string"></Selection:StorageKey>
   </Selection:AddContactSelectionMembersFromSearch>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## AddContactSelectionMembersFromSearch Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services82">
 <SOAP-ENV:Body>
  <Selection:AddContactSelectionMembersFromSearchResponse>
   <Selection:Response xsi:type="xsd:int">0</Selection:Response>
  </Selection:AddContactSelectionMembersFromSearchResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

