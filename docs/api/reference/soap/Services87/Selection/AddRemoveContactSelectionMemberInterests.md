---
title: Services87.SelectionAgent.AddRemoveContactSelectionMemberInterests SOAP
generated: 1
uid: Services87-Selection-AddRemoveContactSelectionMemberInterests
---

# Services87 Selection AddRemoveContactSelectionMemberInterests

SOAP request and response examples **Remote/Services87/Selection.svc**
Implemented by the <see cref="M:SuperOffice.Services87.ISelectionAgent.AddRemoveContactSelectionMemberInterests">SuperOffice.Services87.ISelectionAgent.AddRemoveContactSelectionMemberInterests</see> method.

## AddRemoveContactSelectionMemberInterests

Adds or removes interests on companies and persons in a selection.

* **selectionId:** The id of the selection to add or remove interests members from.
* **addCompanyInterests:** Array of int containing the id's of the interests to add to the company.
* **removeCompanyInterests:** Array of int containing the id's of the interests to remove from the company.
* **addContactInterests:** Array of int containing the id's of the interests to add to the contact.
* **removeContactInterests:** Array of int containing the id's of the interests to remove from the contact.



[WSDL file for Services87/Selection](../Services87-Selection.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## AddRemoveContactSelectionMemberInterests Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Selection:ApplicationToken>1234567-1234-9876</Selection:ApplicationToken>
  <Selection:Credentials>
    <Selection:Ticket>7T:1234abcxyzExample==</Selection:Ticket>
  </Selection:Credentials>
 <SOAP-ENV:Body>
   <Selection:AddRemoveContactSelectionMemberInterests>
    <Selection:SelectionId xsi:type="xsd:int">0</Selection:SelectionId>
    <Selection:AddCompanyInterests xsi:type="NetServerServices872:ArrayOfint">
     <NetServerServices872:int xsi:type="xsd:int">0</NetServerServices872:int>
    </Selection:AddCompanyInterests>
    <Selection:RemoveCompanyInterests xsi:type="NetServerServices872:ArrayOfint">
     <NetServerServices872:int xsi:type="xsd:int">0</NetServerServices872:int>
    </Selection:RemoveCompanyInterests>
    <Selection:AddContactInterests xsi:type="NetServerServices872:ArrayOfint">
     <NetServerServices872:int xsi:type="xsd:int">0</NetServerServices872:int>
    </Selection:AddContactInterests>
    <Selection:RemoveContactInterests xsi:type="NetServerServices872:ArrayOfint">
     <NetServerServices872:int xsi:type="xsd:int">0</NetServerServices872:int>
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
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Selection:AddRemoveContactSelectionMemberInterestsResponse>
  </Selection:AddRemoveContactSelectionMemberInterestsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

