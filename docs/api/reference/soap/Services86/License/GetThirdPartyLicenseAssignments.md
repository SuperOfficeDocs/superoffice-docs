---
title: Services86.LicenseAgent.GetThirdPartyLicenseAssignments SOAP
generated: 1
uid: Services86-License-GetThirdPartyLicenseAssignments
---

# Services86 License GetThirdPartyLicenseAssignments

SOAP request and response examples **Remote/Services86/License.svc**
Implemented by the <see cref="M:SuperOffice.Services86.ILicenseAgent.GetThirdPartyLicenseAssignments">SuperOffice.Services86.ILicenseAgent.GetThirdPartyLicenseAssignments</see> method.

## GetThirdPartyLicenseAssignments

Get license assignments for an associate for licenses belonging to an other module owner than SuperOffice

* **associateId:** User to get third party license assignments for
* **moduleOwner:** Name of the module owner to get license assignments for

**Returns:** Module license names


[WSDL file for Services86/License](../Services86-License.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetThirdPartyLicenseAssignments Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.datacontract.org/2004/07/System.Security.Cryptography"
 xmlns:NetServerServices863="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:License="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <License:ApplicationToken>1234567-1234-9876</License:ApplicationToken>
  <License:Credentials>
    <License:Ticket>7T:1234abcxyzExample==</License:Ticket>
  </License:Credentials>
 <SOAP-ENV:Body>
   <License:GetThirdPartyLicenseAssignments>
    <License:AssociateId xsi:type="xsd:int">0</License:AssociateId>
    <License:ModuleOwner xsi:type="xsd:string"></License:ModuleOwner>
   </License:GetThirdPartyLicenseAssignments>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetThirdPartyLicenseAssignments Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.datacontract.org/2004/07/System.Security.Cryptography"
 xmlns:NetServerServices863="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:License="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <License:GetThirdPartyLicenseAssignmentsResponse>
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
  </License:GetThirdPartyLicenseAssignmentsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

