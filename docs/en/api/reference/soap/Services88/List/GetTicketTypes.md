---
title: Services88.ListAgent.GetTicketTypes SOAP
generated: true
uid: Services88-List-GetTicketTypes
content_type: reference
---

# Services88 List GetTicketTypes

SOAP request and response examples **Remote/Services88/List.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IListAgent.GetTicketTypes">SuperOffice.Services88.IListAgent.GetTicketTypes</see> method.

## GetTicketTypes





[WSDL file for Services88/List](../Services88-List.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetTicketTypes Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetTicketTypes>
   </List:GetTicketTypes>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetTicketTypes Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <List:GetTicketTypesResponse>
   <List:Response xsi:type="List:ArrayOfTicketTypeEntity">
    <List:TicketTypeEntity xsi:type="List:TicketTypeEntity">
     <List:TicketTypeId xsi:type="xsd:int">0</List:TicketTypeId>
     <List:Name xsi:type="xsd:string"></List:Name>
     <List:Rank xsi:type="xsd:short">0</List:Rank>
     <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
     <List:Icon xsi:type="xsd:string"></List:Icon>
     <List:DefaultTicketStatus xsi:type="xsd:int">0</List:DefaultTicketStatus>
     <List:TicketStatuses xsi:type="NetServerServices882:ArrayOfint">
      <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
     </List:TicketStatuses>
     <List:DefaultTicketPriority xsi:type="xsd:int">0</List:DefaultTicketPriority>
     <List:TicketPriorities xsi:type="NetServerServices882:ArrayOfint">
      <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
     </List:TicketPriorities>
     <List:ReplyTemplate xsi:type="xsd:int">0</List:ReplyTemplate>
     <List:IsExternalVisible xsi:type="xsd:boolean">false</List:IsExternalVisible>
     <List:IsDefault xsi:type="xsd:boolean">false</List:IsDefault>
     <List:ShowInNew xsi:type="xsd:boolean">false</List:ShowInNew>
     <List:ExcludeSignature xsi:type="xsd:boolean">false</List:ExcludeSignature>
     <List:ExcludeEmailRecipients xsi:type="xsd:boolean">false</List:ExcludeEmailRecipients>
     <List:ExternalAsDefault xsi:type="xsd:boolean">false</List:ExternalAsDefault>
     <List:VisibleForGroups xsi:type="NetServerServices882:ArrayOfint">
      <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
     </List:VisibleForGroups>
     <List:ReplyForwardNoSignature xsi:type="xsd:boolean">false</List:ReplyForwardNoSignature>
     <List:ReplyExternalAsDefault xsi:type="xsd:boolean">false</List:ReplyExternalAsDefault>
    </List:TicketTypeEntity>
   </List:Response>
  </List:GetTicketTypesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

