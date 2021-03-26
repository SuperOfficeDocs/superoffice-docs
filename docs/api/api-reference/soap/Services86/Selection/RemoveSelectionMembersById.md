---
uid: services86-selection-removeselectionmembersbyid
title: Services86.SelectionAgent.RemoveSelectionMembersById SOAP
Generated: true
---

# Services86 Selection RemoveSelectionMembersById SOAP

SOAP request and response examples **Remote/Services86/Selection.svc**
Implemented by the <see cref="M:SuperOffice.Services86.ISelectionAgent.RemoveSelectionMembersById">SuperOffice.Services86.ISelectionAgent.RemoveSelectionMembersById</see> method.

## RemoveSelectionMembersById

Removes members from the selection as specified in the collection of entity ids. The ids can be a collection of sale ids, or other supported types.

* **selectionId:** The id of the selection where to members will be removed.
* **ids:** A collection of sale/project/contact ids to remove from the selection. The ids can be a collection of sale ids, or other supported types.



[WSDL file for Services86/Selection](../Services86-Selection.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## RemoveSelectionMembersById Request

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
   <Selection:RemoveSelectionMembersById>
    <Selection:SelectionId xsi:type="xsd:int">0</Selection:SelectionId>
    <Selection:Ids xsi:type="NetServerServices862:ArrayOfint">
     <NetServerServices862:int xsi:type="xsd:int">0</NetServerServices862:int>
    </Selection:Ids>
   </Selection:RemoveSelectionMembersById>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## RemoveSelectionMembersById Response

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
  <Selection:RemoveSelectionMembersByIdResponse>
  </Selection:RemoveSelectionMembersByIdResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

