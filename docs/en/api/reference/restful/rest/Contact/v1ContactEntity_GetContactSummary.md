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
GET /api/v1/Contact/{contactId}/Summary?limit=655
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
      "TicketId": 451,
      "TicketStatus": 310,
      "Title": "id",
      "Registered": "2006-12-16T11:16:13.82385+01:00",
      "IconHint": "ea"
    },
    {
      "TicketId": 451,
      "TicketStatus": 310,
      "Title": "id",
      "Registered": "2006-12-16T11:16:13.82385+01:00",
      "IconHint": "ea"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 825,
      "DocumentId": 92,
      "Date": "2011-07-07T11:16:13.82385+02:00",
      "Description": "Team-oriented empowering analyzer",
      "Completed": "Completed",
      "Registered": "2013-05-16T11:16:13.82385+02:00"
    },
    {
      "AppointmentId": 825,
      "DocumentId": 92,
      "Date": "2011-07-07T11:16:13.82385+02:00",
      "Description": "Team-oriented empowering analyzer",
      "Completed": "Completed",
      "Registered": "2013-05-16T11:16:13.82385+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 922,
      "DocumentId": 217,
      "Date": "2003-12-04T11:16:13.82385+01:00",
      "Description": "Ergonomic bi-directional forecast",
      "Completed": "Completed",
      "Registered": "2021-07-28T11:16:13.82385+02:00"
    },
    {
      "AppointmentId": 922,
      "DocumentId": 217,
      "Date": "2003-12-04T11:16:13.82385+01:00",
      "Description": "Ergonomic bi-directional forecast",
      "Completed": "Completed",
      "Registered": "2021-07-28T11:16:13.82385+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 910,
      "SaleDate": "2003-12-17T11:16:13.82385+01:00",
      "Probability": 812,
      "Heading": "nisi",
      "Amount": 6111.3,
      "Currency": "dolorum",
      "AmountInBaseCurrency": 4036.5919999999996,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2018-04-29T11:16:13.82385+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 835,
      "Name": "Kuvalis LLC",
      "CompanyName": "Windler LLC",
      "FirstMessage": "at",
      "LastMessage": "ut",
      "WhenRequested": "2010-05-09T11:16:13.82385+02:00",
      "WhenEnded": "2017-10-24T11:16:13.82385+02:00"
    }
  ]
}
```