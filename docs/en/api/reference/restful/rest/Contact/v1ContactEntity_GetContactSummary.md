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
GET /api/v1/Contact/{contactId}/Summary?limit=668
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
      "TicketId": 638,
      "TicketStatus": 51,
      "Title": "consectetur",
      "Registered": "1997-06-06T10:30:31.9324368+02:00",
      "IconHint": "molestiae"
    },
    {
      "TicketId": 638,
      "TicketStatus": 51,
      "Title": "consectetur",
      "Registered": "1997-06-06T10:30:31.9324368+02:00",
      "IconHint": "molestiae"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 429,
      "DocumentId": 464,
      "Date": "2000-03-08T10:30:31.9324368+01:00",
      "Description": "Synchronised logistical alliance",
      "Completed": "Completed",
      "Registered": "2007-07-27T10:30:31.9324368+02:00"
    },
    {
      "AppointmentId": 429,
      "DocumentId": 464,
      "Date": "2000-03-08T10:30:31.9324368+01:00",
      "Description": "Synchronised logistical alliance",
      "Completed": "Completed",
      "Registered": "2007-07-27T10:30:31.9324368+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 442,
      "DocumentId": 699,
      "Date": "2021-04-15T10:30:31.9324368+02:00",
      "Description": "Phased logistical synergy",
      "Completed": "Completed",
      "Registered": "2013-12-24T10:30:31.9324368+01:00"
    },
    {
      "AppointmentId": 442,
      "DocumentId": 699,
      "Date": "2021-04-15T10:30:31.9324368+02:00",
      "Description": "Phased logistical synergy",
      "Completed": "Completed",
      "Registered": "2013-12-24T10:30:31.9324368+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 256,
      "SaleDate": "2021-06-10T10:30:31.9324368+02:00",
      "Probability": 146,
      "Heading": "odio",
      "Amount": 25206.762,
      "Currency": "quisquam",
      "AmountInBaseCurrency": 1905.472,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2023-12-16T10:30:31.9324368+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 800,
      "Name": "Kling, Bogisich and Boyle",
      "CompanyName": "Fay, Mitchell and Renner",
      "FirstMessage": "quidem",
      "LastMessage": "architecto",
      "WhenRequested": "2018-06-05T10:30:31.9324368+02:00",
      "WhenEnded": "2004-04-29T10:30:31.9324368+02:00"
    }
  ]
}
```