---
uid: services75-quote-testconnection
title: Services75.QuoteAgent.TestConnection SOAP
Generated: true
---

# Services75 Quote TestConnection SOAP

SOAP request and response examples **Remote/Services75/Quote.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IQuoteAgent.TestConnection">SuperOffice.Services75.IQuoteAgent.TestConnection</see> method.

## TestConnection

Used by the Admin clients. Testing if the connection data is sufficient to get a connection with the ERP system. The Connector should try to do some operations to check if the connection has sufficient rights to run. The connection has not been created yet. TestConnection is called without InitializeConnector being called first.

* **connectorName:** Name of the connector.
* **connectionData:** Basically the name/value collection of the configuration data requested to create a connection

**Returns:** How the test went


[WSDL file for Services75/Quote](../Services75-Quote.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## TestConnection Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <Quote:ApplicationToken>1234567-1234-9876</Quote:ApplicationToken>
  <Quote:Credentials>
    <Quote:Ticket>7T:1234abcxyzExample==</Quote:Ticket>
  </Quote:Credentials>
 <SOAP-ENV:Body>
   <Quote:TestConnection>
    <Quote:ConnectorName xsi:type="xsd:string"></Quote:ConnectorName>
    <Quote:ConnectionData xsi:type="Quote:StringDictionary">
     <Quote:StringKeyValuePair>
      <Quote:Key xsi:type="xsd:string"></Quote:Key>
      <Quote:Value xsi:type="xsd:string"></Quote:Value>
     </Quote:StringKeyValuePair>
    </Quote:ConnectionData>
   </Quote:TestConnection>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## TestConnection Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <Quote:TestConnectionResponse>
   <Quote:Response xsi:type="Quote:PluginResponse">
    <Quote:IsOk xsi:type="xsd:boolean">false</Quote:IsOk>
    <Quote:UserExplanation xsi:type="xsd:string"></Quote:UserExplanation>
    <Quote:TechExplanation xsi:type="xsd:string"></Quote:TechExplanation>
    <Quote:ErrorCode xsi:type="xsd:string"></Quote:ErrorCode>
    <Quote:Changes xsi:type="Quote:ChangedData">
     <Quote:AddedRecords xsi:type="Quote:ArrayOfChangedDataItem">
      <Quote:ChangedDataItem xsi:type="Quote:ChangedDataItem">
       <Quote:Tablename xsi:type="xsd:string"></Quote:Tablename>
       <Quote:RecordId xsi:type="xsd:int">0</Quote:RecordId>
      </Quote:ChangedDataItem>
     </Quote:AddedRecords>
     <Quote:UpdatedRecords xsi:type="Quote:ArrayOfChangedDataItem">
      <Quote:ChangedDataItem xsi:type="Quote:ChangedDataItem">
       <Quote:Tablename xsi:type="xsd:string"></Quote:Tablename>
       <Quote:RecordId xsi:type="xsd:int">0</Quote:RecordId>
      </Quote:ChangedDataItem>
     </Quote:UpdatedRecords>
     <Quote:DeletedRecords xsi:type="Quote:ArrayOfChangedDataItem">
      <Quote:ChangedDataItem xsi:type="Quote:ChangedDataItem">
       <Quote:Tablename xsi:type="xsd:string"></Quote:Tablename>
       <Quote:RecordId xsi:type="xsd:int">0</Quote:RecordId>
      </Quote:ChangedDataItem>
     </Quote:DeletedRecords>
    </Quote:Changes>
   </Quote:Response>
  </Quote:TestConnectionResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

