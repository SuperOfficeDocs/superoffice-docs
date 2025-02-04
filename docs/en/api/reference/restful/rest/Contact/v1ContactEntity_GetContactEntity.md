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
GET /api/v1/Contact/{id}?fk=True
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
| Interests | array | The contact's available and selected interests.  Use MDO List name "contint" to get list items. |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  Use MDO List name "associate" to get list items. |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  Use MDO List name "business" to get list items. |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  Use MDO List name "category" to get list items. |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  Use MDO List name "country" to get list items. |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the Person Agent. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered.  Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
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
Last-Modified: Wed, 04 Dec 2013 13:13:31 G12T

{
  "ContactId": 762,
  "Name": "Weber Inc and Sons",
  "Department": "",
  "OrgNr": "945933",
  "Number1": "322080",
  "Number2": "1183598",
  "UpdatedDate": "2013-12-04T13:13:31.5114093+01:00",
  "CreatedDate": "2005-02-26T13:13:31.5114093+01:00",
  "Emails": [
    {
      "Value": "tempore",
      "StrippedValue": "est",
      "Description": "Advanced composite architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 324
        }
      }
    },
    {
      "Value": "tempore",
      "StrippedValue": "est",
      "Description": "Advanced composite architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 324
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 860,
      "Name": "Erdman LLC",
      "ToolTip": "Aspernatur cumque laboriosam dolor fuga eveniet.",
      "Deleted": false,
      "Rank": 298,
      "Type": "necessitatibus",
      "ColorBlock": 786,
      "IconHint": "quia",
      "Selected": true,
      "LastChanged": "2014-10-30T13:13:31.5114093+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dignissimos",
      "StyleHint": "vero",
      "Hidden": true,
      "FullName": "Cleta Gaylord",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 170
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "velit",
      "StrippedValue": "non",
      "Description": "Multi-channelled executive success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 977
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "non",
      "Description": "Multi-channelled executive success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 977
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quas",
      "StrippedValue": "voluptatem",
      "Description": "Polarised eco-centric adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 432
        }
      }
    },
    {
      "Value": "quas",
      "StrippedValue": "voluptatem",
      "Description": "Polarised eco-centric adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 432
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "fugit",
      "StrippedValue": "deleniti",
      "Description": "Organized composite data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 771
        }
      }
    },
    {
      "Value": "fugit",
      "StrippedValue": "deleniti",
      "Description": "Organized composite data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 771
        }
      }
    }
  ],
  "Description": "Re-contextualized 3rd generation initiative",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "sint",
      "PersonId": 200,
      "Mrmrs": "aperiam",
      "Firstname": "Otto",
      "Lastname": "Renner",
      "MiddleName": "Walter, Dooley and Sporer",
      "Title": "iusto",
      "Description": "Implemented bifurcated monitoring",
      "Email": "joanie@erdmannikolaus.ca",
      "FullName": "Delilah Homenick II",
      "DirectPhone": "419-239-4058 x4574",
      "FormalName": "Pagac Group",
      "CountryId": 869,
      "ContactId": 531,
      "ContactName": "Luettgen Group",
      "Retired": 246,
      "Rank": 445,
      "ActiveInterests": 931,
      "ContactDepartment": "",
      "ContactCountryId": 751,
      "ContactOrgNr": "1069214",
      "FaxPhone": "046-427-6740 x050",
      "MobilePhone": "518-303-8729 x54969",
      "ContactPhone": "(639)253-9024 x373",
      "AssociateName": "Keeling, Glover and Lubowitz",
      "AssociateId": 436,
      "UsePersonAddress": true,
      "ContactFax": "non",
      "Kanafname": "sed",
      "Kanalname": "ratione",
      "Post1": "consequatur",
      "Post2": "recusandae",
      "Post3": "est",
      "EmailName": "jordy.fahey@price.com",
      "ContactFullName": "Maude Pansy Bode I",
      "ActiveErpLinks": 870,
      "TicketPriorityId": 586,
      "SupportLanguageId": 170,
      "SupportAssociateId": 907,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 489
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "ut",
  "Xstop": true,
  "ActiveInterests": 636,
  "GroupId": 851,
  "ActiveStatusMonitorId": 422,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 367,
  "DbiAgentId": 677,
  "DbiLastSyncronized": "2016-03-16T13:13:31.5114093+01:00",
  "DbiKey": "eaque",
  "DbiLastModified": "1999-05-19T13:13:31.5114093+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 495,
  "ActiveErpLinks": 976,
  "BounceEmails": [
    "richmond@spinka.biz",
    "gerson@schowalter.biz"
  ],
  "Domains": [
    "recusandae",
    "earum"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Janessa Kohler Sr."
  },
  "ExtraFields": {
    "ExtraFields1": "quasi",
    "ExtraFields2": "quia"
  },
  "CustomFields": {
    "CustomFields1": "eveniet",
    "CustomFields2": "id"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 575
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```