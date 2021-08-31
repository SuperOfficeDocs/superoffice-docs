---
title: CreateDefaultProjectEntity
id: v1ProjectAgent_CreateDefaultProjectEntity
---

# CreateDefaultProjectEntity

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
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 604,
  "Name": "Pollich, Bruen and Gutmann",
  "ProjectNumber": "816943",
  "ProjectMembers": [
    {
      "ProjectmemberId": 25,
      "ContactId": 305,
      "ProjectId": 431,
      "ContactName": "Gutmann, Brakus and Purdy",
      "ContactDepartment": "enable interactive interfaces",
      "ProjectName": "Treutel, Leannon and O'Connell",
      "EmailId": 218,
      "EmailAddress": "aylin_mclaughlin@kubgleichner.info",
      "CountryId": 721,
      "Firstname": "Flossie",
      "MiddleName": "Stroman-Koss",
      "Lastname": "McGlynn",
      "PersonId": 989,
      "Mrmrs": "neque",
      "ProjectMemberTypeName": "Goyette, Osinski and Gislason",
      "Phone": "1-465-330-2408 x841",
      "PhoneId": 15,
      "ProjectMemberTypeId": 721,
      "EmailAddressName": "ava_barton@wunschwelch.ca",
      "Comment": "est",
      "FullName": "Jerod Howe",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "enhance holistic experiences"
          },
          "FieldType": "System.Int32",
          "FieldLength": 645
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "itaque",
      "StrippedValue": "dolores",
      "Description": "Digitized mobile contingency",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 919
        }
      }
    },
    {
      "Value": "itaque",
      "StrippedValue": "dolores",
      "Description": "Digitized mobile contingency",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 919
        }
      }
    }
  ],
  "CreatedDate": "2010-07-14T14:58:04.880461+02:00",
  "UpdatedDate": "1994-12-31T14:58:04.880461+01:00",
  "Description": "Multi-tiered impactful neural-net",
  "Postit": "quidem",
  "CreatedBy": {
    "AssociateId": 686,
    "Name": "Lakin-Dare",
    "PersonId": 817,
    "Rank": 780,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 683,
    "FullName": "Myra Wolf",
    "FormalName": "D'Amore-Hills",
    "Deleted": false,
    "EjUserId": 716,
    "UserName": "Jacobson Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 77
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 924,
    "Name": "Considine, Leannon and Ullrich",
    "PersonId": 300,
    "Rank": 446,
    "Tooltip": "laboriosam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 487,
    "FullName": "Loraine Casper I",
    "FormalName": "Moen-Sauer",
    "Deleted": false,
    "EjUserId": 403,
    "UserName": "Wehner, Haley and Feeney",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 632
      }
    }
  },
  "Associate": {
    "AssociateId": 342,
    "Name": "Reilly, Runte and Torp",
    "PersonId": 102,
    "Rank": 895,
    "Tooltip": "expedita",
    "Type": "AnonymousAssociate",
    "GroupIdx": 936,
    "FullName": "Jaquan Fisher",
    "FormalName": "Harvey-Pfannerstill",
    "Deleted": true,
    "EjUserId": 278,
    "UserName": "Sanford-Bernhard",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 226
      }
    }
  },
  "ProjectStatus": {
    "Id": 289,
    "Value": "esse",
    "Tooltip": "sint",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 157
      }
    }
  },
  "ProjectType": {
    "Id": 548,
    "Value": "porro",
    "Tooltip": "provident",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 545
      }
    }
  },
  "HasImage": false,
  "ImageDescription": "De-engineered upward-trending intranet",
  "ActiveStatusMonitorId": 303,
  "Links": [
    {
      "EntityName": "Little, Hilll and Greenholt",
      "Id": 208,
      "Description": "Synchronised didactic knowledge user",
      "ExtraInfo": "error",
      "LinkId": 661,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 747
        }
      }
    }
  ],
  "ActiveLinks": 148,
  "Completed": false,
  "NextMilestoneDate": "1997-07-14T14:58:04.8814599+02:00",
  "NmdAppointmentId": 660,
  "EndDate": "2019-04-25T14:58:04.8814599+02:00",
  "ActiveErpLinks": 92,
  "UserDefinedFields": {
    "SuperOffice:1": "Nathan Herzog",
    "SuperOffice:2": "838522499"
  },
  "ExtraFields": {
    "ExtraFields1": "sit",
    "ExtraFields2": "exercitationem"
  },
  "CustomFields": {
    "CustomFields1": "nobis",
    "CustomFields2": "commodi"
  },
  "PublishEventDate": "2006-09-07T14:58:04.8814599+02:00",
  "PublishTo": "2020-07-24T14:58:04.8814599+02:00",
  "PublishFrom": "2013-08-06T14:58:04.8814599+02:00",
  "IsPublished": false,
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "engage synergistic e-services"
      },
      "FieldType": "System.String",
      "FieldLength": 935
    }
  }
}
```