---
title: POST Agents/Person/CreateDefaultPersonEntity
uid: v1PersonAgent_CreateDefaultPersonEntity
generated: true
content_type: reference
---

# POST Agents/Person/CreateDefaultPersonEntity

```http
POST /api/v1/Agents/Person/CreateDefaultPersonEntity
```

Loading default values into a new PersonEntity.








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
| Mrmrs | string | e.g. Mrs   sex_title  Use MDO List name "mrmrs" to get list items. |
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
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  Use MDO List name "perspos" to get list items. |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  Use MDO List name "contact_new" to get list items. |
| Country | Country | The country this contact person is located in.  Use MDO List name "country" to get list items. |
| Interests | array | The person's available and selected interests.  Use MDO List name "persint" to get list items. |
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
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  Use MDO List name "category" to get list items. |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  Use MDO List name "business" to get list items. |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  Use MDO List name "associate" to get list items. |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  Use MDO List name "salutation" to get list items. |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | Use MDO List name "customerlanguage" to get list items. |
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
| CreatedByFormId | int32 | The form id of the form that created the person |
| InitialUtmParameters | InitalUtmParameters | Initial utm parameters when creating this person, readonly fields |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Person/CreateDefaultPersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 89,
  "Firstname": "Eda",
  "MiddleName": "Botsford Inc and Sons",
  "Lastname": "Adams",
  "Mrmrs": "ut",
  "Title": "ab",
  "UpdatedDate": "2021-02-14T03:46:55.0351223+01:00",
  "CreatedDate": "1999-06-22T03:46:55.0351223+02:00",
  "BirthDate": "1999-04-05T03:46:55.0351223+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "in",
      "StrippedValue": "ipsam",
      "Description": "Automated radical functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 236
        }
      }
    },
    {
      "Value": "in",
      "StrippedValue": "ipsam",
      "Description": "Automated radical functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 236
        }
      }
    }
  ],
  "Description": "Object-based directional contingency",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "et",
      "StrippedValue": "dolores",
      "Description": "Quality-focused dynamic open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 667
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "dolores",
      "Description": "Quality-focused dynamic open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 667
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "odit",
      "StrippedValue": "autem",
      "Description": "De-engineered exuding success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 630
        }
      }
    },
    {
      "Value": "odit",
      "StrippedValue": "autem",
      "Description": "De-engineered exuding success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 630
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "recusandae",
      "StrippedValue": "quisquam",
      "Description": "Synchronised hybrid neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 967
        }
      }
    },
    {
      "Value": "recusandae",
      "StrippedValue": "quisquam",
      "Description": "Synchronised hybrid neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 967
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "aliquam",
      "StrippedValue": "asperiores",
      "Description": "Re-engineered scalable definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 391
        }
      }
    },
    {
      "Value": "aliquam",
      "StrippedValue": "asperiores",
      "Description": "Re-engineered scalable definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 391
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "alias",
      "StrippedValue": "delectus",
      "Description": "Virtual national analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 616
        }
      }
    },
    {
      "Value": "alias",
      "StrippedValue": "delectus",
      "Description": "Virtual national analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 616
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
      "Id": 843,
      "Name": "Hirthe-O'Conner",
      "ToolTip": "Vel quisquam dolorem assumenda architecto.",
      "Deleted": false,
      "Rank": 723,
      "Type": "repellendus",
      "ColorBlock": 217,
      "IconHint": "porro",
      "Selected": false,
      "LastChanged": "2017-02-08T03:46:55.0351223+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eaque",
      "StyleHint": "nostrum",
      "Hidden": true,
      "FullName": "Reina Kohler",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 71
        }
      }
    }
  ],
  "PersonNumber": "938169",
  "FullName": "Leo Johnson Sr.",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "saepe",
      "StrippedValue": "aliquam",
      "Description": "Synergized demand-driven neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 964
        }
      }
    },
    {
      "Value": "saepe",
      "StrippedValue": "aliquam",
      "Description": "Synergized demand-driven neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 964
        }
      }
    }
  ],
  "FormalName": "Cassin-Hilll",
  "Address": null,
  "Post3": "consectetur",
  "Post2": "qui",
  "Post1": "voluptatem",
  "Kanalname": "aliquid",
  "Kanafname": "quisquam",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "velit",
  "ActiveInterests": 412,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 853,
  "DbiKey": "et",
  "DbiLastModified": "2009-07-13T03:46:55.0351223+02:00",
  "DbiLastSyncronized": "2016-08-30T03:46:55.0351223+02:00",
  "SentInfo": 889,
  "ShowContactTickets": 177,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "id",
      "StrippedValue": "eaque",
      "Description": "Organized multi-tasking complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 453
        }
      }
    },
    {
      "Value": "id",
      "StrippedValue": "eaque",
      "Description": "Organized multi-tasking complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 453
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "provident",
      "StrippedValue": "est",
      "Description": "Upgradable cohesive infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 648
        }
      }
    },
    {
      "Value": "provident",
      "StrippedValue": "est",
      "Description": "Upgradable cohesive infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 648
        }
      }
    }
  ],
  "Source": 389,
  "ActiveErpLinks": 228,
  "ShipmentTypes": [
    {
      "Id": 378,
      "Name": "Quigley LLC",
      "ToolTip": "Nihil dolor sed quaerat nesciunt temporibus.",
      "Deleted": false,
      "Rank": 473,
      "Type": "blanditiis",
      "ColorBlock": 5,
      "IconHint": "ut",
      "Selected": false,
      "LastChanged": "2007-10-23T03:46:55.0351223+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "minus",
      "StyleHint": "iure",
      "Hidden": false,
      "FullName": "Berniece Jenkins",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 822
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 980,
      "Comment": "deserunt",
      "Registered": "2011-01-24T03:46:55.0351223+01:00",
      "RegisteredAssociateId": 64,
      "Updated": "2022-07-20T03:46:55.0351223+02:00",
      "UpdatedAssociateId": 566,
      "LegalBaseId": 884,
      "LegalBaseKey": "voluptatem",
      "LegalBaseName": "Hilll LLC",
      "ConsentPurposeId": 8,
      "ConsentPurposeKey": "sunt",
      "ConsentPurposeName": "Ritchie, O'Connell and Skiles",
      "ConsentSourceId": 423,
      "ConsentSourceKey": "possimus",
      "ConsentSourceName": "Labadie, Jacobson and Lueilwitz",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 806
        }
      }
    }
  ],
  "BounceEmails": [
    "jakayla@cartwrightlindgren.uk",
    "elvie_kassulke@denesik.name"
  ],
  "ActiveStatusMonitorId": 730,
  "CreatedByFormId": 588,
  "InitialUtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "2005037396",
    "SuperOffice:2": "1651388016"
  },
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "a"
  },
  "CustomFields": {
    "CustomFields1": "a",
    "CustomFields2": "sint"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 763
    }
  }
}
```