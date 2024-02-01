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
GET /api/v1/Contact/{contactId}/Summary?limit=46
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
      "TicketId": 27,
      "TicketStatus": 166,
      "Title": "quasi",
      "Registered": "2006-10-18T23:04:04.0219892+02:00",
      "IconHint": "dolores"
    },
    {
      "TicketId": 27,
      "TicketStatus": 166,
      "Title": "quasi",
      "Registered": "2006-10-18T23:04:04.0219892+02:00",
      "IconHint": "dolores"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 651,
      "DocumentId": 562,
      "Date": "2015-08-22T23:04:04.0219892+02:00",
      "Description": "Quality-focused asynchronous parallelism",
      "Completed": "Completed",
      "Registered": "2001-11-05T23:04:04.0219892+01:00"
    },
    {
      "AppointmentId": 651,
      "DocumentId": 562,
      "Date": "2015-08-22T23:04:04.0219892+02:00",
      "Description": "Quality-focused asynchronous parallelism",
      "Completed": "Completed",
      "Registered": "2001-11-05T23:04:04.0219892+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 538,
      "DocumentId": 661,
      "Date": "2000-05-13T23:04:04.0219892+02:00",
      "Description": "Extended hybrid system engine",
      "Completed": "Completed",
      "Registered": "2013-08-20T23:04:04.0219892+02:00"
    },
    {
      "AppointmentId": 538,
      "DocumentId": 661,
      "Date": "2000-05-13T23:04:04.0219892+02:00",
      "Description": "Extended hybrid system engine",
      "Completed": "Completed",
      "Registered": "2013-08-20T23:04:04.0219892+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 705,
      "SaleDate": "2004-04-03T23:04:04.0219892+02:00",
      "Probability": 421,
      "Heading": "est",
      "Amount": 2453.922,
      "Currency": "eum",
      "AmountInBaseCurrency": 27237.593999999997,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2018-08-21T23:04:04.0219892+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 181,
      "Name": "Hansen LLC",
      "CompanyName": "Haag-Cummerata",
      "FirstMessage": "perspiciatis",
      "LastMessage": "molestiae",
      "WhenRequested": "1998-11-12T23:04:04.0219892+01:00",
      "WhenEnded": "2000-11-09T23:04:04.0219892+01:00"
    }
  ]
}
```