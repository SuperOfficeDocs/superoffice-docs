---
title: Services88.PreferenceAgent.DeletePrefDescLinesByPrefDescId SOAP
generated: 1
uid: Services88-Preference-DeletePrefDescLinesByPrefDescId
---

# Services88 Preference DeletePrefDescLinesByPrefDescId

SOAP request and response examples **Remote/Services88/Preference.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IPreferenceAgent.DeletePrefDescLinesByPrefDescId">SuperOffice.Services88.IPreferenceAgent.DeletePrefDescLinesByPrefDescId</see> method.

## DeletePrefDescLinesByPrefDescId

Delete the PrefDescLines associated with Preference Description Id in the SuperOffice database

* **prefDescId:** Primary key of the Preference Description that contains PrefDescLines to delete

**Returns:** Nothing


[WSDL file for Services88/Preference](../Services88-Preference.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeletePrefDescLinesByPrefDescId Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Preference="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Preference:ApplicationToken>1234567-1234-9876</Preference:ApplicationToken>
  <Preference:Credentials>
    <Preference:Ticket>7T:1234abcxyzExample==</Preference:Ticket>
  </Preference:Credentials>
 <SOAP-ENV:Body>
   <Preference:DeletePrefDescLinesByPrefDescId>
    <Preference:PrefDescId xsi:type="xsd:int">0</Preference:PrefDescId>
   </Preference:DeletePrefDescLinesByPrefDescId>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeletePrefDescLinesByPrefDescId Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Preference="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Preference:DeletePrefDescLinesByPrefDescIdResponse>
  </Preference:DeletePrefDescLinesByPrefDescIdResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

