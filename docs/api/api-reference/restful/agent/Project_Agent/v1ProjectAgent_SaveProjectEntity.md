---
title: SaveProjectEntity
id: v1ProjectAgent_SaveProjectEntity
---

# SaveProjectEntity

```http
POST /api/v1/Agents/Project/SaveProjectEntity
```

Updates the existing ProjectEntity or creates a new ProjectEntity if the id parameter is empty








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

The ProjectEntity to be saved. 

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
POST /api/v1/Agents/Project/SaveProjectEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 398,
  "Name": "Grady Inc and Sons",
  "ProjectNumber": "670695",
  "ProjectMembers": [
    {
      "ProjectmemberId": 189,
      "ContactId": 579,
      "ProjectId": 385,
      "ContactName": "Stamm-Gulgowski",
      "ContactDepartment": "",
      "ProjectName": "Eichmann, Leannon and Hettinger",
      "EmailId": 74,
      "EmailAddress": "cloyd@metzlynch.ca",
      "CountryId": 698,
      "Firstname": "Colleen",
      "MiddleName": "Schinner Group",
      "Lastname": "Hyatt",
      "PersonId": 27,
      "Mrmrs": "delectus",
      "ProjectMemberTypeName": "Gulgowski-Boehm",
      "Phone": "024.271.4450 x1752",
      "PhoneId": 648,
      "ProjectMemberTypeId": 97,
      "EmailAddressName": "kathlyn@pfannerstill.us",
      "Comment": "reprehenderit",
      "FullName": "Woodrow Lebsack"
    }
  ],
  "Urls": [
    {
      "Value": "suscipit",
      "StrippedValue": "error",
      "Description": "Customer-focused real-time focus group"
    },
    {
      "Value": "suscipit",
      "StrippedValue": "error",
      "Description": "Customer-focused real-time focus group"
    }
  ],
  "CreatedDate": "2000-01-01T14:58:04.8834598+01:00",
  "UpdatedDate": "2001-01-16T14:58:04.8834598+01:00",
  "Description": "User-friendly methodical help-desk",
  "Postit": "eos",
  "CreatedBy": {
    "AssociateId": 36,
    "Name": "Wisozk Inc and Sons",
    "PersonId": 189,
    "Rank": 174,
    "Tooltip": "earum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 908,
    "FullName": "Gordon Berge",
    "FormalName": "Bahringer-Hessel",
    "Deleted": false,
    "EjUserId": 26,
    "UserName": "Wisoky LLC"
  },
  "UpdatedBy": {
    "AssociateId": 328,
    "Name": "Mante-O'Conner",
    "PersonId": 867,
    "Rank": 885,
    "Tooltip": "nisi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 954,
    "FullName": "Lila Luettgen",
    "FormalName": "Berge-Connelly",
    "Deleted": true,
    "EjUserId": 574,
    "UserName": "Considine, Streich and Ruecker"
  },
  "Associate": {
    "AssociateId": 518,
    "Name": "Rice Group",
    "PersonId": 893,
    "Rank": 771,
    "Tooltip": "explicabo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 258,
    "FullName": "Ms. Melisa Morissette",
    "FormalName": "Hettinger-Hammes",
    "Deleted": true,
    "EjUserId": 525,
    "UserName": "Collier-Wilkinson"
  },
  "ProjectStatus": {
    "Id": 139,
    "Value": "quas",
    "Tooltip": "sapiente"
  },
  "ProjectType": {
    "Id": 224,
    "Value": "qui",
    "Tooltip": "qui"
  },
  "HasImage": false,
  "ImageDescription": "Organic actuating installation",
  "ActiveStatusMonitorId": 918,
  "Links": [
    {
      "EntityName": "Zemlak Inc and Sons",
      "Id": 953,
      "Description": "Future-proofed exuding array",
      "ExtraInfo": "inventore",
      "LinkId": 833
    },
    {
      "EntityName": "Zemlak Inc and Sons",
      "Id": 953,
      "Description": "Future-proofed exuding array",
      "ExtraInfo": "inventore",
      "LinkId": 833
    }
  ],
  "ActiveLinks": 446,
  "Completed": false,
  "NextMilestoneDate": "2021-04-29T14:58:04.8844599+02:00",
  "NmdAppointmentId": 252,
  "EndDate": "2007-04-08T14:58:04.8844599+02:00",
  "ActiveErpLinks": 623,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "Willa Schowalter Sr."
  },
  "ExtraFields": {
    "ExtraFields1": "quia",
    "ExtraFields2": "minima"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "eveniet"
  },
  "PublishEventDate": "2009-06-08T14:58:04.8844599+02:00",
  "PublishTo": "2017-04-29T14:58:04.8844599+02:00",
  "PublishFrom": "2013-07-28T14:58:04.8844599+02:00",
  "IsPublished": true
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 921,
  "Name": "Klein LLC",
  "ProjectNumber": "630024",
  "ProjectMembers": [
    {
      "ProjectmemberId": 120,
      "ContactId": 506,
      "ProjectId": 791,
      "ContactName": "Bartoletti Inc and Sons",
      "ContactDepartment": "maximize back-end models",
      "ProjectName": "Rath, Keeling and Herman",
      "EmailId": 714,
      "EmailAddress": "joshua@pagac.com",
      "CountryId": 748,
      "Firstname": "Cooper",
      "MiddleName": "Oberbrunner, Brakus and Douglas",
      "Lastname": "Steuber",
      "PersonId": 665,
      "Mrmrs": "odit",
      "ProjectMemberTypeName": "Walker, Adams and Metz",
      "Phone": "173.450.5171",
      "PhoneId": 297,
      "ProjectMemberTypeId": 335,
      "EmailAddressName": "peter_conn@beahan.us",
      "Comment": "in",
      "FullName": "Betty Fisher",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "maximize global users"
          },
          "FieldType": "System.Int32",
          "FieldLength": 757
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "sapiente",
      "StrippedValue": "voluptatibus",
      "Description": "Enhanced transitional benchmark",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 454
        }
      }
    },
    {
      "Value": "sapiente",
      "StrippedValue": "voluptatibus",
      "Description": "Enhanced transitional benchmark",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 454
        }
      }
    }
  ],
  "CreatedDate": "1999-08-05T14:58:04.8904652+02:00",
  "UpdatedDate": "1997-11-28T14:58:04.8904652+01:00",
  "Description": "Vision-oriented systemic synergy",
  "Postit": "repudiandae",
  "CreatedBy": {
    "AssociateId": 878,
    "Name": "Fahey Group",
    "PersonId": 349,
    "Rank": 440,
    "Tooltip": "suscipit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 129,
    "FullName": "Josiah Lueilwitz",
    "FormalName": "Stroman-Mayert",
    "Deleted": true,
    "EjUserId": 834,
    "UserName": "Crist, Marvin and Considine",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 665
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 948,
    "Name": "Franecki Inc and Sons",
    "PersonId": 84,
    "Rank": 201,
    "Tooltip": "ex",
    "Type": "AnonymousAssociate",
    "GroupIdx": 238,
    "FullName": "Marianne Morissette",
    "FormalName": "Mayer Group",
    "Deleted": true,
    "EjUserId": 3,
    "UserName": "Lubowitz-Medhurst",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 674
      }
    }
  },
  "Associate": {
    "AssociateId": 37,
    "Name": "Schultz LLC",
    "PersonId": 732,
    "Rank": 505,
    "Tooltip": "rerum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 494,
    "FullName": "Arvilla Cummings",
    "FormalName": "Hamill Group",
    "Deleted": true,
    "EjUserId": 495,
    "UserName": "Beatty-Nikolaus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 682
      }
    }
  },
  "ProjectStatus": {
    "Id": 663,
    "Value": "libero",
    "Tooltip": "quasi",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 579
      }
    }
  },
  "ProjectType": {
    "Id": 48,
    "Value": "eum",
    "Tooltip": "sit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 934
      }
    }
  },
  "HasImage": false,
  "ImageDescription": "Focused scalable extranet",
  "ActiveStatusMonitorId": 957,
  "Links": [
    {
      "EntityName": "Pagac LLC",
      "Id": 554,
      "Description": "Front-line content-based algorithm",
      "ExtraInfo": "excepturi",
      "LinkId": 240,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 299
        }
      }
    }
  ],
  "ActiveLinks": 971,
  "Completed": false,
  "NextMilestoneDate": "2005-06-12T14:58:04.8914657+02:00",
  "NmdAppointmentId": 96,
  "EndDate": "2018-03-13T14:58:04.8914657+01:00",
  "ActiveErpLinks": 591,
  "UserDefinedFields": {
    "SuperOffice:1": "Mr. Elwin Tromp",
    "SuperOffice:2": "1299841785"
  },
  "ExtraFields": {
    "ExtraFields1": "eum",
    "ExtraFields2": "officiis"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "asperiores"
  },
  "PublishEventDate": "2003-02-18T14:58:04.8914657+01:00",
  "PublishTo": "2012-02-28T14:58:04.8914657+01:00",
  "PublishFrom": "1997-07-13T14:58:04.8914657+02:00",
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
      "FieldLength": 114
    }
  }
}
```