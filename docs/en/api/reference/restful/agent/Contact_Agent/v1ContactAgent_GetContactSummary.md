---
title: POST Agents/Contact/GetContactSummary
uid: v1ContactAgent_GetContactSummary
generated: true
---

# POST Agents/Contact/GetContactSummary

```http
POST /api/v1/Agents/Contact/GetContactSummary
```

Get summary of contact and its recent activity.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactSummary?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

ContactId, Limit 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |
| Limit | Integer |  |

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
POST /api/v1/Agents/Contact/GetContactSummary
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 645,
  "Limit": 624
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Contact": null,
  "Tickets": [
    {
      "TicketId": 875,
      "TicketStatus": 9,
      "Title": "quam",
      "Registered": "2018-04-01T13:57:11.9811236+02:00",
      "IconHint": "accusamus"
    },
    {
      "TicketId": 875,
      "TicketStatus": 9,
      "Title": "quam",
      "Registered": "2018-04-01T13:57:11.9811236+02:00",
      "IconHint": "accusamus"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 537,
      "DocumentId": 121,
      "Date": "2020-10-18T13:57:11.9811236+02:00",
      "Description": "Profound user-facing migration",
      "Completed": "Completed",
      "Registered": "2019-09-29T13:57:11.9811236+02:00"
    },
    {
      "AppointmentId": 537,
      "DocumentId": 121,
      "Date": "2020-10-18T13:57:11.9811236+02:00",
      "Description": "Profound user-facing migration",
      "Completed": "Completed",
      "Registered": "2019-09-29T13:57:11.9811236+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 615,
      "DocumentId": 769,
      "Date": "2013-01-17T13:57:11.9811236+01:00",
      "Description": "Self-enabling local portal",
      "Completed": "Completed",
      "Registered": "2007-01-29T13:57:11.9811236+01:00"
    },
    {
      "AppointmentId": 615,
      "DocumentId": 769,
      "Date": "2013-01-17T13:57:11.9811236+01:00",
      "Description": "Self-enabling local portal",
      "Completed": "Completed",
      "Registered": "2007-01-29T13:57:11.9811236+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 638,
      "SaleDate": "1997-06-29T13:57:11.9811236+02:00",
      "Probability": 662,
      "Heading": "odit",
      "Amount": 21615.198,
      "Currency": "hic",
      "AmountInBaseCurrency": 7502.7959999999994,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2008-03-08T13:57:11.9811236+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 203,
      "Name": "Graham LLC",
      "CompanyName": "Cartwright, Balistreri and Kreiger",
      "FirstMessage": "nulla",
      "LastMessage": "earum",
      "WhenRequested": "1999-02-15T13:57:11.9811236+01:00",
      "WhenEnded": "2001-03-27T13:57:11.9811236+02:00"
    }
  ]
}
```