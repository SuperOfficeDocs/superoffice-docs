---
title: GET Contact/{id}/Summary
uid: v1ContactEntity_GetContactSummary
generated: true
content_type: reference
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
GET /api/v1/Contact/{contactId}/Summary?limit=167
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
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Contact": null,
  "Tickets": [
    {
      "TicketId": 365,
      "TicketStatus": 174,
      "Title": "molestiae",
      "Registered": "2013-03-09T03:46:59.8786923+01:00",
      "IconHint": "ut"
    },
    {
      "TicketId": 365,
      "TicketStatus": 174,
      "Title": "molestiae",
      "Registered": "2013-03-09T03:46:59.8786923+01:00",
      "IconHint": "ut"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 132,
      "DocumentId": 474,
      "Date": "2020-11-03T03:46:59.8786923+01:00",
      "Description": "Assimilated even-keeled portal",
      "Completed": "Completed",
      "Registered": "1999-04-21T03:46:59.8786923+02:00"
    },
    {
      "AppointmentId": 132,
      "DocumentId": 474,
      "Date": "2020-11-03T03:46:59.8786923+01:00",
      "Description": "Assimilated even-keeled portal",
      "Completed": "Completed",
      "Registered": "1999-04-21T03:46:59.8786923+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 117,
      "DocumentId": 244,
      "Date": "2024-09-06T03:46:59.8786923+02:00",
      "Description": "Monitored assymetric initiative",
      "Completed": "Completed",
      "Registered": "2019-01-14T03:46:59.8786923+01:00"
    },
    {
      "AppointmentId": 117,
      "DocumentId": 244,
      "Date": "2024-09-06T03:46:59.8786923+02:00",
      "Description": "Monitored assymetric initiative",
      "Completed": "Completed",
      "Registered": "2019-01-14T03:46:59.8786923+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 236,
      "SaleDate": "2005-02-02T03:46:59.8786923+01:00",
      "Probability": 312,
      "Heading": "sit",
      "Amount": 23103.847999999998,
      "Currency": "eum",
      "AmountInBaseCurrency": 24269.696,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2012-02-13T03:46:59.8786923+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 957,
      "Name": "Leuschke, Morar and Jakubowski",
      "CompanyName": "Pacocha-Wehner",
      "FirstMessage": "placeat",
      "LastMessage": "nam",
      "WhenRequested": "2003-09-15T03:46:59.8786923+02:00",
      "WhenEnded": "2015-08-05T03:46:59.8786923+02:00"
    }
  ]
}
```