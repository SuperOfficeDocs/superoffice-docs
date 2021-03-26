---
title: POST Agents/Appointment/RequestForInfo
id: v1AppointmentAgent_RequestForInfo
---

# POST Agents/Appointment/RequestForInfo

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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "AssociateIdForNewContact": 982,
  "Channel": "numquam",
  "Regarding": "quasi",
  "ContactName": "Herman Group",
  "PersonFirstname": "Maria",
  "PersonLastname": "Hills",
  "EmailAddress": "paige_doyle@olson.name",
  "PhoneNumber": "1212115"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "RequestedContacts": [
    {
      "ContactId": 984,
      "Name": "Kautzer-Considine",
      "OrgNr": "1445867",
      "Department": "",
      "URL": "http://www.example.com/",
      "City": "est",
      "DirectPhone": "(766)426-5774",
      "AssociateId": 874,
      "CountryId": 118,
      "EmailAddress": "annalise@yost.com",
      "Kananame": "doloremque",
      "EmailAddressName": "dallas_eichmann@eichmannlockman.info",
      "URLName": "http://www.example.com/",
      "AssociateFullName": "Mr. Nannie Kutch",
      "BusinessName": "Information Technology",
      "CategoryName": "VIP Customer",
      "CountryName": "Sokovia",
      "Address": {},
      "FormattedAddress": "repudiandae",
      "FullName": "Jalen O'Reilly",
      "IsOwnerContact": true,
      "ActiveErpLinks": 526,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 404
        }
      }
    }
  ],
  "RequestedPerson": {
    "Position": "est",
    "PersonId": 868,
    "Mrmrs": "commodi",
    "Firstname": "Rick",
    "Lastname": "Reichel",
    "MiddleName": "Jaskolski-Hettinger",
    "Title": "molestias",
    "Description": "Persistent 4th generation implementation",
    "Email": "ayla.schmeler@renner.uk",
    "FullName": "Keith Stark",
    "DirectPhone": "1-760-177-0450",
    "FormalName": "Watsica LLC",
    "CountryId": 481,
    "ContactId": 334,
    "ContactName": "Ankunding LLC",
    "Retired": 910,
    "Rank": 428,
    "ActiveInterests": 201,
    "ContactDepartment": "",
    "ContactCountryId": 427,
    "ContactOrgNr": "861976",
    "FaxPhone": "1-682-477-8366 x24570",
    "MobilePhone": "1-208-732-3238 x53142",
    "ContactPhone": "181-011-1388",
    "AssociateName": "Mertz, Sipes and Langworth",
    "AssociateId": 740,
    "UsePersonAddress": true,
    "ContactFax": "quaerat",
    "Kanafname": "laboriosam",
    "Kanalname": "quia",
    "Post1": "quam",
    "Post2": "sunt",
    "Post3": "ut",
    "EmailName": "kaylee@emard.co.uk",
    "ContactFullName": "Ollie Murray",
    "ActiveErpLinks": 975,
    "TicketPriorityId": 733,
    "SupportLanguageId": 97,
    "SupportAssociateId": 959,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 515
      }
    }
  },
  "SalesRep": {
    "Position": "qui",
    "PersonId": 879,
    "Mrmrs": "cupiditate",
    "Firstname": "Abdul",
    "Lastname": "Stoltenberg",
    "MiddleName": "Ullrich-Hintz",
    "Title": "commodi",
    "Description": "Re-contextualized fresh-thinking attitude",
    "Email": "carlotta@jacobi.ca",
    "FullName": "Miss Chadrick Wintheiser",
    "DirectPhone": "(448)322-0876 x175",
    "FormalName": "Jewess-Reilly",
    "CountryId": 588,
    "ContactId": 702,
    "ContactName": "Jaskolski-Turcotte",
    "Retired": 569,
    "Rank": 615,
    "ActiveInterests": 963,
    "ContactDepartment": "",
    "ContactCountryId": 350,
    "ContactOrgNr": "1336703",
    "FaxPhone": "656.104.2440 x62753",
    "MobilePhone": "1-357-274-0755 x78858",
    "ContactPhone": "181.045.5801 x0550",
    "AssociateName": "Adams Inc and Sons",
    "AssociateId": 16,
    "UsePersonAddress": true,
    "ContactFax": "nam",
    "Kanafname": "adipisci",
    "Kanalname": "qui",
    "Post1": "et",
    "Post2": "tempore",
    "Post3": "sunt",
    "EmailName": "ceasar_brakus@howe.info",
    "ContactFullName": "Rosendo Crist",
    "ActiveErpLinks": 627,
    "TicketPriorityId": 456,
    "SupportLanguageId": 455,
    "SupportAssociateId": 177,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 729
      }
    }
  },
  "TableRight": {
    "Mask": "Delete",
    "Reason": "leverage revolutionary e-commerce"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 597
    }
  }
}
```