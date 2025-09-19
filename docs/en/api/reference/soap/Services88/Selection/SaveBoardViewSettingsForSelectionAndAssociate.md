---
title: Services88.SelectionAgent.SaveBoardViewSettingsForSelectionAndAssociate SOAP
generated: true
uid: Services88-Selection-SaveBoardViewSettingsForSelectionAndAssociate
content_type: reference
---

# Services88 Selection SaveBoardViewSettingsForSelectionAndAssociate

SOAP request and response examples **Remote/Services88/Selection.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ISelectionAgent.SaveBoardViewSettingsForSelectionAndAssociate">SuperOffice.Services88.ISelectionAgent.SaveBoardViewSettingsForSelectionAndAssociate</see> method.

## SaveBoardViewSettingsForSelectionAndAssociate





[WSDL file for Services88/Selection](../Services88-Selection.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveBoardViewSettingsForSelectionAndAssociate Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Selection:ApplicationToken>1234567-1234-9876</Selection:ApplicationToken>
  <Selection:Credentials>
    <Selection:Ticket>7T:1234abcxyzExample==</Selection:Ticket>
  </Selection:Credentials>
 <SOAP-ENV:Body>
   <Selection:SaveBoardViewSettingsForSelectionAndAssociate>
    <Selection:BoardViewSettings xsi:type="Selection:BoardViewSettingsBase">
     <Selection:BoardViewSettingsId xsi:type="xsd:int">0</Selection:BoardViewSettingsId>
     <Selection:EntityType xsi:type="Selection:BoardViewEntityType">None</Selection:EntityType>
     <Selection:AssociateId xsi:type="xsd:int">0</Selection:AssociateId>
     <Selection:SelectionId xsi:type="xsd:int">0</Selection:SelectionId>
     <Selection:HideEmptyGroups xsi:type="xsd:boolean">false</Selection:HideEmptyGroups>
     <Selection:GroupBy xsi:type="xsd:string"></Selection:GroupBy>
     <Selection:SubGroupBy xsi:type="xsd:string"></Selection:SubGroupBy>
     <Selection:SortBy xsi:type="xsd:string"></Selection:SortBy>
     <Selection:SortDesc xsi:type="xsd:boolean">false</Selection:SortDesc>
     <Selection:SumBy xsi:type="xsd:string"></Selection:SumBy>
     <Selection:ColorBy xsi:type="xsd:string"></Selection:ColorBy>
     <Selection:Filters xsi:type="xsd:string"></Selection:Filters>
    </Selection:BoardViewSettings>
    <Selection:AssociateId xsi:type="xsd:int">0</Selection:AssociateId>
    <Selection:SelectionId xsi:type="xsd:int">0</Selection:SelectionId>
   </Selection:SaveBoardViewSettingsForSelectionAndAssociate>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveBoardViewSettingsForSelectionAndAssociate Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Selection:SaveBoardViewSettingsForSelectionAndAssociateResponse>
   <Selection:Response xsi:type="Selection:BoardViewSettingsBase">
    <Selection:BoardViewSettingsId xsi:type="xsd:int">0</Selection:BoardViewSettingsId>
    <Selection:EntityType xsi:type="Selection:BoardViewEntityType">None</Selection:EntityType>
    <Selection:AssociateId xsi:type="xsd:int">0</Selection:AssociateId>
    <Selection:SelectionId xsi:type="xsd:int">0</Selection:SelectionId>
    <Selection:HideEmptyGroups xsi:type="xsd:boolean">false</Selection:HideEmptyGroups>
    <Selection:GroupBy xsi:type="xsd:string"></Selection:GroupBy>
    <Selection:SubGroupBy xsi:type="xsd:string"></Selection:SubGroupBy>
    <Selection:SortBy xsi:type="xsd:string"></Selection:SortBy>
    <Selection:SortDesc xsi:type="xsd:boolean">false</Selection:SortDesc>
    <Selection:SumBy xsi:type="xsd:string"></Selection:SumBy>
    <Selection:ColorBy xsi:type="xsd:string"></Selection:ColorBy>
    <Selection:Filters xsi:type="xsd:string"></Selection:Filters>
   </Selection:Response>
  </Selection:SaveBoardViewSettingsForSelectionAndAssociateResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

