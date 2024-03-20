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
GET /api/v1/Contact/{contactId}/Summary?limit=399
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
      "TicketId": 30,
      "TicketStatus": 817,
      "Title": "doloribus",
      "Registered": "2011-01-13T12:19:53.2743262+01:00",
      "IconHint": "iste"
    },
    {
      "TicketId": 30,
      "TicketStatus": 817,
      "Title": "doloribus",
      "Registered": "2011-01-13T12:19:53.2743262+01:00",
      "IconHint": "iste"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 505,
      "DocumentId": 131,
      "Date": "2006-03-31T12:19:53.2743262+02:00",
      "Description": "Streamlined tertiary local area network",
      "Completed": "Completed",
      "Registered": "2010-12-07T12:19:53.2743262+01:00"
    },
    {
      "AppointmentId": 505,
      "DocumentId": 131,
      "Date": "2006-03-31T12:19:53.2743262+02:00",
      "Description": "Streamlined tertiary local area network",
      "Completed": "Completed",
      "Registered": "2010-12-07T12:19:53.2743262+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 913,
      "DocumentId": 179,
      "Date": "2004-08-05T12:19:53.2743262+02:00",
      "Description": "Object-based static circuit",
      "Completed": "Completed",
      "Registered": "2023-12-02T12:19:53.2743262+01:00"
    },
    {
      "AppointmentId": 913,
      "DocumentId": 179,
      "Date": "2004-08-05T12:19:53.2743262+02:00",
      "Description": "Object-based static circuit",
      "Completed": "Completed",
      "Registered": "2023-12-02T12:19:53.2743262+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 66,
      "SaleDate": "2018-09-06T12:19:53.2743262+02:00",
      "Probability": 70,
      "Heading": "corrupti",
      "Amount": 9555.5659999999989,
      "Currency": "aut",
      "AmountInBaseCurrency": 3312.638,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2004-02-03T12:19:53.2743262+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 320,
      "Name": "Roberts, Zemlak and Romaguera",
      "CompanyName": "Collins-Schuster",
      "FirstMessage": "voluptate",
      "LastMessage": "qui",
      "WhenRequested": "2004-03-20T12:19:53.2743262+01:00",
      "WhenEnded": "2001-04-09T12:19:53.2743262+02:00"
    }
  ]
}
```