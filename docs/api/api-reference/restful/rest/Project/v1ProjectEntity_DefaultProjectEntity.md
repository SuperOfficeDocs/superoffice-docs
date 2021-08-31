---
title: GET Project/default
id: v1ProjectEntity_DefaultProjectEntity
---

# GET Project/default

```http
GET /api/v1/Project/default
```

Set default values into a new ProjectEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Project agent service CreateDefaultProjectEntity.






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
GET /api/v1/Project/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Thu, 04 Sep 2008 15:05:42 G9T

{
  "ProjectId": 528,
  "Name": "Hodkiewicz LLC",
  "ProjectNumber": "1533561",
  "ProjectMembers": [
    {
      "ProjectmemberId": 596,
      "ContactId": 503,
      "ProjectId": 791,
      "ContactName": "Raynor-Cole",
      "ContactDepartment": "",
      "ProjectName": "Connelly, Balistreri and Champlin",
      "EmailId": 366,
      "EmailAddress": "henry_pfannerstill@lakin.uk",
      "CountryId": 215,
      "Firstname": "Carter",
      "MiddleName": "Schimmel-Bayer",
      "Lastname": "Kuhn",
      "PersonId": 736,
      "Mrmrs": "ut",
      "ProjectMemberTypeName": "Hermiston Group",
      "Phone": "646.354.0740 x40505",
      "PhoneId": 584,
      "ProjectMemberTypeId": 842,
      "EmailAddressName": "sasha_keebler@keeblercrist.name",
      "Comment": "tempora",
      "FullName": "Jeff Grady",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 369
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "recusandae",
      "StrippedValue": "enim",
      "Description": "Re-engineered web-enabled interface",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 835
        }
      }
    },
    {
      "Value": "recusandae",
      "StrippedValue": "enim",
      "Description": "Re-engineered web-enabled interface",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 835
        }
      }
    }
  ],
  "CreatedDate": "2002-09-24T15:05:42.4376687+02:00",
  "UpdatedDate": "2008-09-04T15:05:42.4376687+02:00",
  "Description": "Multi-channelled bi-directional methodology",
  "Postit": "aliquam",
  "CreatedBy": {
    "AssociateId": 488,
    "Name": "Mann Inc and Sons",
    "PersonId": 60,
    "Rank": 552,
    "Tooltip": "eos",
    "Type": "AnonymousAssociate",
    "GroupIdx": 680,
    "FullName": "Deontae Bernhard",
    "FormalName": "Wilkinson, Doyle and Deckow",
    "Deleted": false,
    "EjUserId": 673,
    "UserName": "Dach-Vandervort",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 318
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 323,
    "Name": "Wilderman Group",
    "PersonId": 268,
    "Rank": 876,
    "Tooltip": "est",
    "Type": "AnonymousAssociate",
    "GroupIdx": 989,
    "FullName": "Kiera Swift",
    "FormalName": "Stanton-Mills",
    "Deleted": false,
    "EjUserId": 845,
    "UserName": "Johnson-Beahan",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 274
      }
    }
  },
  "Associate": {
    "AssociateId": 461,
    "Name": "Christiansen, Boehm and Marvin",
    "PersonId": 864,
    "Rank": 835,
    "Tooltip": "quod",
    "Type": "AnonymousAssociate",
    "GroupIdx": 118,
    "FullName": "Kaya Jenkins III",
    "FormalName": "Heaney, Okuneva and Wisoky",
    "Deleted": true,
    "EjUserId": 610,
    "UserName": "Hagenes, Reichert and Mann",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 311
      }
    }
  },
  "ProjectStatus": {
    "Id": 271,
    "Value": "similique",
    "Tooltip": "dolores",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 643
      }
    }
  },
  "ProjectType": {
    "Id": 610,
    "Value": "delectus",
    "Tooltip": "magni",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 83
      }
    }
  },
  "HasImage": true,
  "ImageDescription": "Visionary optimizing orchestration",
  "ActiveStatusMonitorId": 334,
  "Links": [
    {
      "EntityName": "Stroman, Ondricka and Ondricka",
      "Id": 632,
      "Description": "Intuitive incremental encryption",
      "ExtraInfo": "quas",
      "LinkId": 243,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 505
        }
      }
    }
  ],
  "ActiveLinks": 58,
  "Completed": false,
  "NextMilestoneDate": "2008-04-30T15:05:42.4386551+02:00",
  "NmdAppointmentId": 219,
  "EndDate": "2002-06-15T15:05:42.4386551+02:00",
  "ActiveErpLinks": 52,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "386370661"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptatem",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "natus",
    "CustomFields2": "repellat"
  },
  "PublishEventDate": "1999-11-23T15:05:42.4396345+01:00",
  "PublishTo": "1999-06-02T15:05:42.4396345+02:00",
  "PublishFrom": "1998-11-03T15:05:42.4396345+01:00",
  "IsPublished": true,
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
      "FieldLength": 466
    }
  }
}
```