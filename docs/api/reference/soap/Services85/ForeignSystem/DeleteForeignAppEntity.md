---
title: Services85.ForeignSystemAgent.DeleteForeignAppEntity SOAP
generated: 1
uid: Services85-ForeignSystem-DeleteForeignAppEntity
---

# Services85 ForeignSystem DeleteForeignAppEntity

SOAP request and response examples **Remote/Services85/ForeignSystem.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IForeignSystemAgent.DeleteForeignAppEntity">SuperOffice.Services85.IForeignSystemAgent.DeleteForeignAppEntity</see> method.

## DeleteForeignAppEntity

Deletes the ForeignAppEntity

* **foreignAppEntityId:** The identity of the ForeignAppEntity



[WSDL file for Services85/ForeignSystem](../Services85-ForeignSystem.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteForeignAppEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ForeignSystem="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <ForeignSystem:ApplicationToken>1234567-1234-9876</ForeignSystem:ApplicationToken>
  <ForeignSystem:Credentials>
    <ForeignSystem:Ticket>7T:1234abcxyzExample==</ForeignSystem:Ticket>
  </ForeignSystem:Credentials>
 <SOAP-ENV:Body>
   <ForeignSystem:DeleteForeignAppEntity>
    <ForeignSystem:ForeignAppEntityId xsi:type="xsd:int">0</ForeignSystem:ForeignAppEntityId>
   </ForeignSystem:DeleteForeignAppEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteForeignAppEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ForeignSystem="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <ForeignSystem:DeleteForeignAppEntityResponse>
  </ForeignSystem:DeleteForeignAppEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

