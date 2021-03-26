---
uid: services83-license-assignthirdpartylicenses
title: Services83.LicenseAgent.AssignThirdPartyLicenses SOAP
Generated: true
---

# Services83 License AssignThirdPartyLicenses SOAP

SOAP request and response examples **Remote/Services83/License.svc**
Implemented by the <see cref="M:SuperOffice.Services83.ILicenseAgent.AssignThirdPartyLicenses">SuperOffice.Services83.ILicenseAgent.AssignThirdPartyLicenses</see> method.

## AssignThirdPartyLicenses

Assign third party licenses

* **associateId:** User to assign third party licenses for
* **moduleOwner:** Name of the module owner to assign license for
* **moduleLicenseNames:** Name of module licenses to assign

**Returns:** All module license names assigned


[WSDL file for Services83/License](../Services83-License.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## AssignThirdPartyLicenses Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.datacontract.org/2004/07/System.Security.Cryptography"
 xmlns:NetServerServices833="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:License="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <License:ApplicationToken>1234567-1234-9876</License:ApplicationToken>
  <License:Credentials>
    <License:Ticket>7T:1234abcxyzExample==</License:Ticket>
  </License:Credentials>
 <SOAP-ENV:Body>
   <License:AssignThirdPartyLicenses>
    <License:AssociateId xsi:type="xsd:int">0</License:AssociateId>
    <License:ModuleOwner xsi:type="xsd:string"></License:ModuleOwner>
    <License:ModuleLicenseNames xsi:type="NetServerServices833:ArrayOfstring">
     <NetServerServices833:string xsi:type="xsd:string"></NetServerServices833:string>
    </License:ModuleLicenseNames>
   </License:AssignThirdPartyLicenses>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## AssignThirdPartyLicenses Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.datacontract.org/2004/07/System.Security.Cryptography"
 xmlns:NetServerServices833="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:License="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <License:AssignThirdPartyLicensesResponse>
   <License:Response xsi:type="License:ArrayOfModuleLicenseLink">
    <License:ModuleLicenseLink xsi:type="License:ModuleLicenseLink">
     <License:Unrestricted xsi:type="xsd:boolean">false</License:Unrestricted>
     <License:Total xsi:type="xsd:int">0</License:Total>
     <License:Tooltip xsi:type="xsd:string"></License:Tooltip>
     <License:CanAssign xsi:type="xsd:boolean">false</License:CanAssign>
     <License:Free xsi:type="xsd:int">0</License:Free>
     <License:InUse xsi:type="xsd:int">0</License:InUse>
     <License:Assigned xsi:type="xsd:boolean">false</License:Assigned>
     <License:ModuleLicenseId xsi:type="xsd:int">0</License:ModuleLicenseId>
     <License:Name xsi:type="xsd:string"></License:Name>
     <License:Description xsi:type="xsd:string"></License:Description>
     <License:PrerequisiteModuleName xsi:type="xsd:string"></License:PrerequisiteModuleName>
     <License:SortOrder xsi:type="xsd:int">0</License:SortOrder>
    </License:ModuleLicenseLink>
   </License:Response>
  </License:AssignThirdPartyLicensesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

