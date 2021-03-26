---
uid: services84-navigator-getnavigatorcompany
title: Services84.NavigatorAgent.GetNavigatorCompany SOAP
Generated: true
---

# Services84 Navigator GetNavigatorCompany SOAP

SOAP request and response examples **Remote/Services84/Navigator.svc**
Implemented by the <see cref="M:SuperOffice.Services84.INavigatorAgent.GetNavigatorCompany">SuperOffice.Services84.INavigatorAgent.GetNavigatorCompany</see> method.

## GetNavigatorCompany

Gets a NavigatorCompany object.

* **navigatorCompanyId:** The identifier of the NavigatorCompany object

**Returns:** NavigatorCompany


[WSDL file for Services84/Navigator](../Services84-Navigator.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetNavigatorCompany Request

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
   <Navigator:GetNavigatorCompany>
    <Navigator:NavigatorCompanyId xsi:type="xsd:int">0</Navigator:NavigatorCompanyId>
   </Navigator:GetNavigatorCompany>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetNavigatorCompany Response

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
  <Navigator:GetNavigatorCompanyResponse>
   <Navigator:Response xsi:type="Navigator:NavigatorCompany">
    <Navigator:Id xsi:type="xsd:int">0</Navigator:Id>
    <Navigator:Value xsi:type="xsd:string"></Navigator:Value>
    <Navigator:Tooltip xsi:type="xsd:string"></Navigator:Tooltip>
   </Navigator:Response>
  </Navigator:GetNavigatorCompanyResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

