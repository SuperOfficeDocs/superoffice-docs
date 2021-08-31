---
title: GenerateLead
id: v1AppointmentAgent_GenerateLead
---

# GenerateLead

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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "AssociateIdForNewContact": 271,
  "LeadDescription": "Face to face maximized architecture",
  "Relation": "deserunt",
  "RelationId": 552,
  "LeadContact": "ut",
  "LeadPersonFirstname": "Reginald",
  "LeadPersonLastname": "Trantow",
  "LeadPersonEmail": "shaniya_swift@harris.name",
  "LeadPhoneNumber": "639456",
  "CreatorsContact": "sint",
  "CreatorsFirstname": "Dayne",
  "CreatorsLastname": "Schinner"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "RequestedContacts": [
    {
      "ContactId": 134,
      "Name": "Gaylord Inc and Sons",
      "OrgNr": "1843965",
      "Department": "",
      "URL": "http://www.example.com/",
      "City": "culpa",
      "DirectPhone": "1-012-846-0628 x04424",
      "AssociateId": 121,
      "CountryId": 818,
      "EmailAddress": "devon_pollich@emmerichzieme.co.uk",
      "Kananame": "eligendi",
      "EmailAddressName": "jaida_hegmann@willmsrath.co.uk",
      "URLName": "http://www.example.com/",
      "AssociateFullName": "Bennie Erdman",
      "BusinessName": "Information Technology",
      "CategoryName": "VIP Customer",
      "CountryName": "Sokovia",
      "Address": {},
      "FormattedAddress": "corrupti",
      "FullName": "Maymie Cremin DVM",
      "IsOwnerContact": false,
      "ActiveErpLinks": 579,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 800
        }
      }
    }
  ],
  "RequestedPerson": {
    "Position": "est",
    "PersonId": 346,
    "Mrmrs": "quaerat",
    "Firstname": "Lavon",
    "Lastname": "Weimann",
    "MiddleName": "Treutel LLC",
    "Title": "reprehenderit",
    "Description": "Extended interactive local area network",
    "Email": "laurel@cronin.ca",
    "FullName": "Oleta Kuhic",
    "DirectPhone": "220.336.1556 x10448",
    "FormalName": "Hammes, Quitzon and Koelpin",
    "CountryId": 836,
    "ContactId": 430,
    "ContactName": "Hintz-Hyatt",
    "Retired": 985,
    "Rank": 816,
    "ActiveInterests": 847,
    "ContactDepartment": "",
    "ContactCountryId": 787,
    "ContactOrgNr": "602414",
    "FaxPhone": "322.624.8325 x872",
    "MobilePhone": "(366)227-2556 x864",
    "ContactPhone": "727-155-6112 x4761",
    "AssociateName": "Schultz-Purdy",
    "AssociateId": 543,
    "UsePersonAddress": true,
    "ContactFax": "dignissimos",
    "Kanafname": "amet",
    "Kanalname": "ut",
    "Post1": "voluptatem",
    "Post2": "impedit",
    "Post3": "est",
    "EmailName": "alberta.kulas@rippin.com",
    "ContactFullName": "Orville Deckow",
    "ActiveErpLinks": 491,
    "TicketPriorityId": 439,
    "SupportLanguageId": 685,
    "SupportAssociateId": 425,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 745
      }
    }
  },
  "SalesRep": {
    "Position": "ex",
    "PersonId": 622,
    "Mrmrs": "sit",
    "Firstname": "Manuel",
    "Lastname": "Beahan",
    "MiddleName": "Toy LLC",
    "Title": "repellat",
    "Description": "Multi-layered interactive infrastructure",
    "Email": "rhett@murraylangworth.co.uk",
    "FullName": "Flavie Howe",
    "DirectPhone": "1-266-771-0585 x3801",
    "FormalName": "Ziemann, Jenkins and Torp",
    "CountryId": 823,
    "ContactId": 351,
    "ContactName": "Prosacco, West and White",
    "Retired": 654,
    "Rank": 598,
    "ActiveInterests": 754,
    "ContactDepartment": "",
    "ContactCountryId": 583,
    "ContactOrgNr": "708781",
    "FaxPhone": "228-824-0123",
    "MobilePhone": "1-701-617-4504 x085",
    "ContactPhone": "1-711-340-2535 x7276",
    "AssociateName": "Schoen, Oberbrunner and Block",
    "AssociateId": 411,
    "UsePersonAddress": true,
    "ContactFax": "debitis",
    "Kanafname": "eum",
    "Kanalname": "placeat",
    "Post1": "repellat",
    "Post2": "laudantium",
    "Post3": "suscipit",
    "EmailName": "dave@flatleystracke.biz",
    "ContactFullName": "Ernie Eichmann",
    "ActiveErpLinks": 261,
    "TicketPriorityId": 658,
    "SupportLanguageId": 467,
    "SupportAssociateId": 961,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 713
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
      "FieldLength": 677
    }
  }
}
```