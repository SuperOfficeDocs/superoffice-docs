---
title: Services88.PocketAgent.GetCallerIDsFromSelection SOAP
generated: 1
uid: Services88-Pocket-GetCallerIDsFromSelection
---

# Services88 Pocket GetCallerIDsFromSelection

SOAP request and response examples **Remote/Services88/Pocket.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IPocketAgent.GetCallerIDsFromSelection">SuperOffice.Services88.IPocketAgent.GetCallerIDsFromSelection</see> method.

## GetCallerIDsFromSelection

Get caller ids from a selection. Queries the shadow selection of persons and companies, so selections of any kind can be used

* **selectionId:** Id of selection to get caller ids from
* **lastHash:** Hash for the previous call, used for checking if the same set of caller ids was sent in an earlier call, and returning null in that case

**Returns:** Collection of caller IDs, containing the hash of the caller ids


[WSDL file for Services88/Pocket](../Services88-Pocket.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetCallerIDsFromSelection Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Pocket="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Pocket:ApplicationToken>1234567-1234-9876</Pocket:ApplicationToken>
  <Pocket:Credentials>
    <Pocket:Ticket>7T:1234abcxyzExample==</Pocket:Ticket>
  </Pocket:Credentials>
 <SOAP-ENV:Body>
   <Pocket:GetCallerIDsFromSelection>
    <Pocket:SelectionId xsi:type="xsd:int">0</Pocket:SelectionId>
    <Pocket:LastHash xsi:type="xsd:string"></Pocket:LastHash>
   </Pocket:GetCallerIDsFromSelection>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetCallerIDsFromSelection Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Pocket="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Pocket:GetCallerIDsFromSelectionResponse>
   <Pocket:Response xsi:type="Pocket:CallerIDCollection">
    <Pocket:CallerIDHash xsi:type="xsd:string"></Pocket:CallerIDHash>
    <Pocket:CallerIDs xsi:type="Pocket:ArrayOfCallerID">
     <Pocket:CallerID xsi:type="Pocket:CallerID">
      <Pocket:PhoneNumber xsi:type="xsd:long">0</Pocket:PhoneNumber>
      <Pocket:DialInPrefix xsi:type="xsd:short">0</Pocket:DialInPrefix>
      <Pocket:PersonId xsi:type="xsd:int">0</Pocket:PersonId>
      <Pocket:PersonName xsi:type="xsd:string"></Pocket:PersonName>
      <Pocket:Mrmrs xsi:type="xsd:string"></Pocket:Mrmrs>
      <Pocket:ContactId xsi:type="xsd:int">0</Pocket:ContactId>
      <Pocket:ContactName xsi:type="xsd:string"></Pocket:ContactName>
     </Pocket:CallerID>
    </Pocket:CallerIDs>
   </Pocket:Response>
  </Pocket:GetCallerIDsFromSelectionResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

