---
title: Services84.ListAgent.GetAllConsentSource SOAP
generated: 1
uid: Services84-List-GetAllConsentSource
---

# Services84 List GetAllConsentSource

SOAP request and response examples **Remote/Services84/List.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IListAgent.GetAllConsentSource">SuperOffice.Services84.IListAgent.GetAllConsentSource</see> method.

## GetAllConsentSource

Gets an array of all ConsentSource objects.


**Returns:** Array of all ConsentSource objects


[WSDL file for Services84/List](../Services84-List.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetAllConsentSource Request

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
   <List:GetAllConsentSource>
   </List:GetAllConsentSource>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetAllConsentSource Response

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
  <List:GetAllConsentSourceResponse>
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
  </List:GetAllConsentSourceResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

