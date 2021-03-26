---
uid: services84-list-getalllegalbase
title: Services84.ListAgent.GetAllLegalBase SOAP
Generated: true
---

# Services84 List GetAllLegalBase SOAP

SOAP request and response examples **Remote/Services84/List.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IListAgent.GetAllLegalBase">SuperOffice.Services84.IListAgent.GetAllLegalBase</see> method.

## GetAllLegalBase

Gets an array of all LegalBase objects.


**Returns:** Array of all LegalBase objects


[WSDL file for Services84/List](../Services84-List.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetAllLegalBase Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetAllLegalBase>
   </List:GetAllLegalBase>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetAllLegalBase Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <List:GetAllLegalBaseResponse>
   <List:Response xsi:type="List:ArrayOfLegalBase">
    <List:LegalBase xsi:type="List:LegalBase">
     <List:LegalBaseId xsi:type="xsd:int">0</List:LegalBaseId>
     <List:Name xsi:type="xsd:string"></List:Name>
     <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
     <List:Rank xsi:type="xsd:short">0</List:Rank>
     <List:Key xsi:type="xsd:string"></List:Key>
     <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
    </List:LegalBase>
   </List:Response>
  </List:GetAllLegalBaseResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

