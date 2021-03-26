---
uid: services80-preference-deletepreference
title: Services80.PreferenceAgent.DeletePreference SOAP
Generated: true
---

# Services80 Preference DeletePreference SOAP

SOAP request and response examples **Remote/Services80/Preference.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IPreferenceAgent.DeletePreference">SuperOffice.Services80.IPreferenceAgent.DeletePreference</see> method.

## DeletePreference

Delete a preference by id

* **id:** The id of the preference to delete

**Returns:** This method has no return value


[WSDL file for Services80/Preference](../Services80-Preference.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeletePreference Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Preference="http://www.superoffice.net/ws/crm/NetServer/Services80">
  <Preference:ApplicationToken>1234567-1234-9876</Preference:ApplicationToken>
  <Preference:Credentials>
    <Preference:Ticket>7T:1234abcxyzExample==</Preference:Ticket>
  </Preference:Credentials>
 <SOAP-ENV:Body>
   <Preference:DeletePreference>
    <Preference:Id xsi:type="xsd:int">0</Preference:Id>
   </Preference:DeletePreference>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeletePreference Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Preference="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <Preference:DeletePreferenceResponse>
  </Preference:DeletePreferenceResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

