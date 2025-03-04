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
GET /api/v1/Contact/{contactId}/Summary?limit=298
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
      "TicketId": 631,
      "TicketStatus": 1000,
      "Title": "voluptatem",
      "Registered": "2017-01-26T14:13:48.569529+01:00",
      "IconHint": "ducimus"
    },
    {
      "TicketId": 631,
      "TicketStatus": 1000,
      "Title": "voluptatem",
      "Registered": "2017-01-26T14:13:48.569529+01:00",
      "IconHint": "ducimus"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 278,
      "DocumentId": 987,
      "Date": "1999-04-17T14:13:48.569529+02:00",
      "Description": "Proactive empowering groupware",
      "Completed": "Completed",
      "Registered": "2020-05-04T14:13:48.569529+02:00"
    },
    {
      "AppointmentId": 278,
      "DocumentId": 987,
      "Date": "1999-04-17T14:13:48.569529+02:00",
      "Description": "Proactive empowering groupware",
      "Completed": "Completed",
      "Registered": "2020-05-04T14:13:48.569529+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 909,
      "DocumentId": 914,
      "Date": "2006-11-27T14:13:48.569529+01:00",
      "Description": "Profit-focused local orchestration",
      "Completed": "Completed",
      "Registered": "2012-07-06T14:13:48.569529+02:00"
    },
    {
      "AppointmentId": 909,
      "DocumentId": 914,
      "Date": "2006-11-27T14:13:48.569529+01:00",
      "Description": "Profit-focused local orchestration",
      "Completed": "Completed",
      "Registered": "2012-07-06T14:13:48.569529+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 837,
      "SaleDate": "2009-10-22T14:13:48.569529+02:00",
      "Probability": 222,
      "Heading": "laudantium",
      "Amount": 14911.572,
      "Currency": "minus",
      "AmountInBaseCurrency": 20374.134,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2008-12-24T14:13:48.569529+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 360,
      "Name": "Vandervort-Stamm",
      "CompanyName": "Friesen Group",
      "FirstMessage": "rem",
      "LastMessage": "quae",
      "WhenRequested": "2015-01-23T14:13:48.569529+01:00",
      "WhenEnded": "1999-05-19T14:13:48.569529+02:00"
    }
  ]
}
```