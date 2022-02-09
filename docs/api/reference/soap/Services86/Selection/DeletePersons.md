---
title: Services86.SelectionAgent.DeletePersons SOAP
generated: 1
uid: Services86-Selection-DeletePersons
---

# Services86 Selection DeletePersons

SOAP request and response examples **Remote/Services86/Selection.svc**
Implemented by the <see cref="M:SuperOffice.Services86.ISelectionAgent.DeletePersons">SuperOffice.Services86.ISelectionAgent.DeletePersons</see> method.

## DeletePersons

Deletes all persons from a selection. If a person does not have delete rights, it will be skipped.

* **selectionId:** Id of the selection the delete operation will be performed.



[WSDL file for Services86/Selection](../Services86-Selection.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeletePersons Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Selection:ApplicationToken>1234567-1234-9876</Selection:ApplicationToken>
  <Selection:Credentials>
    <Selection:Ticket>7T:1234abcxyzExample==</Selection:Ticket>
  </Selection:Credentials>
 <SOAP-ENV:Body>
   <Selection:DeletePersons>
    <Selection:SelectionId xsi:type="xsd:int">0</Selection:SelectionId>
   </Selection:DeletePersons>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeletePersons Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Selection:DeletePersonsResponse>
  </Selection:DeletePersonsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

