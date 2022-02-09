---
title: Services88.ChatAgent.GetUserAgentList SOAP
generated: 1
uid: Services88-Chat-GetUserAgentList
---

# Services88 Chat GetUserAgentList

SOAP request and response examples **Remote/Services88/Chat.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IChatAgent.GetUserAgentList">SuperOffice.Services88.IChatAgent.GetUserAgentList</see> method.

## GetUserAgentList

Get list of users that can be assigned to chat topics. Users with Chat-CALs from the MDO list 'chatuser'

* **flat:** Return flat list instead of grouping by usergroup.
* **onlyPresent:** Only show users who are present

**Returns:** List of user agents that can be assigned to chat topics, possibly grouped by usergroup.


[WSDL file for Services88/Chat](../Services88-Chat.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetUserAgentList Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Chat="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Chat:ApplicationToken>1234567-1234-9876</Chat:ApplicationToken>
  <Chat:Credentials>
    <Chat:Ticket>7T:1234abcxyzExample==</Chat:Ticket>
  </Chat:Credentials>
 <SOAP-ENV:Body>
   <Chat:GetUserAgentList>
    <Chat:Flat xsi:type="xsd:boolean">false</Chat:Flat>
    <Chat:OnlyPresent xsi:type="xsd:boolean">false</Chat:OnlyPresent>
   </Chat:GetUserAgentList>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetUserAgentList Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Chat="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Chat:GetUserAgentListResponse>
   <Chat:Response xsi:type="Chat:ArrayOfMDOListItem">
    <Chat:MDOListItem xsi:type="Chat:MDOListItem">
     <Chat:Id xsi:type="xsd:int">0</Chat:Id>
     <Chat:Name xsi:type="xsd:string"></Chat:Name>
     <Chat:ToolTip xsi:type="xsd:string"></Chat:ToolTip>
     <Chat:Deleted xsi:type="xsd:boolean">false</Chat:Deleted>
     <Chat:Rank xsi:type="xsd:int">0</Chat:Rank>
     <Chat:Type xsi:type="xsd:string"></Chat:Type>
     <Chat:ChildItems xsi:type="Chat:ArrayOfMDOListItem">
      <Chat:MDOListItem xsi:type="Chat:MDOListItem">
       <Chat:Id xsi:type="xsd:int">0</Chat:Id>
       <Chat:Name xsi:type="xsd:string"></Chat:Name>
       <Chat:ToolTip xsi:type="xsd:string"></Chat:ToolTip>
       <Chat:Deleted xsi:type="xsd:boolean">false</Chat:Deleted>
       <Chat:Rank xsi:type="xsd:int">0</Chat:Rank>
       <Chat:Type xsi:type="xsd:string"></Chat:Type>
       <Chat:ChildItems xsi:type="Chat:ArrayOfMDOListItem">
        <Chat:MDOListItem xsi:type="Chat:MDOListItem">
         <Chat:Id xsi:type="xsd:int">0</Chat:Id>
         <Chat:Name xsi:type="xsd:string"></Chat:Name>
         <Chat:ToolTip xsi:type="xsd:string"></Chat:ToolTip>
         <Chat:Deleted xsi:type="xsd:boolean">false</Chat:Deleted>
         <Chat:Rank xsi:type="xsd:int">0</Chat:Rank>
         <Chat:Type xsi:type="xsd:string"></Chat:Type>
         <Chat:ChildItems xsi:type="Chat:ArrayOfMDOListItem">
          <Chat:MDOListItem xsi:nil="true"></Chat:MDOListItem>
         </Chat:ChildItems>
         <Chat:IconHint xsi:type="xsd:string"></Chat:IconHint>
         <Chat:ColorBlock xsi:type="xsd:int">0</Chat:ColorBlock>
         <Chat:ExtraInfo xsi:type="xsd:string"></Chat:ExtraInfo>
         <Chat:StyleHint xsi:type="xsd:string"></Chat:StyleHint>
         <Chat:FullName xsi:type="xsd:string"></Chat:FullName>
        </Chat:MDOListItem>
       </Chat:ChildItems>
       <Chat:IconHint xsi:type="xsd:string"></Chat:IconHint>
       <Chat:ColorBlock xsi:type="xsd:int">0</Chat:ColorBlock>
       <Chat:ExtraInfo xsi:type="xsd:string"></Chat:ExtraInfo>
       <Chat:StyleHint xsi:type="xsd:string"></Chat:StyleHint>
       <Chat:FullName xsi:type="xsd:string"></Chat:FullName>
      </Chat:MDOListItem>
     </Chat:ChildItems>
     <Chat:IconHint xsi:type="xsd:string"></Chat:IconHint>
     <Chat:ColorBlock xsi:type="xsd:int">0</Chat:ColorBlock>
     <Chat:ExtraInfo xsi:type="xsd:string"></Chat:ExtraInfo>
     <Chat:StyleHint xsi:type="xsd:string"></Chat:StyleHint>
     <Chat:FullName xsi:type="xsd:string"></Chat:FullName>
    </Chat:MDOListItem>
   </Chat:Response>
  </Chat:GetUserAgentListResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

