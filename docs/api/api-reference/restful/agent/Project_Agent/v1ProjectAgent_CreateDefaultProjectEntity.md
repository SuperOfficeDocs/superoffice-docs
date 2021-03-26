---
title: POST Agents/Project/CreateDefaultProjectEntity
id: v1ProjectAgent_CreateDefaultProjectEntity
---

# POST Agents/Project/CreateDefaultProjectEntity

```http
POST /api/v1/Agents/Project/CreateDefaultProjectEntity
```

Set default values into a new ProjectEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance






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

The Project Service. The service implements all services working with the Project object



Carrier object for ProjectEntity.
Services for the ProjectEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IProjectAgent">Project Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProjectId | int32 | Primary key |
| Name | string | Project name |
| ProjectNumber | string | Automatically generated number |
| ProjectMembers | array | The persons which are members of the project |
| Urls | array | The project's internet adresses |
| CreatedDate | date-time | Registered date  in UTC. |
| UpdatedDate | date-time | Last updated date  in UTC. |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| Postit | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| CreatedBy |  | The person that created the project |
| UpdatedBy |  | The person that last updated the project |
| Associate |  | The person that created the project  <para>Use MDO List name "associate" to get list items.</para> |
| ProjectStatus |  | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <para>Use MDO List name "projectstatus" to get list items.</para> |
| ProjectType |  | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <para>Use MDO List name "projecttype" to get list items.</para> |
| HasImage | bool | True if the project has an image. (This is the image that is displayed in the CRM client) |
| ImageDescription | string | Description of the project image if it exists. (This is the image that is displayed in the CRM client) |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for project |
| Links | array | List of all elements linked to the project |
| ActiveLinks | int32 | Number of active links to documents, other appointments, and such |
| Completed | bool | Done (0=false, 1=true). Status implies changes in which fields are shown in GUI, as well as which fields can be updated |
| NextMilestoneDate | date-time | Calculated date, reflects date of closest non-complete future milestone activity |
| NmdAppointmentId | int32 | ID of appointment that "caused" the nextMilestoneDate, can be 0 |
| EndDate | date-time | Planned end date for project, inhertied from type and later editable |
| ActiveErpLinks | int32 | The number of active erp links |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ProjectEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ProjectEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| PublishEventDate | date-time | Publish event date |
| PublishTo | date-time | Publication valid to (inclusive) |
| PublishFrom | date-time | Publication valid from (inclusive) |
| IsPublished | bool | Publication is published |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Project/CreateDefaultProjectEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 716,
  "Name": "Stanton LLC",
  "ProjectNumber": "969174",
  "ProjectMembers": [
    {
      "ProjectmemberId": 704,
      "ContactId": 338,
      "ProjectId": 981,
      "ContactName": "Schmidt, Ziemann and Kilback",
      "ContactDepartment": "",
      "ProjectName": "Fisher, Walsh and Shanahan",
      "EmailId": 752,
      "EmailAddress": "darrin@pfannerstillturcotte.biz",
      "CountryId": 213,
      "Firstname": "Doug",
      "MiddleName": "Considine-Satterfield",
      "Lastname": "Dooley",
      "PersonId": 189,
      "Mrmrs": "velit",
      "ProjectMemberTypeName": "Harris-Spencer",
      "Phone": "780-336-2130",
      "PhoneId": 737,
      "ProjectMemberTypeId": 674,
      "EmailAddressName": "savion.hudson@greenmosciski.name",
      "Comment": "tenetur",
      "FullName": "Belle Dickinson",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 177
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ut",
      "StrippedValue": "in",
      "Description": "Reactive zero administration productivity",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 957
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "in",
      "Description": "Reactive zero administration productivity",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 957
        }
      }
    }
  ],
  "CreatedDate": "2005-02-02T16:48:30.3149311+01:00",
  "UpdatedDate": "2004-10-16T16:48:30.3149311+02:00",
  "Description": "Sharable dedicated standardization",
  "Postit": "ab",
  "CreatedBy": {
    "AssociateId": 329,
    "Name": "Kassulke, Lueilwitz and Bechtelar",
    "PersonId": 716,
    "Rank": 895,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 974,
    "FullName": "Christian Balistreri MD",
    "FormalName": "Corwin, Padberg and Brakus",
    "Deleted": true,
    "EjUserId": 27,
    "UserName": "Kreiger, Collins and Russel",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 96
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 143,
    "Name": "Flatley Group",
    "PersonId": 151,
    "Rank": 380,
    "Tooltip": "placeat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 297,
    "FullName": "Jody Daniel",
    "FormalName": "Heathcote Inc and Sons",
    "Deleted": false,
    "EjUserId": 858,
    "UserName": "Toy, Nikolaus and Olson",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 26
      }
    }
  },
  "Associate": {
    "AssociateId": 427,
    "Name": "Greenfelder-Sawayn",
    "PersonId": 802,
    "Rank": 52,
    "Tooltip": "iusto",
    "Type": "AnonymousAssociate",
    "GroupIdx": 165,
    "FullName": "Isabella Barton",
    "FormalName": "Altenwerth-Eichmann",
    "Deleted": true,
    "EjUserId": 381,
    "UserName": "Runolfsdottir Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "exploit robust niches"
        },
        "FieldType": "System.String",
        "FieldLength": 469
      }
    }
  },
  "ProjectStatus": {
    "Id": 456,
    "Value": "optio",
    "Tooltip": "occaecati",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 457
      }
    }
  },
  "ProjectType": {
    "Id": 911,
    "Value": "accusamus",
    "Tooltip": "quod",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 261
      }
    }
  },
  "HasImage": false,
  "ImageDescription": "Face to face tangible hardware",
  "ActiveStatusMonitorId": 205,
  "Links": [
    {
      "EntityName": "Mayert LLC",
      "Id": 176,
      "Description": "Persistent dynamic help-desk",
      "ExtraInfo": "voluptate",
      "LinkId": 318,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 467
        }
      }
    }
  ],
  "ActiveLinks": 247,
  "Completed": false,
  "NextMilestoneDate": "1996-05-05T16:48:30.3169365+02:00",
  "NmdAppointmentId": 697,
  "EndDate": "2000-05-15T16:48:30.3169365+02:00",
  "ActiveErpLinks": 760,
  "UserDefinedFields": {
    "SuperOffice:1": "1900389768",
    "SuperOffice:2": "Ms. Vena Gusikowski"
  },
  "ExtraFields": {
    "ExtraFields1": "sunt",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "minima",
    "CustomFields2": "et"
  },
  "PublishEventDate": "2018-11-08T16:48:30.3169365+01:00",
  "PublishTo": "1995-03-15T16:48:30.3169365+01:00",
  "PublishFrom": "2011-06-05T16:48:30.3169365+02:00",
  "IsPublished": false,
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
      "FieldLength": 762
    }
  }
}
```