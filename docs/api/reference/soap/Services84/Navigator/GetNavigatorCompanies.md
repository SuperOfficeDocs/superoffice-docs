---
title: Services84.NavigatorAgent.GetNavigatorCompanies SOAP
generated: 1
uid: Services84-Navigator-GetNavigatorCompanies
---

# Services84 Navigator GetNavigatorCompanies

SOAP request and response examples **Remote/Services84/Navigator.svc**
Implemented by the <see cref="M:SuperOffice.Services84.INavigatorAgent.GetNavigatorCompanies">SuperOffice.Services84.INavigatorAgent.GetNavigatorCompanies</see> method.

## GetNavigatorCompanies



* **name:** 



[WSDL file for Services84/Navigator](../Services84-Navigator.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetNavigatorCompanies Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Navigator="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <Navigator:ApplicationToken>1234567-1234-9876</Navigator:ApplicationToken>
  <Navigator:Credentials>
    <Navigator:Ticket>7T:1234abcxyzExample==</Navigator:Ticket>
  </Navigator:Credentials>
 <SOAP-ENV:Body>
   <Navigator:GetNavigatorCompanies>
    <Navigator:Name xsi:type="xsd:string"></Navigator:Name>
   </Navigator:GetNavigatorCompanies>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetNavigatorCompanies Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Navigator="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Navigator:GetNavigatorCompaniesResponse>
   <Navigator:Response xsi:type="Navigator:ArrayOfNavigatorCompany">
    <Navigator:NavigatorCompany xsi:type="Navigator:NavigatorCompany">
     <Navigator:Id xsi:type="xsd:int">0</Navigator:Id>
     <Navigator:Value xsi:type="xsd:string"></Navigator:Value>
     <Navigator:Tooltip xsi:type="xsd:string"></Navigator:Tooltip>
    </Navigator:NavigatorCompany>
   </Navigator:Response>
  </Navigator:GetNavigatorCompaniesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

