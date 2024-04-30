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
GET /api/v1/Contact/{contactId}/Summary?limit=657
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
      "TicketId": 539,
      "TicketStatus": 285,
      "Title": "repellendus",
      "Registered": "2000-08-05T11:44:41.8359334+02:00",
      "IconHint": "et"
    },
    {
      "TicketId": 539,
      "TicketStatus": 285,
      "Title": "repellendus",
      "Registered": "2000-08-05T11:44:41.8359334+02:00",
      "IconHint": "et"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 557,
      "DocumentId": 403,
      "Date": "2014-09-13T11:44:41.8359334+02:00",
      "Description": "Seamless exuding hardware",
      "Completed": "Completed",
      "Registered": "2005-06-24T11:44:41.8359334+02:00"
    },
    {
      "AppointmentId": 557,
      "DocumentId": 403,
      "Date": "2014-09-13T11:44:41.8359334+02:00",
      "Description": "Seamless exuding hardware",
      "Completed": "Completed",
      "Registered": "2005-06-24T11:44:41.8359334+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 663,
      "DocumentId": 577,
      "Date": "2018-01-26T11:44:41.8359334+01:00",
      "Description": "Optimized grid-enabled artificial intelligence",
      "Completed": "Completed",
      "Registered": "2007-06-15T11:44:41.8359334+02:00"
    },
    {
      "AppointmentId": 663,
      "DocumentId": 577,
      "Date": "2018-01-26T11:44:41.8359334+01:00",
      "Description": "Optimized grid-enabled artificial intelligence",
      "Completed": "Completed",
      "Registered": "2007-06-15T11:44:41.8359334+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 917,
      "SaleDate": "2015-06-01T11:44:41.8359334+02:00",
      "Probability": 28,
      "Heading": "beatae",
      "Amount": 23602.154,
      "Currency": "ad",
      "AmountInBaseCurrency": 13711.25,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2013-05-03T11:44:41.8359334+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 891,
      "Name": "Lehner Inc and Sons",
      "CompanyName": "Hermann LLC",
      "FirstMessage": "veritatis",
      "LastMessage": "libero",
      "WhenRequested": "2020-05-19T11:44:41.8359334+02:00",
      "WhenEnded": "2008-09-01T11:44:41.8359334+02:00"
    }
  ]
}
```