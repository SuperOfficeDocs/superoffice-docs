---
title: GET List/TicketPriority/Items/{id}
uid: v1TicketPriorityList_GetTicketPriorityEntity
generated: true
---

# GET List/TicketPriority/Items/{id}

```http
GET /api/v1/List/TicketPriority/Items/{id}
```

Gets a TicketPriorityEntity list item.


Calls the List agent service GetTicketPriorityEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the TicketPriority to return. **Required** |



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
| 404 | Not Found. |

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
GET /api/v1/List/TicketPriority/Items/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 522,
  "Name": "Cronin-Collins",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 280,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 646,
  "MonStart": "2006-10-08T11:44:43.398025+02:00",
  "MonStop": "2006-08-03T11:44:43.398025+02:00",
  "TueStart": "1998-04-23T11:44:43.398025+02:00",
  "TueStop": "2001-07-21T11:44:43.398025+02:00",
  "WedStart": "1999-06-10T11:44:43.398025+02:00",
  "WedStop": "2008-12-22T11:44:43.398025+01:00",
  "ThuStart": "2006-10-04T11:44:43.398025+02:00",
  "ThuStop": "2016-12-22T11:44:43.398025+01:00",
  "FriStart": "2018-08-06T11:44:43.398025+02:00",
  "FriStop": "2022-04-15T11:44:43.398025+02:00",
  "SatStart": "1997-07-16T11:44:43.398025+02:00",
  "SatStop": "2015-09-26T11:44:43.398025+02:00",
  "SunStart": "2003-11-01T11:44:43.398025+01:00",
  "SunStop": "2006-12-14T11:44:43.398025+01:00",
  "NonDates": [
    "ut",
    "aperiam"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 989,
      "AlertLevel": 791,
      "AlertTimeout": 648,
      "Action": 155,
      "DelegateTo": 640,
      "ScriptId": 620,
      "EmailTo": "jimmie@torphyohara.biz",
      "SmsTo": "commodi",
      "ReplyTemplateIdCustomer": 134,
      "ReplyTemplateIdUser": 214,
      "ReplyTemplateIdCatmast": 515,
      "ReplyTemplateIdEmail": 308,
      "RtiCustomerSms": 480,
      "ReplyTemplateIdUserSms": 435,
      "ReplyTemplateIdCatmastSms": 886,
      "ReplyTemplateIdSms": 582,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 808
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 107
    }
  }
}
```