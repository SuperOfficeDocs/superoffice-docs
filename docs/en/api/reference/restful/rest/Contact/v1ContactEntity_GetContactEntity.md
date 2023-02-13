---
title: GET Contact/{id}
uid: v1ContactEntity_GetContactEntity
---

# GET Contact/{id}

```http
GET /api/v1/Contact/{id}
```

Gets a ContactEntity object.


Calls the Contact agent service GetContactEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the ContactEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |
| fk | bool |  Load foreign keys on this entity into the ExtraFields property as 'app.device.keyname'='123' pairs. |

```http
GET /api/v1/Contact/{id}?$select=name,department,category/id
GET /api/v1/Contact/{id}?fk=False
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


## Response:

ContactEntity found.

| Response | Description |
|----------------|-------------|
| 200 | ContactEntity found. |
| 304 | ContactEntity has not changed since the requested If-Modified-Since date. |
| 404 | Not Found. |

### Response body: ContactEntityWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 | Primary key |
| Name | string | Contact name |
| Department | string | Department |
| OrgNr | string | VAT number or similar |
| Number1 | string | Alphanumeric user field |
| Number2 | string | Alphanumeric user field |
| UpdatedDate | date-time | Date last updated  in UTC. |
| CreatedDate | date-time | Date registered  in UTC. |
| Emails | array | The contact's email |
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample request

```http!
GET /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Mon, 16 Feb 2009 11:22:44 G2T

{
  "ContactId": 558,
  "Name": "Koss-Jenkins",
  "Department": "strategize out-of-the-box e-business",
  "OrgNr": "1139792",
  "Number1": "386519",
  "Number2": "927749",
  "UpdatedDate": "2009-02-16T11:22:44.4913885+01:00",
  "CreatedDate": "2018-04-12T11:22:44.4913885+02:00",
  "Emails": [
    {
      "Value": "eius",
      "StrippedValue": "enim",
      "Description": "Cloned empowering paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 149
        }
      }
    },
    {
      "Value": "eius",
      "StrippedValue": "enim",
      "Description": "Cloned empowering paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 149
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 179,
      "Name": "Thiel Group",
      "ToolTip": "Expedita quia.",
      "Deleted": false,
      "Rank": 664,
      "Type": "nesciunt",
      "ColorBlock": 172,
      "IconHint": "non",
      "Selected": false,
      "LastChanged": "2012-05-02T11:22:44.4913885+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "minima",
      "StyleHint": "repellendus",
      "Hidden": false,
      "FullName": "Keira Schulist",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 884
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "illo",
      "StrippedValue": "doloribus",
      "Description": "Visionary neutral array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 114
        }
      }
    },
    {
      "Value": "illo",
      "StrippedValue": "doloribus",
      "Description": "Visionary neutral array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 114
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "inventore",
      "StrippedValue": "minima",
      "Description": "Profound logistical Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 417
        }
      }
    },
    {
      "Value": "inventore",
      "StrippedValue": "minima",
      "Description": "Profound logistical Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 417
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "dolore",
      "StrippedValue": "sapiente",
      "Description": "Expanded maximized access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 7
        }
      }
    },
    {
      "Value": "dolore",
      "StrippedValue": "sapiente",
      "Description": "Expanded maximized access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 7
        }
      }
    }
  ],
  "Description": "Secured value-added instruction set",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "aut",
      "PersonId": 189,
      "Mrmrs": "velit",
      "Firstname": "Carmela",
      "Lastname": "King",
      "MiddleName": "Johns-Ruecker",
      "Title": "consequatur",
      "Description": "Multi-lateral content-based middleware",
      "Email": "mya@beier.biz",
      "FullName": "Miss Halie Kenneth Haag IV",
      "DirectPhone": "1-766-100-4610 x1828",
      "FormalName": "Kiehn, Reinger and Wolf",
      "CountryId": 633,
      "ContactId": 689,
      "ContactName": "Altenwerth-Hettinger",
      "Retired": 564,
      "Rank": 878,
      "ActiveInterests": 290,
      "ContactDepartment": "",
      "ContactCountryId": 391,
      "ContactOrgNr": "877522",
      "FaxPhone": "(488)883-9885 x7656",
      "MobilePhone": "(370)576-4074 x964",
      "ContactPhone": "1-961-769-9211 x1895",
      "AssociateName": "Quitzon-Oberbrunner",
      "AssociateId": 673,
      "UsePersonAddress": false,
      "ContactFax": "omnis",
      "Kanafname": "reiciendis",
      "Kanalname": "atque",
      "Post1": "aut",
      "Post2": "vel",
      "Post3": "praesentium",
      "EmailName": "tyrese@hamill.name",
      "ContactFullName": "Mrs. Brain Vivien Schmitt I",
      "ActiveErpLinks": 630,
      "TicketPriorityId": 209,
      "SupportLanguageId": 443,
      "SupportAssociateId": 435,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 944
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "minima",
  "Xstop": false,
  "ActiveInterests": 419,
  "GroupId": 478,
  "ActiveStatusMonitorId": 301,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 18,
  "DbiAgentId": 897,
  "DbiLastSyncronized": "2022-05-30T11:22:44.4913885+02:00",
  "DbiKey": "aut",
  "DbiLastModified": "2009-03-05T11:22:44.4913885+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 673,
  "ActiveErpLinks": 695,
  "BounceEmails": [
    "janet@haley.ca",
    "domenick@rodriguez.name"
  ],
  "Domains": [
    "officiis",
    "ex"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Theresa Abbott",
    "SuperOffice:2": "Mrs. Meagan Johns V"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "provident"
  },
  "CustomFields": {
    "CustomFields1": "quis",
    "CustomFields2": "incidunt"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 395
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```