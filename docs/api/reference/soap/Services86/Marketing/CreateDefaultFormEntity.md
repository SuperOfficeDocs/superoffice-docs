---
title: Services86.MarketingAgent.CreateDefaultFormEntity SOAP
generated: 1
uid: Services86-Marketing-CreateDefaultFormEntity
---

# Services86 Marketing CreateDefaultFormEntity

SOAP request and response examples **Remote/Services86/Marketing.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IMarketingAgent.CreateDefaultFormEntity">SuperOffice.Services86.IMarketingAgent.CreateDefaultFormEntity</see> method.

## CreateDefaultFormEntity

Loading default values into a new FormEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance


**Returns:** New FormEntity with default values


[WSDL file for Services86/Marketing](../Services86-Marketing.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultFormEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Marketing="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Marketing:ApplicationToken>1234567-1234-9876</Marketing:ApplicationToken>
  <Marketing:Credentials>
    <Marketing:Ticket>7T:1234abcxyzExample==</Marketing:Ticket>
  </Marketing:Credentials>
 <SOAP-ENV:Body>
   <Marketing:CreateDefaultFormEntity>
   </Marketing:CreateDefaultFormEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultFormEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Marketing="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Marketing:CreateDefaultFormEntityResponse>
   <Marketing:Response xsi:type="Marketing:FormEntity">
    <Marketing:FormId xsi:type="xsd:int">0</Marketing:FormId>
    <Marketing:FormKey xsi:type="xsd:string"></Marketing:FormKey>
    <Marketing:Name xsi:type="xsd:string"></Marketing:Name>
    <Marketing:Description xsi:type="xsd:string"></Marketing:Description>
    <Marketing:Config xsi:type="xsd:string"></Marketing:Config>
    <Marketing:FolderId xsi:type="xsd:int">0</Marketing:FolderId>
    <Marketing:ScriptId xsi:type="xsd:int">0</Marketing:ScriptId>
    <Marketing:ResponseShipmentId xsi:type="xsd:int">0</Marketing:ResponseShipmentId>
    <Marketing:Active xsi:type="xsd:boolean">false</Marketing:Active>
    <Marketing:Expires xsi:type="xsd:dateTime">2021-11-30T13:22:58Z</Marketing:Expires>
    <Marketing:MaxSubmits xsi:type="xsd:int">0</Marketing:MaxSubmits>
    <Marketing:Type xsi:type="Marketing:FormType">Normal</Marketing:Type>
    <Marketing:Recipe xsi:type="xsd:string"></Marketing:Recipe>
    <Marketing:GroupId xsi:type="xsd:int">0</Marketing:GroupId>
    <Marketing:Registered xsi:type="xsd:dateTime">2021-11-30T13:22:58Z</Marketing:Registered>
    <Marketing:RegisteredAssociateId xsi:type="xsd:int">0</Marketing:RegisteredAssociateId>
    <Marketing:Updated xsi:type="xsd:dateTime">2021-11-30T13:22:58Z</Marketing:Updated>
    <Marketing:UpdatedAssociateId xsi:type="xsd:int">0</Marketing:UpdatedAssociateId>
    <Marketing:UpdatedCount xsi:type="xsd:short">0</Marketing:UpdatedCount>
    <Marketing:FolderName xsi:type="xsd:string"></Marketing:FolderName>
   </Marketing:Response>
  </Marketing:CreateDefaultFormEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

