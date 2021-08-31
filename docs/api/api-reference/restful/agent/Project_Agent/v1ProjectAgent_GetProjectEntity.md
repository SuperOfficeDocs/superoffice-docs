---
title: GetProjectEntity
id: v1ProjectAgent_GetProjectEntity
---

# GetProjectEntity

```http
POST /api/v1/Agents/Project/GetProjectEntity
```

Gets a ProjectEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| projectEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Project/GetProjectEntity?projectEntityId=159
POST /api/v1/Agents/Project/GetProjectEntity?$select=name,department,category/id
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
POST /api/v1/Agents/Project/GetProjectEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 549,
  "Name": "Anderson-Hartmann",
  "ProjectNumber": "1402966",
  "ProjectMembers": [
    {
      "ProjectmemberId": 646,
      "ContactId": 918,
      "ProjectId": 485,
      "ContactName": "Funk-Konopelski",
      "ContactDepartment": "",
      "ProjectName": "Wolf LLC",
      "EmailId": 655,
      "EmailAddress": "stella_farrell@fisher.uk",
      "CountryId": 58,
      "Firstname": "Bridget",
      "MiddleName": "Grady, Wolff and Hyatt",
      "Lastname": "Schultz",
      "PersonId": 733,
      "Mrmrs": "eius",
      "ProjectMemberTypeName": "Williamson-Lemke",
      "Phone": "833-345-4652 x226",
      "PhoneId": 630,
      "ProjectMemberTypeId": 511,
      "EmailAddressName": "chadrick_feeney@ullrich.com",
      "Comment": "vero",
      "FullName": "Noah Franecki",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 256
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "doloremque",
      "StrippedValue": "quos",
      "Description": "Stand-alone web-enabled info-mediaries",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 522
        }
      }
    },
    {
      "Value": "doloremque",
      "StrippedValue": "quos",
      "Description": "Stand-alone web-enabled info-mediaries",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 522
        }
      }
    }
  ],
  "CreatedDate": "2021-04-05T14:58:04.9104659+02:00",
  "UpdatedDate": "2001-08-01T14:58:04.9104659+02:00",
  "Description": "Pre-emptive client-server contingency",
  "Postit": "quae",
  "CreatedBy": {
    "AssociateId": 37,
    "Name": "McGlynn, Leannon and Hudson",
    "PersonId": 251,
    "Rank": 243,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 775,
    "FullName": "Rosalinda Jast",
    "FormalName": "Zboncak-Gusikowski",
    "Deleted": false,
    "EjUserId": 677,
    "UserName": "Heathcote LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 974
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 625,
    "Name": "Parisian Inc and Sons",
    "PersonId": 470,
    "Rank": 539,
    "Tooltip": "impedit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 971,
    "FullName": "Vallie Nienow",
    "FormalName": "Friesen-Sipes",
    "Deleted": true,
    "EjUserId": 507,
    "UserName": "Ullrich Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 327
      }
    }
  },
  "Associate": {
    "AssociateId": 591,
    "Name": "Franecki-Prohaska",
    "PersonId": 410,
    "Rank": 972,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 627,
    "FullName": "Mrs. Geraldine Kutch",
    "FormalName": "Marvin Inc and Sons",
    "Deleted": false,
    "EjUserId": 606,
    "UserName": "Heidenreich Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 288
      }
    }
  },
  "ProjectStatus": {
    "Id": 251,
    "Value": "facilis",
    "Tooltip": "excepturi",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 880
      }
    }
  },
  "ProjectType": {
    "Id": 994,
    "Value": "aut",
    "Tooltip": "repellat",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 960
      }
    }
  },
  "HasImage": true,
  "ImageDescription": "Open-architected web-enabled ability",
  "ActiveStatusMonitorId": 955,
  "Links": [
    {
      "EntityName": "Lueilwitz LLC",
      "Id": 839,
      "Description": "Inverse zero administration migration",
      "ExtraInfo": "autem",
      "LinkId": 191,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 330
        }
      }
    }
  ],
  "ActiveLinks": 139,
  "Completed": true,
  "NextMilestoneDate": "2013-02-10T14:58:04.9114652+01:00",
  "NmdAppointmentId": 381,
  "EndDate": "2008-08-05T14:58:04.9114652+02:00",
  "ActiveErpLinks": 625,
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Leland Gerlach",
    "SuperOffice:2": "1586541226"
  },
  "ExtraFields": {
    "ExtraFields1": "cum",
    "ExtraFields2": "sit"
  },
  "CustomFields": {
    "CustomFields1": "voluptas",
    "CustomFields2": "est"
  },
  "PublishEventDate": "2021-06-02T14:58:04.9114652+02:00",
  "PublishTo": "1996-11-06T14:58:04.9114652+01:00",
  "PublishFrom": "2007-06-25T14:58:04.9114652+02:00",
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
      "FieldLength": 280
    }
  }
}
```