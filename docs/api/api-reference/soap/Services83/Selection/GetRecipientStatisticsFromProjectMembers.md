---
uid: services83-selection-getrecipientstatisticsfromprojectmembers
title: Services83.SelectionAgent.GetRecipientStatisticsFromProjectMembers SOAP
Generated: true
---

# Services83 Selection GetRecipientStatisticsFromProjectMembers SOAP

SOAP request and response examples **Remote/Services83/Selection.svc**
Implemented by the <see cref="M:SuperOffice.Services83.ISelectionAgent.GetRecipientStatisticsFromProjectMembers">SuperOffice.Services83.ISelectionAgent.GetRecipientStatisticsFromProjectMembers</see> method.

## GetRecipientStatisticsFromProjectMembers

Returns a RecipientStatistics object with a count of addresses, emailaddresses and emailaddresses based on members in a project.

* **projectId:** The id of the project to get the member statistics for.

**Returns:** Returns a RecipientStatistics object.


[WSDL file for Services83/Selection](../Services83-Selection.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetRecipientStatisticsFromProjectMembers Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services83">
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
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services83">
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

