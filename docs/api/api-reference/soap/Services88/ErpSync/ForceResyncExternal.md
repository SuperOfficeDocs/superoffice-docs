---
uid: services88-erpsync-forceresyncexternal
title: Services88.ErpSyncAgent.ForceResyncExternal SOAP
Generated: true
---

# Services88 ErpSync ForceResyncExternal SOAP

SOAP request and response examples **Remote/Services88/ErpSync.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IErpSyncAgent.ForceResyncExternal">SuperOffice.Services88.IErpSyncAgent.ForceResyncExternal</see> method.

## ForceResyncExternal

Force resync from CRM or given Erp connection to all other connections, using external keys
<para /><b>Online Restricted:</b> The ErpSync agent is not available in Online by default. Access must be requested specifically when app is registered. Intended for ERP integration apps.

* **erpConnectionId:** Resync from the given erp connection
* **erpActorType:** Which actor type the external keys are associated with
* **externalKeys:** The internal keys of the entities to resync, or empty to resync all

**Returns:** The response


[WSDL file for Services88/ErpSync](../Services88-ErpSync.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ForceResyncExternal Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <ErpSync:ApplicationToken>1234567-1234-9876</ErpSync:ApplicationToken>
  <ErpSync:Credentials>
    <ErpSync:Ticket>7T:1234abcxyzExample==</ErpSync:Ticket>
  </ErpSync:Credentials>
 <SOAP-ENV:Body>
   <ErpSync:ForceResyncExternal>
    <ErpSync:ErpConnectionId xsi:type="xsd:int">0</ErpSync:ErpConnectionId>
    <ErpSync:ErpActorType xsi:type="ErpSync:ErpActorType">Unknown</ErpSync:ErpActorType>
    <ErpSync:ExternalKeys xsi:type="NetServerServices882:ArrayOfstring">
     <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
    </ErpSync:ExternalKeys>
   </ErpSync:ForceResyncExternal>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ForceResyncExternal Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <ErpSync:ForceResyncExternalResponse>
   <ErpSync:Response xsi:type="ErpSync:PluginResponse">
    <ErpSync:IsOk xsi:type="xsd:boolean">false</ErpSync:IsOk>
    <ErpSync:UserExplanation xsi:type="xsd:string"></ErpSync:UserExplanation>
    <ErpSync:TechExplanation xsi:type="xsd:string"></ErpSync:TechExplanation>
    <ErpSync:ErrorCode xsi:type="xsd:string"></ErpSync:ErrorCode>
    <ErpSync:Changes xsi:type="ErpSync:ChangedData">
     <ErpSync:AddedRecords xsi:type="ErpSync:ArrayOfChangedDataItem">
      <ErpSync:ChangedDataItem xsi:type="ErpSync:ChangedDataItem">
       <ErpSync:Tablename xsi:type="xsd:string"></ErpSync:Tablename>
       <ErpSync:RecordId xsi:type="xsd:int">0</ErpSync:RecordId>
      </ErpSync:ChangedDataItem>
     </ErpSync:AddedRecords>
     <ErpSync:UpdatedRecords xsi:type="ErpSync:ArrayOfChangedDataItem">
      <ErpSync:ChangedDataItem xsi:type="ErpSync:ChangedDataItem">
       <ErpSync:Tablename xsi:type="xsd:string"></ErpSync:Tablename>
       <ErpSync:RecordId xsi:type="xsd:int">0</ErpSync:RecordId>
      </ErpSync:ChangedDataItem>
     </ErpSync:UpdatedRecords>
     <ErpSync:DeletedRecords xsi:type="ErpSync:ArrayOfChangedDataItem">
      <ErpSync:ChangedDataItem xsi:type="ErpSync:ChangedDataItem">
       <ErpSync:Tablename xsi:type="xsd:string"></ErpSync:Tablename>
       <ErpSync:RecordId xsi:type="xsd:int">0</ErpSync:RecordId>
      </ErpSync:ChangedDataItem>
     </ErpSync:DeletedRecords>
    </ErpSync:Changes>
   </ErpSync:Response>
  </ErpSync:ForceResyncExternalResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

