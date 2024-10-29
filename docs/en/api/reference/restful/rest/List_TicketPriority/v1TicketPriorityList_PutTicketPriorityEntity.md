---
title: PUT List/TicketPriority/Items/{id}
uid: v1TicketPriorityList_PutTicketPriorityEntity
generated: true
---

# PUT List/TicketPriority/Items/{id}

```http
PUT /api/v1/List/TicketPriority/Items/{id}
```

Updates the existing TicketPriorityEntity


Calls the List agent service SaveTicketPriorityEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of TicketPriorityEntity to be saved. **Required** |



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

## Request Body: entity 

The details of TicketPriorityEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketPriorityId | Integer | The primary key (auto-incremented) |
| Name | String | The name of the priority. |
| Status | String | The status (normal/deleted) of the priority. |
| Flags | String | A bitmask of flags. |
| SortOrder | Integer | Indicates the sort order for this priority. 1 is first, 100 is last |
| TicketRead | String | This field indicates what to do with the escalation chain when the request is read |
| ChangedOwner | String | This field indicates what to do with the escalation chain when the request changes owner (manually) |
| TicketNewinfo | String | This field indicates what to do with the escalation chain when the request gets new info |
| TicketClosed | String | This field indicates what to do with the escalation chain when the request is closed |
| TicketChangedPriority | String | This field indicates what to do with the escalation chain when the request is changed into this priority |
| TicketNew | String | This field indicates what to do with the escalation chain when a new request is registered |
| Deadline | Integer | Deadline to add if escalated (minutes) |
| MonStart | String | The work hour start for Mondays. Note that only the time part of the DateTime is used |
| MonStop | String | The work hour start for Mondays. Note that only the time part of the DateTime is used |
| TueStart | String | The work hour start for Tuesdays. Note that only the time part of the DateTime is used |
| TueStop | String | The work hour stop for Tuesdays. Note that only the time part of the DateTime is used |
| WedStart | String | The work hour start for Wednesdays. Note that only the time part of the DateTime is used |
| WedStop | String | The work hour stop for Wednesdays. Note that only the time part of the DateTime is used |
| ThuStart | String | The work hour start for Thursdays. Note that only the time part of the DateTime is used |
| ThuStop | String | The work hour stop for Thursdays. Note that only the time part of the DateTime is used |
| FriStart | String | The work hour start for Fridays. Note that only the time part of the DateTime is used |
| FriStop | String | The work hour stop for Fridays. Note that only the time part of the DateTime is used |
| SatStart | String | The work hour start for Saturdays. Note that only the time part of the DateTime is used |
| SatStop | String | The work hour stop for Saturdays. Note that only the time part of the DateTime is used |
| SunStart | String | The work hour start for Sundays. Note that only the time part of the DateTime is used |
| SunStop | String | The work hour stop for Sundays. Note that only the time part of the DateTime is used |
| NonDates | Array | Dates which the escalation time should not be running. Note that only the day of the year (day and month) is used. So the year and time part is not used even if this is a DateTime. Exception - it IS possible to include a year here, for dates that should not repeat every year |
| EscalationLevels | Array | Escalation levels bound to the parent priority |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |
| 400 | Bad request. Entity to save is not in request body. |

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
PUT /api/v1/List/TicketPriority/Items/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 988,
  "Name": "Kuhlman-Johns",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 472,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 475,
  "MonStart": "2020-06-12T13:14:11.5704589+02:00",
  "MonStop": "2008-05-09T13:14:11.5704589+02:00",
  "TueStart": "2002-12-14T13:14:11.5704589+01:00",
  "TueStop": "2023-12-31T13:14:11.5704589+01:00",
  "WedStart": "2015-02-19T13:14:11.5704589+01:00",
  "WedStop": "2010-03-26T13:14:11.5704589+01:00",
  "ThuStart": "2002-12-17T13:14:11.5704589+01:00",
  "ThuStop": "2022-01-18T13:14:11.5704589+01:00",
  "FriStart": "2007-01-14T13:14:11.5704589+01:00",
  "FriStop": "2013-08-21T13:14:11.5704589+02:00",
  "SatStart": "2014-06-14T13:14:11.5704589+02:00",
  "SatStop": "2016-02-01T13:14:11.5704589+01:00",
  "SunStart": "2023-08-27T13:14:11.5704589+02:00",
  "SunStop": "2018-05-18T13:14:11.5704589+02:00",
  "NonDates": [
    "minus",
    "nam"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 616,
      "AlertLevel": 537,
      "AlertTimeout": 30,
      "Action": 388,
      "DelegateTo": 594,
      "ScriptId": 613,
      "EmailTo": "tyrese_murazik@heller.uk",
      "SmsTo": "in",
      "ReplyTemplateIdCustomer": 243,
      "ReplyTemplateIdUser": 194,
      "ReplyTemplateIdCatmast": 788,
      "ReplyTemplateIdEmail": 737,
      "RtiCustomerSms": 59,
      "ReplyTemplateIdUserSms": 700,
      "ReplyTemplateIdCatmastSms": 38,
      "ReplyTemplateIdSms": 964
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 68,
  "Name": "Leffler, Russel and Kohler",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 37,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 295,
  "MonStart": "2019-10-30T13:14:11.5704589+01:00",
  "MonStop": "2019-02-15T13:14:11.5704589+01:00",
  "TueStart": "2011-04-13T13:14:11.5704589+02:00",
  "TueStop": "2014-02-26T13:14:11.5704589+01:00",
  "WedStart": "2003-02-26T13:14:11.5704589+01:00",
  "WedStop": "2004-10-11T13:14:11.5704589+02:00",
  "ThuStart": "1998-02-25T13:14:11.5704589+01:00",
  "ThuStop": "2013-01-29T13:14:11.5704589+01:00",
  "FriStart": "2019-10-16T13:14:11.5704589+02:00",
  "FriStop": "2015-08-06T13:14:11.5704589+02:00",
  "SatStart": "2014-03-05T13:14:11.5704589+01:00",
  "SatStop": "2020-03-01T13:14:11.5704589+01:00",
  "SunStart": "2004-03-24T13:14:11.5704589+01:00",
  "SunStop": "2018-11-29T13:14:11.5704589+01:00",
  "NonDates": [
    "suscipit",
    "velit"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 37,
      "AlertLevel": 579,
      "AlertTimeout": 413,
      "Action": 942,
      "DelegateTo": 744,
      "ScriptId": 749,
      "EmailTo": "monte_kohler@mayert.name",
      "SmsTo": "sit",
      "ReplyTemplateIdCustomer": 574,
      "ReplyTemplateIdUser": 597,
      "ReplyTemplateIdCatmast": 759,
      "ReplyTemplateIdEmail": 913,
      "RtiCustomerSms": 700,
      "ReplyTemplateIdUserSms": 695,
      "ReplyTemplateIdCatmastSms": 278,
      "ReplyTemplateIdSms": 765,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 201
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 687
    }
  }
}
```