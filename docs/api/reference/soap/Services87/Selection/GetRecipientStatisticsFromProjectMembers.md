---
title: Services87.SelectionAgent.GetRecipientStatisticsFromProjectMembers SOAP
generated: 1
uid: Services87-Selection-GetRecipientStatisticsFromProjectMembers
---

# Services87 Selection GetRecipientStatisticsFromProjectMembers

SOAP request and response examples **Remote/Services87/Selection.svc**
Implemented by the <see cref="M:SuperOffice.Services87.ISelectionAgent.GetRecipientStatisticsFromProjectMembers">SuperOffice.Services87.ISelectionAgent.GetRecipientStatisticsFromProjectMembers</see> method.

## GetRecipientStatisticsFromProjectMembers

Returns a RecipientStatistics object with a count of addresses, emailaddresses and emailaddresses based on members in a project.

* **projectId:** The id of the project to get the member statistics for.

**Returns:** Returns a RecipientStatistics object.


[WSDL file for Services87/Selection](../Services87-Selection.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetRecipientStatisticsFromProjectMembers Request

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
   <Selection:GetRecipientStatisticsFromProjectMembers>
    <Selection:ProjectId xsi:type="xsd:int">0</Selection:ProjectId>
   </Selection:GetRecipientStatisticsFromProjectMembers>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetRecipientStatisticsFromProjectMembers Response

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
  <Selection:GetRecipientStatisticsFromProjectMembersResponse>
   <Selection:Response xsi:type="Selection:RecipientStatistics">
    <Selection:Total xsi:type="xsd:int">0</Selection:Total>
    <Selection:ValidPostalAddresses xsi:type="xsd:int">0</Selection:ValidPostalAddresses>
    <Selection:ValidEmailAddresses xsi:type="xsd:int">0</Selection:ValidEmailAddresses>
    <Selection:ValidFaxNumbers xsi:type="xsd:int">0</Selection:ValidFaxNumbers>
    <Selection:NoAddresses xsi:type="xsd:int">0</Selection:NoAddresses>
    <Selection:NoFaxOrEmails xsi:type="xsd:int">0</Selection:NoFaxOrEmails>
   </Selection:Response>
  </Selection:GetRecipientStatisticsFromProjectMembersResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

