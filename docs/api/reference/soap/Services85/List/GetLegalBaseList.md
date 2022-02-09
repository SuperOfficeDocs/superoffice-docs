---
title: Services85.ListAgent.GetLegalBaseList SOAP
generated: 1
uid: Services85-List-GetLegalBaseList
---

# Services85 List GetLegalBaseList

SOAP request and response examples **Remote/Services85/List.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IListAgent.GetLegalBaseList">SuperOffice.Services85.IListAgent.GetLegalBaseList</see> method.

## GetLegalBaseList

Gets an array of LegalBase objects.

* **legalBaseIds:** The identifiers of the LegalBase object

**Returns:** Array of LegalBase objects


[WSDL file for Services85/List](../Services85-List.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetLegalBaseList Request

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
   <List:GetLegalBaseList>
    <List:LegalBaseIds xsi:type="NetServerServices852:ArrayOfint">
     <NetServerServices852:int xsi:type="xsd:int">0</NetServerServices852:int>
    </List:LegalBaseIds>
   </List:GetLegalBaseList>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetLegalBaseList Response

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
  <List:GetLegalBaseListResponse>
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
  </List:GetLegalBaseListResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

