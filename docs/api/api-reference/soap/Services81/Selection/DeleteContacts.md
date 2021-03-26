---
uid: services81-selection-deletecontacts
title: Services81.SelectionAgent.DeleteContacts SOAP
Generated: true
---

# Services81 Selection DeleteContacts SOAP

SOAP request and response examples **Remote/Services81/Selection.svc**
Implemented by the <see cref="M:SuperOffice.Services81.ISelectionAgent.DeleteContacts">SuperOffice.Services81.ISelectionAgent.DeleteContacts</see> method.

## DeleteContacts

Deletes all contacts from a selection. If a contact does not have delete rights, it will be skipped.

* **selectionId:** Id of the selection the delete operation will be performed.



[WSDL file for Services81/Selection](../Services81-Selection.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteContacts Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services81">
  <Selection:ApplicationToken>1234567-1234-9876</Selection:ApplicationToken>
  <Selection:Credentials>
    <Selection:Ticket>7T:1234abcxyzExample==</Selection:Ticket>
  </Selection:Credentials>
 <SOAP-ENV:Body>
   <Selection:DeleteContacts>
    <Selection:SelectionId xsi:type="xsd:int">0</Selection:SelectionId>
   </Selection:DeleteContacts>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteContacts Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services81">
 <SOAP-ENV:Body>
  <Selection:DeleteContactsResponse>
  </Selection:DeleteContactsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

