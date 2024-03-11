---
title: POST Agents/Person/GetPersonSummary
uid: v1PersonAgent_GetPersonSummary
generated: true
---

# POST Agents/Person/GetPersonSummary

```http
POST /api/v1/Agents/Person/GetPersonSummary
```

Get summary of person and recent activity.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetPersonSummary?$select=name,department,category/id
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

PersonId, Limit 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | Integer |  |
| Limit | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PersonSummary

| Property Name | Type |  Description |
|----------------|------|--------------|
| Person | Person | Simple Person data. |
| Tickets | array | Recent tickets on person |
| Followups | array | Recent follow-ups on person |
| Documents | array | Recent documents on person |
| Sales | array | Recent sales on person |
| Chats | array | Recent chats with person |

## Sample request

```http!
POST /api/v1/Agents/Person/GetPersonSummary
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 995,
  "Limit": 331
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Person": null,
  "Tickets": [
    {
      "TicketId": 208,
      "TicketStatus": 787,
      "Title": "quidem",
      "Registered": "2015-03-25T14:23:47.0661361+01:00",
      "IconHint": "perspiciatis"
    },
    {
      "TicketId": 208,
      "TicketStatus": 787,
      "Title": "quidem",
      "Registered": "2015-03-25T14:23:47.0661361+01:00",
      "IconHint": "perspiciatis"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 51,
      "DocumentId": 681,
      "Date": "2008-05-17T14:23:47.0661361+02:00",
      "Description": "Synchronised uniform secured line",
      "Completed": "Completed",
      "Registered": "2012-03-18T14:23:47.0661361+01:00"
    },
    {
      "AppointmentId": 51,
      "DocumentId": 681,
      "Date": "2008-05-17T14:23:47.0661361+02:00",
      "Description": "Synchronised uniform secured line",
      "Completed": "Completed",
      "Registered": "2012-03-18T14:23:47.0661361+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 574,
      "DocumentId": 979,
      "Date": "2014-07-08T14:23:47.0661361+02:00",
      "Description": "Pre-emptive upward-trending productivity",
      "Completed": "Completed",
      "Registered": "2012-10-21T14:23:47.0661361+02:00"
    },
    {
      "AppointmentId": 574,
      "DocumentId": 979,
      "Date": "2014-07-08T14:23:47.0661361+02:00",
      "Description": "Pre-emptive upward-trending productivity",
      "Completed": "Completed",
      "Registered": "2012-10-21T14:23:47.0661361+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 202,
      "SaleDate": "2001-06-09T14:23:47.0661361+02:00",
      "Probability": 834,
      "Heading": "doloremque",
      "Amount": 24952.908,
      "Currency": "voluptates",
      "AmountInBaseCurrency": 15879.978,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2003-04-25T14:23:47.0661361+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 827,
      "Name": "Robel, Heaney and Gaylord",
      "CompanyName": "Leffler Group",
      "FirstMessage": "et",
      "LastMessage": "sit",
      "WhenRequested": "2018-02-28T14:23:47.0661361+01:00",
      "WhenEnded": "2007-02-18T14:23:47.0661361+01:00"
    }
  ]
}
```