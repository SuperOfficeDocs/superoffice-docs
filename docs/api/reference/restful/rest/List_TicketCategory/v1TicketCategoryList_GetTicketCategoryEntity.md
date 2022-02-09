---
title: GET List/TicketCategory/Items/{id}
id: v1TicketCategoryList_GetTicketCategoryEntity
---

# GET List/TicketCategory/Items/{id}

```http
GET /api/v1/List/TicketCategory/Items/{id}
```

Gets a TicketCategoryEntity list item.

Calls the List agent service GetTicketCategoryEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the TicketCategoryEntity to return. **Required** |



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


## Response: object

This entity describes the meta data for a ticket category, and provides special operations on it.



Carrier object for TicketCategoryEntity.
Services for the TicketCategoryEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IListAgent">List Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |
| 404 | Not Found. |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketCategoryId | int32 | The id of the ticket category. (primary key) |
| ParentId | int32 | The parent category for this category. -1 if this is a toplevel category. |
| Name | string | The (short) name of this category. E.g. &amp;apos;support&amp;apos;. |
| Fullname | string | The fullname (compiled from parents&amp;apos; names) for this category. E.g. &amp;apos;norway/product A/support&amp;apos;. |
| CategoryMaster | int32 | The user associated with this category. |
| Flags | string | A bitmask representing flags for this category. |
| DelegateMethod | string | An integer indicating the delegation method for this category. |
| ExternalName | string | The external name for this category, used for the customer frontend. |
| ClosingStatus | string | Determines the default status used in the GUI when creating a ticket |
| MsgClosingStatus | string | Determines the default status used in the GUI when adding a request to a ticket |
| AssignmentLag | int32 | Number of minutes we shall override the assignment if a customer sends consecutive messages to this category |
| ReplyTemplate | int32 | Reply template to merge with messages posted in this category |
| NotificationEmail | string | Comma separated list of addresses to notify when requests are redelegated to (unassigned) in this category. |
| DefaultTicketStatus |  | Default status for new tickets, if 0 then there is a fallback to a user-dependent value |
| DefaultMessageStatus |  | Default status for new messages, if 0 then there is a fallback to a user-dependent value |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketCategoryEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketCategoryEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
GET /api/v1/List/TicketCategory/Items/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketCategoryId": 85,
  "ParentId": 124,
  "Name": "Morar-Cronin",
  "Fullname": "consequuntur",
  "CategoryMaster": 164,
  "Flags": "AcceptWhenReplying",
  "DelegateMethod": "Even",
  "ExternalName": "Bernier, Runolfsdottir and Johnson",
  "ClosingStatus": "Active",
  "MsgClosingStatus": "Active",
  "AssignmentLag": 82,
  "ReplyTemplate": 707,
  "NotificationEmail": "carolyne.friesen@schowalter.biz",
  "DefaultTicketStatus": {
    "TicketStatusId": 803,
    "Name": "Boehm, Lesch and Ledner",
    "Status": "Active",
    "TimeCounter": "Externally",
    "NoEmailReopen": true,
    "IsDefault": false,
    "UsedInQueue": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "enhance 24/365 schemas"
        },
        "FieldType": "System.Int32",
        "FieldLength": 984
      }
    }
  },
  "DefaultMessageStatus": {
    "TicketStatusId": 323,
    "Name": "Wisoky, Lind and Schroeder",
    "Status": "Active",
    "TimeCounter": "Externally",
    "NoEmailReopen": false,
    "IsDefault": true,
    "UsedInQueue": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 757
      }
    }
  },
  "ExtraFields": {
    "ExtraFields1": "eligendi",
    "ExtraFields2": "quia"
  },
  "CustomFields": {
    "CustomFields1": "tempora",
    "CustomFields2": "consectetur"
  },
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 97
    }
  }
}
```