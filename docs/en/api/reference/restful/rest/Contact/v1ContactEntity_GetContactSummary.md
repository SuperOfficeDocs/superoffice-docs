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
GET /api/v1/Contact/{contactId}/Summary?limit=591
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
      "TicketId": 617,
      "TicketStatus": 410,
      "Title": "enim",
      "Registered": "2015-08-07T11:24:53.1405767+02:00",
      "IconHint": "aut"
    },
    {
      "TicketId": 617,
      "TicketStatus": 410,
      "Title": "enim",
      "Registered": "2015-08-07T11:24:53.1405767+02:00",
      "IconHint": "aut"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 488,
      "DocumentId": 324,
      "Date": "2010-10-08T11:24:53.1405767+02:00",
      "Description": "Persevering real-time forecast",
      "Completed": "Completed",
      "Registered": "2024-03-30T11:24:53.1405767+01:00"
    },
    {
      "AppointmentId": 488,
      "DocumentId": 324,
      "Date": "2010-10-08T11:24:53.1405767+02:00",
      "Description": "Persevering real-time forecast",
      "Completed": "Completed",
      "Registered": "2024-03-30T11:24:53.1405767+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 679,
      "DocumentId": 919,
      "Date": "2024-10-12T11:24:53.1405767+02:00",
      "Description": "Operative 4th generation synergy",
      "Completed": "Completed",
      "Registered": "2016-11-11T11:24:53.1405767+01:00"
    },
    {
      "AppointmentId": 679,
      "DocumentId": 919,
      "Date": "2024-10-12T11:24:53.1405767+02:00",
      "Description": "Operative 4th generation synergy",
      "Completed": "Completed",
      "Registered": "2016-11-11T11:24:53.1405767+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 230,
      "SaleDate": "2018-07-22T11:24:53.1405767+02:00",
      "Probability": 634,
      "Heading": "at",
      "Amount": 7295.9519999999993,
      "Currency": "quidem",
      "AmountInBaseCurrency": 31092.414,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2024-08-19T11:24:53.1405767+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 783,
      "Name": "Marvin Inc and Sons",
      "CompanyName": "Langosh, Jacobson and Murazik",
      "FirstMessage": "molestiae",
      "LastMessage": "amet",
      "WhenRequested": "2007-01-31T11:24:53.1405767+01:00",
      "WhenEnded": "2001-11-13T11:24:53.1405767+01:00"
    }
  ]
}
```