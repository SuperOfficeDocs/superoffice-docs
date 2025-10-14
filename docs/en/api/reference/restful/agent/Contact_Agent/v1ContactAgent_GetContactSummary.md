---
title: POST Agents/Contact/GetContactSummary
uid: v1ContactAgent_GetContactSummary
generated: true
content_type: reference
---

# POST Agents/Contact/GetContactSummary

```http
POST /api/v1/Agents/Contact/GetContactSummary
```

Get summary of contact and its recent activity.


NsApiSlow threshold: 2000 ms.






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
  "ContactId": 118,
  "Limit": 978
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
      "TicketId": 380,
      "TicketStatus": 624,
      "Title": "sit",
      "Registered": "2022-06-19T03:40:46.483746+02:00",
      "IconHint": "dolor"
    },
    {
      "TicketId": 380,
      "TicketStatus": 624,
      "Title": "sit",
      "Registered": "2022-06-19T03:40:46.483746+02:00",
      "IconHint": "dolor"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 920,
      "DocumentId": 544,
      "Date": "2020-10-14T03:40:46.483746+02:00",
      "Description": "Horizontal next generation time-frame",
      "Completed": "Completed",
      "Registered": "1998-09-12T03:40:46.483746+02:00"
    },
    {
      "AppointmentId": 920,
      "DocumentId": 544,
      "Date": "2020-10-14T03:40:46.483746+02:00",
      "Description": "Horizontal next generation time-frame",
      "Completed": "Completed",
      "Registered": "1998-09-12T03:40:46.483746+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 268,
      "DocumentId": 541,
      "Date": "2001-05-15T03:40:46.483746+02:00",
      "Description": "Implemented value-added throughput",
      "Completed": "Completed",
      "Registered": "2011-08-16T03:40:46.483746+02:00"
    },
    {
      "AppointmentId": 268,
      "DocumentId": 541,
      "Date": "2001-05-15T03:40:46.483746+02:00",
      "Description": "Implemented value-added throughput",
      "Completed": "Completed",
      "Registered": "2011-08-16T03:40:46.483746+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 79,
      "SaleDate": "2003-11-26T03:40:46.483746+01:00",
      "Probability": 904,
      "Heading": "aut",
      "Amount": 28986.365999999998,
      "Currency": "commodi",
      "AmountInBaseCurrency": 12322.887999999999,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2002-11-27T03:40:46.483746+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 75,
      "Name": "Kunze LLC",
      "CompanyName": "Casper, Ankunding and Stehr",
      "FirstMessage": "hic",
      "LastMessage": "blanditiis",
      "WhenRequested": "2010-02-20T03:40:46.483746+01:00",
      "WhenEnded": "1999-02-05T03:40:46.483746+01:00"
    }
  ]
}
```