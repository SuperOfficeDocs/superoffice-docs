---
title: Services88.PreferenceAgent.SavePreferenceDescriptionLines SOAP
generated: 1
uid: Services88-Preference-SavePreferenceDescriptionLines
---

# Services88 Preference SavePreferenceDescriptionLines

SOAP request and response examples **Remote/Services88/Preference.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IPreferenceAgent.SavePreferenceDescriptionLines">SuperOffice.Services88.IPreferenceAgent.SavePreferenceDescriptionLines</see> method.

## SavePreferenceDescriptionLines

Saves the PreferenceDescriptionLine array in the SuperOffice database

* **preferenceDescriptionLines:** The PreferenceDescriptionLine array to save.

**Returns:** The updated PrefDesc lines (If the PreferenceDescriptionLine array was new, it returns with id's set.


[WSDL file for Services88/Preference](../Services88-Preference.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SavePreferenceDescriptionLines Request

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
   <Preference:SavePreferenceDescriptionLines>
    <Preference:PreferenceDescriptionLines xsi:type="Preference:ArrayOfPreferenceDescriptionLine">
     <Preference:PreferenceDescriptionLine xsi:type="Preference:PreferenceDescriptionLine">
      <Preference:PrefDescLineId xsi:type="xsd:int">0</Preference:PrefDescLineId>
      <Preference:PrefDescId xsi:type="xsd:int">0</Preference:PrefDescId>
      <Preference:PrefValue xsi:type="xsd:string"></Preference:PrefValue>
      <Preference:PrefShowValue xsi:type="xsd:string"></Preference:PrefShowValue>
      <Preference:Description xsi:type="xsd:string"></Preference:Description>
      <Preference:IsBuiltin xsi:type="xsd:boolean">false</Preference:IsBuiltin>
     </Preference:PreferenceDescriptionLine>
    </Preference:PreferenceDescriptionLines>
   </Preference:SavePreferenceDescriptionLines>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SavePreferenceDescriptionLines Response

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
  <Preference:SavePreferenceDescriptionLinesResponse>
   <Preference:Response xsi:type="Preference:ArrayOfPreferenceDescriptionLine">
    <Preference:PreferenceDescriptionLine xsi:type="Preference:PreferenceDescriptionLine">
     <Preference:PrefDescLineId xsi:type="xsd:int">0</Preference:PrefDescLineId>
     <Preference:PrefDescId xsi:type="xsd:int">0</Preference:PrefDescId>
     <Preference:PrefValue xsi:type="xsd:string"></Preference:PrefValue>
     <Preference:PrefShowValue xsi:type="xsd:string"></Preference:PrefShowValue>
     <Preference:Description xsi:type="xsd:string"></Preference:Description>
     <Preference:IsBuiltin xsi:type="xsd:boolean">false</Preference:IsBuiltin>
    </Preference:PreferenceDescriptionLine>
   </Preference:Response>
  </Preference:SavePreferenceDescriptionLinesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

