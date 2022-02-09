---
title: Services88.SelectionAgent.DeleteContacts SOAP
generated: 1
uid: Services88-Selection-DeleteContacts
---

# Services88 Selection DeleteContacts

SOAP request and response examples **Remote/Services88/Selection.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ISelectionAgent.DeleteContacts">SuperOffice.Services88.ISelectionAgent.DeleteContacts</see> method.

## DeleteContacts

Deletes all contacts from a selection. If a contact does not have delete rights, it will be skipped.

* **selectionId:** Id of the selection the delete operation will be performed.



[WSDL file for Services88/Selection](../Services88-Selection.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteContacts Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Selection:DeleteContactsResponse>
  </Selection:DeleteContactsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

