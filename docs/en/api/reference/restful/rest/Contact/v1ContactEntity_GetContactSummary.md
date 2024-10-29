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
GET /api/v1/Contact/{contactId}/Summary?limit=896
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
      "TicketId": 401,
      "TicketStatus": 197,
      "Title": "aliquid",
      "Registered": "1997-08-31T13:14:10.7579101+02:00",
      "IconHint": "nisi"
    },
    {
      "TicketId": 401,
      "TicketStatus": 197,
      "Title": "aliquid",
      "Registered": "1997-08-31T13:14:10.7579101+02:00",
      "IconHint": "nisi"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 559,
      "DocumentId": 108,
      "Date": "1999-03-01T13:14:10.7579101+01:00",
      "Description": "Focused background instruction set",
      "Completed": "Completed",
      "Registered": "2002-05-13T13:14:10.7579101+02:00"
    },
    {
      "AppointmentId": 559,
      "DocumentId": 108,
      "Date": "1999-03-01T13:14:10.7579101+01:00",
      "Description": "Focused background instruction set",
      "Completed": "Completed",
      "Registered": "2002-05-13T13:14:10.7579101+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 72,
      "DocumentId": 745,
      "Date": "1999-03-31T13:14:10.7579101+02:00",
      "Description": "Polarised optimal extranet",
      "Completed": "Completed",
      "Registered": "2015-11-07T13:14:10.7579101+01:00"
    },
    {
      "AppointmentId": 72,
      "DocumentId": 745,
      "Date": "1999-03-31T13:14:10.7579101+02:00",
      "Description": "Polarised optimal extranet",
      "Completed": "Completed",
      "Registered": "2015-11-07T13:14:10.7579101+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 838,
      "SaleDate": "2007-07-21T13:14:10.7579101+02:00",
      "Probability": 922,
      "Heading": "sequi",
      "Amount": 8461.8,
      "Currency": "est",
      "AmountInBaseCurrency": 2729.714,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2017-08-21T13:14:10.7579101+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 495,
      "Name": "Gutkowski Inc and Sons",
      "CompanyName": "Breitenberg-Ullrich",
      "FirstMessage": "nam",
      "LastMessage": "aut",
      "WhenRequested": "2019-02-13T13:14:10.7579101+01:00",
      "WhenEnded": "1997-07-02T13:14:10.7579101+02:00"
    }
  ]
}
```