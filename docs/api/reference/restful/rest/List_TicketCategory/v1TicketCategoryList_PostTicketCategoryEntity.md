---
title: POST List/TicketCategory/Items
id: v1TicketCategoryList_PostTicketCategoryEntity
---

# POST List/TicketCategory/Items

```http
POST /api/v1/List/TicketCategory/Items
```

Create a new TicketCategoryEntity list item

Calls the List agent service SaveTicketCategoryEntity.






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

## Request Body: newEntity  

The TicketCategoryEntity to be created. 

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


## Response: object

This entity describes the meta data for a ticket category, and provides special operations on it.



Carrier object for TicketCategoryEntity.
Services for the TicketCategoryEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IListAgent">List Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

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
POST /api/v1/List/TicketCategory/Items
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketCategoryId": 298,
  "ParentId": 263,
  "Name": "Adams, Wisozk and Lubowitz",
  "Fullname": "dolores",
  "CategoryMaster": 966,
  "Flags": "AcceptWhenReplying",
  "DelegateMethod": "Even",
  "ExternalName": "Senger-Sawayn",
  "ClosingStatus": "Active",
  "MsgClosingStatus": "Active",
  "AssignmentLag": 909,
  "ReplyTemplate": 591,
  "NotificationEmail": "tess@kris.uk",
  "DefaultTicketStatus": {
    "TicketStatusId": 580,
    "Name": "McLaughlin, Rolfson and Hand",
    "Status": "Active",
    "TimeCounter": "Externally",
    "NoEmailReopen": true,
    "IsDefault": false,
    "UsedInQueue": true
  },
  "DefaultMessageStatus": {
    "TicketStatusId": 566,
    "Name": "Brown, Nienow and Beatty",
    "Status": "Active",
    "TimeCounter": "Externally",
    "NoEmailReopen": false,
    "IsDefault": true,
    "UsedInQueue": true
  },
  "ExtraFields": {
    "ExtraFields1": "expedita",
    "ExtraFields2": "quaerat"
  },
  "CustomFields": {
    "CustomFields1": "soluta",
    "CustomFields2": "nisi"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketCategoryId": 628,
  "ParentId": 739,
  "Name": "Kohler, Dach and Bartoletti",
  "Fullname": "est",
  "CategoryMaster": 478,
  "Flags": "AcceptWhenReplying",
  "DelegateMethod": "Even",
  "ExternalName": "Quitzon Inc and Sons",
  "ClosingStatus": "Active",
  "MsgClosingStatus": "Active",
  "AssignmentLag": 295,
  "ReplyTemplate": 120,
  "NotificationEmail": "kelsi.smith@wintheiser.us",
  "DefaultTicketStatus": {
    "TicketStatusId": 704,
    "Name": "Reilly-Lang",
    "Status": "Active",
    "TimeCounter": "Externally",
    "NoEmailReopen": true,
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
        "FieldLength": 838
      }
    }
  },
  "DefaultMessageStatus": {
    "TicketStatusId": 965,
    "Name": "Tromp Group",
    "Status": "Active",
    "TimeCounter": "Externally",
    "NoEmailReopen": true,
    "IsDefault": true,
    "UsedInQueue": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 394
      }
    }
  },
  "ExtraFields": {
    "ExtraFields1": "beatae",
    "ExtraFields2": "debitis"
  },
  "CustomFields": {
    "CustomFields1": "exercitationem",
    "CustomFields2": "libero"
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
      "FieldLength": 417
    }
  }
}
```