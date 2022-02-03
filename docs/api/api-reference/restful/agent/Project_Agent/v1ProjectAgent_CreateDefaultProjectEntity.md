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
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 993,
  "Name": "Kertzmann, White and Boehm",
  "ProjectNumber": "836543",
  "ProjectMembers": [
    {
      "ProjectmemberId": 376,
      "ContactId": 975,
      "ProjectId": 136,
      "ContactName": "Johnston, McKenzie and Kautzer",
      "ContactDepartment": "",
      "ProjectName": "Walsh, Ziemann and Reichel",
      "EmailId": 529,
      "EmailAddress": "janet@trantow.biz",
      "CountryId": 846,
      "Firstname": "Emelia",
      "MiddleName": "Schmitt-Bernier",
      "Lastname": "Ankunding",
      "PersonId": 643,
      "Mrmrs": "voluptas",
      "ProjectMemberTypeName": "Satterfield, Kozey and Sanford",
      "Phone": "(667)572-1886",
      "PhoneId": 891,
      "ProjectMemberTypeId": 630,
      "EmailAddressName": "pamela@leannonmaggio.ca",
      "Comment": "reprehenderit",
      "FullName": "Amiya Runolfsson",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 782
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "officia",
      "StrippedValue": "architecto",
      "Description": "Monitored composite help-desk",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 588
        }
      }
    },
    {
      "Value": "officia",
      "StrippedValue": "architecto",
      "Description": "Monitored composite help-desk",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 588
        }
      }
    }
  ],
  "CreatedDate": "2019-01-29T18:28:49.8561071+01:00",
  "UpdatedDate": "1996-07-29T18:28:49.8561071+02:00",
  "Description": "Open-architected upward-trending functionalities",
  "Postit": "repudiandae",
  "CreatedBy": {
    "AssociateId": 444,
    "Name": "Steuber, Schinner and Hammes",
    "PersonId": 434,
    "Rank": 236,
    "Tooltip": "iure",
    "Type": "AnonymousAssociate",
    "GroupIdx": 702,
    "FullName": "Miss Laverna Cole",
    "FormalName": "Bauch-Harber",
    "Deleted": false,
    "EjUserId": 680,
    "UserName": "Jast-Rempel",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 979
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 444,
    "Name": "Swift, Predovic and Ondricka",
    "PersonId": 913,
    "Rank": 259,
    "Tooltip": "vel",
    "Type": "AnonymousAssociate",
    "GroupIdx": 342,
    "FullName": "Jordyn Smitham",
    "FormalName": "Simonis, Sauer and Bins",
    "Deleted": true,
    "EjUserId": 941,
    "UserName": "Wisozk, Jast and Kozey",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 475
      }
    }
  },
  "Associate": {
    "AssociateId": 33,
    "Name": "Spencer LLC",
    "PersonId": 421,
    "Rank": 457,
    "Tooltip": "earum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 962,
    "FullName": "Mr. Henderson Wolff",
    "FormalName": "McGlynn Group",
    "Deleted": true,
    "EjUserId": 461,
    "UserName": "Rippin, McClure and White",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 990
      }
    }
  },
  "ProjectStatus": {
    "Id": 474,
    "Value": "in",
    "Tooltip": "magnam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 698
      }
    }
  },
  "ProjectType": {
    "Id": 87,
    "Value": "pariatur",
    "Tooltip": "quae",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 37
      }
    }
  },
  "HasImage": true,
  "ImageDescription": "Open-architected 24/7 moderator",
  "ActiveStatusMonitorId": 825,
  "Links": [
    {
      "EntityName": "Lemke, Wilkinson and Harvey",
      "Id": 737,
      "Description": "Multi-channelled clear-thinking superstructure",
      "ExtraInfo": "blanditiis",
      "LinkId": 469,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 861
        }
      }
    }
  ],
  "ActiveLinks": 789,
  "Completed": true,
  "NextMilestoneDate": "2004-05-26T18:28:49.8581371+02:00",
  "NmdAppointmentId": 389,
  "EndDate": "2004-10-25T18:28:49.8581371+02:00",
  "ActiveErpLinks": 504,
  "UserDefinedFields": {
    "SuperOffice:1": "Pauline Wolff",
    "SuperOffice:2": "Alfreda Kihn"
  },
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "fuga"
  },
  "CustomFields": {
    "CustomFields1": "exercitationem",
    "CustomFields2": "ab"
  },
  "PublishEventDate": "2018-02-02T18:28:49.8581371+01:00",
  "PublishTo": "2007-06-02T18:28:49.8581371+02:00",
  "PublishFrom": "2016-10-21T18:28:49.8581371+02:00",
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
      "FieldType": "System.Int32",
      "FieldLength": 962
    }
  }
}
```