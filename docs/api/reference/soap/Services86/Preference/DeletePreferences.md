---
title: Services86.PreferenceAgent.DeletePreferences SOAP
generated: 1
uid: Services86-Preference-DeletePreferences
---

# Services86 Preference DeletePreferences

SOAP request and response examples **Remote/Services86/Preference.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IPreferenceAgent.DeletePreferences">SuperOffice.Services86.IPreferenceAgent.DeletePreferences</see> method.

## DeletePreferences

Delete some preferences by id

* **ids:** The ids of the preference to delete

**Returns:** This method has no return value


[WSDL file for Services86/Preference](../Services86-Preference.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeletePreferences Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Preference="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Preference:ApplicationToken>1234567-1234-9876</Preference:ApplicationToken>
  <Preference:Credentials>
    <Preference:Ticket>7T:1234abcxyzExample==</Preference:Ticket>
  </Preference:Credentials>
 <SOAP-ENV:Body>
   <Preference:DeletePreferences>
    <Preference:Ids xsi:type="NetServerServices862:ArrayOfint">
     <NetServerServices862:int xsi:type="xsd:int">0</NetServerServices862:int>
    </Preference:Ids>
   </Preference:DeletePreferences>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeletePreferences Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Preference="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Preference:DeletePreferencesResponse>
  </Preference:DeletePreferencesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

