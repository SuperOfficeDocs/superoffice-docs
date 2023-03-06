---
title: Services88.ArchiveAgent.GetRelatedData SOAP
generated: 1
uid: Services88-Archive-GetRelatedData
---

# Services88 Archive GetRelatedData

SOAP request and response examples **Remote/Services88/Archive.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IArchiveAgent.GetRelatedData">SuperOffice.Services88.IArchiveAgent.GetRelatedData</see> method.

## GetRelatedData





[WSDL file for Services88/Archive](../Services88-Archive.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetRelatedData Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Archive="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Archive:ApplicationToken>1234567-1234-9876</Archive:ApplicationToken>
  <Archive:Credentials>
    <Archive:Ticket>7T:1234abcxyzExample==</Archive:Ticket>
  </Archive:Credentials>
 <SOAP-ENV:Body>
   <Archive:GetRelatedData>
    <Archive:Table xsi:type="xsd:string"></Archive:Table>
    <Archive:RecordId xsi:type="xsd:int">0</Archive:RecordId>
    <Archive:Fields xsi:type="NetServerServices882:ArrayOfstring">
     <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
    </Archive:Fields>
   </Archive:GetRelatedData>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetRelatedData Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Archive="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Archive:GetRelatedDataResponse>
   <Archive:Response xsi:type="Archive:ArrayOfRelatedData">
    <Archive:RelatedData xsi:type="Archive:RelatedData">
     <Archive:Field xsi:type="xsd:string"></Archive:Field>
     <Archive:FieldValue xsi:type="Archive:ArchiveColumnData">
      <Archive:DisplayValue xsi:type="xsd:string"></Archive:DisplayValue>
      <Archive:TooltipHint xsi:type="xsd:string"></Archive:TooltipHint>
      <Archive:LinkHint xsi:type="xsd:string"></Archive:LinkHint>
     </Archive:FieldValue>
    </Archive:RelatedData>
   </Archive:Response>
  </Archive:GetRelatedDataResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

