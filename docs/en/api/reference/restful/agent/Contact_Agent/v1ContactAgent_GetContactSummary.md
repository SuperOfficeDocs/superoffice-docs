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
  "ContactId": 511,
  "Limit": 816
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
      "TicketId": 851,
      "TicketStatus": 749,
      "Title": "eum",
      "Registered": "2010-07-07T23:03:55.5506364+02:00",
      "IconHint": "mollitia"
    },
    {
      "TicketId": 851,
      "TicketStatus": 749,
      "Title": "eum",
      "Registered": "2010-07-07T23:03:55.5506364+02:00",
      "IconHint": "mollitia"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 729,
      "DocumentId": 113,
      "Date": "2011-12-23T23:03:55.5506364+01:00",
      "Description": "Mandatory optimizing alliance",
      "Completed": "Completed",
      "Registered": "2015-12-15T23:03:55.5506364+01:00"
    },
    {
      "AppointmentId": 729,
      "DocumentId": 113,
      "Date": "2011-12-23T23:03:55.5506364+01:00",
      "Description": "Mandatory optimizing alliance",
      "Completed": "Completed",
      "Registered": "2015-12-15T23:03:55.5506364+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 613,
      "DocumentId": 762,
      "Date": "2018-04-20T23:03:55.5506364+02:00",
      "Description": "Versatile discrete policy",
      "Completed": "Completed",
      "Registered": "2003-08-04T23:03:55.5506364+02:00"
    },
    {
      "AppointmentId": 613,
      "DocumentId": 762,
      "Date": "2018-04-20T23:03:55.5506364+02:00",
      "Description": "Versatile discrete policy",
      "Completed": "Completed",
      "Registered": "2003-08-04T23:03:55.5506364+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 501,
      "SaleDate": "2013-01-09T23:03:55.5506364+01:00",
      "Probability": 559,
      "Heading": "nemo",
      "Amount": 3325.174,
      "Currency": "ea",
      "AmountInBaseCurrency": 24667.714,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2017-08-14T23:03:55.5506364+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 487,
      "Name": "Kuvalis Inc and Sons",
      "CompanyName": "Heathcote-Sanford",
      "FirstMessage": "autem",
      "LastMessage": "qui",
      "WhenRequested": "1999-07-28T23:03:55.5506364+02:00",
      "WhenEnded": "2022-12-08T23:03:55.5506364+01:00"
    }
  ]
}
```