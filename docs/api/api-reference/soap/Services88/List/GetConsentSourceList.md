---
uid: services88-list-getconsentsourcelist
title: Services88.ListAgent.GetConsentSourceList SOAP
Generated: true
---

# Services88 List GetConsentSourceList SOAP

SOAP request and response examples **Remote/Services88/List.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IListAgent.GetConsentSourceList">SuperOffice.Services88.IListAgent.GetConsentSourceList</see> method.

## GetConsentSourceList

Gets an array of ConsentSource objects.

* **consentSourceIds:** The identifiers of the ConsentSource object

**Returns:** Array of ConsentSource objects


[WSDL file for Services88/List](../Services88-List.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetConsentSourceList Request

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
   <List:GetConsentSourceList>
    <List:ConsentSourceIds xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </List:ConsentSourceIds>
   </List:GetConsentSourceList>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetConsentSourceList Response

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
  <List:GetConsentSourceListResponse>
   <List:Response xsi:type="List:ArrayOfConsentSource">
    <List:ConsentSource xsi:type="List:ConsentSource">
     <List:ConsentSourceId xsi:type="xsd:int">0</List:ConsentSourceId>
     <List:Name xsi:type="xsd:string"></List:Name>
     <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
     <List:Rank xsi:type="xsd:short">0</List:Rank>
     <List:Key xsi:type="xsd:string"></List:Key>
     <List:MailTemplateId xsi:type="xsd:int">0</List:MailTemplateId>
     <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
    </List:ConsentSource>
   </List:Response>
  </List:GetConsentSourceListResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

