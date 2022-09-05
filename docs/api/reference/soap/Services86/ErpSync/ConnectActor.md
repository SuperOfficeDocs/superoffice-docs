---
title: Services86.ErpSyncAgent.ConnectActor SOAP
generated: 1
uid: Services86-ErpSync-ConnectActor
---

# Services86 ErpSync ConnectActor

SOAP request and response examples **Remote/Services86/ErpSync.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IErpSyncAgent.ConnectActor">SuperOffice.Services86.IErpSyncAgent.ConnectActor</see> method.

## ConnectActor

Create a link between Erp and Crm and set default values
<para /><b>Online Restricted:</b> The ErpSync agent is not available in Online by default. Access must be requested specifically when app is registered. Intended for ERP integration apps.

* **erpConnectionId:** ErpConnectionId
* **crmRecordId:** CrmRecordId
* **crmActorType:** The Crm Actor type
* **erpKey:** 
* **erpActorType:** The Erp Actor type
* **fieldValues:** The Crm Fields



[WSDL file for Services86/ErpSync](../Services86-ErpSync.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ConnectActor Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <ErpSync:ApplicationToken>1234567-1234-9876</ErpSync:ApplicationToken>
  <ErpSync:Credentials>
    <ErpSync:Ticket>7T:1234abcxyzExample==</ErpSync:Ticket>
  </ErpSync:Credentials>
 <SOAP-ENV:Body>
   <ErpSync:ConnectActor>
    <ErpSync:ErpConnectionId xsi:type="xsd:int">0</ErpSync:ErpConnectionId>
    <ErpSync:CrmRecordId xsi:type="xsd:int">0</ErpSync:CrmRecordId>
    <ErpSync:CrmActorType xsi:type="ErpSync:CrmActorType">Unknown</ErpSync:CrmActorType>
    <ErpSync:ErpKey xsi:type="xsd:string"></ErpSync:ErpKey>
    <ErpSync:ErpActorType xsi:type="ErpSync:ErpActorType">Unknown</ErpSync:ErpActorType>
    <ErpSync:FieldValues xsi:type="ErpSync:ArrayOfErpSyncFieldValue">
     <ErpSync:ErpSyncFieldValue xsi:type="ErpSync:ErpSyncFieldValue">
      <ErpSync:DisplayName xsi:type="xsd:string"></ErpSync:DisplayName>
      <ErpSync:CrmFieldKey xsi:type="xsd:string"></ErpSync:CrmFieldKey>
      <ErpSync:Value xsi:type="xsd:string"></ErpSync:Value>
      <ErpSync:DisplayValue xsi:type="xsd:string"></ErpSync:DisplayValue>
      <ErpSync:SyncToCrm xsi:type="xsd:boolean">false</ErpSync:SyncToCrm>
      <ErpSync:SyncToErp xsi:type="xsd:boolean">false</ErpSync:SyncToErp>
     </ErpSync:ErpSyncFieldValue>
    </ErpSync:FieldValues>
   </ErpSync:ConnectActor>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ConnectActor Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <ErpSync:ConnectActorResponse>
  </ErpSync:ConnectActorResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

