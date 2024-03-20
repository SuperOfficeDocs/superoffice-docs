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
  "PersonId": 672,
  "Limit": 204
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
      "TicketId": 334,
      "TicketStatus": 671,
      "Title": "facilis",
      "Registered": "2001-05-02T12:19:45.742156+02:00",
      "IconHint": "quam"
    },
    {
      "TicketId": 334,
      "TicketStatus": 671,
      "Title": "facilis",
      "Registered": "2001-05-02T12:19:45.742156+02:00",
      "IconHint": "quam"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 472,
      "DocumentId": 464,
      "Date": "1999-01-08T12:19:45.742156+01:00",
      "Description": "User-centric tertiary hardware",
      "Completed": "Completed",
      "Registered": "2009-04-02T12:19:45.742156+02:00"
    },
    {
      "AppointmentId": 472,
      "DocumentId": 464,
      "Date": "1999-01-08T12:19:45.742156+01:00",
      "Description": "User-centric tertiary hardware",
      "Completed": "Completed",
      "Registered": "2009-04-02T12:19:45.742156+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 410,
      "DocumentId": 85,
      "Date": "2011-06-21T12:19:45.742156+02:00",
      "Description": "Inverse value-added contingency",
      "Completed": "Completed",
      "Registered": "1998-09-19T12:19:45.742156+02:00"
    },
    {
      "AppointmentId": 410,
      "DocumentId": 85,
      "Date": "2011-06-21T12:19:45.742156+02:00",
      "Description": "Inverse value-added contingency",
      "Completed": "Completed",
      "Registered": "1998-09-19T12:19:45.742156+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 387,
      "SaleDate": "2019-07-07T12:19:45.742156+02:00",
      "Probability": 680,
      "Heading": "minus",
      "Amount": 18838.474,
      "Currency": "in",
      "AmountInBaseCurrency": 17349.824,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2007-05-12T12:19:45.742156+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 462,
      "Name": "Nader Inc and Sons",
      "CompanyName": "Kunze Inc and Sons",
      "FirstMessage": "deleniti",
      "LastMessage": "expedita",
      "WhenRequested": "2001-01-06T12:19:45.742156+01:00",
      "WhenEnded": "2016-04-16T12:19:45.742156+02:00"
    }
  ]
}
```