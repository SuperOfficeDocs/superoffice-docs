---
title: Services85.ErpSyncAgent.GetErpFieldValues SOAP
generated: 1
uid: Services85-ErpSync-GetErpFieldValues
---

# Services85 ErpSync GetErpFieldValues

SOAP request and response examples **Remote/Services85/ErpSync.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IErpSyncAgent.GetErpFieldValues">SuperOffice.Services85.IErpSyncAgent.GetErpFieldValues</see> method.

## GetErpFieldValues

Get the values for the specified fields from the ERP connection

* **erpConnectionId:** The id of the connection
* **crmActorType:** The type of the CRM entity
* **entityId:** The id of the entity
* **fieldKeys:** The fields for which you want to get the values

**Returns:** An array containing the values for the specified fields, in the same order


[WSDL file for Services85/ErpSync](../Services85-ErpSync.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetErpFieldValues Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <ErpSync:ApplicationToken>1234567-1234-9876</ErpSync:ApplicationToken>
  <ErpSync:Credentials>
    <ErpSync:Ticket>7T:1234abcxyzExample==</ErpSync:Ticket>
  </ErpSync:Credentials>
 <SOAP-ENV:Body>
   <ErpSync:GetErpFieldValues>
    <ErpSync:ErpConnectionId xsi:type="xsd:int">0</ErpSync:ErpConnectionId>
    <ErpSync:CrmActorType xsi:type="ErpSync:CrmActorType">Unknown</ErpSync:CrmActorType>
    <ErpSync:EntityId xsi:type="xsd:int">0</ErpSync:EntityId>
    <ErpSync:FieldKeys xsi:type="NetServerServices852:ArrayOfstring">
     <NetServerServices852:string xsi:type="xsd:string"></NetServerServices852:string>
    </ErpSync:FieldKeys>
   </ErpSync:GetErpFieldValues>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetErpFieldValues Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <ErpSync:GetErpFieldValuesResponse>
   <ErpSync:Response xsi:type="NetServerServices852:ArrayOfstring">
    <NetServerServices852:string xsi:type="xsd:string"></NetServerServices852:string>
   </ErpSync:Response>
  </ErpSync:GetErpFieldValuesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

