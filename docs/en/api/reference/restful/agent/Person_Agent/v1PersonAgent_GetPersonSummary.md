---
title: POST Agents/Person/GetPersonSummary
uid: v1PersonAgent_GetPersonSummary
generated: true
content_type: reference
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
  "PersonId": 289,
  "Limit": 919
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
      "TicketId": 409,
      "TicketStatus": 503,
      "Title": "id",
      "Registered": "2011-03-17T03:41:53.855719+01:00",
      "IconHint": "voluptatibus"
    },
    {
      "TicketId": 409,
      "TicketStatus": 503,
      "Title": "id",
      "Registered": "2011-03-17T03:41:53.855719+01:00",
      "IconHint": "voluptatibus"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 748,
      "DocumentId": 460,
      "Date": "2019-02-25T03:41:53.855719+01:00",
      "Description": "Cross-group national hardware",
      "Completed": "Completed",
      "Registered": "2010-12-19T03:41:53.855719+01:00"
    },
    {
      "AppointmentId": 748,
      "DocumentId": 460,
      "Date": "2019-02-25T03:41:53.855719+01:00",
      "Description": "Cross-group national hardware",
      "Completed": "Completed",
      "Registered": "2010-12-19T03:41:53.855719+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 416,
      "DocumentId": 159,
      "Date": "2019-07-31T03:41:53.855719+02:00",
      "Description": "Team-oriented dynamic frame",
      "Completed": "Completed",
      "Registered": "2015-10-28T03:41:53.855719+01:00"
    },
    {
      "AppointmentId": 416,
      "DocumentId": 159,
      "Date": "2019-07-31T03:41:53.855719+02:00",
      "Description": "Team-oriented dynamic frame",
      "Completed": "Completed",
      "Registered": "2015-10-28T03:41:53.855719+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 27,
      "SaleDate": "2025-01-04T03:41:53.855719+01:00",
      "Probability": 25,
      "Heading": "ut",
      "Amount": 14598.171999999999,
      "Currency": "voluptatum",
      "AmountInBaseCurrency": 31130.021999999997,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2008-08-17T03:41:53.855719+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 657,
      "Name": "Rath Inc and Sons",
      "CompanyName": "Bartell, Abernathy and Brekke",
      "FirstMessage": "excepturi",
      "LastMessage": "aut",
      "WhenRequested": "2017-04-24T03:41:53.855719+02:00",
      "WhenEnded": "2017-11-07T03:41:53.855719+01:00"
    }
  ]
}
```