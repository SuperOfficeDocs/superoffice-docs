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
GET /api/v1/Contact/{contactId}/Summary?limit=762
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
      "TicketId": 628,
      "TicketStatus": 88,
      "Title": "ut",
      "Registered": "2008-04-07T12:57:42.2920417+02:00",
      "IconHint": "optio"
    },
    {
      "TicketId": 628,
      "TicketStatus": 88,
      "Title": "ut",
      "Registered": "2008-04-07T12:57:42.2920417+02:00",
      "IconHint": "optio"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 861,
      "DocumentId": 579,
      "Date": "2005-02-15T12:57:42.2920417+01:00",
      "Description": "Synergized high-level encoding",
      "Completed": "Completed",
      "Registered": "2002-08-10T12:57:42.2920417+02:00"
    },
    {
      "AppointmentId": 861,
      "DocumentId": 579,
      "Date": "2005-02-15T12:57:42.2920417+01:00",
      "Description": "Synergized high-level encoding",
      "Completed": "Completed",
      "Registered": "2002-08-10T12:57:42.2920417+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 18,
      "DocumentId": 646,
      "Date": "2012-05-21T12:57:42.2920417+02:00",
      "Description": "Robust multimedia knowledge base",
      "Completed": "Completed",
      "Registered": "2010-04-18T12:57:42.2920417+02:00"
    },
    {
      "AppointmentId": 18,
      "DocumentId": 646,
      "Date": "2012-05-21T12:57:42.2920417+02:00",
      "Description": "Robust multimedia knowledge base",
      "Completed": "Completed",
      "Registered": "2010-04-18T12:57:42.2920417+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 280,
      "SaleDate": "2008-09-11T12:57:42.2920417+02:00",
      "Probability": 292,
      "Heading": "voluptatem",
      "Amount": 25222.432,
      "Currency": "veritatis",
      "AmountInBaseCurrency": 3005.506,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2010-01-07T12:57:42.2920417+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 814,
      "Name": "Hayes, Jaskolski and Ankunding",
      "CompanyName": "Johnston Group",
      "FirstMessage": "consequatur",
      "LastMessage": "sit",
      "WhenRequested": "1999-02-06T12:57:42.2920417+01:00",
      "WhenEnded": "1999-10-16T12:57:42.2920417+02:00"
    }
  ]
}
```