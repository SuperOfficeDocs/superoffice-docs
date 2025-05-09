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
GET /api/v1/Contact/{contactId}/Summary?limit=499
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
      "TicketId": 460,
      "TicketStatus": 584,
      "Title": "voluptatem",
      "Registered": "2003-08-24T16:32:47.3839895+02:00",
      "IconHint": "fugiat"
    },
    {
      "TicketId": 460,
      "TicketStatus": 584,
      "Title": "voluptatem",
      "Registered": "2003-08-24T16:32:47.3839895+02:00",
      "IconHint": "fugiat"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 973,
      "DocumentId": 439,
      "Date": "2015-02-14T16:32:47.3839895+01:00",
      "Description": "Horizontal content-based adapter",
      "Completed": "Completed",
      "Registered": "2022-08-11T16:32:47.3839895+02:00"
    },
    {
      "AppointmentId": 973,
      "DocumentId": 439,
      "Date": "2015-02-14T16:32:47.3839895+01:00",
      "Description": "Horizontal content-based adapter",
      "Completed": "Completed",
      "Registered": "2022-08-11T16:32:47.3839895+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 685,
      "DocumentId": 984,
      "Date": "2019-01-16T16:32:47.3839895+01:00",
      "Description": "Down-sized cohesive access",
      "Completed": "Completed",
      "Registered": "2012-12-30T16:32:47.3839895+01:00"
    },
    {
      "AppointmentId": 685,
      "DocumentId": 984,
      "Date": "2019-01-16T16:32:47.3839895+01:00",
      "Description": "Down-sized cohesive access",
      "Completed": "Completed",
      "Registered": "2012-12-30T16:32:47.3839895+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 869,
      "SaleDate": "2008-03-01T16:32:47.3839895+01:00",
      "Probability": 319,
      "Heading": "facere",
      "Amount": 23191.6,
      "Currency": "rerum",
      "AmountInBaseCurrency": 10878.114,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2009-08-25T16:32:47.3839895+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 970,
      "Name": "Hackett, Purdy and Hickle",
      "CompanyName": "Russel-Torphy",
      "FirstMessage": "reprehenderit",
      "LastMessage": "ut",
      "WhenRequested": "2014-12-14T16:32:47.3839895+01:00",
      "WhenEnded": "2008-12-01T16:32:47.3839895+01:00"
    }
  ]
}
```