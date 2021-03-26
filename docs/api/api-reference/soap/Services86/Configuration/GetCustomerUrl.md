---
uid: services86-configuration-getcustomerurl
title: Services86.ConfigurationAgent.GetCustomerUrl SOAP
Generated: true
---

# Services86 Configuration GetCustomerUrl SOAP

SOAP request and response examples **Remote/Services86/Configuration.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IConfigurationAgent.GetCustomerUrl">SuperOffice.Services86.IConfigurationAgent.GetCustomerUrl</see> method.

## GetCustomerUrl

This method will get the URL for the external access to the customer center


**Returns:** The URL to the customer center, without any actions


[WSDL file for Services86/Configuration](../Services86-Configuration.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetCustomerUrl Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Configuration:ApplicationToken>1234567-1234-9876</Configuration:ApplicationToken>
  <Configuration:Credentials>
    <Configuration:Ticket>7T:1234abcxyzExample==</Configuration:Ticket>
  </Configuration:Credentials>
 <SOAP-ENV:Body>
   <Configuration:GetCustomerUrl>
   </Configuration:GetCustomerUrl>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetCustomerUrl Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Configuration:GetCustomerUrlResponse>
   <Configuration:Response xsi:type="xsd:string"></Configuration:Response>
  </Configuration:GetCustomerUrlResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

