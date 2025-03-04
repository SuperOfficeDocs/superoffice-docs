---
title: POST Agents/List/GetTicketPriorityEntity
uid: v1ListAgent_GetTicketPriorityEntity
generated: true
---

# POST Agents/List/GetTicketPriorityEntity

```http
POST /api/v1/Agents/List/GetTicketPriorityEntity
```

Gets a TicketPriorityEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| ticketPriorityEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/GetTicketPriorityEntity?ticketPriorityEntityId=34
POST /api/v1/Agents/List/GetTicketPriorityEntity?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: TicketPriorityEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketPriorityId | int32 | The primary key (auto-incremented) |
| Name | string | The name of the priority. |
| Status | string | The status (normal/deleted) of the priority. |
| Flags | string | A bitmask of flags. |
| SortOrder | int32 | Indicates the sort order for this priority. 1 is first, 100 is last |
| TicketRead | string | This field indicates what to do with the escalation chain when the request is read |
| ChangedOwner | string | This field indicates what to do with the escalation chain when the request changes owner (manually) |
| TicketNewinfo | string | This field indicates what to do with the escalation chain when the request gets new info |
| TicketClosed | string | This field indicates what to do with the escalation chain when the request is closed |
| TicketChangedPriority | string | This field indicates what to do with the escalation chain when the request is changed into this priority |
| TicketNew | string | This field indicates what to do with the escalation chain when a new request is registered |
| Deadline | int32 | Deadline to add if escalated (minutes) |
| MonStart | date-time | The work hour start for Mondays. Note that only the time part of the DateTime is used |
| MonStop | date-time | The work hour start for Mondays. Note that only the time part of the DateTime is used |
| TueStart | date-time | The work hour start for Tuesdays. Note that only the time part of the DateTime is used |
| TueStop | date-time | The work hour stop for Tuesdays. Note that only the time part of the DateTime is used |
| WedStart | date-time | The work hour start for Wednesdays. Note that only the time part of the DateTime is used |
| WedStop | date-time | The work hour stop for Wednesdays. Note that only the time part of the DateTime is used |
| ThuStart | date-time | The work hour start for Thursdays. Note that only the time part of the DateTime is used |
| ThuStop | date-time | The work hour stop for Thursdays. Note that only the time part of the DateTime is used |
| FriStart | date-time | The work hour start for Fridays. Note that only the time part of the DateTime is used |
| FriStop | date-time | The work hour stop for Fridays. Note that only the time part of the DateTime is used |
| SatStart | date-time | The work hour start for Saturdays. Note that only the time part of the DateTime is used |
| SatStop | date-time | The work hour stop for Saturdays. Note that only the time part of the DateTime is used |
| SunStart | date-time | The work hour start for Sundays. Note that only the time part of the DateTime is used |
| SunStop | date-time | The work hour stop for Sundays. Note that only the time part of the DateTime is used |
| NonDates | array | Dates which the escalation time should not be running. Note that only the day of the year (day and month) is used. So the year and time part is not used even if this is a DateTime. Exception - it IS possible to include a year here, for dates that should not repeat every year |
| EscalationLevels | array | Escalation levels bound to the parent priority |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/List/GetTicketPriorityEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 279,
  "Name": "Schuppe, Gutmann and McGlynn",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 837,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 823,
  "MonStart": "2017-05-02T14:13:40.422226+02:00",
  "MonStop": "2019-04-07T14:13:40.422226+02:00",
  "TueStart": "2002-11-12T14:13:40.422226+01:00",
  "TueStop": "1998-07-18T14:13:40.422226+02:00",
  "WedStart": "2021-10-25T14:13:40.422226+02:00",
  "WedStop": "2002-10-09T14:13:40.422226+02:00",
  "ThuStart": "2018-06-17T14:13:40.422226+02:00",
  "ThuStop": "2018-09-03T14:13:40.422226+02:00",
  "FriStart": "2017-04-24T14:13:40.422226+02:00",
  "FriStop": "2016-07-29T14:13:40.422226+02:00",
  "SatStart": "2013-10-08T14:13:40.422226+02:00",
  "SatStop": "2018-01-24T14:13:40.422226+01:00",
  "SunStart": "2009-08-05T14:13:40.422226+02:00",
  "SunStop": "2009-06-01T14:13:40.422226+02:00",
  "NonDates": [
    "ipsum",
    "sit"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 867,
      "AlertLevel": 109,
      "AlertTimeout": 631,
      "Action": 222,
      "DelegateTo": 54,
      "ScriptId": 709,
      "EmailTo": "danika_hagenes@kulas.co.uk",
      "SmsTo": "consequatur",
      "ReplyTemplateIdCustomer": 770,
      "ReplyTemplateIdUser": 291,
      "ReplyTemplateIdCatmast": 171,
      "ReplyTemplateIdEmail": 557,
      "RtiCustomerSms": 84,
      "ReplyTemplateIdUserSms": 793,
      "ReplyTemplateIdCatmastSms": 447,
      "ReplyTemplateIdSms": 750,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 708
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 205
    }
  }
}
```