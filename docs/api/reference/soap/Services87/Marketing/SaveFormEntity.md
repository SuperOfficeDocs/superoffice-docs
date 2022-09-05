---
title: Services87.MarketingAgent.SaveFormEntity SOAP
generated: 1
uid: Services87-Marketing-SaveFormEntity
---

# Services87 Marketing SaveFormEntity

SOAP request and response examples **Remote/Services87/Marketing.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IMarketingAgent.SaveFormEntity">SuperOffice.Services87.IMarketingAgent.SaveFormEntity</see> method.

## SaveFormEntity

Updates the existing FormEntity or creates a new FormEntity if the id parameter is 0.

* **formEntity:** The FormEntity that is saved.

**Returns:** New or updated FormEntity


[WSDL file for Services87/Marketing](../Services87-Marketing.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveFormEntity Request

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
   <Marketing:SaveFormEntity>
    <Marketing:FormEntity xsi:type="Marketing:FormEntity">
     <Marketing:FormId xsi:type="xsd:int">0</Marketing:FormId>
     <Marketing:FormKey xsi:type="xsd:string"></Marketing:FormKey>
     <Marketing:Name xsi:type="xsd:string"></Marketing:Name>
     <Marketing:Description xsi:type="xsd:string"></Marketing:Description>
     <Marketing:Config xsi:type="xsd:string"></Marketing:Config>
     <Marketing:FolderId xsi:type="xsd:int">0</Marketing:FolderId>
     <Marketing:ScriptId xsi:type="xsd:int">0</Marketing:ScriptId>
     <Marketing:ResponseShipmentId xsi:type="xsd:int">0</Marketing:ResponseShipmentId>
     <Marketing:Active xsi:type="xsd:boolean">false</Marketing:Active>
     <Marketing:Expires xsi:type="xsd:dateTime">2022-08-26T08:57:27Z</Marketing:Expires>
     <Marketing:MaxSubmits xsi:type="xsd:int">0</Marketing:MaxSubmits>
     <Marketing:Type xsi:type="Marketing:FormType">Normal</Marketing:Type>
     <Marketing:Recipe xsi:type="xsd:string"></Marketing:Recipe>
     <Marketing:GroupId xsi:type="xsd:int">0</Marketing:GroupId>
     <Marketing:NewTicket xsi:type="xsd:boolean">false</Marketing:NewTicket>
     <Marketing:RecaptchaMode xsi:type="Marketing:FormsRecaptchaMode">NotAvailable</Marketing:RecaptchaMode>
     <Marketing:Registered xsi:type="xsd:dateTime">2022-08-26T08:57:27Z</Marketing:Registered>
     <Marketing:RegisteredAssociateId xsi:type="xsd:int">0</Marketing:RegisteredAssociateId>
     <Marketing:Updated xsi:type="xsd:dateTime">2022-08-26T08:57:27Z</Marketing:Updated>
     <Marketing:UpdatedAssociateId xsi:type="xsd:int">0</Marketing:UpdatedAssociateId>
     <Marketing:UpdatedCount xsi:type="xsd:short">0</Marketing:UpdatedCount>
     <Marketing:FolderName xsi:type="xsd:string"></Marketing:FolderName>
    </Marketing:FormEntity>
   </Marketing:SaveFormEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveFormEntity Response

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
  <Marketing:SaveFormEntityResponse>
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
    <Marketing:Expires xsi:type="xsd:dateTime">2022-08-26T08:57:27Z</Marketing:Expires>
    <Marketing:MaxSubmits xsi:type="xsd:int">0</Marketing:MaxSubmits>
    <Marketing:Type xsi:type="Marketing:FormType">Normal</Marketing:Type>
    <Marketing:Recipe xsi:type="xsd:string"></Marketing:Recipe>
    <Marketing:GroupId xsi:type="xsd:int">0</Marketing:GroupId>
    <Marketing:NewTicket xsi:type="xsd:boolean">false</Marketing:NewTicket>
    <Marketing:RecaptchaMode xsi:type="Marketing:FormsRecaptchaMode">NotAvailable</Marketing:RecaptchaMode>
    <Marketing:Registered xsi:type="xsd:dateTime">2022-08-26T08:57:27Z</Marketing:Registered>
    <Marketing:RegisteredAssociateId xsi:type="xsd:int">0</Marketing:RegisteredAssociateId>
    <Marketing:Updated xsi:type="xsd:dateTime">2022-08-26T08:57:27Z</Marketing:Updated>
    <Marketing:UpdatedAssociateId xsi:type="xsd:int">0</Marketing:UpdatedAssociateId>
    <Marketing:UpdatedCount xsi:type="xsd:short">0</Marketing:UpdatedCount>
    <Marketing:FolderName xsi:type="xsd:string"></Marketing:FolderName>
   </Marketing:Response>
  </Marketing:SaveFormEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

