---
title: Services85.ResourceAgent.GetResourceSubstitutions SOAP
generated: 1
uid: Services85-Resource-GetResourceSubstitutions
---

# Services85 Resource GetResourceSubstitutions

SOAP request and response examples **Remote/Services85/Resource.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IResourceAgent.GetResourceSubstitutions">SuperOffice.Services85.IResourceAgent.GetResourceSubstitutions</see> method.

## GetResourceSubstitutions

Get substitutions for some or all resources for one culture

* **resourceNames:** Array of names of resources for which overrides are sought; if empty, then get all
* **culture:** .NET culture string; if empty, then get all
* **activeOnly:** If true, then only resources with active substitutions will be returned; if false then ALL existing overrides will be returned

**Returns:** Array of override objects, empty if there are none


[WSDL file for Services85/Resource](../Services85-Resource.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetResourceSubstitutions Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Resource="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Resource:ApplicationToken>1234567-1234-9876</Resource:ApplicationToken>
  <Resource:Credentials>
    <Resource:Ticket>7T:1234abcxyzExample==</Resource:Ticket>
  </Resource:Credentials>
 <SOAP-ENV:Body>
   <Resource:GetResourceSubstitutions>
    <Resource:ResourceNames xsi:type="NetServerServices852:ArrayOfstring">
     <NetServerServices852:string xsi:type="xsd:string"></NetServerServices852:string>
    </Resource:ResourceNames>
    <Resource:Culture xsi:type="xsd:string"></Resource:Culture>
    <Resource:ActiveOnly xsi:type="xsd:boolean">false</Resource:ActiveOnly>
   </Resource:GetResourceSubstitutions>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetResourceSubstitutions Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Resource="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Resource:GetResourceSubstitutionsResponse>
   <Resource:Response xsi:type="Resource:ArrayOfResourceOverride">
    <Resource:ResourceOverride xsi:type="Resource:ResourceOverride">
     <Resource:ResourceName xsi:type="xsd:string"></Resource:ResourceName>
     <Resource:ResourceValue xsi:type="xsd:string"></Resource:ResourceValue>
     <Resource:Culture xsi:type="xsd:string"></Resource:Culture>
     <Resource:IsActive xsi:type="xsd:boolean">false</Resource:IsActive>
    </Resource:ResourceOverride>
   </Resource:Response>
  </Resource:GetResourceSubstitutionsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

