---
title: Services84.QuoteAgent.GetConnectionStartupErrors SOAP
generated: 1
uid: Services84-Quote-GetConnectionStartupErrors
---

# Services84 Quote GetConnectionStartupErrors

SOAP request and response examples **Remote/Services84/Quote.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IQuoteAgent.GetConnectionStartupErrors">SuperOffice.Services84.IQuoteAgent.GetConnectionStartupErrors</see> method.

## GetConnectionStartupErrors

[WSDL file for Services84/Quote](../Services84-Quote.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetConnectionStartupErrors Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <Quote:ApplicationToken>1234567-1234-9876</Quote:ApplicationToken>
  <Quote:Credentials>
    <Quote:Ticket>7T:1234abcxyzExample==</Quote:Ticket>
  </Quote:Credentials>
 <SOAP-ENV:Body>
   <Quote:GetConnectionStartupErrors>
   </Quote:GetConnectionStartupErrors>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## GetConnectionStartupErrors Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Quote:GetConnectionStartupErrorsResponse>
   <Quote:Response xsi:type="Quote:ArrayOfPluginResponse">
    <Quote:PluginResponse xsi:type="Quote:PluginResponse">
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
    </Quote:PluginResponse>
   </Quote:Response>
  </Quote:GetConnectionStartupErrorsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```
