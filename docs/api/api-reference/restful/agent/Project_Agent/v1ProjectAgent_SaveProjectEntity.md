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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 32,
  "Name": "Haag, Hartmann and Veum",
  "ProjectNumber": "705327",
  "ProjectMembers": [
    {
      "ProjectmemberId": 668,
      "ContactId": 657,
      "ProjectId": 314,
      "ContactName": "Nikolaus Inc and Sons",
      "ContactDepartment": "",
      "ProjectName": "Conn-Veum",
      "EmailId": 835,
      "EmailAddress": "jayme_abbott@hayes.us",
      "CountryId": 824,
      "Firstname": "Naomi",
      "MiddleName": "Schinner-Rosenbaum",
      "Lastname": "Trantow",
      "PersonId": 351,
      "Mrmrs": "labore",
      "ProjectMemberTypeName": "Kovacek, Okuneva and Stroman",
      "Phone": "(351)547-2572 x263",
      "PhoneId": 811,
      "ProjectMemberTypeId": 31,
      "EmailAddressName": "vito.wilkinson@grimes.us",
      "Comment": "molestias",
      "FullName": "Michael McClure"
    }
  ],
  "Urls": [
    {
      "Value": "ratione",
      "StrippedValue": "quia",
      "Description": "Vision-oriented 24/7 matrices"
    },
    {
      "Value": "ratione",
      "StrippedValue": "quia",
      "Description": "Vision-oriented 24/7 matrices"
    }
  ],
  "CreatedDate": "2010-11-06T16:48:30.3189336+01:00",
  "UpdatedDate": "1999-12-29T16:48:30.3189336+01:00",
  "Description": "Reactive fault-tolerant approach",
  "Postit": "ut",
  "CreatedBy": {
    "AssociateId": 864,
    "Name": "Lind Inc and Sons",
    "PersonId": 476,
    "Rank": 541,
    "Tooltip": "corrupti",
    "Type": "AnonymousAssociate",
    "GroupIdx": 978,
    "FullName": "Libbie Dach",
    "FormalName": "Hammes-Osinski",
    "Deleted": true,
    "EjUserId": 700,
    "UserName": "Prosacco LLC"
  },
  "UpdatedBy": {
    "AssociateId": 735,
    "Name": "Bode, Powlowski and Jacobs",
    "PersonId": 222,
    "Rank": 652,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 885,
    "FullName": "Angelita Berge I",
    "FormalName": "Kertzmann, Goldner and Daniel",
    "Deleted": true,
    "EjUserId": 629,
    "UserName": "Koelpin LLC"
  },
  "Associate": {
    "AssociateId": 379,
    "Name": "Cremin, Beer and Braun",
    "PersonId": 575,
    "Rank": 694,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 130,
    "FullName": "Jadyn Hintz Jr.",
    "FormalName": "Schroeder LLC",
    "Deleted": false,
    "EjUserId": 874,
    "UserName": "Johnson, Breitenberg and Hilpert"
  },
  "ProjectStatus": {
    "Id": 99,
    "Value": "est",
    "Tooltip": "repellat"
  },
  "ProjectType": {
    "Id": 585,
    "Value": "laborum",
    "Tooltip": "laborum"
  },
  "HasImage": true,
  "ImageDescription": "Optional actuating matrices",
  "ActiveStatusMonitorId": 874,
  "Links": [
    {
      "EntityName": "Jenkins, Wyman and Stanton",
      "Id": 301,
      "Description": "Upgradable zero tolerance instruction set",
      "ExtraInfo": "velit",
      "LinkId": 857
    },
    {
      "EntityName": "Jenkins, Wyman and Stanton",
      "Id": 301,
      "Description": "Upgradable zero tolerance instruction set",
      "ExtraInfo": "velit",
      "LinkId": 857
    }
  ],
  "ActiveLinks": 310,
  "Completed": true,
  "NextMilestoneDate": "2011-06-04T16:48:30.3199332+02:00",
  "NmdAppointmentId": 592,
  "EndDate": "2003-07-07T16:48:30.3199332+02:00",
  "ActiveErpLinks": 957,
  "UserDefinedFields": {
    "SuperOffice:1": "Gust Tillman",
    "SuperOffice:2": "Terrill Langosh"
  },
  "ExtraFields": {
    "ExtraFields1": "nulla",
    "ExtraFields2": "occaecati"
  },
  "CustomFields": {
    "CustomFields1": "eius",
    "CustomFields2": "quasi"
  },
  "PublishEventDate": "2008-08-18T16:48:30.3199332+02:00",
  "PublishTo": "1998-04-14T16:48:30.3199332+02:00",
  "PublishFrom": "2005-07-23T16:48:30.3199332+02:00",
  "IsPublished": false
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 206,
  "Name": "Altenwerth, Schmidt and Sipes",
  "ProjectNumber": "1095567",
  "ProjectMembers": [
    {
      "ProjectmemberId": 407,
      "ContactId": 312,
      "ProjectId": 995,
      "ContactName": "Carroll, Gibson and Bergnaum",
      "ContactDepartment": "",
      "ProjectName": "Leffler-Bartoletti",
      "EmailId": 601,
      "EmailAddress": "sean@anderson.ca",
      "CountryId": 60,
      "Firstname": "Thaddeus",
      "MiddleName": "Leuschke, Mann and Sauer",
      "Lastname": "Nitzsche",
      "PersonId": 285,
      "Mrmrs": "nulla",
      "ProjectMemberTypeName": "White, Mosciski and Heller",
      "Phone": "1-340-247-1412 x55104",
      "PhoneId": 710,
      "ProjectMemberTypeId": 522,
      "EmailAddressName": "dustin_howell@russelkassulke.co.uk",
      "Comment": "reiciendis",
      "FullName": "Sallie Lindgren",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 189
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "aliquam",
      "StrippedValue": "nesciunt",
      "Description": "Innovative multi-tasking strategy",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 932
        }
      }
    },
    {
      "Value": "aliquam",
      "StrippedValue": "nesciunt",
      "Description": "Innovative multi-tasking strategy",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 932
        }
      }
    }
  ],
  "CreatedDate": "2015-12-26T16:48:30.324934+01:00",
  "UpdatedDate": "2006-11-08T16:48:30.324934+01:00",
  "Description": "Diverse contextually-based budgetary management",
  "Postit": "alias",
  "CreatedBy": {
    "AssociateId": 341,
    "Name": "Lebsack-Schuppe",
    "PersonId": 688,
    "Rank": 623,
    "Tooltip": "asperiores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 851,
    "FullName": "Magdalen Rau",
    "FormalName": "Hayes Group",
    "Deleted": false,
    "EjUserId": 240,
    "UserName": "Hessel, Macejkovic and Mohr",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 528
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 498,
    "Name": "Wiegand, Russel and Buckridge",
    "PersonId": 726,
    "Rank": 139,
    "Tooltip": "architecto",
    "Type": "AnonymousAssociate",
    "GroupIdx": 664,
    "FullName": "Kenya Hayes",
    "FormalName": "Howell, Runte and Armstrong",
    "Deleted": false,
    "EjUserId": 22,
    "UserName": "Quigley-Stark",
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
  "Associate": {
    "AssociateId": 45,
    "Name": "Renner-Rowe",
    "PersonId": 556,
    "Rank": 980,
    "Tooltip": "quia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 47,
    "FullName": "Muriel Volkman IV",
    "FormalName": "Corkery Group",
    "Deleted": true,
    "EjUserId": 833,
    "UserName": "Jacobson, Kreiger and D'Amore",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 824
      }
    }
  },
  "ProjectStatus": {
    "Id": 1001,
    "Value": "aut",
    "Tooltip": "odit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 136
      }
    }
  },
  "ProjectType": {
    "Id": 346,
    "Value": "odit",
    "Tooltip": "voluptate",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 639
      }
    }
  },
  "HasImage": true,
  "ImageDescription": "Synergistic hybrid functionalities",
  "ActiveStatusMonitorId": 562,
  "Links": [
    {
      "EntityName": "Harber Group",
      "Id": 320,
      "Description": "Visionary leading edge definition",
      "ExtraInfo": "repudiandae",
      "LinkId": 365,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "harness best-of-breed infomediaries"
          },
          "FieldType": "System.Int32",
          "FieldLength": 610
        }
      }
    }
  ],
  "ActiveLinks": 585,
  "Completed": true,
  "NextMilestoneDate": "2021-01-27T16:48:30.3259393+01:00",
  "NmdAppointmentId": 804,
  "EndDate": "1998-01-21T16:48:30.3259393+01:00",
  "ActiveErpLinks": 159,
  "UserDefinedFields": {
    "SuperOffice:1": "Adolph Shields I",
    "SuperOffice:2": "704117017"
  },
  "ExtraFields": {
    "ExtraFields1": "laborum",
    "ExtraFields2": "officiis"
  },
  "CustomFields": {
    "CustomFields1": "enim",
    "CustomFields2": "nisi"
  },
  "PublishEventDate": "2006-09-13T16:48:30.3259393+02:00",
  "PublishTo": "1997-07-24T16:48:30.3259393+02:00",
  "PublishFrom": "2008-10-27T16:48:30.3259393+01:00",
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
      "FieldLength": 653
    }
  }
}
```