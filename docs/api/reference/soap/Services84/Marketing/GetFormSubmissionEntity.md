---
title: Services84.MarketingAgent.GetFormSubmissionEntity SOAP
generated: 1
uid: Services84-Marketing-GetFormSubmissionEntity
---

# Services84 Marketing GetFormSubmissionEntity

SOAP request and response examples **Remote/Services84/Marketing.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IMarketingAgent.GetFormSubmissionEntity">SuperOffice.Services84.IMarketingAgent.GetFormSubmissionEntity</see> method.

## GetFormSubmissionEntity

Gets a FormSubmissionEntity object.

* **formSubmissionEntityId:** The identifier of the FormSubmissionEntity object

**Returns:** FormSubmissionEntity

[WSDL file for Services84/Marketing](../Services84-Marketing.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetFormSubmissionEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Marketing="http://www.superoffice.net/ws/crm/NetServer/Services84">
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
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Marketing="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Marketing:GetFormSubmissionEntityResponse>
   <Marketing:Response xsi:type="Marketing:FormSubmissionEntity">
    <Marketing:FormSubmissionId xsi:type="xsd:int">0</Marketing:FormSubmissionId>
    <Marketing:FormId xsi:type="xsd:int">0</Marketing:FormId>
    <Marketing:WhenSubmitted xsi:type="xsd:dateTime">2021-11-30T13:22:15Z</Marketing:WhenSubmitted>
    <Marketing:ContactId xsi:type="xsd:int">0</Marketing:ContactId>
    <Marketing:PersonId xsi:type="xsd:int">0</Marketing:PersonId>
    <Marketing:EmailAddress xsi:type="xsd:string"></Marketing:EmailAddress>
    <Marketing:ResponseShipmentAddrId xsi:type="xsd:int">0</Marketing:ResponseShipmentAddrId>
    <Marketing:Response xsi:type="xsd:string"></Marketing:Response>
   </Marketing:Response>
  </Marketing:GetFormSubmissionEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```
