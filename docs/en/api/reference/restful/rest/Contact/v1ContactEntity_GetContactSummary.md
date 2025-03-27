---
title: GET Contact/{id}/Summary
uid: v1ContactEntity_GetContactSummary
generated: true
---

# GET Contact/{id}/Summary

```http
GET /api/v1/Contact/{contactId}/Summary
```

Get summary of contact and its recent activity.






| Path Part | Type | Description |
|-----------|------|-------------|
| contactId | int32 | The contact id to summarize. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| limit | int32 |  Max number of items to include in summary lists. |

```http
GET /api/v1/Contact/{contactId}/Summary?limit=428
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


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ContactSummary

| Property Name | Type |  Description |
|----------------|------|--------------|
| Contact | Contact | Simple Contact data. |
| Tickets | array | Recent tickets on contact |
| Followups | array | Recent follow-ups on contact |
| Documents | array | Recent documents on contact |
| Sales | array | Recent sales on contact |
| Chats | array | Recent chats with contact |

## Sample request

```http!
GET /api/v1/Contact/{contactId}/Summary
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Contact": null,
  "Tickets": [
    {
      "TicketId": 448,
      "TicketStatus": 618,
      "Title": "assumenda",
      "Registered": "2016-06-10T02:38:26.011077+02:00",
      "IconHint": "aliquam"
    },
    {
      "TicketId": 448,
      "TicketStatus": 618,
      "Title": "assumenda",
      "Registered": "2016-06-10T02:38:26.011077+02:00",
      "IconHint": "aliquam"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 99,
      "DocumentId": 713,
      "Date": "2015-12-29T02:38:26.011077+01:00",
      "Description": "Implemented bi-directional adapter",
      "Completed": "Completed",
      "Registered": "2001-09-10T02:38:26.011077+02:00"
    },
    {
      "AppointmentId": 99,
      "DocumentId": 713,
      "Date": "2015-12-29T02:38:26.011077+01:00",
      "Description": "Implemented bi-directional adapter",
      "Completed": "Completed",
      "Registered": "2001-09-10T02:38:26.011077+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 794,
      "DocumentId": 751,
      "Date": "1998-04-07T02:38:26.011077+02:00",
      "Description": "Organic 6th generation software",
      "Completed": "Completed",
      "Registered": "2007-01-01T02:38:26.011077+01:00"
    },
    {
      "AppointmentId": 794,
      "DocumentId": 751,
      "Date": "1998-04-07T02:38:26.011077+02:00",
      "Description": "Organic 6th generation software",
      "Completed": "Completed",
      "Registered": "2007-01-01T02:38:26.011077+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 294,
      "SaleDate": "2019-12-11T02:38:26.011077+01:00",
      "Probability": 976,
      "Heading": "aperiam",
      "Amount": 8458.666,
      "Currency": "amet",
      "AmountInBaseCurrency": 9850.162,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2012-07-04T02:38:26.011077+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 297,
      "Name": "Kuhic-Haley",
      "CompanyName": "Ward Inc and Sons",
      "FirstMessage": "autem",
      "LastMessage": "in",
      "WhenRequested": "2022-04-14T02:38:26.011077+02:00",
      "WhenEnded": "2024-04-16T02:38:26.011077+02:00"
    }
  ]
}
```