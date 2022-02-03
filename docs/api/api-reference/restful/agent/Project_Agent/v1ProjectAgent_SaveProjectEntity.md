---
title: POST Agents/Project/SaveProjectEntity
id: v1ProjectAgent_SaveProjectEntity
---

# POST Agents/Project/SaveProjectEntity

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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 250,
  "Name": "Terry, Mueller and Balistreri",
  "ProjectNumber": "351267",
  "ProjectMembers": [
    {
      "ProjectmemberId": 323,
      "ContactId": 558,
      "ProjectId": 548,
      "ContactName": "Dibbert, Batz and Zemlak",
      "ContactDepartment": "",
      "ProjectName": "Kuhlman LLC",
      "EmailId": 984,
      "EmailAddress": "eldridge@wisokymclaughlin.com",
      "CountryId": 97,
      "Firstname": "Emil",
      "MiddleName": "Schuster Group",
      "Lastname": "Bergnaum",
      "PersonId": 771,
      "Mrmrs": "dolorem",
      "ProjectMemberTypeName": "Gibson-Mante",
      "Phone": "725.267.2841",
      "PhoneId": 571,
      "ProjectMemberTypeId": 382,
      "EmailAddressName": "darian@rau.info",
      "Comment": "quis",
      "FullName": "Tomasa Abshire"
    }
  ],
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "atque",
      "Description": "Visionary bi-directional strategy"
    },
    {
      "Value": "et",
      "StrippedValue": "atque",
      "Description": "Visionary bi-directional strategy"
    }
  ],
  "CreatedDate": "2012-09-03T18:28:49.8601393+02:00",
  "UpdatedDate": "1996-12-02T18:28:49.8601393+01:00",
  "Description": "Monitored bi-directional open system",
  "Postit": "saepe",
  "CreatedBy": {
    "AssociateId": 51,
    "Name": "Buckridge, Gusikowski and Grimes",
    "PersonId": 606,
    "Rank": 125,
    "Tooltip": "dignissimos",
    "Type": "AnonymousAssociate",
    "GroupIdx": 834,
    "FullName": "Eve Kuphal",
    "FormalName": "Klein, Goyette and Wolff",
    "Deleted": false,
    "EjUserId": 244,
    "UserName": "Rodriguez-Yundt"
  },
  "UpdatedBy": {
    "AssociateId": 370,
    "Name": "Schuster LLC",
    "PersonId": 857,
    "Rank": 659,
    "Tooltip": "delectus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 494,
    "FullName": "Lexi Abbott",
    "FormalName": "Yost, Block and Hane",
    "Deleted": false,
    "EjUserId": 598,
    "UserName": "Beahan LLC"
  },
  "Associate": {
    "AssociateId": 448,
    "Name": "Hilll, Kemmer and Klocko",
    "PersonId": 161,
    "Rank": 162,
    "Tooltip": "quos",
    "Type": "AnonymousAssociate",
    "GroupIdx": 305,
    "FullName": "Ned Zieme",
    "FormalName": "Yost-Gleichner",
    "Deleted": false,
    "EjUserId": 505,
    "UserName": "Gutkowski, Beatty and Leannon"
  },
  "ProjectStatus": {
    "Id": 887,
    "Value": "omnis",
    "Tooltip": "eveniet"
  },
  "ProjectType": {
    "Id": 540,
    "Value": "ut",
    "Tooltip": "earum"
  },
  "HasImage": false,
  "ImageDescription": "Synchronised 4th generation database",
  "ActiveStatusMonitorId": 421,
  "Links": [
    {
      "EntityName": "Satterfield Group",
      "Id": 695,
      "Description": "Adaptive human-resource extranet",
      "ExtraInfo": "rerum",
      "LinkId": 991
    },
    {
      "EntityName": "Satterfield Group",
      "Id": 695,
      "Description": "Adaptive human-resource extranet",
      "ExtraInfo": "rerum",
      "LinkId": 991
    }
  ],
  "ActiveLinks": 606,
  "Completed": true,
  "NextMilestoneDate": "2005-02-13T18:28:49.8621093+01:00",
  "NmdAppointmentId": 824,
  "EndDate": "2006-10-04T18:28:49.8621093+02:00",
  "ActiveErpLinks": 311,
  "UserDefinedFields": {
    "SuperOffice:1": "850844058",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "exercitationem"
  },
  "CustomFields": {
    "CustomFields1": "commodi",
    "CustomFields2": "eum"
  },
  "PublishEventDate": "2021-02-14T18:28:49.8621093+01:00",
  "PublishTo": "2018-01-14T18:28:49.8621093+01:00",
  "PublishFrom": "2009-11-11T18:28:49.8621093+01:00",
  "IsPublished": false
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 343,
  "Name": "Altenwerth, Mohr and Tremblay",
  "ProjectNumber": "781769",
  "ProjectMembers": [
    {
      "ProjectmemberId": 368,
      "ContactId": 342,
      "ProjectId": 595,
      "ContactName": "Zemlak LLC",
      "ContactDepartment": "",
      "ProjectName": "Upton, Smitham and Harris",
      "EmailId": 376,
      "EmailAddress": "haylie_leuschke@connmarks.us",
      "CountryId": 533,
      "Firstname": "Ryley",
      "MiddleName": "Bins-Walter",
      "Lastname": "Thompson",
      "PersonId": 512,
      "Mrmrs": "est",
      "ProjectMemberTypeName": "Lehner-Dickens",
      "Phone": "413-866-8321",
      "PhoneId": 875,
      "ProjectMemberTypeId": 527,
      "EmailAddressName": "ernie_predovic@jacobskoss.us",
      "Comment": "deserunt",
      "FullName": "Tressie Larson",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "iterate mission-critical portals"
          },
          "FieldType": "System.String",
          "FieldLength": 306
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quia",
      "StrippedValue": "veniam",
      "Description": "Ergonomic logistical software",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 296
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "veniam",
      "Description": "Ergonomic logistical software",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 296
        }
      }
    }
  ],
  "CreatedDate": "2003-01-01T18:28:49.8661371+01:00",
  "UpdatedDate": "2007-05-27T18:28:49.8661371+02:00",
  "Description": "Optimized attitude-oriented knowledge user",
  "Postit": "quia",
  "CreatedBy": {
    "AssociateId": 163,
    "Name": "Berge Group",
    "PersonId": 889,
    "Rank": 937,
    "Tooltip": "blanditiis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 579,
    "FullName": "Antonia Fisher",
    "FormalName": "Ortiz, Mante and Homenick",
    "Deleted": false,
    "EjUserId": 188,
    "UserName": "Kilback-Strosin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 402
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 300,
    "Name": "Jaskolski, Witting and Bode",
    "PersonId": 562,
    "Rank": 56,
    "Tooltip": "quia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 244,
    "FullName": "Edison Durgan",
    "FormalName": "Schimmel-Collins",
    "Deleted": true,
    "EjUserId": 774,
    "UserName": "Osinski-Kassulke",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 460
      }
    }
  },
  "Associate": {
    "AssociateId": 366,
    "Name": "Pacocha-Green",
    "PersonId": 445,
    "Rank": 991,
    "Tooltip": "corrupti",
    "Type": "AnonymousAssociate",
    "GroupIdx": 814,
    "FullName": "Ms. Jerome Bergstrom",
    "FormalName": "Daniel LLC",
    "Deleted": true,
    "EjUserId": 329,
    "UserName": "Hessel Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 301
      }
    }
  },
  "ProjectStatus": {
    "Id": 301,
    "Value": "qui",
    "Tooltip": "quibusdam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 198
      }
    }
  },
  "ProjectType": {
    "Id": 588,
    "Value": "sint",
    "Tooltip": "magnam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 844
      }
    }
  },
  "HasImage": false,
  "ImageDescription": "Programmable real-time orchestration",
  "ActiveStatusMonitorId": 508,
  "Links": [
    {
      "EntityName": "Runolfsson-Sporer",
      "Id": 634,
      "Description": "Business-focused asynchronous functionalities",
      "ExtraInfo": "sit",
      "LinkId": 556,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 761
        }
      }
    }
  ],
  "ActiveLinks": 768,
  "Completed": true,
  "NextMilestoneDate": "2005-06-21T18:28:49.8701112+02:00",
  "NmdAppointmentId": 665,
  "EndDate": "1998-01-06T18:28:49.8701112+01:00",
  "ActiveErpLinks": 872,
  "UserDefinedFields": {
    "SuperOffice:1": "1673332476",
    "SuperOffice:2": "Dr. Kelly Jaskolski"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptates",
    "ExtraFields2": "provident"
  },
  "CustomFields": {
    "CustomFields1": "cumque",
    "CustomFields2": "aut"
  },
  "PublishEventDate": "1995-11-20T18:28:49.8701112+01:00",
  "PublishTo": "1999-07-29T18:28:49.8701112+02:00",
  "PublishFrom": "2001-07-14T18:28:49.8701112+02:00",
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
      "FieldLength": 564
    }
  }
}
```