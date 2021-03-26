---
uid: services88-selection-getrecipientstatisticsfromcontactpersonids
title: Services88.SelectionAgent.GetRecipientStatisticsFromContactPersonIds SOAP
Generated: true
---

# Services88 Selection GetRecipientStatisticsFromContactPersonIds SOAP

SOAP request and response examples **Remote/Services88/Selection.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ISelectionAgent.GetRecipientStatisticsFromContactPersonIds">SuperOffice.Services88.ISelectionAgent.GetRecipientStatisticsFromContactPersonIds</see> method.

## GetRecipientStatisticsFromContactPersonIds

Returns a RecipientStatistics object with a count of addresses, emailaddresses and emailaddresses based on contact and persons in a collection of ContactPersonId.

* **contactPersonIds:** A collection of ContactPersonId to get the statistics for.

**Returns:** Returns a RecipientStatistics object.


[WSDL file for Services88/Selection](../Services88-Selection.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetRecipientStatisticsFromContactPersonIds Request

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
   <Selection:GetRecipientStatisticsFromContactPersonIds>
    <Selection:ContactPersonIds xsi:type="Selection:ArrayOfContactPersonId">
     <Selection:ContactPersonId xsi:type="Selection:ContactPersonId">
      <Selection:PersonId xsi:type="xsd:int">0</Selection:PersonId>
      <Selection:ContactId xsi:type="xsd:int">0</Selection:ContactId>
     </Selection:ContactPersonId>
    </Selection:ContactPersonIds>
   </Selection:GetRecipientStatisticsFromContactPersonIds>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetRecipientStatisticsFromContactPersonIds Response

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
  <Selection:GetRecipientStatisticsFromContactPersonIdsResponse>
   <Selection:Response xsi:type="Selection:RecipientStatistics">
    <Selection:Total xsi:type="xsd:int">0</Selection:Total>
    <Selection:ValidPostalAddresses xsi:type="xsd:int">0</Selection:ValidPostalAddresses>
    <Selection:ValidEmailAddresses xsi:type="xsd:int">0</Selection:ValidEmailAddresses>
    <Selection:ValidFaxNumbers xsi:type="xsd:int">0</Selection:ValidFaxNumbers>
    <Selection:NoAddresses xsi:type="xsd:int">0</Selection:NoAddresses>
    <Selection:NoFaxOrEmails xsi:type="xsd:int">0</Selection:NoFaxOrEmails>
   </Selection:Response>
  </Selection:GetRecipientStatisticsFromContactPersonIdsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

