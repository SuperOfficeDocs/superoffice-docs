---
title: Services88.TargetsAgent.DeleteTargetGroup SOAP
generated: true
uid: Services88-Targets-DeleteTargetGroup
content_type: reference
---

# Services88 Targets DeleteTargetGroup

SOAP request and response examples **Remote/Services88/Targets.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ITargetsAgent.DeleteTargetGroup">SuperOffice.Services88.ITargetsAgent.DeleteTargetGroup</see> method.

## DeleteTargetGroup





[WSDL file for Services88/Targets](../Services88-Targets.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteTargetGroup Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Targets="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Targets:ApplicationToken>1234567-1234-9876</Targets:ApplicationToken>
  <Targets:Credentials>
    <Targets:Ticket>7T:1234abcxyzExample==</Targets:Ticket>
  </Targets:Credentials>
 <SOAP-ENV:Body>
   <Targets:DeleteTargetGroup>
    <Targets:TargetGroupId xsi:type="xsd:int">0</Targets:TargetGroupId>
   </Targets:DeleteTargetGroup>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteTargetGroup Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Targets="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Targets:DeleteTargetGroupResponse>
  </Targets:DeleteTargetGroupResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

