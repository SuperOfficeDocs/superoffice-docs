---
title: Services88.DiagnosticsAgent.GetAnalyticsData SOAP
generated: true
uid: Services88-Diagnostics-GetAnalyticsData
content_type: reference
---

# Services88 Diagnostics GetAnalyticsData

SOAP request and response examples **Remote/Services88/Diagnostics.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IDiagnosticsAgent.GetAnalyticsData">SuperOffice.Services88.IDiagnosticsAgent.GetAnalyticsData</see> method.

## GetAnalyticsData





[WSDL file for Services88/Diagnostics](../Services88-Diagnostics.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetAnalyticsData Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Diagnostics="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Diagnostics:ApplicationToken>1234567-1234-9876</Diagnostics:ApplicationToken>
  <Diagnostics:Credentials>
    <Diagnostics:Ticket>7T:1234abcxyzExample==</Diagnostics:Ticket>
  </Diagnostics:Credentials>
 <SOAP-ENV:Body>
   <Diagnostics:GetAnalyticsData>
   </Diagnostics:GetAnalyticsData>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetAnalyticsData Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Diagnostics="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Diagnostics:GetAnalyticsDataResponse>
   <Diagnostics:Response xsi:type="Diagnostics:AnalyticsData">
    <Diagnostics:AmplitudeApiKey xsi:type="xsd:string"></Diagnostics:AmplitudeApiKey>
    <Diagnostics:UserflowToken xsi:type="xsd:string"></Diagnostics:UserflowToken>
    <Diagnostics:Name xsi:type="xsd:string"></Diagnostics:Name>
    <Diagnostics:Email xsi:type="xsd:string"></Diagnostics:Email>
    <Diagnostics:Company xsi:type="xsd:string"></Diagnostics:Company>
    <Diagnostics:LicenseStatus xsi:type="Diagnostics:UserAndInstallationLicenceStatus">
     <Diagnostics:AdminWarningDate xsi:type="xsd:dateTime">2025-12-18T01:30:08Z</Diagnostics:AdminWarningDate>
     <Diagnostics:ExpiryDate xsi:type="xsd:dateTime">2025-12-18T01:30:08Z</Diagnostics:ExpiryDate>
     <Diagnostics:GraceDate xsi:type="xsd:dateTime">2025-12-18T01:30:08Z</Diagnostics:GraceDate>
     <Diagnostics:CompanyName xsi:type="xsd:string"></Diagnostics:CompanyName>
     <Diagnostics:SerialNr xsi:type="xsd:string"></Diagnostics:SerialNr>
     <Diagnostics:UserLicenses xsi:type="NetServerServices882:ArrayOfstring">
      <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
     </Diagnostics:UserLicenses>
    </Diagnostics:LicenseStatus>
    <Diagnostics:HasLicensce xsi:type="Diagnostics:StringBoolDictionary">
     <Diagnostics:StringBoolKeyValuePair>
      <Diagnostics:Key xsi:type="xsd:string"></Diagnostics:Key>
      <Diagnostics:Value xsi:type="xsd:boolean">false</Diagnostics:Value>
     </Diagnostics:StringBoolKeyValuePair>
    </Diagnostics:HasLicensce>
    <Diagnostics:SystemLicenseNames xsi:type="NetServerServices882:ArrayOfstring">
     <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
    </Diagnostics:SystemLicenseNames>
    <Diagnostics:UserSignedUpAt xsi:type="xsd:string"></Diagnostics:UserSignedUpAt>
    <Diagnostics:NumContact xsi:type="xsd:int">0</Diagnostics:NumContact>
    <Diagnostics:NumPerson xsi:type="xsd:int">0</Diagnostics:NumPerson>
    <Diagnostics:NumAppointment xsi:type="xsd:int">0</Diagnostics:NumAppointment>
    <Diagnostics:NumSale xsi:type="xsd:int">0</Diagnostics:NumSale>
    <Diagnostics:NumProject xsi:type="xsd:int">0</Diagnostics:NumProject>
    <Diagnostics:NumSelection xsi:type="xsd:int">0</Diagnostics:NumSelection>
    <Diagnostics:NumEmailItem xsi:type="xsd:int">0</Diagnostics:NumEmailItem>
    <Diagnostics:NumTicketLogAction xsi:type="xsd:int">0</Diagnostics:NumTicketLogAction>
    <Diagnostics:NumDashboard xsi:type="xsd:int">0</Diagnostics:NumDashboard>
    <Diagnostics:NumQuote xsi:type="xsd:int">0</Diagnostics:NumQuote>
    <Diagnostics:NumQuoteLine xsi:type="xsd:int">0</Diagnostics:NumQuoteLine>
    <Diagnostics:NumDocument xsi:type="xsd:int">0</Diagnostics:NumDocument>
    <Diagnostics:NumTargetAssignmentInfo xsi:type="xsd:int">0</Diagnostics:NumTargetAssignmentInfo>
    <Diagnostics:NumMailing xsi:type="xsd:int">0</Diagnostics:NumMailing>
    <Diagnostics:NumForm xsi:type="xsd:int">0</Diagnostics:NumForm>
    <Diagnostics:NumWorkflow xsi:type="xsd:int">0</Diagnostics:NumWorkflow>
    <Diagnostics:TotContact xsi:type="xsd:int">0</Diagnostics:TotContact>
    <Diagnostics:TotPerson xsi:type="xsd:int">0</Diagnostics:TotPerson>
    <Diagnostics:TotAppointment xsi:type="xsd:int">0</Diagnostics:TotAppointment>
    <Diagnostics:TotSale xsi:type="xsd:int">0</Diagnostics:TotSale>
    <Diagnostics:TotProject xsi:type="xsd:int">0</Diagnostics:TotProject>
    <Diagnostics:TotSelection xsi:type="xsd:int">0</Diagnostics:TotSelection>
    <Diagnostics:TotEmailItem xsi:type="xsd:int">0</Diagnostics:TotEmailItem>
    <Diagnostics:TotTicketLogAction xsi:type="xsd:int">0</Diagnostics:TotTicketLogAction>
    <Diagnostics:TotDashboard xsi:type="xsd:int">0</Diagnostics:TotDashboard>
    <Diagnostics:TotQuote xsi:type="xsd:int">0</Diagnostics:TotQuote>
    <Diagnostics:TotQuoteLine xsi:type="xsd:int">0</Diagnostics:TotQuoteLine>
    <Diagnostics:TotDocument xsi:type="xsd:int">0</Diagnostics:TotDocument>
    <Diagnostics:TotTargetAssignmentInfo xsi:type="xsd:int">0</Diagnostics:TotTargetAssignmentInfo>
    <Diagnostics:TotMailing xsi:type="xsd:int">0</Diagnostics:TotMailing>
    <Diagnostics:TotForm xsi:type="xsd:int">0</Diagnostics:TotForm>
    <Diagnostics:TotWorkflow xsi:type="xsd:int">0</Diagnostics:TotWorkflow>
    <Diagnostics:UserRegisteredAgeDays xsi:type="xsd:int">0</Diagnostics:UserRegisteredAgeDays>
    <Diagnostics:UserCountryName xsi:type="xsd:string"></Diagnostics:UserCountryName>
    <Diagnostics:UserCountryCode xsi:type="xsd:string"></Diagnostics:UserCountryCode>
    <Diagnostics:Preferences xsi:type="Diagnostics:StringBoolDictionary">
     <Diagnostics:StringBoolKeyValuePair>
      <Diagnostics:Key xsi:type="xsd:string"></Diagnostics:Key>
      <Diagnostics:Value xsi:type="xsd:boolean">false</Diagnostics:Value>
     </Diagnostics:StringBoolKeyValuePair>
    </Diagnostics:Preferences>
    <Diagnostics:TotWebUsers xsi:type="xsd:int">0</Diagnostics:TotWebUsers>
    <Diagnostics:GroupCountryName xsi:type="xsd:string"></Diagnostics:GroupCountryName>
    <Diagnostics:GroupCountryCode xsi:type="xsd:string"></Diagnostics:GroupCountryCode>
    <Diagnostics:GroupRegisteredDate xsi:type="xsd:string"></Diagnostics:GroupRegisteredDate>
    <Diagnostics:GroupRegisteredAgeDays xsi:type="xsd:int">0</Diagnostics:GroupRegisteredAgeDays>
    <Diagnostics:FeatureToggles xsi:type="Diagnostics:StringBoolDictionary">
     <Diagnostics:StringBoolKeyValuePair>
      <Diagnostics:Key xsi:type="xsd:string"></Diagnostics:Key>
      <Diagnostics:Value xsi:type="xsd:boolean">false</Diagnostics:Value>
     </Diagnostics:StringBoolKeyValuePair>
    </Diagnostics:FeatureToggles>
    <Diagnostics:FileVersion xsi:type="xsd:string"></Diagnostics:FileVersion>
    <Diagnostics:FileVersionNumber xsi:type="xsd:int">0</Diagnostics:FileVersionNumber>
   </Diagnostics:Response>
  </Diagnostics:GetAnalyticsDataResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

