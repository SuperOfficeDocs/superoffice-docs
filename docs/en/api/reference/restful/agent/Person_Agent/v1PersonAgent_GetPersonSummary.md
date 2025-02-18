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
  "PersonId": 53,
  "Limit": 251
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
      "TicketId": 199,
      "TicketStatus": 303,
      "Title": "reprehenderit",
      "Registered": "2003-09-11T14:32:03.389864+02:00",
      "IconHint": "cupiditate"
    },
    {
      "TicketId": 199,
      "TicketStatus": 303,
      "Title": "reprehenderit",
      "Registered": "2003-09-11T14:32:03.389864+02:00",
      "IconHint": "cupiditate"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 882,
      "DocumentId": 306,
      "Date": "2012-12-08T14:32:03.389864+01:00",
      "Description": "Visionary mission-critical standardization",
      "Completed": "Completed",
      "Registered": "2017-09-10T14:32:03.389864+02:00"
    },
    {
      "AppointmentId": 882,
      "DocumentId": 306,
      "Date": "2012-12-08T14:32:03.389864+01:00",
      "Description": "Visionary mission-critical standardization",
      "Completed": "Completed",
      "Registered": "2017-09-10T14:32:03.389864+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 203,
      "DocumentId": 888,
      "Date": "2001-07-24T14:32:03.389864+02:00",
      "Description": "Switchable optimizing moratorium",
      "Completed": "Completed",
      "Registered": "2019-08-28T14:32:03.389864+02:00"
    },
    {
      "AppointmentId": 203,
      "DocumentId": 888,
      "Date": "2001-07-24T14:32:03.389864+02:00",
      "Description": "Switchable optimizing moratorium",
      "Completed": "Completed",
      "Registered": "2019-08-28T14:32:03.389864+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 859,
      "SaleDate": "2024-04-03T14:32:03.389864+02:00",
      "Probability": 602,
      "Heading": "aut",
      "Amount": 2124.852,
      "Currency": "iure",
      "AmountInBaseCurrency": 23454.856,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2008-09-30T14:32:03.389864+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 804,
      "Name": "Schulist Inc and Sons",
      "CompanyName": "Gusikowski-Stark",
      "FirstMessage": "sit",
      "LastMessage": "et",
      "WhenRequested": "2000-05-07T14:32:03.389864+02:00",
      "WhenEnded": "2013-05-17T14:32:03.389864+02:00"
    }
  ]
}
```