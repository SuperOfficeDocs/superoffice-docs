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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 408,
  "Limit": 799
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
      "TicketId": 71,
      "TicketStatus": 651,
      "Title": "aliquid",
      "Registered": "2022-06-24T11:24:48.3595217+02:00",
      "IconHint": "porro"
    },
    {
      "TicketId": 71,
      "TicketStatus": 651,
      "Title": "aliquid",
      "Registered": "2022-06-24T11:24:48.3595217+02:00",
      "IconHint": "porro"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 831,
      "DocumentId": 226,
      "Date": "2014-01-08T11:24:48.3595217+01:00",
      "Description": "Balanced maximized paradigm",
      "Completed": "Completed",
      "Registered": "1998-09-28T11:24:48.3595217+02:00"
    },
    {
      "AppointmentId": 831,
      "DocumentId": 226,
      "Date": "2014-01-08T11:24:48.3595217+01:00",
      "Description": "Balanced maximized paradigm",
      "Completed": "Completed",
      "Registered": "1998-09-28T11:24:48.3595217+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 54,
      "DocumentId": 445,
      "Date": "1999-09-19T11:24:48.3595217+02:00",
      "Description": "Fully-configurable analyzing parallelism",
      "Completed": "Completed",
      "Registered": "2022-11-07T11:24:48.3595217+01:00"
    },
    {
      "AppointmentId": 54,
      "DocumentId": 445,
      "Date": "1999-09-19T11:24:48.3595217+02:00",
      "Description": "Fully-configurable analyzing parallelism",
      "Completed": "Completed",
      "Registered": "2022-11-07T11:24:48.3595217+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 223,
      "SaleDate": "1998-10-20T11:24:48.3595217+02:00",
      "Probability": 77,
      "Heading": "nihil",
      "Amount": 9467.814,
      "Currency": "temporibus",
      "AmountInBaseCurrency": 6650.348,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "1998-12-02T11:24:48.3595217+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 132,
      "Name": "Hodkiewicz, Pouros and Mayer",
      "CompanyName": "Mohr-Jacobson",
      "FirstMessage": "earum",
      "LastMessage": "sed",
      "WhenRequested": "1998-06-10T11:24:48.3595217+02:00",
      "WhenEnded": "2011-04-10T11:24:48.3595217+02:00"
    }
  ]
}
```