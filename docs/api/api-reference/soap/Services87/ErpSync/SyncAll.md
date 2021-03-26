---
uid: services87-erpsync-syncall
title: Services87.ErpSyncAgent.SyncAll SOAP
Generated: true
---

# Services87 ErpSync SyncAll SOAP

SOAP request and response examples **Remote/Services87/ErpSync.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IErpSyncAgent.SyncAll">SuperOffice.Services87.IErpSyncAgent.SyncAll</see> method.

## SyncAll

Sync all active connections
<para /><b>Online Restricted:</b> The ErpSync agent is not available in Online by default. Access must be requested specifically when app is registered. Intended for ERP integration apps.


**Returns:** The response


[WSDL file for Services87/ErpSync](../Services87-ErpSync.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SyncAll Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <ErpSync:ApplicationToken>1234567-1234-9876</ErpSync:ApplicationToken>
  <ErpSync:Credentials>
    <ErpSync:Ticket>7T:1234abcxyzExample==</ErpSync:Ticket>
  </ErpSync:Credentials>
 <SOAP-ENV:Body>
   <ErpSync:SyncAll>
   </ErpSync:SyncAll>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SyncAll Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <ErpSync:SyncAllResponse>
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
  </ErpSync:SyncAllResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

