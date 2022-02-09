---
title: Services85.ListAgent.GetLegalBase SOAP
generated: 1
uid: Services85-List-GetLegalBase
---

# Services85 List GetLegalBase

SOAP request and response examples **Remote/Services85/List.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IListAgent.GetLegalBase">SuperOffice.Services85.IListAgent.GetLegalBase</see> method.

## GetLegalBase

Gets a LegalBase object.

* **legalBaseId:** The identifier of the LegalBase object

**Returns:** LegalBase


[WSDL file for Services85/List](../Services85-List.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetLegalBase Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetLegalBase>
    <List:LegalBaseId xsi:type="xsd:int">0</List:LegalBaseId>
   </List:GetLegalBase>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetLegalBase Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <List:GetLegalBaseResponse>
   <List:Response xsi:type="List:LegalBase">
    <List:LegalBaseId xsi:type="xsd:int">0</List:LegalBaseId>
    <List:Name xsi:type="xsd:string"></List:Name>
    <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
    <List:Rank xsi:type="xsd:short">0</List:Rank>
    <List:Key xsi:type="xsd:string"></List:Key>
    <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
   </List:Response>
  </List:GetLegalBaseResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

