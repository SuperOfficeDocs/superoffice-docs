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
GET /api/v1/Contact/{contactId}/Summary?limit=602
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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Contact": null,
  "Tickets": [
    {
      "TicketId": 622,
      "TicketStatus": 965,
      "Title": "ab",
      "Registered": "2002-10-25T03:40:55.5850292+02:00",
      "IconHint": "veritatis"
    },
    {
      "TicketId": 622,
      "TicketStatus": 965,
      "Title": "ab",
      "Registered": "2002-10-25T03:40:55.5850292+02:00",
      "IconHint": "veritatis"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 206,
      "DocumentId": 759,
      "Date": "2004-01-23T03:40:55.5850292+01:00",
      "Description": "Operative tangible middleware",
      "Completed": "Completed",
      "Registered": "2016-11-24T03:40:55.5850292+01:00"
    },
    {
      "AppointmentId": 206,
      "DocumentId": 759,
      "Date": "2004-01-23T03:40:55.5850292+01:00",
      "Description": "Operative tangible middleware",
      "Completed": "Completed",
      "Registered": "2016-11-24T03:40:55.5850292+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 946,
      "DocumentId": 784,
      "Date": "1999-05-11T03:40:55.5850292+02:00",
      "Description": "Managed secondary function",
      "Completed": "Completed",
      "Registered": "1999-02-20T03:40:55.5850292+01:00"
    },
    {
      "AppointmentId": 946,
      "DocumentId": 784,
      "Date": "1999-05-11T03:40:55.5850292+02:00",
      "Description": "Managed secondary function",
      "Completed": "Completed",
      "Registered": "1999-02-20T03:40:55.5850292+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 522,
      "SaleDate": "2008-03-20T03:40:55.5850292+01:00",
      "Probability": 569,
      "Heading": "fuga",
      "Amount": 4923.514,
      "Currency": "nihil",
      "AmountInBaseCurrency": 12485.856,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2016-01-26T03:40:55.5850292+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 509,
      "Name": "Murray-Cremin",
      "CompanyName": "Botsford-McLaughlin",
      "FirstMessage": "voluptatem",
      "LastMessage": "quidem",
      "WhenRequested": "2010-02-17T03:40:55.5850292+01:00",
      "WhenEnded": "2004-01-15T03:40:55.5850292+01:00"
    }
  ]
}
```