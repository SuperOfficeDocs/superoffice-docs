---
title: Services84.SelectionAgent.AddRemoveContactSelectionMemberInterests SOAP
generated: 1
uid: Services84-Selection-AddRemoveContactSelectionMemberInterests
---

# Services84 Selection AddRemoveContactSelectionMemberInterests

SOAP request and response examples **Remote/Services84/Selection.svc**
Implemented by the <see cref="M:SuperOffice.Services84.ISelectionAgent.AddRemoveContactSelectionMemberInterests">SuperOffice.Services84.ISelectionAgent.AddRemoveContactSelectionMemberInterests</see> method.

## AddRemoveContactSelectionMemberInterests

Adds or removes interests on companies and persons in a selection.

* **selectionId:** The id of the selection to add or remove interests members from.
* **addCompanyInterests:** Array of int containing the id's of the interests to add to the company.
* **removeCompanyInterests:** Array of int containing the id's of the interests to remove from the company.
* **addContactInterests:** Array of int containing the id's of the interests to add to the contact.
* **removeContactInterests:** Array of int containing the id's of the interests to remove from the contact.



[WSDL file for Services84/Selection](../Services84-Selection.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## AddRemoveContactSelectionMemberInterests Request

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
   <Selection:AddRemoveContactSelectionMemberInterests>
    <Selection:SelectionId xsi:type="xsd:int">0</Selection:SelectionId>
    <Selection:AddCompanyInterests xsi:type="NetServerServices842:ArrayOfint">
     <NetServerServices842:int xsi:type="xsd:int">0</NetServerServices842:int>
    </Selection:AddCompanyInterests>
    <Selection:RemoveCompanyInterests xsi:type="NetServerServices842:ArrayOfint">
     <NetServerServices842:int xsi:type="xsd:int">0</NetServerServices842:int>
    </Selection:RemoveCompanyInterests>
    <Selection:AddContactInterests xsi:type="NetServerServices842:ArrayOfint">
     <NetServerServices842:int xsi:type="xsd:int">0</NetServerServices842:int>
    </Selection:AddContactInterests>
    <Selection:RemoveContactInterests xsi:type="NetServerServices842:ArrayOfint">
     <NetServerServices842:int xsi:type="xsd:int">0</NetServerServices842:int>
    </Selection:RemoveContactInterests>
   </Selection:AddRemoveContactSelectionMemberInterests>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## AddRemoveContactSelectionMemberInterests Response

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
  <Selection:AddRemoveContactSelectionMemberInterestsResponse>
  </Selection:AddRemoveContactSelectionMemberInterestsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

