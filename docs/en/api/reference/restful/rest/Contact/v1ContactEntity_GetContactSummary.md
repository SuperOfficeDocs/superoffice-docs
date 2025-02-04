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
GET /api/v1/Contact/{contactId}/Summary?limit=467
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
      "TicketId": 977,
      "TicketStatus": 260,
      "Title": "et",
      "Registered": "2014-05-16T13:13:31.5738909+02:00",
      "IconHint": "iure"
    },
    {
      "TicketId": 977,
      "TicketStatus": 260,
      "Title": "et",
      "Registered": "2014-05-16T13:13:31.5738909+02:00",
      "IconHint": "iure"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 454,
      "DocumentId": 223,
      "Date": "2021-02-22T13:13:31.5738909+01:00",
      "Description": "Decentralized radical info-mediaries",
      "Completed": "Completed",
      "Registered": "2020-03-23T13:13:31.5738909+01:00"
    },
    {
      "AppointmentId": 454,
      "DocumentId": 223,
      "Date": "2021-02-22T13:13:31.5738909+01:00",
      "Description": "Decentralized radical info-mediaries",
      "Completed": "Completed",
      "Registered": "2020-03-23T13:13:31.5738909+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 854,
      "DocumentId": 941,
      "Date": "2012-03-26T13:13:31.5738909+02:00",
      "Description": "Down-sized zero defect benchmark",
      "Completed": "Completed",
      "Registered": "2000-04-26T13:13:31.5738909+02:00"
    },
    {
      "AppointmentId": 854,
      "DocumentId": 941,
      "Date": "2012-03-26T13:13:31.5738909+02:00",
      "Description": "Down-sized zero defect benchmark",
      "Completed": "Completed",
      "Registered": "2000-04-26T13:13:31.5738909+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 71,
      "SaleDate": "2009-09-06T13:13:31.5738909+02:00",
      "Probability": 599,
      "Heading": "beatae",
      "Amount": 22718.365999999998,
      "Currency": "inventore",
      "AmountInBaseCurrency": 6600.204,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2019-09-17T13:13:31.5738909+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 736,
      "Name": "Kuhlman, Runte and O'Keefe",
      "CompanyName": "Bayer, Huel and Abbott",
      "FirstMessage": "amet",
      "LastMessage": "minus",
      "WhenRequested": "2021-12-01T13:13:31.5738909+01:00",
      "WhenEnded": "1998-11-29T13:13:31.5738909+01:00"
    }
  ]
}
```