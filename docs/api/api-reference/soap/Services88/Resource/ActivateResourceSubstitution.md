---
uid: services88-resource-activateresourcesubstitution
title: Services88.ResourceAgent.ActivateResourceSubstitution SOAP
Generated: true
---

# Services88 Resource ActivateResourceSubstitution SOAP

SOAP request and response examples **Remote/Services88/Resource.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IResourceAgent.ActivateResourceSubstitution">SuperOffice.Services88.IResourceAgent.ActivateResourceSubstitution</see> method.

## ActivateResourceSubstitution

Activate or deactive a resource substitution for one or more cultures

* **resourceName:** The name of the resource, without any brackets; if blank then this is the MASTER SWITCH for the override system
* **culture:** The .NET culture string; if blank, then ALL substitutions for this resource will be affected
* **isActive:** New status of override

**Returns:** This method has no return value


[WSDL file for Services88/Resource](../Services88-Resource.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ActivateResourceSubstitution Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Resource="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Resource="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Resource:ActivateResourceSubstitutionResponse>
  </Resource:ActivateResourceSubstitutionResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

