---
title: GET Person/{id}/Summary
id: v1PersonEntity_GetPersonSummary
---

# GET Person/{id}/Summary

```http
GET /api/v1/Person/{personId}/Summary
```

Get summary of person and recent activity.






| Path Part | Type | Description |
|-----------|------|-------------|
| personId | int32 | The person id to summarize. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| limit | int32 |  Max number of items to include in summary lists. |

```http
GET /api/v1/Person/{personId}/Summary?limit=915
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


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
GET /api/v1/Person/{personId}/Summary
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Person": {
    "Position": "est",
    "PersonId": 830,
    "Mrmrs": "voluptatem",
    "Firstname": "Novella",
    "Lastname": "Pollich",
    "MiddleName": "Morar, Tillman and Corwin",
    "Title": "consectetur",
    "Description": "Down-sized stable toolset",
    "Email": "bradford_zulauf@schaefer.uk",
    "FullName": "Judson Cruickshank",
    "DirectPhone": "674.028.6820",
    "FormalName": "Hagenes-Trantow",
    "CountryId": 867,
    "ContactId": 70,
    "ContactName": "Abernathy-Effertz",
    "Retired": 301,
    "Rank": 569,
    "ActiveInterests": 794,
    "ContactDepartment": "",
    "ContactCountryId": 750,
    "ContactOrgNr": "271127",
    "FaxPhone": "1-360-366-5226",
    "MobilePhone": "181.475.7550",
    "ContactPhone": "614-525-5604",
    "AssociateName": "Willms, Maggio and Willms",
    "AssociateId": 861,
    "UsePersonAddress": false,
    "ContactFax": "eum",
    "Kanafname": "deserunt",
    "Kanalname": "nemo",
    "Post1": "at",
    "Post2": "beatae",
    "Post3": "repudiandae",
    "EmailName": "sonya@pagacemmerich.com",
    "ContactFullName": "Dr. Sonia Conn",
    "ActiveErpLinks": 514,
    "TicketPriorityId": 8,
    "SupportLanguageId": 703,
    "SupportAssociateId": 557,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 981
      }
    }
  },
  "Tickets": [
    {
      "TicketId": 659,
      "TicketStatus": 553,
      "Title": "optio",
      "Registered": "2007-07-07T15:05:42.4096338+02:00"
    },
    {
      "TicketId": 659,
      "TicketStatus": 553,
      "Title": "optio",
      "Registered": "2007-07-07T15:05:42.4096338+02:00"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 729,
      "DocumentId": 882,
      "Date": "2007-09-03T15:05:42.4096338+02:00",
      "Description": "Profit-focused fresh-thinking analyzer",
      "Completed": "Completed",
      "Registered": "2012-04-13T15:05:42.4096338+02:00"
    },
    {
      "AppointmentId": 729,
      "DocumentId": 882,
      "Date": "2007-09-03T15:05:42.4096338+02:00",
      "Description": "Profit-focused fresh-thinking analyzer",
      "Completed": "Completed",
      "Registered": "2012-04-13T15:05:42.4096338+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 150,
      "DocumentId": 542,
      "Date": "2002-12-15T15:05:42.4096338+01:00",
      "Description": "Inverse cohesive algorithm",
      "Completed": "Completed",
      "Registered": "2001-04-14T15:05:42.4096338+02:00"
    },
    {
      "AppointmentId": 150,
      "DocumentId": 542,
      "Date": "2002-12-15T15:05:42.4096338+01:00",
      "Description": "Inverse cohesive algorithm",
      "Completed": "Completed",
      "Registered": "2001-04-14T15:05:42.4096338+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 389,
      "SaleDate": "1995-11-18T15:05:42.4096338+01:00",
      "Probability": 885,
      "Heading": "velit",
      "Amount": 9906.574,
      "Currency": "saepe",
      "AmountInBaseCurrency": 833.644,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2009-08-02T15:05:42.4096338+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 294,
      "Name": "Kuvalis-Treutel",
      "CompanyName": "Hodkiewicz-Reichel",
      "FirstMessage": "nihil",
      "LastMessage": "est",
      "WhenRequested": "1996-04-14T15:05:42.4096338+02:00",
      "WhenEnded": "2013-11-14T15:05:42.4096338+01:00"
    }
  ]
}
```