---
uid: services88-marketing-saveformsubmissionentity
title: Services88.MarketingAgent.SaveFormSubmissionEntity SOAP
Generated: true
---

# Services88 Marketing SaveFormSubmissionEntity SOAP

SOAP request and response examples **Remote/Services88/Marketing.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IMarketingAgent.SaveFormSubmissionEntity">SuperOffice.Services88.IMarketingAgent.SaveFormSubmissionEntity</see> method.

## SaveFormSubmissionEntity

Updates the existing FormSubmissionEntity or creates a new FormSubmissionEntity if the id parameter is 0.

* **formSubmissionEntity:** The FormSubmissionEntity that is saved.

**Returns:** New or updated FormSubmissionEntity


[WSDL file for Services88/Marketing](../Services88-Marketing.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveFormSubmissionEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Marketing="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Marketing:ApplicationToken>1234567-1234-9876</Marketing:ApplicationToken>
  <Marketing:Credentials>
    <Marketing:Ticket>7T:1234abcxyzExample==</Marketing:Ticket>
  </Marketing:Credentials>
 <SOAP-ENV:Body>
   <Marketing:SaveFormSubmissionEntity>
    <Marketing:FormSubmissionEntity xsi:type="Marketing:FormSubmissionEntity">
     <Marketing:FormSubmissionId xsi:type="xsd:int">0</Marketing:FormSubmissionId>
     <Marketing:FormId xsi:type="xsd:int">0</Marketing:FormId>
     <Marketing:WhenSubmitted xsi:type="xsd:dateTime">2021-03-25T21:37:03Z</Marketing:WhenSubmitted>
     <Marketing:ContactId xsi:type="xsd:int">0</Marketing:ContactId>
     <Marketing:PersonId xsi:type="xsd:int">0</Marketing:PersonId>
     <Marketing:EmailAddress xsi:type="xsd:string"></Marketing:EmailAddress>
     <Marketing:ResponseShipmentAddrId xsi:type="xsd:int">0</Marketing:ResponseShipmentAddrId>
     <Marketing:Response xsi:type="xsd:string"></Marketing:Response>
     <Marketing:Status xsi:type="Marketing:FormSubmissionStatus">Unknown</Marketing:Status>
     <Marketing:ProcessingLog xsi:type="xsd:string"></Marketing:ProcessingLog>
    </Marketing:FormSubmissionEntity>
   </Marketing:SaveFormSubmissionEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveFormSubmissionEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Marketing="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Marketing:SaveFormSubmissionEntityResponse>
   <Marketing:Response xsi:type="Marketing:FormSubmissionEntity">
    <Marketing:FormSubmissionId xsi:type="xsd:int">0</Marketing:FormSubmissionId>
    <Marketing:FormId xsi:type="xsd:int">0</Marketing:FormId>
    <Marketing:WhenSubmitted xsi:type="xsd:dateTime">2021-03-25T21:37:03Z</Marketing:WhenSubmitted>
    <Marketing:ContactId xsi:type="xsd:int">0</Marketing:ContactId>
    <Marketing:PersonId xsi:type="xsd:int">0</Marketing:PersonId>
    <Marketing:EmailAddress xsi:type="xsd:string"></Marketing:EmailAddress>
    <Marketing:ResponseShipmentAddrId xsi:type="xsd:int">0</Marketing:ResponseShipmentAddrId>
    <Marketing:Response xsi:type="xsd:string"></Marketing:Response>
    <Marketing:Status xsi:type="Marketing:FormSubmissionStatus">Unknown</Marketing:Status>
    <Marketing:ProcessingLog xsi:type="xsd:string"></Marketing:ProcessingLog>
   </Marketing:Response>
  </Marketing:SaveFormSubmissionEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

