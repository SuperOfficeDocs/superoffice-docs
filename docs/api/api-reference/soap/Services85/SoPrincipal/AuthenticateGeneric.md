---
uid: services85-soprincipal-authenticategeneric
title: Services85.SoPrincipalAgent.AuthenticateGeneric SOAP
Generated: true
---

# Services85 SoPrincipal AuthenticateGeneric SOAP

SOAP request and response examples **Remote/Services85/SoPrincipal.svc**
Implemented by the <see cref="M:SuperOffice.Services85.ISoPrincipalAgent.AuthenticateGeneric">SuperOffice.Services85.ISoPrincipalAgent.AuthenticateGeneric</see> method.

## AuthenticateGeneric





[WSDL file for Services85/SoPrincipal](../Services85-SoPrincipal.md)

## AuthenticateGeneric Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.datacontract.org/2004/07/System.Security.Cryptography"
 xmlns:NetServerServices853="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:SoPrincipal="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <SoPrincipal:ApplicationToken>1234567-1234-9876</SoPrincipal:ApplicationToken>
 <SOAP-ENV:Body>
   <SoPrincipal:AuthenticateGeneric>
    <SoPrincipal:AuthenticationData xsi:type="SoPrincipal:AuthenticationGenericData">
     <SoPrincipal:AuthenticationGenericDataKeyValuePair>
      <SoPrincipal:Key xsi:type="xsd:string"></SoPrincipal:Key>
      <SoPrincipal:Value xsi:type="xsd:string"></SoPrincipal:Value>
     </SoPrincipal:AuthenticationGenericDataKeyValuePair>
    </SoPrincipal:AuthenticationData>
   </SoPrincipal:AuthenticateGeneric>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## AuthenticateGeneric Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.datacontract.org/2004/07/System.Security.Cryptography"
 xmlns:NetServerServices853="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:SoPrincipal="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <SoPrincipal:AuthenticateResponse>
   <SoPrincipal:Response xsi:type="SoPrincipal:SoPrincipalCarrier">
    <SoPrincipal:UserType xsi:type="SoPrincipal:UserType">Unknown</SoPrincipal:UserType>
    <SoPrincipal:Associate xsi:type="xsd:string"></SoPrincipal:Associate>
    <SoPrincipal:AssociateId xsi:type="xsd:int">0</SoPrincipal:AssociateId>
    <SoPrincipal:IsPerson xsi:type="xsd:boolean">false</SoPrincipal:IsPerson>
    <SoPrincipal:PersonId xsi:type="xsd:int">0</SoPrincipal:PersonId>
    <SoPrincipal:CountryId xsi:type="xsd:int">0</SoPrincipal:CountryId>
    <SoPrincipal:HomeCountryId xsi:type="xsd:int">0</SoPrincipal:HomeCountryId>
    <SoPrincipal:ContactId xsi:type="xsd:int">0</SoPrincipal:ContactId>
    <SoPrincipal:GroupId xsi:type="xsd:int">0</SoPrincipal:GroupId>
    <SoPrincipal:BusinessId xsi:type="xsd:int">0</SoPrincipal:BusinessId>
    <SoPrincipal:CategoryId xsi:type="xsd:int">0</SoPrincipal:CategoryId>
    <SoPrincipal:ContactOwner xsi:type="xsd:int">0</SoPrincipal:ContactOwner>
    <SoPrincipal:RoleId xsi:type="xsd:int">0</SoPrincipal:RoleId>
    <SoPrincipal:RoleName xsi:type="xsd:string"></SoPrincipal:RoleName>
    <SoPrincipal:RoleDescription xsi:type="xsd:string"></SoPrincipal:RoleDescription>
    <SoPrincipal:RoleType xsi:type="SoPrincipal:RoleType">Employee</SoPrincipal:RoleType>
    <SoPrincipal:Licenses xsi:type="SoPrincipal:ArrayOfGrantedModuleLicense">
     <SoPrincipal:GrantedModuleLicense xsi:type="SoPrincipal:GrantedModuleLicense">
      <SoPrincipal:OwnerId xsi:type="xsd:int">0</SoPrincipal:OwnerId>
      <SoPrincipal:OwnerName xsi:type="xsd:string"></SoPrincipal:OwnerName>
      <SoPrincipal:OwnerDescription xsi:type="xsd:string"></SoPrincipal:OwnerDescription>
      <SoPrincipal:ModuleId xsi:type="xsd:int">0</SoPrincipal:ModuleId>
      <SoPrincipal:Name xsi:type="xsd:string"></SoPrincipal:Name>
      <SoPrincipal:Description xsi:type="xsd:string"></SoPrincipal:Description>
      <SoPrincipal:Version xsi:type="xsd:string"></SoPrincipal:Version>
      <SoPrincipal:LicenseType xsi:type="SoPrincipal:LicenseType">Unknown</SoPrincipal:LicenseType>
      <SoPrincipal:ExtraFlags xsi:type="xsd:int">0</SoPrincipal:ExtraFlags>
      <SoPrincipal:SortOrder xsi:type="xsd:int">0</SoPrincipal:SortOrder>
      <SoPrincipal:LicenseNumber xsi:type="xsd:int">0</SoPrincipal:LicenseNumber>
      <SoPrincipal:IsHidden xsi:type="xsd:boolean">false</SoPrincipal:IsHidden>
      <SoPrincipal:IsUnrestricted xsi:type="xsd:boolean">false</SoPrincipal:IsUnrestricted>
      <SoPrincipal:ExpiryDate xsi:type="xsd:dateTime">2021-03-25T21:35:58Z</SoPrincipal:ExpiryDate>
     </SoPrincipal:GrantedModuleLicense>
    </SoPrincipal:Licenses>
    <SoPrincipal:FullName xsi:type="xsd:string"></SoPrincipal:FullName>
    <SoPrincipal:EMailAddress xsi:type="xsd:string"></SoPrincipal:EMailAddress>
    <SoPrincipal:FunctionRights xsi:type="NetServerServices853:ArrayOfstring">
     <NetServerServices853:string xsi:type="xsd:string"></NetServerServices853:string>
    </SoPrincipal:FunctionRights>
    <SoPrincipal:EjUserId xsi:type="xsd:int">0</SoPrincipal:EjUserId>
    <SoPrincipal:EjAccessLevel xsi:type="xsd:int">0</SoPrincipal:EjAccessLevel>
    <SoPrincipal:EjUserStatus xsi:type="SoPrincipal:EjUserStatus">StatusNone</SoPrincipal:EjUserStatus>
    <SoPrincipal:ProvidedCredentials xsi:type="SoPrincipal:ArrayOfProvidedCredential">
     <SoPrincipal:ProvidedCredential xsi:type="SoPrincipal:ProvidedCredential">
      <SoPrincipal:Type xsi:type="xsd:string"></SoPrincipal:Type>
      <SoPrincipal:SearchName xsi:type="xsd:string"></SoPrincipal:SearchName>
      <SoPrincipal:DisplayName xsi:type="xsd:string"></SoPrincipal:DisplayName>
      <SoPrincipal:CredentialId xsi:type="xsd:int">0</SoPrincipal:CredentialId>
     </SoPrincipal:ProvidedCredential>
    </SoPrincipal:ProvidedCredentials>
    <SoPrincipal:SecondaryGroups xsi:type="NetServerServices853:ArrayOfint">
     <NetServerServices853:int xsi:type="xsd:int">0</NetServerServices853:int>
    </SoPrincipal:SecondaryGroups>
    <SoPrincipal:DatabaseContextIdentifier xsi:type="xsd:string"></SoPrincipal:DatabaseContextIdentifier>
   </SoPrincipal:Response>
   <SoPrincipal:Credentials xsi:type="SoPrincipal:SoCredentials">
    <SoPrincipal:Ticket xsi:type="xsd:string"></SoPrincipal:Ticket>
   </SoPrincipal:Credentials>
   <SoPrincipal:AuthenticationSucceeded xsi:type="xsd:boolean">false</SoPrincipal:AuthenticationSucceeded>
  </SoPrincipal:AuthenticateResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

