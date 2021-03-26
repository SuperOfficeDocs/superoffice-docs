---
uid: services82-quote-rejectquoteversion
title: Services82.QuoteAgent.RejectQuoteVersion SOAP
Generated: true
---

# Services82 Quote RejectQuoteVersion SOAP

SOAP request and response examples **Remote/Services82/Quote.svc**
Implemented by the <see cref="M:SuperOffice.Services82.IQuoteAgent.RejectQuoteVersion">SuperOffice.Services82.IQuoteAgent.RejectQuoteVersion</see> method.

## RejectQuoteVersion

Rejects a quote version

* **quoteVersionId:** QuoteVersionId to approve.
* **rejectedByText:** 'Rejected by' prefix to RejectionText used when creating appointment task to log rejection. Must be passed since service does not know which language to use for 'Rejected By' string.
* **rejectedByAssociateId:** AssociateId of the associate who rejected the quote version.
* **rejectionText:** Rejection text.

**Returns:** Response of the the operation


[WSDL file for Services82/Quote](../Services82-Quote.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## RejectQuoteVersion Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services82">
  <Quote:ApplicationToken>1234567-1234-9876</Quote:ApplicationToken>
  <Quote:Credentials>
    <Quote:Ticket>7T:1234abcxyzExample==</Quote:Ticket>
  </Quote:Credentials>
 <SOAP-ENV:Body>
   <Quote:RejectQuoteVersion>
    <Quote:QuoteVersionId xsi:type="xsd:int">0</Quote:QuoteVersionId>
    <Quote:RejectedByText xsi:type="xsd:string"></Quote:RejectedByText>
    <Quote:RejectedByAssociateId xsi:type="xsd:int">0</Quote:RejectedByAssociateId>
    <Quote:RejectionText xsi:type="xsd:string"></Quote:RejectionText>
   </Quote:RejectQuoteVersion>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## RejectQuoteVersion Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services82">
 <SOAP-ENV:Body>
  <Quote:RejectQuoteVersionResponse>
   <Quote:Response xsi:type="Quote:ApproveRejectResponse">
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
    <Quote:CreatedAppointmentId xsi:type="xsd:int">0</Quote:CreatedAppointmentId>
   </Quote:Response>
  </Quote:RejectQuoteVersionResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

