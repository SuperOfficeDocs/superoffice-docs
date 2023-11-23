---
title: Services88.SelectionAgent.GetSelectionSummaries SOAP
generated: true
uid: Services88-Selection-GetSelectionSummaries
---

# Services88 Selection GetSelectionSummaries

SOAP request and response examples **Remote/Services88/Selection.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ISelectionAgent.GetSelectionSummaries">SuperOffice.Services88.ISelectionAgent.GetSelectionSummaries</see> method.

## GetSelectionSummaries





[WSDL file for Services88/Selection](../Services88-Selection.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetSelectionSummaries Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Selection:ApplicationToken>1234567-1234-9876</Selection:ApplicationToken>
  <Selection:Credentials>
    <Selection:Ticket>7T:1234abcxyzExample==</Selection:Ticket>
  </Selection:Credentials>
 <SOAP-ENV:Body>
   <Selection:GetSelectionSummaries>
    <Selection:SelectionIds xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </Selection:SelectionIds>
   </Selection:GetSelectionSummaries>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetSelectionSummaries Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Selection:GetSelectionSummariesResponse>
   <Selection:Response xsi:type="Selection:ArrayOfSelectionSummaryItem">
    <Selection:SelectionSummaryItem xsi:type="Selection:SelectionSummaryItem">
     <Selection:SelectionId xsi:type="xsd:int">0</Selection:SelectionId>
     <Selection:Name xsi:type="xsd:string"></Selection:Name>
     <Selection:TargetTable xsi:type="xsd:string"></Selection:TargetTable>
     <Selection:Registered xsi:type="xsd:dateTime">2023-11-10T12:37:43Z</Selection:Registered>
     <Selection:ProviderName xsi:type="xsd:string"></Selection:ProviderName>
    </Selection:SelectionSummaryItem>
   </Selection:Response>
  </Selection:GetSelectionSummariesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

