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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 244,
  "Name": "Yost-Terry",
  "ProjectNumber": "1179839",
  "ProjectMembers": [
    {
      "ProjectmemberId": 937,
      "ContactId": 482,
      "ProjectId": 208,
      "ContactName": "Abbott, Zulauf and Wuckert",
      "ContactDepartment": "",
      "ProjectName": "Legros, Pacocha and Volkman",
      "EmailId": 979,
      "EmailAddress": "ethan_trantow@sporer.co.uk",
      "CountryId": 646,
      "Firstname": "Danika",
      "MiddleName": "Johnston Inc and Sons",
      "Lastname": "Daniel",
      "PersonId": 314,
      "Mrmrs": "exercitationem",
      "ProjectMemberTypeName": "Hilpert Group",
      "Phone": "(270)554-6575 x070",
      "PhoneId": 973,
      "ProjectMemberTypeId": 665,
      "EmailAddressName": "kristoffer@bartell.us",
      "Comment": "eos",
      "FullName": "Wyatt Shanahan"
    }
  ],
  "Urls": [
    {
      "Value": "enim",
      "StrippedValue": "ut",
      "Description": "Front-line client-server instruction set"
    },
    {
      "Value": "enim",
      "StrippedValue": "ut",
      "Description": "Front-line client-server instruction set"
    }
  ],
  "CreatedDate": "2011-04-18T18:25:50.7978838+02:00",
  "UpdatedDate": "2006-11-12T18:25:50.7978838+01:00",
  "Description": "Reverse-engineered discrete functionalities",
  "Postit": "aut",
  "CreatedBy": {
    "AssociateId": 390,
    "Name": "Nicolas, Bechtelar and Luettgen",
    "PersonId": 920,
    "Rank": 205,
    "Tooltip": "nam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 331,
    "FullName": "Rylan Rempel",
    "FormalName": "Lehner, Swaniawski and Hauck",
    "Deleted": false,
    "EjUserId": 727,
    "UserName": "Haley LLC"
  },
  "UpdatedBy": {
    "AssociateId": 326,
    "Name": "Parker, McCullough and McCullough",
    "PersonId": 115,
    "Rank": 723,
    "Tooltip": "perspiciatis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 67,
    "FullName": "Judd Morissette",
    "FormalName": "Quigley Inc and Sons",
    "Deleted": false,
    "EjUserId": 21,
    "UserName": "Schinner-Wehner"
  },
  "Associate": {
    "AssociateId": 961,
    "Name": "Sauer LLC",
    "PersonId": 17,
    "Rank": 886,
    "Tooltip": "quo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 729,
    "FullName": "Mrs. Elvie Harvey",
    "FormalName": "Hartmann, Mosciski and Lemke",
    "Deleted": false,
    "EjUserId": 418,
    "UserName": "Moen, Schimmel and Hoeger"
  },
  "ProjectStatus": {
    "Id": 436,
    "Value": "repellendus",
    "Tooltip": "est"
  },
  "ProjectType": {
    "Id": 105,
    "Value": "nam",
    "Tooltip": "iure"
  },
  "HasImage": false,
  "ImageDescription": "Grass-roots responsive capacity",
  "ActiveStatusMonitorId": 100,
  "Links": [
    {
      "EntityName": "Hegmann, Skiles and Cummings",
      "Id": 340,
      "Description": "Extended bandwidth-monitored encryption",
      "ExtraInfo": "eum",
      "LinkId": 735
    },
    {
      "EntityName": "Hegmann, Skiles and Cummings",
      "Id": 340,
      "Description": "Extended bandwidth-monitored encryption",
      "ExtraInfo": "eum",
      "LinkId": 735
    }
  ],
  "ActiveLinks": 5,
  "Completed": true,
  "NextMilestoneDate": "2002-07-07T18:25:50.7998835+02:00",
  "NmdAppointmentId": 381,
  "EndDate": "2017-09-03T18:25:50.7998835+02:00",
  "ActiveErpLinks": 355,
  "UserDefinedFields": {
    "SuperOffice:1": "862925116",
    "SuperOffice:2": "Mrs. Bartholome Koepp"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptate",
    "ExtraFields2": "molestiae"
  },
  "CustomFields": {
    "CustomFields1": "occaecati",
    "CustomFields2": "laudantium"
  },
  "PublishEventDate": "2009-12-11T18:25:50.7998835+01:00",
  "PublishTo": "2019-01-06T18:25:50.7998835+01:00",
  "PublishFrom": "2019-12-18T18:25:50.7998835+01:00",
  "IsPublished": false
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 349,
  "Name": "Hand-Murray",
  "ProjectNumber": "1452259",
  "ProjectMembers": [
    {
      "ProjectmemberId": 970,
      "ContactId": 562,
      "ProjectId": 546,
      "ContactName": "Casper Group",
      "ContactDepartment": "",
      "ProjectName": "Greenfelder, Weissnat and Rosenbaum",
      "EmailId": 128,
      "EmailAddress": "madison@bergnaum.co.uk",
      "CountryId": 853,
      "Firstname": "Alize",
      "MiddleName": "Corkery Inc and Sons",
      "Lastname": "McLaughlin",
      "PersonId": 289,
      "Mrmrs": "velit",
      "ProjectMemberTypeName": "Schaden LLC",
      "Phone": "127-105-5766 x382",
      "PhoneId": 504,
      "ProjectMemberTypeId": 462,
      "EmailAddressName": "fern@grady.us",
      "Comment": "ducimus",
      "FullName": "Rene Lebsack",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 641
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "sunt",
      "StrippedValue": "cupiditate",
      "Description": "Proactive secondary core",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 418
        }
      }
    },
    {
      "Value": "sunt",
      "StrippedValue": "cupiditate",
      "Description": "Proactive secondary core",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 418
        }
      }
    }
  ],
  "CreatedDate": "2016-10-15T18:25:50.803884+02:00",
  "UpdatedDate": "2017-05-22T18:25:50.803884+02:00",
  "Description": "Function-based static collaboration",
  "Postit": "sunt",
  "CreatedBy": {
    "AssociateId": 829,
    "Name": "Sporer Group",
    "PersonId": 505,
    "Rank": 230,
    "Tooltip": "laboriosam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 79,
    "FullName": "Judd Murphy",
    "FormalName": "Hammes, Beahan and Wiegand",
    "Deleted": true,
    "EjUserId": 269,
    "UserName": "Stracke, Nolan and Dach",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 962
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 113,
    "Name": "Cartwright-Ward",
    "PersonId": 632,
    "Rank": 753,
    "Tooltip": "sint",
    "Type": "AnonymousAssociate",
    "GroupIdx": 796,
    "FullName": "Ladarius Klocko",
    "FormalName": "Grimes-Wiegand",
    "Deleted": true,
    "EjUserId": 183,
    "UserName": "Stark, Larson and Stracke",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 926
      }
    }
  },
  "Associate": {
    "AssociateId": 37,
    "Name": "Deckow Inc and Sons",
    "PersonId": 1001,
    "Rank": 932,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 726,
    "FullName": "Caleb Powlowski",
    "FormalName": "Runte, Wolff and Ankunding",
    "Deleted": true,
    "EjUserId": 42,
    "UserName": "Schowalter-Harber",
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
  "ProjectStatus": {
    "Id": 171,
    "Value": "odio",
    "Tooltip": "et",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 718
      }
    }
  },
  "ProjectType": {
    "Id": 638,
    "Value": "enim",
    "Tooltip": "reiciendis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 574
      }
    }
  },
  "HasImage": true,
  "ImageDescription": "Adaptive human-resource utilisation",
  "ActiveStatusMonitorId": 84,
  "Links": [
    {
      "EntityName": "Stark-Stracke",
      "Id": 336,
      "Description": "Up-sized background orchestration",
      "ExtraInfo": "corrupti",
      "LinkId": 22,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 828
        }
      }
    }
  ],
  "ActiveLinks": 759,
  "Completed": true,
  "NextMilestoneDate": "1994-09-06T18:25:50.8058836+02:00",
  "NmdAppointmentId": 813,
  "EndDate": "1994-10-24T18:25:50.8058836+02:00",
  "ActiveErpLinks": 58,
  "UserDefinedFields": {
    "SuperOffice:1": "Jacques Berge",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "atque",
    "ExtraFields2": "dolor"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "in"
  },
  "PublishEventDate": "2004-07-17T18:25:50.8058836+02:00",
  "PublishTo": "2010-08-05T18:25:50.8058836+02:00",
  "PublishFrom": "2010-10-03T18:25:50.8058836+02:00",
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
      "FieldLength": 220
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```