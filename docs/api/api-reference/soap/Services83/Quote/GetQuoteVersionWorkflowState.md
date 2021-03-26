---
uid: services83-quote-getquoteversionworkflowstate
title: Services83.QuoteAgent.GetQuoteVersionWorkflowState SOAP
Generated: true
---

# Services83 Quote GetQuoteVersionWorkflowState SOAP

SOAP request and response examples **Remote/Services83/Quote.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IQuoteAgent.GetQuoteVersionWorkflowState">SuperOffice.Services83.IQuoteAgent.GetQuoteVersionWorkflowState</see> method.

## GetQuoteVersionWorkflowState

Get all button states for the Quote version dialog. Packages ImageState, Button states and status info into one call. Collects most important warnings/errors from across all quotelines/alternatives in this quote version.

* **quoteVersionId:** Id of the quote version to get the button states for.
* **quoteAlternativeId:** Id of the active quote alternative id.

**Returns:** Workflow state information


[WSDL file for Services83/Quote](../Services83-Quote.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetQuoteVersionWorkflowState Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <Quote:ApplicationToken>1234567-1234-9876</Quote:ApplicationToken>
  <Quote:Credentials>
    <Quote:Ticket>7T:1234abcxyzExample==</Quote:Ticket>
  </Quote:Credentials>
 <SOAP-ENV:Body>
   <Quote:GetQuoteVersionWorkflowState>
    <Quote:QuoteVersionId xsi:type="xsd:int">0</Quote:QuoteVersionId>
    <Quote:QuoteAlternativeId xsi:type="xsd:int">0</Quote:QuoteAlternativeId>
   </Quote:GetQuoteVersionWorkflowState>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetQuoteVersionWorkflowState Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <Quote:GetQuoteVersionWorkflowStateResponse>
   <Quote:Response xsi:type="Quote:QuoteVersionWorkflowState">
    <Quote:ActionButtons xsi:type="Quote:ArrayOfQuoteVersionButtonState">
     <Quote:QuoteVersionButtonState xsi:type="Quote:QuoteVersionButtonState">
      <Quote:Action xsi:type="Quote:QuoteVersionButtonAction">None</Quote:Action>
      <Quote:ImageHint xsi:type="xsd:string"></Quote:ImageHint>
      <Quote:DisplayText xsi:type="xsd:string"></Quote:DisplayText>
      <Quote:TooltipText xsi:type="xsd:string"></Quote:TooltipText>
      <Quote:Enabled xsi:type="xsd:boolean">false</Quote:Enabled>
     </Quote:QuoteVersionButtonState>
    </Quote:ActionButtons>
    <Quote:StateImage xsi:type="Quote:QuoteVersionButtonState">
     <Quote:Action xsi:type="Quote:QuoteVersionButtonAction">None</Quote:Action>
     <Quote:ImageHint xsi:type="xsd:string"></Quote:ImageHint>
     <Quote:DisplayText xsi:type="xsd:string"></Quote:DisplayText>
     <Quote:TooltipText xsi:type="xsd:string"></Quote:TooltipText>
     <Quote:Enabled xsi:type="xsd:boolean">false</Quote:Enabled>
    </Quote:StateImage>
    <Quote:UpdatePricesButton xsi:type="Quote:QuoteVersionButtonState">
     <Quote:Action xsi:type="Quote:QuoteVersionButtonAction">None</Quote:Action>
     <Quote:ImageHint xsi:type="xsd:string"></Quote:ImageHint>
     <Quote:DisplayText xsi:type="xsd:string"></Quote:DisplayText>
     <Quote:TooltipText xsi:type="xsd:string"></Quote:TooltipText>
     <Quote:Enabled xsi:type="xsd:boolean">false</Quote:Enabled>
    </Quote:UpdatePricesButton>
    <Quote:Status xsi:type="Quote:QuoteVersionStatusInformation">
     <Quote:Status xsi:type="Quote:QuoteStatus">Ok</Quote:Status>
     <Quote:IconHint xsi:type="xsd:string"></Quote:IconHint>
     <Quote:DisplayMessage xsi:type="xsd:string"></Quote:DisplayMessage>
     <Quote:DisplayTooltip xsi:type="xsd:string"></Quote:DisplayTooltip>
    </Quote:Status>
   </Quote:Response>
  </Quote:GetQuoteVersionWorkflowStateResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

