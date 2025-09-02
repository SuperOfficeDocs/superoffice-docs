---
title: Services88.SelectionAgent.GetSelectionShadowMembersArchiveRows SOAP
generated: true
uid: Services88-Selection-GetSelectionShadowMembersArchiveRows
content_type: reference
---

# Services88 Selection GetSelectionShadowMembersArchiveRows

SOAP request and response examples **Remote/Services88/Selection.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ISelectionAgent.GetSelectionShadowMembersArchiveRows">SuperOffice.Services88.ISelectionAgent.GetSelectionShadowMembersArchiveRows</see> method.

## GetSelectionShadowMembersArchiveRows





[WSDL file for Services88/Selection](../Services88-Selection.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetSelectionShadowMembersArchiveRows Request

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
   <Selection:GetSelectionShadowMembersArchiveRows>
    <Selection:SelectionId xsi:type="xsd:int">0</Selection:SelectionId>
    <Selection:Select xsi:type="xsd:string"></Selection:Select>
   </Selection:GetSelectionShadowMembersArchiveRows>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetSelectionShadowMembersArchiveRows Response

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
  <Selection:GetSelectionShadowMembersArchiveRowsResponse>
   <Selection:Response xsi:type="Selection:ArrayOfArchiveListItem">
    <Selection:ArchiveListItem xsi:type="Selection:ArchiveListItem">
     <Selection:EntityName xsi:type="xsd:string"></Selection:EntityName>
     <Selection:PrimaryKey xsi:type="xsd:int">0</Selection:PrimaryKey>
     <Selection:ColumnData xsi:type="Selection:ColumnDataDictionary">
      <Selection:ColumnDataKeyValuePair>
       <Selection:Key xsi:type="xsd:string"></Selection:Key>
       <Selection:Value xsi:type="Selection:ArchiveColumnData">
        <Selection:DisplayValue xsi:type="xsd:string"></Selection:DisplayValue>
        <Selection:TooltipHint xsi:type="xsd:string"></Selection:TooltipHint>
        <Selection:LinkHint xsi:type="xsd:string"></Selection:LinkHint>
       </Selection:Value>
      </Selection:ColumnDataKeyValuePair>
     </Selection:ColumnData>
     <Selection:LinkHint xsi:type="xsd:string"></Selection:LinkHint>
     <Selection:StyleHint xsi:type="xsd:string"></Selection:StyleHint>
    </Selection:ArchiveListItem>
   </Selection:Response>
  </Selection:GetSelectionShadowMembersArchiveRowsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

