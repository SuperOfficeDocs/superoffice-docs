---
uid: services86-customerservice-getprogramurl
title: Services86.CustomerServiceAgent.GetProgramUrl SOAP
Generated: true
---

# Services86 CustomerService GetProgramUrl SOAP

SOAP request and response examples **Remote/Services86/CustomerService.svc**
Implemented by the <see cref="M:SuperOffice.Services86.ICustomerServiceAgent.GetProgramUrl">SuperOffice.Services86.ICustomerServiceAgent.GetProgramUrl</see> method.

## GetProgramUrl

This method will convert a module name into a Service URL.

* **programName:** In this parameter you must specify which CS program you want to create an URL for. Valid examples are "ticket", "rms", "spm" etc.
* **external:** If set to true, this will generate URLs that are accesible from the outside (for example Internet)

**Returns:** Returns a valid Service URL composed of the give parameters.


[WSDL file for Services86/CustomerService](../Services86-CustomerService.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetProgramUrl Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CustomerService="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <CustomerService:ApplicationToken>1234567-1234-9876</CustomerService:ApplicationToken>
  <CustomerService:Credentials>
    <CustomerService:Ticket>7T:1234abcxyzExample==</CustomerService:Ticket>
  </CustomerService:Credentials>
 <SOAP-ENV:Body>
   <CustomerService:GetProgramUrl>
    <CustomerService:ProgramName xsi:type="xsd:string"></CustomerService:ProgramName>
    <CustomerService:External xsi:type="xsd:boolean">false</CustomerService:External>
   </CustomerService:GetProgramUrl>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetProgramUrl Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CustomerService="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <CustomerService:GetProgramUrlResponse>
   <CustomerService:Response xsi:type="xsd:string"></CustomerService:Response>
  </CustomerService:GetProgramUrlResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

