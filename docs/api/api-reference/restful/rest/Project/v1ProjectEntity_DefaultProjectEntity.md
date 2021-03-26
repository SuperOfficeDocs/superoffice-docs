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
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Tue, 02 Sep 2003 09:40:59 G9T

{
  "ProjectId": 258,
  "Name": "Price, Rogahn and Goldner",
  "ProjectNumber": "1061083",
  "ProjectMembers": [
    {
      "ProjectmemberId": 136,
      "ContactId": 42,
      "ProjectId": 471,
      "ContactName": "Collier Group",
      "ContactDepartment": "",
      "ProjectName": "Hilll, Johns and Block",
      "EmailId": 375,
      "EmailAddress": "nash_sporer@boscofunk.us",
      "CountryId": 893,
      "Firstname": "Justina",
      "MiddleName": "Zieme-McCullough",
      "Lastname": "Lakin",
      "PersonId": 289,
      "Mrmrs": "cum",
      "ProjectMemberTypeName": "Wiegand LLC",
      "Phone": "442.718.5837",
      "PhoneId": 413,
      "ProjectMemberTypeId": 179,
      "EmailAddressName": "lucius@padberg.biz",
      "Comment": "similique",
      "FullName": "Lee Nitzsche",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 433
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "non",
      "StrippedValue": "totam",
      "Description": "Progressive zero defect complexity",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 230
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "totam",
      "Description": "Progressive zero defect complexity",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 230
        }
      }
    }
  ],
  "CreatedDate": "2018-09-17T09:40:59.4146655+02:00",
  "UpdatedDate": "2003-09-02T09:40:59.4146655+02:00",
  "Description": "Future-proofed heuristic paradigm",
  "Postit": "qui",
  "CreatedBy": {
    "AssociateId": 547,
    "Name": "Macejkovic, Leuschke and Rice",
    "PersonId": 967,
    "Rank": 294,
    "Tooltip": "dolorem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 869,
    "FullName": "Elton Rath",
    "FormalName": "Deckow-Goodwin",
    "Deleted": true,
    "EjUserId": 743,
    "UserName": "Labadie, Beer and Kihn",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 102
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 566,
    "Name": "Erdman-Schowalter",
    "PersonId": 890,
    "Rank": 659,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 870,
    "FullName": "Jason Brekke Sr.",
    "FormalName": "Crist Inc and Sons",
    "Deleted": true,
    "EjUserId": 676,
    "UserName": "Larkin, Rau and Klocko",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 44
      }
    }
  },
  "Associate": {
    "AssociateId": 315,
    "Name": "Johnson-Brown",
    "PersonId": 170,
    "Rank": 858,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 608,
    "FullName": "Wilfredo Wiza",
    "FormalName": "Shields-Mosciski",
    "Deleted": true,
    "EjUserId": 97,
    "UserName": "Murray, Runolfsson and Fahey",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 697
      }
    }
  },
  "ProjectStatus": {
    "Id": 128,
    "Value": "pariatur",
    "Tooltip": "voluptatem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 341
      }
    }
  },
  "ProjectType": {
    "Id": 397,
    "Value": "possimus",
    "Tooltip": "dolorum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 549
      }
    }
  },
  "HasImage": false,
  "ImageDescription": "Managed neutral archive",
  "ActiveStatusMonitorId": 691,
  "Links": [
    {
      "EntityName": "Corkery Group",
      "Id": 481,
      "Description": "Future-proofed didactic archive",
      "ExtraInfo": "reiciendis",
      "LinkId": 65,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 882
        }
      }
    }
  ],
  "ActiveLinks": 97,
  "Completed": true,
  "NextMilestoneDate": "1999-04-17T09:40:59.4166632+02:00",
  "NmdAppointmentId": 67,
  "EndDate": "2011-05-21T09:40:59.4166632+02:00",
  "ActiveErpLinks": 319,
  "UserDefinedFields": {
    "SuperOffice:1": "610285144",
    "SuperOffice:2": "181276918"
  },
  "ExtraFields": {
    "ExtraFields1": "iure",
    "ExtraFields2": "a"
  },
  "CustomFields": {
    "CustomFields1": "illum",
    "CustomFields2": "asperiores"
  },
  "PublishEventDate": "2020-05-12T09:40:59.4166632+02:00",
  "PublishTo": "1996-10-06T09:40:59.4166632+02:00",
  "PublishFrom": "2000-09-10T09:40:59.4166632+02:00",
  "IsPublished": false,
  "TableRight": {
    "Mask": "Delete",
    "Reason": "incubate frictionless ROI"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 539
    }
  }
}
```