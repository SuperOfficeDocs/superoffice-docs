---
uid: services75-resource-activateresourcesubstitution
title: Services75.ResourceAgent.ActivateResourceSubstitution SOAP
Generated: true
---

# Services75 Resource ActivateResourceSubstitution SOAP

SOAP request and response examples **Remote/Services75/Resource.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IResourceAgent.ActivateResourceSubstitution">SuperOffice.Services75.IResourceAgent.ActivateResourceSubstitution</see> method.

## ActivateResourceSubstitution

Activate or deactive a resource substitution for one or more cultures

* **resourceName:** The name of the resource, without any brackets; if blank then this is the MASTER SWITCH for the override system
* **culture:** The .NET culture string; if blank, then ALL substitutions for this resource will be affected
* **isActive:** New status of override

**Returns:** This method has no return value


[WSDL file for Services75/Resource](../Services75-Resource.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ActivateResourceSubstitution Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Resource="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <Resource:ApplicationToken>1234567-1234-9876</Resource:ApplicationToken>
  <Resource:Credentials>
    <Resource:Ticket>7T:1234abcxyzExample==</Resource:Ticket>
  </Resource:Credentials>
 <SOAP-ENV:Body>
   <Resource:ActivateResourceSubstitution>
    <Resource:ResourceName xsi:type="xsd:string"></Resource:ResourceName>
    <Resource:Culture xsi:type="xsd:string"></Resource:Culture>
    <Resource:IsActive xsi:type="xsd:boolean">false</Resource:IsActive>
   </Resource:ActivateResourceSubstitution>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ActivateResourceSubstitution Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Resource="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <Resource:ActivateResourceSubstitutionResponse>
  </Resource:ActivateResourceSubstitutionResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

