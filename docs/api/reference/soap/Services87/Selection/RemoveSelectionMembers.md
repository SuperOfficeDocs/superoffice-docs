---
title: Services87.SelectionAgent.RemoveSelectionMembers SOAP
generated: 1
uid: Services87-Selection-RemoveSelectionMembers
---

# Services87 Selection RemoveSelectionMembers

SOAP request and response examples **Remote/Services87/Selection.svc**
Implemented by the <see cref="M:SuperOffice.Services87.ISelectionAgent.RemoveSelectionMembers">SuperOffice.Services87.ISelectionAgent.RemoveSelectionMembers</see> method.

## RemoveSelectionMembers

Removes members from the selection as  specified in the collection of entity ids. The ids are selection member ids (selection member primary key)

* **selectionId:** The id of the selection where to members will be removed.
* **selectionMemberIds:** Selection member primary keys



[WSDL file for Services87/Selection](../Services87-Selection.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## RemoveSelectionMembers Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Selection:ApplicationToken>1234567-1234-9876</Selection:ApplicationToken>
  <Selection:Credentials>
    <Selection:Ticket>7T:1234abcxyzExample==</Selection:Ticket>
  </Selection:Credentials>
 <SOAP-ENV:Body>
   <Selection:RemoveSelectionMembers>
    <Selection:SelectionId xsi:type="xsd:int">0</Selection:SelectionId>
    <Selection:SelectionMemberIds xsi:type="NetServerServices872:ArrayOfint">
     <NetServerServices872:int xsi:type="xsd:int">0</NetServerServices872:int>
    </Selection:SelectionMemberIds>
   </Selection:RemoveSelectionMembers>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## RemoveSelectionMembers Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Selection:RemoveSelectionMembersResponse>
  </Selection:RemoveSelectionMembersResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

