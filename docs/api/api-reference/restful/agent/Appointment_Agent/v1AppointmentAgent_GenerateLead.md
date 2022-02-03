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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "AssociateIdForNewContact": 190,
  "LeadDescription": "Seamless real-time software",
  "Relation": "vel",
  "RelationId": 978,
  "LeadContact": "dolor",
  "LeadPersonFirstname": "Desmond",
  "LeadPersonLastname": "Rippin",
  "LeadPersonEmail": "liliane.corwin@white.info",
  "LeadPhoneNumber": "786862",
  "CreatorsContact": "aut",
  "CreatorsFirstname": "Dangelo",
  "CreatorsLastname": "Carroll"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "RequestedContacts": [
    {
      "ContactId": 359,
      "Name": "Murazik Inc and Sons",
      "OrgNr": "632227",
      "Department": "",
      "URL": "http://www.example.com/",
      "City": "consectetur",
      "DirectPhone": "(143)554-7380",
      "AssociateId": 806,
      "CountryId": 550,
      "EmailAddress": "nash.koelpin@lemke.ca",
      "Kananame": "ullam",
      "EmailAddressName": "felicia_deckow@ohara.biz",
      "URLName": "http://www.example.com/",
      "AssociateFullName": "Brady Rogahn",
      "BusinessName": "Information Technology",
      "CategoryName": "VIP Customer",
      "CountryName": "Sokovia",
      "Address": {},
      "FormattedAddress": "aliquid",
      "FullName": "Maudie Steuber",
      "IsOwnerContact": true,
      "ActiveErpLinks": 544,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 823
        }
      }
    }
  ],
  "RequestedPerson": {
    "Position": "quod",
    "PersonId": 887,
    "Mrmrs": "facere",
    "Firstname": "Garnet",
    "Lastname": "Fay",
    "MiddleName": "Mertz-Weimann",
    "Title": "cum",
    "Description": "Balanced tangible Graphical User Interface",
    "Email": "chet_farrell@schoenjohnston.info",
    "FullName": "Theresia Larkin",
    "DirectPhone": "1-620-723-4737",
    "FormalName": "Schulist, Harris and Kihn",
    "CountryId": 339,
    "ContactId": 530,
    "ContactName": "Swift, Padberg and Toy",
    "Retired": 809,
    "Rank": 436,
    "ActiveInterests": 610,
    "ContactDepartment": "",
    "ContactCountryId": 678,
    "ContactOrgNr": "957692",
    "FaxPhone": "388-020-4340",
    "MobilePhone": "340-874-8884 x8802",
    "ContactPhone": "425-613-1444 x8652",
    "AssociateName": "Ward, Wunsch and Rau",
    "AssociateId": 226,
    "UsePersonAddress": true,
    "ContactFax": "et",
    "Kanafname": "dolor",
    "Kanalname": "optio",
    "Post1": "labore",
    "Post2": "quos",
    "Post3": "consequatur",
    "EmailName": "leonard.hackett@stiedemann.com",
    "ContactFullName": "Ms. Jules Stiedemann",
    "ActiveErpLinks": 808,
    "TicketPriorityId": 403,
    "SupportLanguageId": 590,
    "SupportAssociateId": 1000,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 879
      }
    }
  },
  "SalesRep": {
    "Position": "quaerat",
    "PersonId": 740,
    "Mrmrs": "eos",
    "Firstname": "Rafaela",
    "Lastname": "Kovacek",
    "MiddleName": "Wintheiser-Witting",
    "Title": "velit",
    "Description": "De-engineered tertiary toolset",
    "Email": "kristopher.cassin@zboncak.us",
    "FullName": "Thurman Blanda",
    "DirectPhone": "(320)578-7364",
    "FormalName": "Beatty, Kilback and Rogahn",
    "CountryId": 170,
    "ContactId": 42,
    "ContactName": "Bruen-Pouros",
    "Retired": 916,
    "Rank": 433,
    "ActiveInterests": 768,
    "ContactDepartment": "",
    "ContactCountryId": 376,
    "ContactOrgNr": "1224302",
    "FaxPhone": "(684)786-1168 x35205",
    "MobilePhone": "(020)320-2772",
    "ContactPhone": "757.573.0132",
    "AssociateName": "Wisoky-Haley",
    "AssociateId": 272,
    "UsePersonAddress": false,
    "ContactFax": "architecto",
    "Kanafname": "excepturi",
    "Kanalname": "saepe",
    "Post1": "est",
    "Post2": "fugit",
    "Post3": "explicabo",
    "EmailName": "marianne_ohara@purdy.us",
    "ContactFullName": "Stacey Harvey",
    "ActiveErpLinks": 637,
    "TicketPriorityId": 230,
    "SupportLanguageId": 191,
    "SupportAssociateId": 865,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 296
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
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 717
    }
  }
}
```