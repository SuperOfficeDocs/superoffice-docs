---
title: GET Contact/{id}
uid: v1ContactEntity_GetContactEntity
generated: true
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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
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
Last-Modified: Sat, 13 May 2017 16:00:47 G5T

{
  "ContactId": 518,
  "Name": "Okuneva LLC",
  "Department": "",
  "OrgNr": "1148947",
  "Number1": "541001",
  "Number2": "688394",
  "UpdatedDate": "2017-05-13T16:00:47.7428547+02:00",
  "CreatedDate": "2005-12-21T16:00:47.7428547+01:00",
  "Emails": [
    {
      "Value": "perspiciatis",
      "StrippedValue": "qui",
      "Description": "Persistent motivating algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 139
        }
      }
    },
    {
      "Value": "perspiciatis",
      "StrippedValue": "qui",
      "Description": "Persistent motivating algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 139
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 546,
      "Name": "VonRueden-Kshlerin",
      "ToolTip": "Alias praesentium illo qui exercitationem officiis tempore.",
      "Deleted": false,
      "Rank": 170,
      "Type": "ullam",
      "ColorBlock": 23,
      "IconHint": "doloremque",
      "Selected": true,
      "LastChanged": "2002-05-16T16:00:47.7428547+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "numquam",
      "StyleHint": "earum",
      "Hidden": false,
      "FullName": "Ewald Daugherty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 832
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "amet",
      "StrippedValue": "cupiditate",
      "Description": "Team-oriented bi-directional moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 985
        }
      }
    },
    {
      "Value": "amet",
      "StrippedValue": "cupiditate",
      "Description": "Team-oriented bi-directional moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 985
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "repellendus",
      "StrippedValue": "quis",
      "Description": "Grass-roots 5th generation concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 706
        }
      }
    },
    {
      "Value": "repellendus",
      "StrippedValue": "quis",
      "Description": "Grass-roots 5th generation concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 706
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "quos",
      "Description": "Streamlined clear-thinking knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 243
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "quos",
      "Description": "Streamlined clear-thinking knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 243
        }
      }
    }
  ],
  "Description": "Polarised foreground process improvement",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "in",
      "PersonId": 498,
      "Mrmrs": "incidunt",
      "Firstname": "Violette",
      "Lastname": "Maggio",
      "MiddleName": "Gaylord, Adams and Russel",
      "Title": "quam",
      "Description": "Persistent background open architecture",
      "Email": "estelle@bednar.info",
      "FullName": "Duane Daugherty",
      "DirectPhone": "647.410.0078 x602",
      "FormalName": "Heathcote-Howell",
      "CountryId": 668,
      "ContactId": 385,
      "ContactName": "Mitchell-Dooley",
      "Retired": 554,
      "Rank": 404,
      "ActiveInterests": 860,
      "ContactDepartment": "",
      "ContactCountryId": 765,
      "ContactOrgNr": "936443",
      "FaxPhone": "1-837-291-7702 x323",
      "MobilePhone": "058.165.1976",
      "ContactPhone": "120.553.3687 x717",
      "AssociateName": "Gislason Inc and Sons",
      "AssociateId": 72,
      "UsePersonAddress": false,
      "ContactFax": "eos",
      "Kanafname": "veritatis",
      "Kanalname": "ut",
      "Post1": "et",
      "Post2": "ratione",
      "Post3": "non",
      "EmailName": "jacky.bode@tremblaytillman.biz",
      "ContactFullName": "Estell Stokes",
      "ActiveErpLinks": 333,
      "TicketPriorityId": 203,
      "SupportLanguageId": 345,
      "SupportAssociateId": 217,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 467
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "excepturi",
  "Xstop": false,
  "ActiveInterests": 701,
  "GroupId": 787,
  "ActiveStatusMonitorId": 30,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 355,
  "DbiAgentId": 570,
  "DbiLastSyncronized": "1998-07-01T16:00:47.7428547+02:00",
  "DbiKey": "doloribus",
  "DbiLastModified": "2022-06-03T16:00:47.7428547+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 703,
  "ActiveErpLinks": 496,
  "BounceEmails": [
    "violet@beier.us",
    "wilmer@senger.com"
  ],
  "Domains": [
    "repellat",
    "quis"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "1546892464"
  },
  "ExtraFields": {
    "ExtraFields1": "assumenda",
    "ExtraFields2": "veritatis"
  },
  "CustomFields": {
    "CustomFields1": "dignissimos",
    "CustomFields2": "ipsa"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 160
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```