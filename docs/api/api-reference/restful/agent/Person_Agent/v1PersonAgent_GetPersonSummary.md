---
title: POST Agents/Person/GetPersonSummary
id: v1PersonAgent_GetPersonSummary
---

# POST Agents/Person/GetPersonSummary

```http
POST /api/v1/Agents/Person/GetPersonSummary
```

Get summary of person and recent activity.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetPersonSummary?$select=name,department,category/id
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

PersonId, Limit 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | int32 |  |
| Limit | int32 |  |


## Response: object

Summary of person, with recent activities, chats, and requests included.



Carrier object for PersonSummary.
Services for the PersonSummary Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Person |  | Simple Person data. |
| Tickets | array | Recent tickets on person |
| Followups | array | Recent follow-ups on person |
| Documents | array | Recent documents on person |
| Sales | array | Recent sales on person |
| Chats | array | Recent chats with person |

## Sample Request

```http!
POST /api/v1/Agents/Person/GetPersonSummary
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "PersonId": 797,
  "Limit": 70
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Person": {
    "Position": "ut",
    "PersonId": 591,
    "Mrmrs": "et",
    "Firstname": "Hazel",
    "Lastname": "Trantow",
    "MiddleName": "Frami-Kemmer",
    "Title": "tempore",
    "Description": "Balanced composite database",
    "Email": "agnes@bednarmorar.us",
    "FullName": "Jerrod Nienow",
    "DirectPhone": "(637)046-1854 x31231",
    "FormalName": "Waters, Fritsch and Schuster",
    "CountryId": 633,
    "ContactId": 900,
    "ContactName": "Schamberger-Lakin",
    "Retired": 753,
    "Rank": 742,
    "ActiveInterests": 461,
    "ContactDepartment": "engineer mission-critical methodologies",
    "ContactCountryId": 739,
    "ContactOrgNr": "1598222",
    "FaxPhone": "(005)760-6368",
    "MobilePhone": "687-833-6081 x53262",
    "ContactPhone": "(144)525-3162",
    "AssociateName": "Collins-Mann",
    "AssociateId": 219,
    "UsePersonAddress": true,
    "ContactFax": "id",
    "Kanafname": "ut",
    "Kanalname": "dolore",
    "Post1": "at",
    "Post2": "veritatis",
    "Post3": "soluta",
    "EmailName": "gerard_hermann@huels.ca",
    "ContactFullName": "Donny Grimes",
    "ActiveErpLinks": 595,
    "TicketPriorityId": 175,
    "SupportLanguageId": 609,
    "SupportAssociateId": 691,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 541
      }
    }
  },
  "Tickets": [
    {
      "TicketId": 441,
      "TicketStatus": 750,
      "Title": "culpa",
      "Registered": "2000-03-19T16:48:30.1989346+01:00"
    },
    {
      "TicketId": 441,
      "TicketStatus": 750,
      "Title": "culpa",
      "Registered": "2000-03-19T16:48:30.1989346+01:00"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 360,
      "DocumentId": 742,
      "Date": "2000-01-14T16:48:30.1989346+01:00",
      "Description": "Streamlined didactic middleware",
      "Completed": "Completed",
      "Registered": "2006-04-10T16:48:30.1989346+02:00"
    },
    {
      "AppointmentId": 360,
      "DocumentId": 742,
      "Date": "2000-01-14T16:48:30.1989346+01:00",
      "Description": "Streamlined didactic middleware",
      "Completed": "Completed",
      "Registered": "2006-04-10T16:48:30.1989346+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 310,
      "DocumentId": 921,
      "Date": "2009-08-15T16:48:30.1989346+02:00",
      "Description": "Secured 5th generation time-frame",
      "Completed": "Completed",
      "Registered": "2000-12-14T16:48:30.1989346+01:00"
    },
    {
      "AppointmentId": 310,
      "DocumentId": 921,
      "Date": "2009-08-15T16:48:30.1989346+02:00",
      "Description": "Secured 5th generation time-frame",
      "Completed": "Completed",
      "Registered": "2000-12-14T16:48:30.1989346+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 588,
      "SaleDate": "2001-10-08T16:48:30.1989346+02:00",
      "Probability": 218,
      "Heading": "nemo",
      "Amount": 9684.06,
      "Currency": "voluptates",
      "AmountInBaseCurrency": 17478.318,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2001-02-13T16:48:30.1989346+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 525,
      "Name": "Waters-Strosin",
      "CompanyName": "Swaniawski, Zieme and Hegmann",
      "FirstMessage": "qui",
      "LastMessage": "corporis",
      "WhenRequested": "2009-07-07T16:48:30.1999349+02:00",
      "WhenEnded": "2000-09-02T16:48:30.1999349+02:00"
    }
  ]
}
```