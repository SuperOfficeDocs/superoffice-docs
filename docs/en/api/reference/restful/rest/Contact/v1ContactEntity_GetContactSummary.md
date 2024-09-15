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
GET /api/v1/Contact/{contactId}/Summary?limit=993
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
      "TicketId": 176,
      "TicketStatus": 520,
      "Title": "omnis",
      "Registered": "2017-11-10T04:02:06.4316632+01:00",
      "IconHint": "molestiae"
    },
    {
      "TicketId": 176,
      "TicketStatus": 520,
      "Title": "omnis",
      "Registered": "2017-11-10T04:02:06.4316632+01:00",
      "IconHint": "molestiae"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 641,
      "DocumentId": 560,
      "Date": "2002-11-08T04:02:06.4316632+01:00",
      "Description": "Progressive asynchronous installation",
      "Completed": "Completed",
      "Registered": "1997-08-20T04:02:06.4316632+02:00"
    },
    {
      "AppointmentId": 641,
      "DocumentId": 560,
      "Date": "2002-11-08T04:02:06.4316632+01:00",
      "Description": "Progressive asynchronous installation",
      "Completed": "Completed",
      "Registered": "1997-08-20T04:02:06.4316632+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 69,
      "DocumentId": 464,
      "Date": "1998-12-02T04:02:06.4316632+01:00",
      "Description": "Reactive attitude-oriented installation",
      "Completed": "Completed",
      "Registered": "2002-06-30T04:02:06.4316632+02:00"
    },
    {
      "AppointmentId": 69,
      "DocumentId": 464,
      "Date": "1998-12-02T04:02:06.4316632+01:00",
      "Description": "Reactive attitude-oriented installation",
      "Completed": "Completed",
      "Registered": "2002-06-30T04:02:06.4316632+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 584,
      "SaleDate": "2015-06-07T04:02:06.4316632+02:00",
      "Probability": 984,
      "Heading": "sit",
      "Amount": 10476.962,
      "Currency": "cumque",
      "AmountInBaseCurrency": 22715.232,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2019-05-05T04:02:06.4316632+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 433,
      "Name": "Bailey LLC",
      "CompanyName": "Hahn Group",
      "FirstMessage": "et",
      "LastMessage": "voluptatum",
      "WhenRequested": "2003-06-10T04:02:06.4316632+02:00",
      "WhenEnded": "2005-08-18T04:02:06.4316632+02:00"
    }
  ]
}
```