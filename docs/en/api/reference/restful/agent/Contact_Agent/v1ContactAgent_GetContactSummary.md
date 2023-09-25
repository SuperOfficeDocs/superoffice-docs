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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 438,
  "Limit": 74
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
      "TicketId": 788,
      "TicketStatus": 841,
      "Title": "velit",
      "Registered": "2004-12-10T03:24:47.4551836+01:00",
      "IconHint": "sint"
    },
    {
      "TicketId": 788,
      "TicketStatus": 841,
      "Title": "velit",
      "Registered": "2004-12-10T03:24:47.4551836+01:00",
      "IconHint": "sint"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 418,
      "DocumentId": 423,
      "Date": "1996-10-09T03:24:47.4551836+02:00",
      "Description": "Re-contextualized client-driven structure",
      "Completed": "Completed",
      "Registered": "2021-02-08T03:24:47.4551836+01:00"
    },
    {
      "AppointmentId": 418,
      "DocumentId": 423,
      "Date": "1996-10-09T03:24:47.4551836+02:00",
      "Description": "Re-contextualized client-driven structure",
      "Completed": "Completed",
      "Registered": "2021-02-08T03:24:47.4551836+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 759,
      "DocumentId": 855,
      "Date": "2001-07-14T03:24:47.4551836+02:00",
      "Description": "Polarised hybrid circuit",
      "Completed": "Completed",
      "Registered": "2016-12-05T03:24:47.4551836+01:00"
    },
    {
      "AppointmentId": 759,
      "DocumentId": 855,
      "Date": "2001-07-14T03:24:47.4551836+02:00",
      "Description": "Polarised hybrid circuit",
      "Completed": "Completed",
      "Registered": "2016-12-05T03:24:47.4551836+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 757,
      "SaleDate": "1999-04-03T03:24:47.4551836+02:00",
      "Probability": 254,
      "Heading": "ratione",
      "Amount": 12134.848,
      "Currency": "sunt",
      "AmountInBaseCurrency": 18233.612,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2002-07-19T03:24:47.4551836+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 897,
      "Name": "Jewess-Gleichner",
      "CompanyName": "Crona, Kulas and Grant",
      "FirstMessage": "dolor",
      "LastMessage": "mollitia",
      "WhenRequested": "2016-05-21T03:24:47.4551836+02:00",
      "WhenEnded": "2020-09-10T03:24:47.4551836+02:00"
    }
  ]
}
```