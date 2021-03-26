---
uid: services88-quote-getconnectionstartupresponse
title: Services88.QuoteAgent.GetConnectionStartupResponse SOAP
Generated: true
---

# Services88 Quote GetConnectionStartupResponse SOAP

SOAP request and response examples **Remote/Services88/Quote.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IQuoteAgent.GetConnectionStartupResponse">SuperOffice.Services88.IQuoteAgent.GetConnectionStartupResponse</see> method.

## GetConnectionStartupResponse

Returns the PluginResponseInfo for the connection initialization. Does not initialize the connection, just returns what happened when initialize was called.

* **quoteConnectionId:** Primary key of the connection

**Returns:** PluginResponseInfo for the connection initialization.


[WSDL file for Services88/Quote](../Services88-Quote.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetConnectionStartupResponse Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Quote:ApplicationToken>1234567-1234-9876</Quote:ApplicationToken>
  <Quote:Credentials>
    <Quote:Ticket>7T:1234abcxyzExample==</Quote:Ticket>
  </Quote:Credentials>
 <SOAP-ENV:Body>
   <Quote:GetConnectionStartupResponse>
    <Quote:QuoteConnectionId xsi:type="xsd:int">0</Quote:QuoteConnectionId>
   </Quote:GetConnectionStartupResponse>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetConnectionStartupResponse Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Quote:GetConnectionStartupResponseResponse>
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
  </Quote:GetConnectionStartupResponseResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

