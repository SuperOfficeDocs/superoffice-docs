---
title: GET Contact/{id}/Summary
uid: v1ContactEntity_GetContactSummary
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
GET /api/v1/Contact/{contactId}/Summary?limit=127
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
      "TicketId": 785,
      "TicketStatus": 668,
      "Title": "nihil",
      "Registered": "2012-05-07T14:19:10.2092258+02:00",
      "IconHint": "non"
    },
    {
      "TicketId": 785,
      "TicketStatus": 668,
      "Title": "nihil",
      "Registered": "2012-05-07T14:19:10.2092258+02:00",
      "IconHint": "non"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 494,
      "DocumentId": 317,
      "Date": "2002-11-25T14:19:10.2092258+01:00",
      "Description": "Secured explicit encoding",
      "Completed": "Completed",
      "Registered": "2000-09-23T14:19:10.2092258+02:00"
    },
    {
      "AppointmentId": 494,
      "DocumentId": 317,
      "Date": "2002-11-25T14:19:10.2092258+01:00",
      "Description": "Secured explicit encoding",
      "Completed": "Completed",
      "Registered": "2000-09-23T14:19:10.2092258+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 862,
      "DocumentId": 886,
      "Date": "2013-10-08T14:19:10.2092258+02:00",
      "Description": "Enhanced directional ability",
      "Completed": "Completed",
      "Registered": "2017-06-01T14:19:10.2092258+02:00"
    },
    {
      "AppointmentId": 862,
      "DocumentId": 886,
      "Date": "2013-10-08T14:19:10.2092258+02:00",
      "Description": "Enhanced directional ability",
      "Completed": "Completed",
      "Registered": "2017-06-01T14:19:10.2092258+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 410,
      "SaleDate": "1996-06-20T14:19:10.2092258+02:00",
      "Probability": 698,
      "Heading": "veniam",
      "Amount": 14187.618,
      "Currency": "vitae",
      "AmountInBaseCurrency": 2193.7999999999997,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2018-08-05T14:19:10.2092258+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 304,
      "Name": "Bayer Inc and Sons",
      "CompanyName": "Douglas, Stehr and Leffler",
      "FirstMessage": "voluptas",
      "LastMessage": "est",
      "WhenRequested": "2003-05-03T14:19:10.2092258+02:00",
      "WhenEnded": "2013-10-05T14:19:10.2092258+02:00"
    }
  ]
}
```