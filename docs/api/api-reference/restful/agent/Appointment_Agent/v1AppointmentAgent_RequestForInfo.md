---
title: RequestForInfo
id: v1AppointmentAgent_RequestForInfo
---

# RequestForInfo

```http
POST /api/v1/Agents/Appointment/RequestForInfo
```

Submits a request for information.

The request is added to the task list of the user that is responsible for this contact. Based on wether the person the request is made for is found or not, the following happens: If the person is found, the person, person's contact and sales representative is returned. If neither the person nor the contact is found a new person and contact is created (if sufficient data is supplied), and the person, person's contact and sales representative is returned. If the contact and not the person is found a new person is created on this contact, and the contact, salesrep, and person is returned (if there was enough data to return the person). If more than one contact is found a list of contacts is returned.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/RequestForInfo?$select=name,department,category/id
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

AssociateIdForNewContact, Channel, Regarding, ContactName, PersonFirstname, PersonLastname, EmailAddress, PhoneNumber 

| Property Name | Type |  Description |
|----------------|------|--------------|
| AssociateIdForNewContact | int32 |  |
| Channel | string |  |
| Regarding | string |  |
| ContactName | string |  |
| PersonFirstname | string |  |
| PersonLastname | string |  |
| EmailAddress | string |  |
| PhoneNumber | string |  |


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
POST /api/v1/Agents/Appointment/RequestForInfo
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "AssociateIdForNewContact": 924,
  "Channel": "eum",
  "Regarding": "omnis",
  "ContactName": "Gusikowski, Mosciski and Wiegand",
  "PersonFirstname": "Janie",
  "PersonLastname": "Koss",
  "EmailAddress": "leonor.rath@upton.name",
  "PhoneNumber": "1025968"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "RequestedContacts": [
    {
      "ContactId": 162,
      "Name": "Tremblay, Thiel and Kautzer",
      "OrgNr": "1138425",
      "Department": "",
      "URL": "http://www.example.com/",
      "City": "quis",
      "DirectPhone": "082-450-1403",
      "AssociateId": 239,
      "CountryId": 51,
      "EmailAddress": "marcus@okeefe.com",
      "Kananame": "molestias",
      "EmailAddressName": "jarrod@rolfson.ca",
      "URLName": "http://www.example.com/",
      "AssociateFullName": "Jedidiah Koch",
      "BusinessName": "Information Technology",
      "CategoryName": "VIP Customer",
      "CountryName": "Sokovia",
      "Address": {},
      "FormattedAddress": "qui",
      "FullName": "Nasir Davis",
      "IsOwnerContact": false,
      "ActiveErpLinks": 410,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "empower leading-edge web-readiness"
          },
          "FieldType": "System.Int32",
          "FieldLength": 846
        }
      }
    }
  ],
  "RequestedPerson": {
    "Position": "recusandae",
    "PersonId": 616,
    "Mrmrs": "et",
    "Firstname": "Theodore",
    "Lastname": "Thiel",
    "MiddleName": "Homenick, Williamson and Leffler",
    "Title": "quam",
    "Description": "Ameliorated reciprocal open system",
    "Email": "rahsaan@morissette.info",
    "FullName": "Kaitlyn Kuhn",
    "DirectPhone": "233-724-1537 x22655",
    "FormalName": "Bernhard-Rice",
    "CountryId": 216,
    "ContactId": 276,
    "ContactName": "Hoeger-Lindgren",
    "Retired": 424,
    "Rank": 801,
    "ActiveInterests": 310,
    "ContactDepartment": "",
    "ContactCountryId": 439,
    "ContactOrgNr": "792788",
    "FaxPhone": "067.642.4606 x758",
    "MobilePhone": "104.066.5212",
    "ContactPhone": "(700)846-8222 x58800",
    "AssociateName": "Bergstrom-Crona",
    "AssociateId": 500,
    "UsePersonAddress": false,
    "ContactFax": "in",
    "Kanafname": "et",
    "Kanalname": "iste",
    "Post1": "aut",
    "Post2": "sapiente",
    "Post3": "et",
    "EmailName": "rafaela@hagenes.ca",
    "ContactFullName": "Dr. Hattie Renner",
    "ActiveErpLinks": 159,
    "TicketPriorityId": 563,
    "SupportLanguageId": 126,
    "SupportAssociateId": 568,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 555
      }
    }
  },
  "SalesRep": {
    "Position": "porro",
    "PersonId": 588,
    "Mrmrs": "ut",
    "Firstname": "Wilbert",
    "Lastname": "King",
    "MiddleName": "Turcotte, Grant and Botsford",
    "Title": "ad",
    "Description": "Multi-layered background help-desk",
    "Email": "fidel@collins.uk",
    "FullName": "Else Stamm",
    "DirectPhone": "(018)312-3578 x54388",
    "FormalName": "Schmeler, Reichel and Metz",
    "CountryId": 456,
    "ContactId": 682,
    "ContactName": "Pollich-Kub",
    "Retired": 621,
    "Rank": 901,
    "ActiveInterests": 19,
    "ContactDepartment": "",
    "ContactCountryId": 606,
    "ContactOrgNr": "977163",
    "FaxPhone": "303-587-8477 x24374",
    "MobilePhone": "375.163.1534",
    "ContactPhone": "222-842-7025 x37870",
    "AssociateName": "Schimmel-Carroll",
    "AssociateId": 171,
    "UsePersonAddress": true,
    "ContactFax": "qui",
    "Kanafname": "minus",
    "Kanalname": "eligendi",
    "Post1": "sed",
    "Post2": "voluptates",
    "Post3": "quia",
    "EmailName": "amanda@gutkowskimurray.name",
    "ContactFullName": "Dudley McClure",
    "ActiveErpLinks": 803,
    "TicketPriorityId": 216,
    "SupportLanguageId": 570,
    "SupportAssociateId": 99,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 667
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
      "FieldLength": 76
    }
  }
}
```