---
title: POST Agents/Person/GetPersonSummary
uid: v1PersonAgent_GetPersonSummary
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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "PersonId": 521,
  "Limit": 203
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
      "TicketId": 854,
      "TicketStatus": 402,
      "Title": "aspernatur",
      "Registered": "2006-07-06T17:37:18.5262422+02:00",
      "IconHint": "natus"
    },
    {
      "TicketId": 854,
      "TicketStatus": 402,
      "Title": "aspernatur",
      "Registered": "2006-07-06T17:37:18.5262422+02:00",
      "IconHint": "natus"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 289,
      "DocumentId": 926,
      "Date": "2009-07-14T17:37:18.5262422+02:00",
      "Description": "Ergonomic foreground service-desk",
      "Completed": "Completed",
      "Registered": "2001-01-29T17:37:18.5262422+01:00"
    },
    {
      "AppointmentId": 289,
      "DocumentId": 926,
      "Date": "2009-07-14T17:37:18.5262422+02:00",
      "Description": "Ergonomic foreground service-desk",
      "Completed": "Completed",
      "Registered": "2001-01-29T17:37:18.5262422+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 471,
      "DocumentId": 470,
      "Date": "2019-12-04T17:37:18.5262422+01:00",
      "Description": "Virtual bandwidth-monitored functionalities",
      "Completed": "Completed",
      "Registered": "2017-09-16T17:37:18.5262422+02:00"
    },
    {
      "AppointmentId": 471,
      "DocumentId": 470,
      "Date": "2019-12-04T17:37:18.5262422+01:00",
      "Description": "Virtual bandwidth-monitored functionalities",
      "Completed": "Completed",
      "Registered": "2017-09-16T17:37:18.5262422+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 821,
      "SaleDate": "1998-11-02T17:37:18.5262422+01:00",
      "Probability": 941,
      "Heading": "omnis",
      "Amount": 8656.108,
      "Currency": "optio",
      "AmountInBaseCurrency": 17039.558,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2009-01-13T17:37:18.5262422+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 813,
      "Name": "Kutch Group",
      "CompanyName": "Hansen, Block and Hauck",
      "FirstMessage": "accusamus",
      "LastMessage": "aut",
      "WhenRequested": "2019-01-28T17:37:18.5262422+01:00",
      "WhenEnded": "1998-05-09T17:37:18.5262422+02:00"
    }
  ]
}
```