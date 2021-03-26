---
uid: services86-mdo-getlistnames
title: Services86.MDOAgent.GetListNames SOAP
Generated: true
---

# Services86 MDO GetListNames SOAP

SOAP request and response examples **Remote/Services86/MDO.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IMDOAgent.GetListNames">SuperOffice.Services86.IMDOAgent.GetListNames</see> method.

## GetListNames

Returns a list of all MDO List names. These names can also be used with the Archive agent as ProviderNames.


**Returns:** Array of list names.


[WSDL file for Services86/MDO](../Services86-MDO.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetListNames Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:MDO="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <MDO:ApplicationToken>1234567-1234-9876</MDO:ApplicationToken>
  <MDO:Credentials>
    <MDO:Ticket>7T:1234abcxyzExample==</MDO:Ticket>
  </MDO:Credentials>
 <SOAP-ENV:Body>
   <MDO:GetListNames>
   </MDO:GetListNames>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetListNames Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:MDO="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <MDO:GetListNamesResponse>
   <MDO:Response xsi:type="NetServerServices862:ArrayOfstring">
    <NetServerServices862:string xsi:type="xsd:string"></NetServerServices862:string>
   </MDO:Response>
  </MDO:GetListNamesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

