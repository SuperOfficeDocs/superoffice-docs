---
uid: services85-marketing-getformsubmissionentity
title: Services85.MarketingAgent.GetFormSubmissionEntity SOAP
Generated: true
---

# Services85 Marketing GetFormSubmissionEntity SOAP

SOAP request and response examples **Remote/Services85/Marketing.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IMarketingAgent.GetFormSubmissionEntity">SuperOffice.Services85.IMarketingAgent.GetFormSubmissionEntity</see> method.

## GetFormSubmissionEntity

Gets a FormSubmissionEntity object.

* **formSubmissionEntityId:** The identifier of the FormSubmissionEntity object

**Returns:** FormSubmissionEntity


[WSDL file for Services85/Marketing](../Services85-Marketing.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetFormSubmissionEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Marketing="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Marketing:ApplicationToken>1234567-1234-9876</Marketing:ApplicationToken>
  <Marketing:Credentials>
    <Marketing:Ticket>7T:1234abcxyzExample==</Marketing:Ticket>
  </Marketing:Credentials>
 <SOAP-ENV:Body>
   <Marketing:GetFormSubmissionEntity>
    <Marketing:FormSubmissionEntityId xsi:type="xsd:int">0</Marketing:FormSubmissionEntityId>
   </Marketing:GetFormSubmissionEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetFormSubmissionEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Marketing="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Marketing:GetFormSubmissionEntityResponse>
   <Marketing:Response xsi:type="Marketing:FormSubmissionEntity">
    <Marketing:FormSubmissionId xsi:type="xsd:int">0</Marketing:FormSubmissionId>
    <Marketing:FormId xsi:type="xsd:int">0</Marketing:FormId>
    <Marketing:WhenSubmitted xsi:type="xsd:dateTime">2021-03-25T21:35:51Z</Marketing:WhenSubmitted>
    <Marketing:ContactId xsi:type="xsd:int">0</Marketing:ContactId>
    <Marketing:PersonId xsi:type="xsd:int">0</Marketing:PersonId>
    <Marketing:EmailAddress xsi:type="xsd:string"></Marketing:EmailAddress>
    <Marketing:ResponseShipmentAddrId xsi:type="xsd:int">0</Marketing:ResponseShipmentAddrId>
    <Marketing:Response xsi:type="xsd:string"></Marketing:Response>
    <Marketing:Status xsi:type="Marketing:FormSubmissionStatus">Unknown</Marketing:Status>
    <Marketing:ProcessingLog xsi:type="xsd:string"></Marketing:ProcessingLog>
   </Marketing:Response>
  </Marketing:GetFormSubmissionEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

