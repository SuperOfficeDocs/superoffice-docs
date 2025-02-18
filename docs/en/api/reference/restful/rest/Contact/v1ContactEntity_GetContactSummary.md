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
GET /api/v1/Contact/{contactId}/Summary?limit=775
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
      "TicketId": 1000,
      "TicketStatus": 959,
      "Title": "quis",
      "Registered": "2019-11-03T14:32:11.3489356+01:00",
      "IconHint": "eveniet"
    },
    {
      "TicketId": 1000,
      "TicketStatus": 959,
      "Title": "quis",
      "Registered": "2019-11-03T14:32:11.3489356+01:00",
      "IconHint": "eveniet"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 848,
      "DocumentId": 199,
      "Date": "2009-04-29T14:32:11.3489356+02:00",
      "Description": "Programmable fault-tolerant model",
      "Completed": "Completed",
      "Registered": "2007-08-04T14:32:11.3489356+02:00"
    },
    {
      "AppointmentId": 848,
      "DocumentId": 199,
      "Date": "2009-04-29T14:32:11.3489356+02:00",
      "Description": "Programmable fault-tolerant model",
      "Completed": "Completed",
      "Registered": "2007-08-04T14:32:11.3489356+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 1001,
      "DocumentId": 181,
      "Date": "2024-12-09T14:32:11.3489356+01:00",
      "Description": "Function-based holistic local area network",
      "Completed": "Completed",
      "Registered": "2023-04-22T14:32:11.3489356+02:00"
    },
    {
      "AppointmentId": 1001,
      "DocumentId": 181,
      "Date": "2024-12-09T14:32:11.3489356+01:00",
      "Description": "Function-based holistic local area network",
      "Completed": "Completed",
      "Registered": "2023-04-22T14:32:11.3489356+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 799,
      "SaleDate": "2022-07-07T14:32:11.3489356+02:00",
      "Probability": 343,
      "Heading": "distinctio",
      "Amount": 5603.592,
      "Currency": "aut",
      "AmountInBaseCurrency": 25745.809999999998,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2013-02-12T14:32:11.3489356+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 438,
      "Name": "Kling-Monahan",
      "CompanyName": "Friesen-Swift",
      "FirstMessage": "ut",
      "LastMessage": "eveniet",
      "WhenRequested": "2015-01-02T14:32:11.3489356+01:00",
      "WhenEnded": "2013-09-09T14:32:11.3489356+02:00"
    }
  ]
}
```