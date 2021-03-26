---
uid: services82-user-getuserinfo
title: Services82.UserAgent.GetUserInfo SOAP
Generated: true
---

# Services82 User GetUserInfo SOAP

SOAP request and response examples **Remote/Services82/User.svc**
Implemented by the <see cref="M:SuperOffice.Services82.IUserAgent.GetUserInfo">SuperOffice.Services82.IUserAgent.GetUserInfo</see> method.

## GetUserInfo

Gets a UserInfo object.

* **userInfoId:** The identifier of the UserInfo object

**Returns:** UserInfo


[WSDL file for Services82/User](../Services82-User.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetUserInfo Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services82">
  <User:ApplicationToken>1234567-1234-9876</User:ApplicationToken>
  <User:Credentials>
    <User:Ticket>7T:1234abcxyzExample==</User:Ticket>
  </User:Credentials>
 <SOAP-ENV:Body>
   <User:GetUserInfo>
    <User:UserInfoId xsi:type="xsd:int">0</User:UserInfoId>
   </User:GetUserInfo>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetUserInfo Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services82">
 <SOAP-ENV:Body>
  <User:GetUserInfoResponse>
   <User:Response xsi:type="User:UserInfo">
    <User:Deleted xsi:type="xsd:boolean">false</User:Deleted>
    <User:UserInfoId xsi:type="xsd:int">0</User:UserInfoId>
    <User:UserName xsi:type="xsd:string"></User:UserName>
    <User:PersonId xsi:type="xsd:int">0</User:PersonId>
    <User:Rank xsi:type="xsd:short">0</User:Rank>
    <User:Tooltip xsi:type="xsd:string"></User:Tooltip>
    <User:UserGroupId xsi:type="xsd:int">0</User:UserGroupId>
    <User:EjUserId xsi:type="xsd:int">0</User:EjUserId>
    <User:UserType xsi:type="User:UserType">Unknown</User:UserType>
    <User:GrantedLicenses xsi:type="NetServerServices822:ArrayOfstring">
     <NetServerServices822:string xsi:type="xsd:string"></NetServerServices822:string>
    </User:GrantedLicenses>
    <User:CanLogon xsi:type="xsd:boolean">false</User:CanLogon>
    <User:RoleName xsi:type="xsd:string"></User:RoleName>
    <User:RoleTooltip xsi:type="xsd:string"></User:RoleTooltip>
    <User:UserGroupName xsi:type="xsd:string"></User:UserGroupName>
    <User:UserGroupTooltip xsi:type="xsd:string"></User:UserGroupTooltip>
   </User:Response>
  </User:GetUserInfoResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

