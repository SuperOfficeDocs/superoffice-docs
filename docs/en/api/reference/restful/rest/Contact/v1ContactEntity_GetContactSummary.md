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
GET /api/v1/Contact/{contactId}/Summary?limit=222
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
      "TicketId": 350,
      "TicketStatus": 652,
      "Title": "beatae",
      "Registered": "2010-03-18T11:22:44.5382515+01:00",
      "IconHint": "eveniet"
    },
    {
      "TicketId": 350,
      "TicketStatus": 652,
      "Title": "beatae",
      "Registered": "2010-03-18T11:22:44.5382515+01:00",
      "IconHint": "eveniet"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 652,
      "DocumentId": 321,
      "Date": "2002-02-02T11:22:44.5382515+01:00",
      "Description": "Optimized systemic structure",
      "Completed": "Completed",
      "Registered": "2004-05-10T11:22:44.5382515+02:00"
    },
    {
      "AppointmentId": 652,
      "DocumentId": 321,
      "Date": "2002-02-02T11:22:44.5382515+01:00",
      "Description": "Optimized systemic structure",
      "Completed": "Completed",
      "Registered": "2004-05-10T11:22:44.5382515+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 81,
      "DocumentId": 508,
      "Date": "2017-03-22T11:22:44.5382515+01:00",
      "Description": "Horizontal systemic customer loyalty",
      "Completed": "Completed",
      "Registered": "2013-11-18T11:22:44.5382515+01:00"
    },
    {
      "AppointmentId": 81,
      "DocumentId": 508,
      "Date": "2017-03-22T11:22:44.5382515+01:00",
      "Description": "Horizontal systemic customer loyalty",
      "Completed": "Completed",
      "Registered": "2013-11-18T11:22:44.5382515+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 106,
      "SaleDate": "2010-08-04T11:22:44.5382515+02:00",
      "Probability": 150,
      "Heading": "id",
      "Amount": 24222.685999999998,
      "Currency": "sunt",
      "AmountInBaseCurrency": 29914.03,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2014-08-26T11:22:44.5382515+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 605,
      "Name": "Medhurst-Wiza",
      "CompanyName": "Eichmann, McClure and Nader",
      "FirstMessage": "laborum",
      "LastMessage": "qui",
      "WhenRequested": "2010-12-05T11:22:44.5382515+01:00",
      "WhenEnded": "2015-05-19T11:22:44.5382515+02:00"
    }
  ]
}
```