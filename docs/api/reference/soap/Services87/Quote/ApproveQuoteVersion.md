---
title: Services87.QuoteAgent.ApproveQuoteVersion SOAP
generated: 1
uid: Services87-Quote-ApproveQuoteVersion
---

# Services87 Quote ApproveQuoteVersion

SOAP request and response examples **Remote/Services87/Quote.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IQuoteAgent.ApproveQuoteVersion">SuperOffice.Services87.IQuoteAgent.ApproveQuoteVersion</see> method.

## ApproveQuoteVersion

Approves a quote version

* **quoteVersionId:** QuoteVersionId to approve.
* **approvedByText:** 'Approved by' prefix to ApprovalText used when creating appointment task to log approval. Must be passed since service does not know which language to use for 'Approved By' string.
* **approvedByAssociateId:** AssociateId of the associate who approved the quote version.
* **approvalText:** Approval text.

**Returns:** Response of the the operation


[WSDL file for Services87/Quote](../Services87-Quote.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ApproveQuoteVersion Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Quote:ApplicationToken>1234567-1234-9876</Quote:ApplicationToken>
  <Quote:Credentials>
    <Quote:Ticket>7T:1234abcxyzExample==</Quote:Ticket>
  </Quote:Credentials>
 <SOAP-ENV:Body>
   <Quote:ApproveQuoteVersion>
    <Quote:QuoteVersionId xsi:type="xsd:int">0</Quote:QuoteVersionId>
    <Quote:ApprovedByText xsi:type="xsd:string"></Quote:ApprovedByText>
    <Quote:ApprovedByAssociateId xsi:type="xsd:int">0</Quote:ApprovedByAssociateId>
    <Quote:ApprovalText xsi:type="xsd:string"></Quote:ApprovalText>
   </Quote:ApproveQuoteVersion>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ApproveQuoteVersion Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Quote:ApproveQuoteVersionResponse>
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
  </Quote:ApproveQuoteVersionResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

