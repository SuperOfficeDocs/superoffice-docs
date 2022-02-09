---
title: Services87.MarketingAgent.CreateDefaultFormSubmissionEntity SOAP
generated: 1
uid: Services87-Marketing-CreateDefaultFormSubmissionEntity
---

# Services87 Marketing CreateDefaultFormSubmissionEntity

SOAP request and response examples **Remote/Services87/Marketing.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IMarketingAgent.CreateDefaultFormSubmissionEntity">SuperOffice.Services87.IMarketingAgent.CreateDefaultFormSubmissionEntity</see> method.

## CreateDefaultFormSubmissionEntity

Loading default values into a new FormSubmissionEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance


**Returns:** New FormSubmissionEntity with default values


[WSDL file for Services87/Marketing](../Services87-Marketing.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultFormSubmissionEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Marketing="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Marketing:ApplicationToken>1234567-1234-9876</Marketing:ApplicationToken>
  <Marketing:Credentials>
    <Marketing:Ticket>7T:1234abcxyzExample==</Marketing:Ticket>
  </Marketing:Credentials>
 <SOAP-ENV:Body>
   <Marketing:CreateDefaultFormSubmissionEntity>
   </Marketing:CreateDefaultFormSubmissionEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultFormSubmissionEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Marketing="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Marketing:CreateDefaultFormSubmissionEntityResponse>
   <Marketing:Response xsi:type="Marketing:FormSubmissionEntity">
    <Marketing:FormSubmissionId xsi:type="xsd:int">0</Marketing:FormSubmissionId>
    <Marketing:FormId xsi:type="xsd:int">0</Marketing:FormId>
    <Marketing:WhenSubmitted xsi:type="xsd:dateTime">2021-11-30T13:23:21Z</Marketing:WhenSubmitted>
    <Marketing:ContactId xsi:type="xsd:int">0</Marketing:ContactId>
    <Marketing:PersonId xsi:type="xsd:int">0</Marketing:PersonId>
    <Marketing:EmailAddress xsi:type="xsd:string"></Marketing:EmailAddress>
    <Marketing:ResponseShipmentAddrId xsi:type="xsd:int">0</Marketing:ResponseShipmentAddrId>
    <Marketing:Response xsi:type="xsd:string"></Marketing:Response>
    <Marketing:Status xsi:type="Marketing:FormSubmissionStatus">Unknown</Marketing:Status>
    <Marketing:ProcessingLog xsi:type="xsd:string"></Marketing:ProcessingLog>
   </Marketing:Response>
  </Marketing:CreateDefaultFormSubmissionEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

