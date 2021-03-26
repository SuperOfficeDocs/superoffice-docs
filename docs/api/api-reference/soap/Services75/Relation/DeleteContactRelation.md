---
uid: services75-relation-deletecontactrelation
title: Services75.RelationAgent.DeleteContactRelation SOAP
Generated: true
---

# Services75 Relation DeleteContactRelation SOAP

SOAP request and response examples **Remote/Services75/Relation.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IRelationAgent.DeleteContactRelation">SuperOffice.Services75.IRelationAgent.DeleteContactRelation</see> method.

## DeleteContactRelation

Deletes the spesified contact relation.

* **contactRelationEntityId:** 



[WSDL file for Services75/Relation](../Services75-Relation.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteContactRelation Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Relation="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <Relation:ApplicationToken>1234567-1234-9876</Relation:ApplicationToken>
  <Relation:Credentials>
    <Relation:Ticket>7T:1234abcxyzExample==</Relation:Ticket>
  </Relation:Credentials>
 <SOAP-ENV:Body>
   <Relation:DeleteContactRelation>
    <Relation:ContactRelationEntityId xsi:type="xsd:int">0</Relation:ContactRelationEntityId>
   </Relation:DeleteContactRelation>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteContactRelation Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Relation="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <Relation:DeleteContactRelationResponse>
  </Relation:DeleteContactRelationResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

