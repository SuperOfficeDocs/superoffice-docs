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
GET /api/v1/Contact/{contactId}/Summary?limit=136
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
      "TicketId": 764,
      "TicketStatus": 432,
      "Title": "nesciunt",
      "Registered": "2019-12-30T02:30:52.4911666+01:00",
      "IconHint": "tenetur"
    },
    {
      "TicketId": 764,
      "TicketStatus": 432,
      "Title": "nesciunt",
      "Registered": "2019-12-30T02:30:52.4911666+01:00",
      "IconHint": "tenetur"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 213,
      "DocumentId": 825,
      "Date": "2009-04-13T02:30:52.4911666+02:00",
      "Description": "Distributed heuristic structure",
      "Completed": "Completed",
      "Registered": "2010-03-27T02:30:52.4911666+01:00"
    },
    {
      "AppointmentId": 213,
      "DocumentId": 825,
      "Date": "2009-04-13T02:30:52.4911666+02:00",
      "Description": "Distributed heuristic structure",
      "Completed": "Completed",
      "Registered": "2010-03-27T02:30:52.4911666+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 926,
      "DocumentId": 722,
      "Date": "2000-12-31T02:30:52.4911666+01:00",
      "Description": "Focused leading edge complexity",
      "Completed": "Completed",
      "Registered": "2002-03-28T02:30:52.4911666+01:00"
    },
    {
      "AppointmentId": 926,
      "DocumentId": 722,
      "Date": "2000-12-31T02:30:52.4911666+01:00",
      "Description": "Focused leading edge complexity",
      "Completed": "Completed",
      "Registered": "2002-03-28T02:30:52.4911666+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 615,
      "SaleDate": "2003-03-07T02:30:52.4911666+01:00",
      "Probability": 976,
      "Heading": "eius",
      "Amount": 21894.124,
      "Currency": "consequuntur",
      "AmountInBaseCurrency": 21715.486,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2005-12-06T02:30:52.4911666+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 775,
      "Name": "Hamill-Romaguera",
      "CompanyName": "Labadie Group",
      "FirstMessage": "exercitationem",
      "LastMessage": "delectus",
      "WhenRequested": "2004-12-10T02:30:52.4911666+01:00",
      "WhenEnded": "2017-08-21T02:30:52.4911666+02:00"
    }
  ]
}
```