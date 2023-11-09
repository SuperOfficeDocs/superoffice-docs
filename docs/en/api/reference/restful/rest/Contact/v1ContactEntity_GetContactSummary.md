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
GET /api/v1/Contact/{contactId}/Summary?limit=420
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
      "TicketId": 751,
      "TicketStatus": 920,
      "Title": "corrupti",
      "Registered": "2007-01-11T11:06:41.7540989+01:00",
      "IconHint": "qui"
    },
    {
      "TicketId": 751,
      "TicketStatus": 920,
      "Title": "corrupti",
      "Registered": "2007-01-11T11:06:41.7540989+01:00",
      "IconHint": "qui"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 736,
      "DocumentId": 960,
      "Date": "2005-10-02T11:06:41.7540989+02:00",
      "Description": "Right-sized methodical extranet",
      "Completed": "Completed",
      "Registered": "2003-01-24T11:06:41.7540989+01:00"
    },
    {
      "AppointmentId": 736,
      "DocumentId": 960,
      "Date": "2005-10-02T11:06:41.7540989+02:00",
      "Description": "Right-sized methodical extranet",
      "Completed": "Completed",
      "Registered": "2003-01-24T11:06:41.7540989+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 665,
      "DocumentId": 190,
      "Date": "2018-01-03T11:06:41.7540989+01:00",
      "Description": "Focused executive adapter",
      "Completed": "Completed",
      "Registered": "2002-12-30T11:06:41.7540989+01:00"
    },
    {
      "AppointmentId": 665,
      "DocumentId": 190,
      "Date": "2018-01-03T11:06:41.7540989+01:00",
      "Description": "Focused executive adapter",
      "Completed": "Completed",
      "Registered": "2002-12-30T11:06:41.7540989+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 275,
      "SaleDate": "2021-06-26T11:06:41.7540989+02:00",
      "Probability": 812,
      "Heading": "maiores",
      "Amount": 6111.3,
      "Currency": "fuga",
      "AmountInBaseCurrency": 5967.1359999999995,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2003-02-04T11:06:41.7540989+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 652,
      "Name": "Ritchie-Jakubowski",
      "CompanyName": "Howell Inc and Sons",
      "FirstMessage": "et",
      "LastMessage": "recusandae",
      "WhenRequested": "1999-03-23T11:06:41.7540989+01:00",
      "WhenEnded": "2016-07-11T11:06:41.7540989+02:00"
    }
  ]
}
```