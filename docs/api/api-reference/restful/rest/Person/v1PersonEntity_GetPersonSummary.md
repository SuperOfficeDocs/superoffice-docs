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
GET /api/v1/Person/{personId}/Summary?limit=472
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
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Person": {
    "Position": "labore",
    "PersonId": 650,
    "Mrmrs": "repellendus",
    "Firstname": "Syble",
    "Lastname": "Hagenes",
    "MiddleName": "Wuckert, Bergstrom and Abernathy",
    "Title": "sunt",
    "Description": "Reverse-engineered foreground moratorium",
    "Email": "alena.turner@zieme.co.uk",
    "FullName": "Miss Shad Rogahn",
    "DirectPhone": "1-223-156-4022 x685",
    "FormalName": "Morar, Murphy and Willms",
    "CountryId": 497,
    "ContactId": 476,
    "ContactName": "Hammes-Heidenreich",
    "Retired": 253,
    "Rank": 104,
    "ActiveInterests": 945,
    "ContactDepartment": "",
    "ContactCountryId": 171,
    "ContactOrgNr": "781710",
    "FaxPhone": "(005)367-5600",
    "MobilePhone": "(547)685-2431 x23118",
    "ContactPhone": "212.433.2163 x10782",
    "AssociateName": "Keeling-Renner",
    "AssociateId": 680,
    "UsePersonAddress": false,
    "ContactFax": "ea",
    "Kanafname": "minus",
    "Kanalname": "qui",
    "Post1": "rerum",
    "Post2": "fuga",
    "Post3": "amet",
    "EmailName": "rozella.kshlerin@kunze.com",
    "ContactFullName": "Wallace Nienow",
    "ActiveErpLinks": 346,
    "TicketPriorityId": 190,
    "SupportLanguageId": 670,
    "SupportAssociateId": 420,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 433
      }
    }
  },
  "Tickets": [
    {
      "TicketId": 509,
      "TicketStatus": 76,
      "Title": "et",
      "Registered": "2015-04-15T18:25:50.7315958+02:00"
    },
    {
      "TicketId": 509,
      "TicketStatus": 76,
      "Title": "et",
      "Registered": "2015-04-15T18:25:50.7315958+02:00"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 534,
      "DocumentId": 621,
      "Date": "2004-07-09T18:25:50.7315958+02:00",
      "Description": "Enterprise-wide disintermediate forecast",
      "Completed": "Completed",
      "Registered": "1995-11-07T18:25:50.7315958+01:00"
    },
    {
      "AppointmentId": 534,
      "DocumentId": 621,
      "Date": "2004-07-09T18:25:50.7315958+02:00",
      "Description": "Enterprise-wide disintermediate forecast",
      "Completed": "Completed",
      "Registered": "1995-11-07T18:25:50.7315958+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 38,
      "DocumentId": 301,
      "Date": "1996-07-13T18:25:50.7315958+02:00",
      "Description": "Proactive responsive portal",
      "Completed": "Completed",
      "Registered": "2015-05-11T18:25:50.7315958+02:00"
    },
    {
      "AppointmentId": 38,
      "DocumentId": 301,
      "Date": "1996-07-13T18:25:50.7315958+02:00",
      "Description": "Proactive responsive portal",
      "Completed": "Completed",
      "Registered": "2015-05-11T18:25:50.7315958+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 462,
      "SaleDate": "2004-10-06T18:25:50.7315958+02:00",
      "Probability": 853,
      "Heading": "ipsam",
      "Amount": 12203.796,
      "Currency": "veritatis",
      "AmountInBaseCurrency": 24106.728,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2004-01-03T18:25:50.7315958+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 971,
      "Name": "Parker, Hartmann and Kunze",
      "CompanyName": "Durgan Group",
      "FirstMessage": "voluptatibus",
      "LastMessage": "quaerat",
      "WhenRequested": "1998-02-14T18:25:50.7315958+01:00",
      "WhenEnded": "2003-02-08T18:25:50.7315958+01:00"
    }
  ]
}
```