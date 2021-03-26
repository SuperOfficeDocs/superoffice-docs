---
uid: services83-user-getuserinfolist
title: Services83.UserAgent.GetUserInfoList SOAP
Generated: true
---

# Services83 User GetUserInfoList SOAP

SOAP request and response examples **Remote/Services83/User.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IUserAgent.GetUserInfoList">SuperOffice.Services83.IUserAgent.GetUserInfoList</see> method.

## GetUserInfoList

Gets an array of UserInfo objects.

* **userInfoIds:** The identifiers of the UserInfo object

**Returns:** Array of UserInfo objects


[WSDL file for Services83/User](../Services83-User.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetUserInfoList Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <User:ApplicationToken>1234567-1234-9876</User:ApplicationToken>
  <User:Credentials>
    <User:Ticket>7T:1234abcxyzExample==</User:Ticket>
  </User:Credentials>
 <SOAP-ENV:Body>
   <User:GetUserInfoList>
    <User:UserInfoIds xsi:type="NetServerServices832:ArrayOfint">
     <NetServerServices832:int xsi:type="xsd:int">0</NetServerServices832:int>
    </User:UserInfoIds>
   </User:GetUserInfoList>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetUserInfoList Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <User:GetUserInfoListResponse>
   <User:Response xsi:type="User:ArrayOfUserInfo">
    <User:UserInfo xsi:type="User:UserInfo">
     <User:Deleted xsi:type="xsd:boolean">false</User:Deleted>
     <User:UserInfoId xsi:type="xsd:int">0</User:UserInfoId>
     <User:UserName xsi:type="xsd:string"></User:UserName>
     <User:PersonId xsi:type="xsd:int">0</User:PersonId>
     <User:Rank xsi:type="xsd:short">0</User:Rank>
     <User:Tooltip xsi:type="xsd:string"></User:Tooltip>
     <User:UserGroupId xsi:type="xsd:int">0</User:UserGroupId>
     <User:EjUserId xsi:type="xsd:int">0</User:EjUserId>
     <User:UserType xsi:type="User:UserType">Unknown</User:UserType>
     <User:GrantedLicenses xsi:type="NetServerServices832:ArrayOfstring">
      <NetServerServices832:string xsi:type="xsd:string"></NetServerServices832:string>
     </User:GrantedLicenses>
     <User:CanLogon xsi:type="xsd:boolean">false</User:CanLogon>
     <User:RoleName xsi:type="xsd:string"></User:RoleName>
     <User:RoleTooltip xsi:type="xsd:string"></User:RoleTooltip>
     <User:UserGroupName xsi:type="xsd:string"></User:UserGroupName>
     <User:UserGroupTooltip xsi:type="xsd:string"></User:UserGroupTooltip>
    </User:UserInfo>
   </User:Response>
  </User:GetUserInfoListResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

