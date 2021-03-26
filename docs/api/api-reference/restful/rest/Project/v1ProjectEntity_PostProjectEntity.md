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
  "ProjectId": 548,
  "Name": "Jones Group",
  "ProjectNumber": "1052078",
  "ProjectMembers": [
    {
      "ProjectmemberId": 999,
      "ContactId": 263,
      "ProjectId": 657,
      "ContactName": "Nicolas Group",
      "ContactDepartment": "",
      "ProjectName": "Rogahn LLC",
      "EmailId": 382,
      "EmailAddress": "kristy@fritsch.com",
      "CountryId": 577,
      "Firstname": "Hunter",
      "MiddleName": "Schoen, Cartwright and Streich",
      "Lastname": "Hamill",
      "PersonId": 713,
      "Mrmrs": "rerum",
      "ProjectMemberTypeName": "Heathcote, Carroll and Leffler",
      "Phone": "381-173-6118",
      "PhoneId": 954,
      "ProjectMemberTypeId": 878,
      "EmailAddressName": "troy.reynolds@kubbaumbach.info",
      "Comment": "itaque",
      "FullName": "Selena Huel"
    }
  ],
  "Urls": [
    {
      "Value": "perspiciatis",
      "StrippedValue": "ab",
      "Description": "Multi-channelled user-facing migration"
    },
    {
      "Value": "perspiciatis",
      "StrippedValue": "ab",
      "Description": "Multi-channelled user-facing migration"
    }
  ],
  "CreatedDate": "2018-10-28T09:40:59.4467885+01:00",
  "UpdatedDate": "2016-06-26T09:40:59.4467885+02:00",
  "Description": "Seamless mobile algorithm",
  "Postit": "labore",
  "CreatedBy": {
    "AssociateId": 750,
    "Name": "Flatley, Quigley and Schoen",
    "PersonId": 171,
    "Rank": 992,
    "Tooltip": "assumenda",
    "Type": "AnonymousAssociate",
    "GroupIdx": 154,
    "FullName": "Dr. Antonietta Parisian",
    "FormalName": "Jakubowski, Kuphal and Graham",
    "Deleted": false,
    "EjUserId": 486,
    "UserName": "Rohan, Conroy and Pfannerstill"
  },
  "UpdatedBy": {
    "AssociateId": 61,
    "Name": "Schaefer LLC",
    "PersonId": 162,
    "Rank": 417,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 297,
    "FullName": "Mr. Daphne O'Hara",
    "FormalName": "Jacobson, Okuneva and Rutherford",
    "Deleted": true,
    "EjUserId": 901,
    "UserName": "Bode-Lynch"
  },
  "Associate": {
    "AssociateId": 410,
    "Name": "Hintz Inc and Sons",
    "PersonId": 747,
    "Rank": 286,
    "Tooltip": "pariatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 104,
    "FullName": "Miss Rosina Doyle",
    "FormalName": "Monahan Inc and Sons",
    "Deleted": true,
    "EjUserId": 579,
    "UserName": "Sanford-O'Hara"
  },
  "ProjectStatus": {
    "Id": 828,
    "Value": "pariatur",
    "Tooltip": "eum"
  },
  "ProjectType": {
    "Id": 827,
    "Value": "ut",
    "Tooltip": "ut"
  },
  "HasImage": false,
  "ImageDescription": "Reverse-engineered exuding collaboration",
  "ActiveStatusMonitorId": 787,
  "Links": [
    {
      "EntityName": "Wilkinson Inc and Sons",
      "Id": 495,
      "Description": "Monitored web-enabled toolset",
      "ExtraInfo": "et",
      "LinkId": 859
    },
    {
      "EntityName": "Wilkinson Inc and Sons",
      "Id": 495,
      "Description": "Monitored web-enabled toolset",
      "ExtraInfo": "et",
      "LinkId": 859
    }
  ],
  "ActiveLinks": 202,
  "Completed": true,
  "NextMilestoneDate": "2016-10-04T09:40:59.447664+02:00",
  "NmdAppointmentId": 223,
  "EndDate": "2008-12-25T09:40:59.447664+01:00",
  "ActiveErpLinks": 762,
  "UserDefinedFields": {
    "SuperOffice:1": "1682443606",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "dolorem",
    "ExtraFields2": "non"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "tempore"
  },
  "PublishEventDate": "2000-03-02T09:40:59.447664+01:00",
  "PublishTo": "2018-10-15T09:40:59.447664+02:00",
  "PublishFrom": "1998-09-12T09:40:59.447664+02:00",
  "IsPublished": true
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 926,
  "Name": "Cummerata-Purdy",
  "ProjectNumber": "844352",
  "ProjectMembers": [
    {
      "ProjectmemberId": 881,
      "ContactId": 871,
      "ProjectId": 324,
      "ContactName": "Hand-Reichel",
      "ContactDepartment": "",
      "ProjectName": "Hills-Strosin",
      "EmailId": 531,
      "EmailAddress": "leo@weissnat.com",
      "CountryId": 885,
      "Firstname": "Antwan",
      "MiddleName": "Wisozk-Rau",
      "Lastname": "Lemke",
      "PersonId": 703,
      "Mrmrs": "nisi",
      "ProjectMemberTypeName": "Roberts, Cummerata and Gaylord",
      "Phone": "1-886-735-7341",
      "PhoneId": 992,
      "ProjectMemberTypeId": 871,
      "EmailAddressName": "madaline.hahn@heller.info",
      "Comment": "veniam",
      "FullName": "Cara Schaefer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 870
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "sed",
      "StrippedValue": "reprehenderit",
      "Description": "Inverse next generation analyzer",
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
    {
      "Value": "sed",
      "StrippedValue": "reprehenderit",
      "Description": "Inverse next generation analyzer",
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
    }
  ],
  "CreatedDate": "2006-10-19T09:40:59.452663+02:00",
  "UpdatedDate": "2006-12-18T09:40:59.452663+01:00",
  "Description": "Devolved zero administration software",
  "Postit": "quae",
  "CreatedBy": {
    "AssociateId": 373,
    "Name": "Bayer LLC",
    "PersonId": 944,
    "Rank": 337,
    "Tooltip": "quibusdam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 818,
    "FullName": "Kelley Schaefer",
    "FormalName": "Wolff Group",
    "Deleted": true,
    "EjUserId": 787,
    "UserName": "Keeling Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 128
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 696,
    "Name": "Greenholt-Murphy",
    "PersonId": 104,
    "Rank": 934,
    "Tooltip": "beatae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 234,
    "FullName": "Remington Heller",
    "FormalName": "Gorczany Inc and Sons",
    "Deleted": false,
    "EjUserId": 91,
    "UserName": "Howell LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "deliver next-generation deliverables"
        },
        "FieldType": "System.Int32",
        "FieldLength": 590
      }
    }
  },
  "Associate": {
    "AssociateId": 278,
    "Name": "Renner, Runolfsdottir and Klocko",
    "PersonId": 270,
    "Rank": 250,
    "Tooltip": "sit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 518,
    "FullName": "Giovanna Kris",
    "FormalName": "Armstrong, Murphy and Stoltenberg",
    "Deleted": true,
    "EjUserId": 526,
    "UserName": "Hermann, Murphy and Lowe",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 955
      }
    }
  },
  "ProjectStatus": {
    "Id": 384,
    "Value": "temporibus",
    "Tooltip": "quod",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 503
      }
    }
  },
  "ProjectType": {
    "Id": 585,
    "Value": "vitae",
    "Tooltip": "rem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 351
      }
    }
  },
  "HasImage": false,
  "ImageDescription": "Digitized radical benchmark",
  "ActiveStatusMonitorId": 920,
  "Links": [
    {
      "EntityName": "Price, Orn and Mohr",
      "Id": 923,
      "Description": "Devolved client-server policy",
      "ExtraInfo": "aut",
      "LinkId": 296,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 179
        }
      }
    }
  ],
  "ActiveLinks": 146,
  "Completed": false,
  "NextMilestoneDate": "2002-08-31T09:40:59.4536627+02:00",
  "NmdAppointmentId": 988,
  "EndDate": "2007-03-06T09:40:59.4536627+01:00",
  "ActiveErpLinks": 48,
  "UserDefinedFields": {
    "SuperOffice:1": "2108858973",
    "SuperOffice:2": "1095717661"
  },
  "ExtraFields": {
    "ExtraFields1": "amet",
    "ExtraFields2": "soluta"
  },
  "CustomFields": {
    "CustomFields1": "veniam",
    "CustomFields2": "magnam"
  },
  "PublishEventDate": "1998-07-23T09:40:59.4536627+02:00",
  "PublishTo": "1998-12-10T09:40:59.4536627+01:00",
  "PublishFrom": "2003-09-22T09:40:59.4536627+02:00",
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
      "FieldLength": 104
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```