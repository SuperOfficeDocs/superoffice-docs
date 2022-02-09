---
title: Services86.QuoteAgent.SendQuoteVersion SOAP
generated: 1
uid: Services86-Quote-SendQuoteVersion
---

# Services86 Quote SendQuoteVersion

SOAP request and response examples **Remote/Services86/Quote.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IQuoteAgent.SendQuoteVersion">SuperOffice.Services86.IQuoteAgent.SendQuoteVersion</see> method.

## SendQuoteVersion

Send the quote to the user's customer. More parameters to be added later...

* **quoteVersionId:** QuoteVersionId of the quoteversion to send
* **expiryDate:** Date the quote expires
* **followupDate:** Date for the followup task, to remind the sales rep about the quote
* **followupText:** The body text for the follwup appointment, resolved to the correct culture (no resources please)
* **culture:** Desired culture for email body and other culture-sensitive templates/content

**Returns:** Response of the operation


[WSDL file for Services86/Quote](../Services86-Quote.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SendQuoteVersion Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Quote:ApplicationToken>1234567-1234-9876</Quote:ApplicationToken>
  <Quote:Credentials>
    <Quote:Ticket>7T:1234abcxyzExample==</Quote:Ticket>
  </Quote:Credentials>
 <SOAP-ENV:Body>
   <Quote:SendQuoteVersion>
    <Quote:QuoteVersionId xsi:type="xsd:int">0</Quote:QuoteVersionId>
    <Quote:ExpiryDate xsi:type="xsd:dateTime">2021-11-30T13:23:02Z</Quote:ExpiryDate>
    <Quote:FollowupDate xsi:type="xsd:dateTime">2021-11-30T13:23:02Z</Quote:FollowupDate>
    <Quote:FollowupText xsi:type="xsd:string"></Quote:FollowupText>
    <Quote:Culture xsi:type="xsd:string"></Quote:Culture>
   </Quote:SendQuoteVersion>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SendQuoteVersion Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Quote:SendQuoteVersionResponse>
   <Quote:Response xsi:type="Quote:PluginUrlResponse">
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
    <Quote:Url xsi:type="xsd:string"></Quote:Url>
   </Quote:Response>
  </Quote:SendQuoteVersionResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

