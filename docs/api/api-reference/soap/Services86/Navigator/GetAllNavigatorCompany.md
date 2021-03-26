---
uid: services86-navigator-getallnavigatorcompany
title: Services86.NavigatorAgent.GetAllNavigatorCompany SOAP
Generated: true
---

# Services86 Navigator GetAllNavigatorCompany SOAP

SOAP request and response examples **Remote/Services86/Navigator.svc**
Implemented by the <see cref="M:SuperOffice.Services86.INavigatorAgent.GetAllNavigatorCompany">SuperOffice.Services86.INavigatorAgent.GetAllNavigatorCompany</see> method.

## GetAllNavigatorCompany

Gets an array of all NavigatorCompany objects.


**Returns:** Array of all NavigatorCompany objects


[WSDL file for Services86/Navigator](../Services86-Navigator.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetAllNavigatorCompany Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Navigator="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Navigator:ApplicationToken>1234567-1234-9876</Navigator:ApplicationToken>
  <Navigator:Credentials>
    <Navigator:Ticket>7T:1234abcxyzExample==</Navigator:Ticket>
  </Navigator:Credentials>
 <SOAP-ENV:Body>
   <Navigator:GetAllNavigatorCompany>
   </Navigator:GetAllNavigatorCompany>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetAllNavigatorCompany Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Navigator="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Navigator:GetAllNavigatorCompanyResponse>
   <Navigator:Response xsi:type="Navigator:ArrayOfNavigatorCompany">
    <Navigator:NavigatorCompany xsi:type="Navigator:NavigatorCompany">
     <Navigator:Id xsi:type="xsd:int">0</Navigator:Id>
     <Navigator:Value xsi:type="xsd:string"></Navigator:Value>
     <Navigator:Tooltip xsi:type="xsd:string"></Navigator:Tooltip>
    </Navigator:NavigatorCompany>
   </Navigator:Response>
  </Navigator:GetAllNavigatorCompanyResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

