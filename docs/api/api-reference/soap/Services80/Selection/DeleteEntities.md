---
uid: services80-selection-deleteentities
title: Services80.SelectionAgent.DeleteEntities SOAP
Generated: true
---

# Services80 Selection DeleteEntities SOAP

SOAP request and response examples **Remote/Services80/Selection.svc**
Implemented by the <see cref="M:SuperOffice.Services80.ISelectionAgent.DeleteEntities">SuperOffice.Services80.ISelectionAgent.DeleteEntities</see> method.

## DeleteEntities

Deletes all entities from a selection. If an entity does not have delete rights, it will be skipped.

* **selectionId:** Id of the selection the delete operation will be performed.



[WSDL file for Services80/Selection](../Services80-Selection.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteEntities Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services80">
  <Selection:ApplicationToken>1234567-1234-9876</Selection:ApplicationToken>
  <Selection:Credentials>
    <Selection:Ticket>7T:1234abcxyzExample==</Selection:Ticket>
  </Selection:Credentials>
 <SOAP-ENV:Body>
   <Selection:DeleteEntities>
    <Selection:SelectionId xsi:type="xsd:int">0</Selection:SelectionId>
   </Selection:DeleteEntities>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteEntities Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <Selection:DeleteEntitiesResponse>
  </Selection:DeleteEntitiesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

