---
title: POST Agents/Appointment/GenerateLead
uid: v1AppointmentAgent_GenerateLead
---

# POST Agents/Appointment/GenerateLead

```http
POST /api/v1/Agents/Appointment/GenerateLead
```

Adds a sales lead (task) to a contact in SuperOffice.

If the contact or person is known, the sales lead is added to the current contact. If not, a new contact is created, with the associate with ownerIdForNewContact as responsible (Our Contact). A relation is created between the contact and the person submitting the lead. Based on wether the person the request is made for is found or not, the following happens: If the person is found, the person, person's contact and sales representative is returned. If neither the person nor the contact is found a new person and contact is created (if sufficient data is supplied), and the person, person's contact and sales representative is returned. If the contact and not the person is found a new person is created on this contact, and the contact, salesrep, and person is returned (if there was enough data to return the person). If more than one contact is found a list of contacts is returned.

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/GenerateLead?$select=name,department,category/id
```

## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request

AssociateIdForNewContact, LeadDescription, Relation, RelationId, LeadContact, LeadPersonFirstname, LeadPersonLastname, LeadPersonEmail, LeadPhoneNumber, CreatorsContact, CreatorsFirstname, CreatorsLastname

| Property Name | Type |  Description |
|----------------|------|--------------|
| AssociateIdForNewContact | int32 |  |
| LeadDescription | string |  |
| Relation | string |  |
| RelationId | int32 |  |
| LeadContact | string |  |
| LeadPersonFirstname | string |  |
| LeadPersonLastname | string |  |
| LeadPersonEmail | string |  |
| LeadPhoneNumber | string |  |
| CreatorsContact | string |  |
| CreatorsFirstname | string |  |
| CreatorsLastname | string |  |

## Response

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body:

| Property Name | Type |  Description |
|----------------|------|--------------|
| RequestedContacts | array | The companies that match the request |
| RequestedPerson |  | The person that matches the request. |
| SalesRep |  | The sales representative for the person that matches the request. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Appointment/GenerateLead
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "AssociateIdForNewContact": 738,
  "LeadDescription": "Re-contextualized 6th generation alliance",
  "Relation": "fuga",
  "RelationId": 731,
  "LeadContact": "praesentium",
  "LeadPersonFirstname": "Tyrel",
  "LeadPersonLastname": "Rowe",
  "LeadPersonEmail": "randall@johns.uk",
  "LeadPhoneNumber": "1516746",
  "CreatorsContact": "modi",
  "CreatorsFirstname": "Julie",
  "CreatorsLastname": "Kertzmann"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "RequestedContacts": [
    {
      "ContactId": 902,
      "Name": "Hermiston Inc and Sons",
      "OrgNr": "483249",
      "Department": "",
      "URL": "http://www.example.com/",
      "City": "quod",
      "DirectPhone": "792-531-6004 x0992",
      "AssociateId": 522,
      "CountryId": 940,
      "EmailAddress": "herta@shanahan.uk",
      "Kananame": "cum",
      "EmailAddressName": "francesco@oberbrunner.info",
      "URLName": "http://www.example.com/",
      "AssociateFullName": "Imelda Effertz",
      "BusinessName": "Information Technology",
      "CategoryName": "VIP Customer",
      "CountryName": "Sokovia",
      "Address": null,
      "FormattedAddress": "amet",
      "FullName": "Ms. Janice Kaitlin Swift",
      "IsOwnerContact": false,
      "ActiveErpLinks": 278,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 828
        }
      }
    }
  ],
  "RequestedPerson": null,
  "SalesRep": null,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 669
    }
  }
}
```
