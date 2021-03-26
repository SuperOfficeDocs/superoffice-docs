---
uid: services80-selection-getrecipientstatistics
title: Services80.SelectionAgent.GetRecipientStatistics SOAP
Generated: true
---

# Services80 Selection GetRecipientStatistics SOAP

SOAP request and response examples **Remote/Services80/Selection.svc**
Implemented by the <see cref="M:SuperOffice.Services80.ISelectionAgent.GetRecipientStatistics">SuperOffice.Services80.ISelectionAgent.GetRecipientStatistics</see> method.

## GetRecipientStatistics

Returns a RecipientStatistics object with a count of addresses, emailaddresses and emailaddresses.

* **selectionId:** The id of the selection to get the statistics for.

**Returns:** Returns a RecipientStatistics object.


[WSDL file for Services80/Selection](../Services80-Selection.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetRecipientStatistics Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services80">
  <Selection:ApplicationToken>1234567-1234-9876</Selection:ApplicationToken>
  <Selection:Credentials>
    <Selection:Ticket>7T:1234abcxyzExample==</Selection:Ticket>
  </Selection:Credentials>
 <SOAP-ENV:Body>
   <Selection:GetRecipientStatistics>
    <Selection:SelectionId xsi:type="xsd:int">0</Selection:SelectionId>
   </Selection:GetRecipientStatistics>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetRecipientStatistics Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <Selection:GetRecipientStatisticsResponse>
   <Selection:Response xsi:type="Selection:RecipientStatistics">
    <Selection:Total xsi:type="xsd:int">0</Selection:Total>
    <Selection:ValidPostalAddresses xsi:type="xsd:int">0</Selection:ValidPostalAddresses>
    <Selection:ValidEmailAddresses xsi:type="xsd:int">0</Selection:ValidEmailAddresses>
    <Selection:ValidFaxNumbers xsi:type="xsd:int">0</Selection:ValidFaxNumbers>
    <Selection:NoAddresses xsi:type="xsd:int">0</Selection:NoAddresses>
    <Selection:NoFaxOrEmails xsi:type="xsd:int">0</Selection:NoFaxOrEmails>
   </Selection:Response>
  </Selection:GetRecipientStatisticsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

