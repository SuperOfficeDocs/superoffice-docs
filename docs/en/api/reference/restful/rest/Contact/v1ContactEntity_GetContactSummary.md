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
GET /api/v1/Contact/{contactId}/Summary?limit=808
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
      "TicketId": 491,
      "TicketStatus": 228,
      "Title": "magni",
      "Registered": "2003-09-07T13:28:31.5074055+02:00",
      "IconHint": "dolorem"
    },
    {
      "TicketId": 491,
      "TicketStatus": 228,
      "Title": "magni",
      "Registered": "2003-09-07T13:28:31.5074055+02:00",
      "IconHint": "dolorem"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 627,
      "DocumentId": 502,
      "Date": "2003-11-22T13:28:31.5074055+01:00",
      "Description": "Total composite database",
      "Completed": "Completed",
      "Registered": "2007-07-03T13:28:31.5074055+02:00"
    },
    {
      "AppointmentId": 627,
      "DocumentId": 502,
      "Date": "2003-11-22T13:28:31.5074055+01:00",
      "Description": "Total composite database",
      "Completed": "Completed",
      "Registered": "2007-07-03T13:28:31.5074055+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 534,
      "DocumentId": 229,
      "Date": "2001-11-06T13:28:31.5074055+01:00",
      "Description": "User-friendly exuding success",
      "Completed": "Completed",
      "Registered": "2015-03-01T13:28:31.5074055+01:00"
    },
    {
      "AppointmentId": 534,
      "DocumentId": 229,
      "Date": "2001-11-06T13:28:31.5074055+01:00",
      "Description": "User-friendly exuding success",
      "Completed": "Completed",
      "Registered": "2015-03-01T13:28:31.5074055+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 103,
      "SaleDate": "2000-02-19T13:28:31.5074055+01:00",
      "Probability": 357,
      "Heading": "qui",
      "Amount": 23937.492,
      "Currency": "quo",
      "AmountInBaseCurrency": 28795.192,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2008-11-17T13:28:31.5074055+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 438,
      "Name": "Zemlak LLC",
      "CompanyName": "Wilderman, Senger and Bahringer",
      "FirstMessage": "accusamus",
      "LastMessage": "et",
      "WhenRequested": "2017-06-06T13:28:31.5074055+02:00",
      "WhenEnded": "2021-04-12T13:28:31.5074055+02:00"
    }
  ]
}
```