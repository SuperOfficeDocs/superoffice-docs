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
GET /api/v1/Person/{personId}/Summary?limit=404
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
    "Position": "quibusdam",
    "PersonId": 669,
    "Mrmrs": "id",
    "Firstname": "Olga",
    "Lastname": "Kulas",
    "MiddleName": "Gaylord, Stiedemann and Ferry",
    "Title": "quidem",
    "Description": "Mandatory context-sensitive success",
    "Email": "carleton@carroll.ca",
    "FullName": "Aidan Welch",
    "DirectPhone": "(251)466-2588 x0553",
    "FormalName": "Dickens LLC",
    "CountryId": 369,
    "ContactId": 780,
    "ContactName": "Torphy Inc and Sons",
    "Retired": 947,
    "Rank": 741,
    "ActiveInterests": 854,
    "ContactDepartment": "",
    "ContactCountryId": 649,
    "ContactOrgNr": "1179041",
    "FaxPhone": "258-047-5715 x7842",
    "MobilePhone": "756-861-1286 x15453",
    "ContactPhone": "782-636-4824",
    "AssociateName": "Daugherty-DuBuque",
    "AssociateId": 236,
    "UsePersonAddress": false,
    "ContactFax": "cumque",
    "Kanafname": "quasi",
    "Kanalname": "molestiae",
    "Post1": "ipsa",
    "Post2": "dicta",
    "Post3": "ab",
    "EmailName": "flossie@davis.info",
    "ContactFullName": "Adah Bayer",
    "ActiveErpLinks": 169,
    "TicketPriorityId": 523,
    "SupportLanguageId": 438,
    "SupportAssociateId": 118,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 155
      }
    }
  },
  "Tickets": [
    {
      "TicketId": 561,
      "TicketStatus": 994,
      "Title": "est",
      "Registered": "1997-11-03T09:40:59.3866657+01:00"
    },
    {
      "TicketId": 561,
      "TicketStatus": 994,
      "Title": "est",
      "Registered": "1997-11-03T09:40:59.3866657+01:00"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 414,
      "DocumentId": 965,
      "Date": "2005-07-02T09:40:59.3866657+02:00",
      "Description": "Operative maximized artificial intelligence",
      "Completed": "Completed",
      "Registered": "1996-11-18T09:40:59.3866657+01:00"
    },
    {
      "AppointmentId": 414,
      "DocumentId": 965,
      "Date": "2005-07-02T09:40:59.3866657+02:00",
      "Description": "Operative maximized artificial intelligence",
      "Completed": "Completed",
      "Registered": "1996-11-18T09:40:59.3866657+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 845,
      "DocumentId": 635,
      "Date": "1994-01-14T09:40:59.3866657+01:00",
      "Description": "Polarised client-server intranet",
      "Completed": "Completed",
      "Registered": "2011-07-25T09:40:59.3866657+02:00"
    },
    {
      "AppointmentId": 845,
      "DocumentId": 635,
      "Date": "1994-01-14T09:40:59.3866657+01:00",
      "Description": "Polarised client-server intranet",
      "Completed": "Completed",
      "Registered": "2011-07-25T09:40:59.3866657+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 394,
      "SaleDate": "2011-12-11T09:40:59.3866657+01:00",
      "Probability": 655,
      "Heading": "et",
      "Amount": 16682.282,
      "Currency": "laudantium",
      "AmountInBaseCurrency": 29848.216,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "1995-01-20T09:40:59.3866657+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 891,
      "Name": "Boyer, Hintz and Hermiston",
      "CompanyName": "West-Funk",
      "FirstMessage": "libero",
      "LastMessage": "blanditiis",
      "WhenRequested": "2000-03-07T09:40:59.3866657+01:00",
      "WhenEnded": "2016-12-11T09:40:59.3866657+01:00"
    }
  ]
}
```