---
title: POST Project
id: v1ProjectEntity_PostProjectEntity
---

# POST Project

```http
POST /api/v1/Project
```

Creates a new ProjectEntity

Calls the Project agent service SaveProjectEntity.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Project?$select=name,department,category/id
```


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



ProjectEntity entity with API _Links added.

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
| _Links | object |  |

## Sample Request

```http!
POST /api/v1/Project
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 578,
  "Name": "Casper, Wisozk and Schmitt",
  "ProjectNumber": "950845",
  "ProjectMembers": [
    {
      "ProjectmemberId": 807,
      "ContactId": 238,
      "ProjectId": 170,
      "ContactName": "Stehr Inc and Sons",
      "ContactDepartment": "",
      "ProjectName": "Streich, Hodkiewicz and Roob",
      "EmailId": 144,
      "EmailAddress": "lisa_doyle@hackettboyle.info",
      "CountryId": 336,
      "Firstname": "Hilda",
      "MiddleName": "Schmitt LLC",
      "Lastname": "Hagenes",
      "PersonId": 362,
      "Mrmrs": "ut",
      "ProjectMemberTypeName": "Koelpin, Goodwin and Ziemann",
      "Phone": "1-518-125-3182 x422",
      "PhoneId": 548,
      "ProjectMemberTypeId": 820,
      "EmailAddressName": "pattie_prosacco@moore.co.uk",
      "Comment": "quo",
      "FullName": "Malika Connelly"
    }
  ],
  "Urls": [
    {
      "Value": "inventore",
      "StrippedValue": "deleniti",
      "Description": "Customizable even-keeled access"
    },
    {
      "Value": "inventore",
      "StrippedValue": "deleniti",
      "Description": "Customizable even-keeled access"
    }
  ],
  "CreatedDate": "2004-06-21T15:05:42.4446667+02:00",
  "UpdatedDate": "2014-04-27T15:05:42.4446667+02:00",
  "Description": "Customizable 24 hour help-desk",
  "Postit": "voluptatem",
  "CreatedBy": {
    "AssociateId": 541,
    "Name": "Harvey, Batz and Wuckert",
    "PersonId": 816,
    "Rank": 608,
    "Tooltip": "perferendis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 572,
    "FullName": "Simeon Feest",
    "FormalName": "Marks LLC",
    "Deleted": false,
    "EjUserId": 995,
    "UserName": "Abernathy Group"
  },
  "UpdatedBy": {
    "AssociateId": 398,
    "Name": "Daniel, Wunsch and Lehner",
    "PersonId": 192,
    "Rank": 271,
    "Tooltip": "expedita",
    "Type": "AnonymousAssociate",
    "GroupIdx": 844,
    "FullName": "Rodolfo Brakus",
    "FormalName": "Schmeler LLC",
    "Deleted": false,
    "EjUserId": 534,
    "UserName": "Baumbach Inc and Sons"
  },
  "Associate": {
    "AssociateId": 912,
    "Name": "Kling-Sanford",
    "PersonId": 512,
    "Rank": 700,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 208,
    "FullName": "Melvin Langworth II",
    "FormalName": "Zulauf, Goyette and Jewess",
    "Deleted": false,
    "EjUserId": 376,
    "UserName": "Haag Group"
  },
  "ProjectStatus": {
    "Id": 434,
    "Value": "perferendis",
    "Tooltip": "unde"
  },
  "ProjectType": {
    "Id": 202,
    "Value": "libero",
    "Tooltip": "repellendus"
  },
  "HasImage": true,
  "ImageDescription": "Centralized real-time interface",
  "ActiveStatusMonitorId": 757,
  "Links": [
    {
      "EntityName": "Marks, Smitham and Jenkins",
      "Id": 817,
      "Description": "Proactive dynamic benchmark",
      "ExtraInfo": "soluta",
      "LinkId": 934
    },
    {
      "EntityName": "Marks, Smitham and Jenkins",
      "Id": 817,
      "Description": "Proactive dynamic benchmark",
      "ExtraInfo": "soluta",
      "LinkId": 934
    }
  ],
  "ActiveLinks": 565,
  "Completed": false,
  "NextMilestoneDate": "2018-06-21T15:05:42.4456633+02:00",
  "NmdAppointmentId": 445,
  "EndDate": "2003-05-06T15:05:42.4456633+02:00",
  "ActiveErpLinks": 969,
  "UserDefinedFields": {
    "SuperOffice:1": "1080939804",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "aliquam",
    "ExtraFields2": "corporis"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "incidunt"
  },
  "PublishEventDate": "2014-03-17T15:05:42.4456633+01:00",
  "PublishTo": "2019-01-15T15:05:42.4456633+01:00",
  "PublishFrom": "2008-09-21T15:05:42.4456633+02:00",
  "IsPublished": false
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 543,
  "Name": "Walsh-Krajcik",
  "ProjectNumber": "995203",
  "ProjectMembers": [
    {
      "ProjectmemberId": 329,
      "ContactId": 357,
      "ProjectId": 176,
      "ContactName": "Bergnaum LLC",
      "ContactDepartment": "",
      "ProjectName": "Little-Kassulke",
      "EmailId": 326,
      "EmailAddress": "mekhi.volkman@greenfelder.us",
      "CountryId": 677,
      "Firstname": "Madelyn",
      "MiddleName": "Adams-Franecki",
      "Lastname": "Volkman",
      "PersonId": 285,
      "Mrmrs": "ad",
      "ProjectMemberTypeName": "Daugherty LLC",
      "Phone": "1-455-385-6662 x6002",
      "PhoneId": 247,
      "ProjectMemberTypeId": 402,
      "EmailAddressName": "cale.cummings@hyattosinski.name",
      "Comment": "necessitatibus",
      "FullName": "Candice Rath I",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 813
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "dolorem",
      "StrippedValue": "iusto",
      "Description": "Integrated zero tolerance internet solution",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 750
        }
      }
    },
    {
      "Value": "dolorem",
      "StrippedValue": "iusto",
      "Description": "Integrated zero tolerance internet solution",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 750
        }
      }
    }
  ],
  "CreatedDate": "1995-08-12T15:05:42.4506694+02:00",
  "UpdatedDate": "2017-02-16T15:05:42.4506694+01:00",
  "Description": "Proactive 4th generation open architecture",
  "Postit": "tenetur",
  "CreatedBy": {
    "AssociateId": 891,
    "Name": "Beer Inc and Sons",
    "PersonId": 897,
    "Rank": 660,
    "Tooltip": "consequatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 622,
    "FullName": "Janice Streich",
    "FormalName": "Daugherty-Glover",
    "Deleted": true,
    "EjUserId": 423,
    "UserName": "Hansen Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 455
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 333,
    "Name": "Emard Group",
    "PersonId": 519,
    "Rank": 117,
    "Tooltip": "maxime",
    "Type": "AnonymousAssociate",
    "GroupIdx": 361,
    "FullName": "Nicholas Baumbach",
    "FormalName": "Price, Gaylord and Howe",
    "Deleted": false,
    "EjUserId": 919,
    "UserName": "Kovacek-Kozey",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 526
      }
    }
  },
  "Associate": {
    "AssociateId": 617,
    "Name": "Denesik-Dooley",
    "PersonId": 601,
    "Rank": 650,
    "Tooltip": "soluta",
    "Type": "AnonymousAssociate",
    "GroupIdx": 510,
    "FullName": "Easton Wisozk",
    "FormalName": "Weissnat-Reichert",
    "Deleted": true,
    "EjUserId": 102,
    "UserName": "Larkin-Bergnaum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 368
      }
    }
  },
  "ProjectStatus": {
    "Id": 781,
    "Value": "iusto",
    "Tooltip": "at",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 995
      }
    }
  },
  "ProjectType": {
    "Id": 501,
    "Value": "error",
    "Tooltip": "omnis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 366
      }
    }
  },
  "HasImage": true,
  "ImageDescription": "Focused attitude-oriented intranet",
  "ActiveStatusMonitorId": 414,
  "Links": [
    {
      "EntityName": "Rohan, Breitenberg and Dibbert",
      "Id": 193,
      "Description": "Implemented high-level attitude",
      "ExtraInfo": "aut",
      "LinkId": 834,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 703
        }
      }
    }
  ],
  "ActiveLinks": 710,
  "Completed": false,
  "NextMilestoneDate": "2007-06-17T15:05:42.4516682+02:00",
  "NmdAppointmentId": 455,
  "EndDate": "1994-12-08T15:05:42.4516682+01:00",
  "ActiveErpLinks": 6,
  "UserDefinedFields": {
    "SuperOffice:1": "345953563",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "cumque",
    "ExtraFields2": "sequi"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "ullam"
  },
  "PublishEventDate": "2001-01-17T15:05:42.4516682+01:00",
  "PublishTo": "2015-06-04T15:05:42.4516682+02:00",
  "PublishFrom": "2001-03-05T15:05:42.4516682+01:00",
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
      "FieldLength": 452
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```