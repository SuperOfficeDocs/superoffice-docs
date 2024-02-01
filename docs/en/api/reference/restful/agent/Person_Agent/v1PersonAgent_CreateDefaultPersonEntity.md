---
title: POST Agents/Person/CreateDefaultPersonEntity
uid: v1PersonAgent_CreateDefaultPersonEntity
generated: true
---

# POST Agents/Person/CreateDefaultPersonEntity

```http
POST /api/v1/Agents/Person/CreateDefaultPersonEntity
```

Set default values into a new PersonEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance







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

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PersonEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | int32 | Primary key |
| Firstname | string | First name |
| MiddleName | string | Middle name or 'van' etc. |
| Lastname | string | Last name |
| Mrmrs | string | e.g. Mrs   sex_title  <para>Use MDO List name "mrmrs" to get list items.</para> |
| Title | string | Title |
| UpdatedDate | date-time | Last updated date  in UTC. |
| CreatedDate | date-time | Registered date  in UTC. |
| BirthDate | date-time | The Person birth date as UTC Date. Year 1 = Null. Year 2 = unknown year. |
| CreatedBy | Associate | The user that created the person object |
| Emails | array | A collection of the person's emails |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| IsAssociate | bool | Checks if the person object is an associate. The property is read-only. |
| PrivatePhones | array | Returns a collection of phone numbers that belong to the contact person. |
| Faxes | array | Returns a collection of fax numbers that belong to the contact person. |
| MobilePhones | array | Returns a collection of mobile phone numbers that belong to the contact person. |
| OfficePhones | array | Returns a collection of office phone numbers that belong to the contact person. |
| OtherPhones | array | Returns a collection of pagers that belong to the contact person. |
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  <para>Use MDO List name "perspos" to get list items.</para> |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  <para>Use MDO List name "contact_new" to get list items.</para> |
| Country | Country | The country this contact person is located in.  <para>Use MDO List name "country" to get list items.</para> |
| Interests | array | The person's available and selected interests.  <para>Use MDO List name "persint" to get list items.</para> |
| PersonNumber | string | Alphanumeric user field |
| FullName | string | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| NoMailing | bool | Spam filter. Indicates if this person should retrieve advertising. |
| UsePersonAddress | bool | True if the person's address should be used as mailing address, instead of the contact's address. |
| Retired | bool | True if the user is retired and should have no rights, not appear in lists, etc. |
| Urls | array | The urls related to this person. |
| FormalName | string | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| Address | Address | Structure holding formatted address data. The layout of the array structure indicates the layout of the localized address. |
| Post3 | string | Postal address, used in Japanese versions only |
| Post2 | string | Postal address, used in Japanese versions only |
| Post1 | string | Postal address, used in Japanese versions only |
| Kanalname | string | Kana last name, used in Japanese versions only |
| Kanafname | string | Kana first name, used in Japanese versions only |
| CorrespondingAssociate | Associate | The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user). |
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "category" to get list items.</para> |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "business" to get list items.</para> |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  <para>Use MDO List name "associate" to get list items.</para> |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  <para>Use MDO List name "salutation" to get list items.</para> |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | <para>Use MDO List name "customerlanguage" to get list items.</para> |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| DbiLastSyncronized | date-time | Last external syncronization. |
| SentInfo | int32 | Has information on username/password been sent (ejournal) |
| ShowContactTickets | int32 | Should tickets related to the company be shown to this person |
| UserInfo | UserInfo | Information about the user if this person is a user.  If IsAssociate (e.g. is user is true) the UserInfo will be provided. |
| ChatEmails | array |  |
| InternetPhones | array |  |
| Source | int32 | How did we get this person? For future integration needs |
| ActiveErpLinks | int32 | How many active ERP links are there for this person? |
| ShipmentTypes | array | The person's available and selected shipment types. |
| Consents | array | The person's available consent information. Missing consents are not deleted. To remove a consent, mark its legalbase as 'WITHDRAWN' |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for person |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Person/CreateDefaultPersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 816,
  "Firstname": "Veda",
  "MiddleName": "Bayer Group",
  "Lastname": "Ziemann",
  "Mrmrs": "et",
  "Title": "non",
  "UpdatedDate": "2008-01-27T23:03:56.3726236+01:00",
  "CreatedDate": "2002-08-07T23:03:56.3726236+02:00",
  "BirthDate": "2021-03-30T23:03:56.3726236+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "omnis",
      "StrippedValue": "ut",
      "Description": "Team-oriented needs-based toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 668
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "ut",
      "Description": "Team-oriented needs-based toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 668
        }
      }
    }
  ],
  "Description": "Object-based object-oriented ability",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "enim",
      "StrippedValue": "voluptates",
      "Description": "Reduced secondary middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 511
        }
      }
    },
    {
      "Value": "enim",
      "StrippedValue": "voluptates",
      "Description": "Reduced secondary middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 511
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "voluptatem",
      "StrippedValue": "doloribus",
      "Description": "User-friendly mission-critical conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 664
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "doloribus",
      "Description": "User-friendly mission-critical conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 664
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "aspernatur",
      "StrippedValue": "assumenda",
      "Description": "Total solution-oriented encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 267
        }
      }
    },
    {
      "Value": "aspernatur",
      "StrippedValue": "assumenda",
      "Description": "Total solution-oriented encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 267
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "ipsa",
      "StrippedValue": "quis",
      "Description": "Programmable responsive project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 587
        }
      }
    },
    {
      "Value": "ipsa",
      "StrippedValue": "quis",
      "Description": "Programmable responsive project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 587
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "eos",
      "StrippedValue": "est",
      "Description": "Cross-platform foreground strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 888
        }
      }
    },
    {
      "Value": "eos",
      "StrippedValue": "est",
      "Description": "Cross-platform foreground strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 888
        }
      }
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 335,
      "Name": "Stroman Group",
      "ToolTip": "Illum maiores velit incidunt.",
      "Deleted": false,
      "Rank": 220,
      "Type": "enim",
      "ColorBlock": 692,
      "IconHint": "nostrum",
      "Selected": true,
      "LastChanged": "2002-01-29T23:03:56.3761291+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "fugiat",
      "StyleHint": "voluptas",
      "Hidden": true,
      "FullName": "Abigail Barrows",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 206
        }
      }
    }
  ],
  "PersonNumber": "612690",
  "FullName": "Roscoe Johns",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "illo",
      "StrippedValue": "soluta",
      "Description": "Profit-focused user-facing hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 213
        }
      }
    },
    {
      "Value": "illo",
      "StrippedValue": "soluta",
      "Description": "Profit-focused user-facing hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 213
        }
      }
    }
  ],
  "FormalName": "Cruickshank-Durgan",
  "Address": null,
  "Post3": "cumque",
  "Post2": "possimus",
  "Post1": "tempora",
  "Kanalname": "ea",
  "Kanafname": "consequuntur",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "consequatur",
  "ActiveInterests": 867,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 448,
  "DbiKey": "reiciendis",
  "DbiLastModified": "2019-02-08T23:03:56.3781233+01:00",
  "DbiLastSyncronized": "2012-12-29T23:03:56.3781233+01:00",
  "SentInfo": 177,
  "ShowContactTickets": 797,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "quaerat",
      "StrippedValue": "natus",
      "Description": "Persevering system-worthy extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 614
        }
      }
    },
    {
      "Value": "quaerat",
      "StrippedValue": "natus",
      "Description": "Persevering system-worthy extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 614
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "error",
      "StrippedValue": "et",
      "Description": "Configurable dynamic superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 301
        }
      }
    },
    {
      "Value": "error",
      "StrippedValue": "et",
      "Description": "Configurable dynamic superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 301
        }
      }
    }
  ],
  "Source": 213,
  "ActiveErpLinks": 944,
  "ShipmentTypes": [
    {
      "Id": 556,
      "Name": "Witting-Parker",
      "ToolTip": "Rem ea est.",
      "Deleted": true,
      "Rank": 886,
      "Type": "quia",
      "ColorBlock": 671,
      "IconHint": "consequuntur",
      "Selected": false,
      "LastChanged": "2022-04-05T23:03:56.3786233+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolorem",
      "StyleHint": "itaque",
      "Hidden": false,
      "FullName": "Dana Tromp",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 821
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 661,
      "Comment": "et",
      "Registered": "2004-04-05T23:03:56.3786233+02:00",
      "RegisteredAssociateId": 910,
      "Updated": "1998-03-29T23:03:56.3786233+02:00",
      "UpdatedAssociateId": 571,
      "LegalBaseId": 426,
      "LegalBaseKey": "asperiores",
      "LegalBaseName": "Walker-Keeling",
      "ConsentPurposeId": 740,
      "ConsentPurposeKey": "ut",
      "ConsentPurposeName": "Grady-Harber",
      "ConsentSourceId": 704,
      "ConsentSourceKey": "rem",
      "ConsentSourceName": "Fisher, Koepp and Langworth",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 217
        }
      }
    }
  ],
  "BounceEmails": [
    "declan@oberbrunnergerlach.uk",
    "salvador@torphywolff.co.uk"
  ],
  "ActiveStatusMonitorId": 976,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "Ms. Lauriane Ellis Cummerata V"
  },
  "ExtraFields": {
    "ExtraFields1": "ullam",
    "ExtraFields2": "ipsa"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "dolor"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 128
    }
  }
}
```