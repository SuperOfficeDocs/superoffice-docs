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
GET /api/v1/Contact/{contactId}/Summary?limit=458
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
      "TicketId": 871,
      "TicketStatus": 810,
      "Title": "vitae",
      "Registered": "2000-04-01T16:00:47.8053524+02:00",
      "IconHint": "distinctio"
    },
    {
      "TicketId": 871,
      "TicketStatus": 810,
      "Title": "vitae",
      "Registered": "2000-04-01T16:00:47.8053524+02:00",
      "IconHint": "distinctio"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 92,
      "DocumentId": 804,
      "Date": "2007-12-11T16:00:47.8053524+01:00",
      "Description": "Synergistic assymetric circuit",
      "Completed": "Completed",
      "Registered": "2005-08-27T16:00:47.8053524+02:00"
    },
    {
      "AppointmentId": 92,
      "DocumentId": 804,
      "Date": "2007-12-11T16:00:47.8053524+01:00",
      "Description": "Synergistic assymetric circuit",
      "Completed": "Completed",
      "Registered": "2005-08-27T16:00:47.8053524+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 836,
      "DocumentId": 322,
      "Date": "1999-09-05T16:00:47.8053524+02:00",
      "Description": "Streamlined 6th generation website",
      "Completed": "Completed",
      "Registered": "2000-04-14T16:00:47.8053524+02:00"
    },
    {
      "AppointmentId": 836,
      "DocumentId": 322,
      "Date": "1999-09-05T16:00:47.8053524+02:00",
      "Description": "Streamlined 6th generation website",
      "Completed": "Completed",
      "Registered": "2000-04-14T16:00:47.8053524+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 456,
      "SaleDate": "2007-08-25T16:00:47.8053524+02:00",
      "Probability": 987,
      "Heading": "magnam",
      "Amount": 22245.131999999998,
      "Currency": "deserunt",
      "AmountInBaseCurrency": 26497.969999999998,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2003-08-12T16:00:47.8053524+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 60,
      "Name": "Williamson LLC",
      "CompanyName": "Ortiz-Walker",
      "FirstMessage": "impedit",
      "LastMessage": "nobis",
      "WhenRequested": "2017-08-27T16:00:47.8053524+02:00",
      "WhenEnded": "2022-07-25T16:00:47.8053524+02:00"
    }
  ]
}
```