---
title: Services86.PreferenceAgent.DeletePreferenceDescription SOAP
generated: 1
uid: Services86-Preference-DeletePreferenceDescription
---

# Services86 Preference DeletePreferenceDescription

SOAP request and response examples **Remote/Services86/Preference.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IPreferenceAgent.DeletePreferenceDescription">SuperOffice.Services86.IPreferenceAgent.DeletePreferenceDescription</see> method.

## DeletePreferenceDescription

Deletes the PreferenceDescription

* **preferenceDescriptionId:** The identity of the PreferenceDescription



[WSDL file for Services86/Preference](../Services86-Preference.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeletePreferenceDescription Request

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
   <Preference:DeletePreferenceDescription>
    <Preference:PreferenceDescriptionId xsi:type="xsd:int">0</Preference:PreferenceDescriptionId>
   </Preference:DeletePreferenceDescription>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeletePreferenceDescription Response

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
  <Preference:DeletePreferenceDescriptionResponse>
  </Preference:DeletePreferenceDescriptionResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

