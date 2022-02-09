---
title: Services87.SelectionAgent.AddSelectionMembers SOAP
generated: 1
uid: Services87-Selection-AddSelectionMembers
---

# Services87 Selection AddSelectionMembers

SOAP request and response examples **Remote/Services87/Selection.svc**
Implemented by the <see cref="M:SuperOffice.Services87.ISelectionAgent.AddSelectionMembers">SuperOffice.Services87.ISelectionAgent.AddSelectionMembers</see> method.

## AddSelectionMembers

Add selection members to a static selection of type others than contacts.

* **selectionId:** The selection id to add the members to.
* **ids:** Collection of ids to add to the selection.

**Returns:** Returns number of members added to the selection.


[WSDL file for Services87/Selection](../Services87-Selection.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## AddSelectionMembers Request

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
   <Selection:AddSelectionMembers>
    <Selection:SelectionId xsi:type="xsd:int">0</Selection:SelectionId>
    <Selection:Ids xsi:type="NetServerServices872:ArrayOfint">
     <NetServerServices872:int xsi:type="xsd:int">0</NetServerServices872:int>
    </Selection:Ids>
   </Selection:AddSelectionMembers>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## AddSelectionMembers Response

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
  <Selection:AddSelectionMembersResponse>
   <Selection:Response xsi:type="xsd:int">0</Selection:Response>
  </Selection:AddSelectionMembersResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

