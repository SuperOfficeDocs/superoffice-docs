---
uid: services81-navigator-getnavigatorcompanylist
title: Services81.NavigatorAgent.GetNavigatorCompanyList SOAP
Generated: true
---

# Services81 Navigator GetNavigatorCompanyList SOAP

SOAP request and response examples **Remote/Services81/Navigator.svc**
Implemented by the <see cref="M:SuperOffice.Services81.INavigatorAgent.GetNavigatorCompanyList">SuperOffice.Services81.INavigatorAgent.GetNavigatorCompanyList</see> method.

## GetNavigatorCompanyList

Gets an array of NavigatorCompany objects.

* **navigatorCompanyIds:** The identifiers of the NavigatorCompany object

**Returns:** Array of NavigatorCompany objects


[WSDL file for Services81/Navigator](../Services81-Navigator.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetNavigatorCompanyList Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Navigator="http://www.superoffice.net/ws/crm/NetServer/Services81">
  <Navigator:ApplicationToken>1234567-1234-9876</Navigator:ApplicationToken>
  <Navigator:Credentials>
    <Navigator:Ticket>7T:1234abcxyzExample==</Navigator:Ticket>
  </Navigator:Credentials>
 <SOAP-ENV:Body>
   <Navigator:GetNavigatorCompanyList>
    <Navigator:NavigatorCompanyIds xsi:type="NetServerServices812:ArrayOfint">
     <NetServerServices812:int xsi:type="xsd:int">0</NetServerServices812:int>
    </Navigator:NavigatorCompanyIds>
   </Navigator:GetNavigatorCompanyList>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetNavigatorCompanyList Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Navigator="http://www.superoffice.net/ws/crm/NetServer/Services81">
 <SOAP-ENV:Body>
  <Navigator:GetNavigatorCompanyListResponse>
   <Navigator:Response xsi:type="Navigator:ArrayOfNavigatorCompany">
    <Navigator:NavigatorCompany xsi:type="Navigator:NavigatorCompany">
     <Navigator:Id xsi:type="xsd:int">0</Navigator:Id>
     <Navigator:Value xsi:type="xsd:string"></Navigator:Value>
     <Navigator:Tooltip xsi:type="xsd:string"></Navigator:Tooltip>
    </Navigator:NavigatorCompany>
   </Navigator:Response>
  </Navigator:GetNavigatorCompanyListResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

