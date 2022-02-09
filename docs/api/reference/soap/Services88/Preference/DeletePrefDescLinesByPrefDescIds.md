---
title: Services88.PreferenceAgent.DeletePrefDescLinesByPrefDescIds SOAP
generated: 1
uid: Services88-Preference-DeletePrefDescLinesByPrefDescIds
---

# Services88 Preference DeletePrefDescLinesByPrefDescIds

SOAP request and response examples **Remote/Services88/Preference.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IPreferenceAgent.DeletePrefDescLinesByPrefDescIds">SuperOffice.Services88.IPreferenceAgent.DeletePrefDescLinesByPrefDescIds</see> method.

## DeletePrefDescLinesByPrefDescIds

Delete the PrefDescLines associated with Preference Description Ids in the SuperOffice database

* **prefDescIds:** Primary keys of the Preference Descriptions that contains PrefDescLines to delete

**Returns:** Nothing


[WSDL file for Services88/Preference](../Services88-Preference.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeletePrefDescLinesByPrefDescIds Request

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
   <Preference:DeletePrefDescLinesByPrefDescIds>
    <Preference:PrefDescIds xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </Preference:PrefDescIds>
   </Preference:DeletePrefDescLinesByPrefDescIds>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeletePrefDescLinesByPrefDescIds Response

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
  <Preference:DeletePrefDescLinesByPrefDescIdsResponse>
  </Preference:DeletePrefDescLinesByPrefDescIdsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

