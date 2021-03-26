---
title: POST Agents/Appointment/GenerateLead
id: v1AppointmentAgent_GenerateLead
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


## Response: object

Carrier object for SalesActivity.
Services for the SalesActivity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAppointmentAgent">Appointment Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| RequestedContacts | array | The companies that match the request |
| RequestedPerson |  | The person that matches the request. |
| SalesRep |  | The sales representative for the person that matches the request. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Appointment/GenerateLead
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "AssociateIdForNewContact": 474,
  "LeadDescription": "User-friendly non-volatile hub",
  "Relation": "ipsa",
  "RelationId": 170,
  "LeadContact": "non",
  "LeadPersonFirstname": "Thalia",
  "LeadPersonLastname": "Dare",
  "LeadPersonEmail": "rudy@bernhard.name",
  "LeadPhoneNumber": "1264735",
  "CreatorsContact": "qui",
  "CreatorsFirstname": "Nelle",
  "CreatorsLastname": "Ferry"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "RequestedContacts": [
    {
      "ContactId": 544,
      "Name": "Hodkiewicz Group",
      "OrgNr": "1022079",
      "Department": "",
      "URL": "http://www.example.com/",
      "City": "autem",
      "DirectPhone": "824.215.7387",
      "AssociateId": 682,
      "CountryId": 156,
      "EmailAddress": "matilde@eichmann.us",
      "Kananame": "nisi",
      "EmailAddressName": "adah_dare@jacobsondickens.uk",
      "URLName": "http://www.example.com/",
      "AssociateFullName": "Shaun Gerlach",
      "BusinessName": "Information Technology",
      "CategoryName": "VIP Customer",
      "CountryName": "Sokovia",
      "Address": {},
      "FormattedAddress": "molestiae",
      "FullName": "Kiera Haag",
      "IsOwnerContact": false,
      "ActiveErpLinks": 832,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 508
        }
      }
    }
  ],
  "RequestedPerson": {
    "Position": "odio",
    "PersonId": 19,
    "Mrmrs": "beatae",
    "Firstname": "Marques",
    "Lastname": "Simonis",
    "MiddleName": "Witting LLC",
    "Title": "qui",
    "Description": "Pre-emptive transitional infrastructure",
    "Email": "neva@howe.co.uk",
    "FullName": "Geovanny Reinger",
    "DirectPhone": "176.617.3253 x1124",
    "FormalName": "Hand-Veum",
    "CountryId": 701,
    "ContactId": 639,
    "ContactName": "Predovic, Osinski and Schuppe",
    "Retired": 161,
    "Rank": 81,
    "ActiveInterests": 344,
    "ContactDepartment": "",
    "ContactCountryId": 662,
    "ContactOrgNr": "1091504",
    "FaxPhone": "552-585-1360 x32115",
    "MobilePhone": "(764)186-6040 x467",
    "ContactPhone": "(641)444-0856 x627",
    "AssociateName": "Halvorson, Hegmann and Orn",
    "AssociateId": 953,
    "UsePersonAddress": true,
    "ContactFax": "quas",
    "Kanafname": "eius",
    "Kanalname": "ut",
    "Post1": "voluptates",
    "Post2": "sed",
    "Post3": "aperiam",
    "EmailName": "keon.jerde@connelly.com",
    "ContactFullName": "Uriah Batz",
    "ActiveErpLinks": 724,
    "TicketPriorityId": 436,
    "SupportLanguageId": 616,
    "SupportAssociateId": 882,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 376
      }
    }
  },
  "SalesRep": {
    "Position": "modi",
    "PersonId": 962,
    "Mrmrs": "minus",
    "Firstname": "Emmie",
    "Lastname": "Walker",
    "MiddleName": "Nicolas-Lockman",
    "Title": "illum",
    "Description": "Reduced object-oriented capability",
    "Email": "lacey.krajcik@bartell.us",
    "FullName": "Kayla VonRueden",
    "DirectPhone": "(720)030-4425 x264",
    "FormalName": "Balistreri Inc and Sons",
    "CountryId": 619,
    "ContactId": 604,
    "ContactName": "Gulgowski Group",
    "Retired": 284,
    "Rank": 878,
    "ActiveInterests": 295,
    "ContactDepartment": "",
    "ContactCountryId": 299,
    "ContactOrgNr": "1240011",
    "FaxPhone": "1-843-770-2543",
    "MobilePhone": "127.126.8802 x5735",
    "ContactPhone": "(436)511-1130 x776",
    "AssociateName": "Prohaska LLC",
    "AssociateId": 103,
    "UsePersonAddress": true,
    "ContactFax": "odit",
    "Kanafname": "ducimus",
    "Kanalname": "maiores",
    "Post1": "laboriosam",
    "Post2": "laboriosam",
    "Post3": "ad",
    "EmailName": "agustin.hane@volkmanveum.name",
    "ContactFullName": "Marge Yundt",
    "ActiveErpLinks": 114,
    "TicketPriorityId": 460,
    "SupportLanguageId": 60,
    "SupportAssociateId": 464,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 304
      }
    }
  },
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "syndicate enterprise partnerships"
      },
      "FieldType": "System.String",
      "FieldLength": 729
    }
  }
}
```