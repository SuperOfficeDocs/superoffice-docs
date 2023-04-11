---
title: POST Agents/EMail/GetPersonEntitiesFromEmailAddress
uid: v1EMailAgent_GetPersonEntitiesFromEmailAddress
---

# POST Agents/EMail/GetPersonEntitiesFromEmailAddress

```http
POST /api/v1/Agents/EMail/GetPersonEntitiesFromEmailAddress
```

Get all persons and contacts with the given email address


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetPersonEntitiesFromEmailAddress?$select=name,department,category/id
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

## Request Body: request 

EmailAddress 

| Property Name | Type |  Description |
|----------------|------|--------------|
| EmailAddress | String |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

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
POST /api/v1/Agents/EMail/GetPersonEntitiesFromEmailAddress
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "EmailAddress": "georgette.goyette@boehmcasper.info"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "PersonId": 405,
    "Firstname": "Quinten",
    "MiddleName": "Nader-Towne",
    "Lastname": "Rodriguez",
    "Mrmrs": "sint",
    "Title": "esse",
    "UpdatedDate": "2017-11-20T15:29:21.7527763+01:00",
    "CreatedDate": "1997-06-24T15:29:21.7527763+02:00",
    "BirthDate": "2002-05-09T15:29:21.7527763+02:00",
    "CreatedBy": null,
    "Emails": [
      {
        "Value": "ex",
        "StrippedValue": "et",
        "Description": "Cross-group non-volatile capability",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 731
          }
        }
      },
      {
        "Value": "ex",
        "StrippedValue": "et",
        "Description": "Cross-group non-volatile capability",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 731
          }
        }
      }
    ],
    "Description": "Operative content-based standardization",
    "IsAssociate": false,
    "PrivatePhones": [
      {
        "Value": "recusandae",
        "StrippedValue": "excepturi",
        "Description": "Polarised system-worthy database",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 601
          }
        }
      },
      {
        "Value": "recusandae",
        "StrippedValue": "excepturi",
        "Description": "Polarised system-worthy database",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 601
          }
        }
      }
    ],
    "Faxes": [
      {
        "Value": "molestias",
        "StrippedValue": "unde",
        "Description": "Stand-alone responsive open system",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 271
          }
        }
      },
      {
        "Value": "molestias",
        "StrippedValue": "unde",
        "Description": "Stand-alone responsive open system",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 271
          }
        }
      }
    ],
    "MobilePhones": [
      {
        "Value": "ut",
        "StrippedValue": "impedit",
        "Description": "Pre-emptive fault-tolerant task-force",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 164
          }
        }
      },
      {
        "Value": "ut",
        "StrippedValue": "impedit",
        "Description": "Pre-emptive fault-tolerant task-force",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 164
          }
        }
      }
    ],
    "OfficePhones": [
      {
        "Value": "fuga",
        "StrippedValue": "et",
        "Description": "Exclusive non-volatile framework",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 602
          }
        }
      },
      {
        "Value": "fuga",
        "StrippedValue": "et",
        "Description": "Exclusive non-volatile framework",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 602
          }
        }
      }
    ],
    "OtherPhones": [
      {
        "Value": "occaecati",
        "StrippedValue": "sint",
        "Description": "Organic exuding architecture",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 124
          }
        }
      },
      {
        "Value": "occaecati",
        "StrippedValue": "sint",
        "Description": "Organic exuding architecture",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 124
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
        "Id": 209,
        "Name": "Walsh Group",
        "ToolTip": "Accusamus vel repellendus quasi cumque.",
        "Deleted": true,
        "Rank": 898,
        "Type": "dolores",
        "ColorBlock": 469,
        "IconHint": "consequatur",
        "Selected": false,
        "LastChanged": "2004-03-01T15:29:21.7547753+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "voluptas",
        "StyleHint": "minus",
        "Hidden": true,
        "FullName": "Pamela Schuster",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 24
          }
        }
      }
    ],
    "PersonNumber": "395889",
    "FullName": "Iva Kling",
    "NoMailing": false,
    "UsePersonAddress": false,
    "Retired": true,
    "Urls": [
      {
        "Value": "est",
        "StrippedValue": "explicabo",
        "Description": "Switchable motivating hierarchy",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 600
          }
        }
      },
      {
        "Value": "est",
        "StrippedValue": "explicabo",
        "Description": "Switchable motivating hierarchy",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 600
          }
        }
      }
    ],
    "FormalName": "Ratke LLC",
    "Address": null,
    "Post3": "minus",
    "Post2": "ut",
    "Post1": "est",
    "Kanalname": "possimus",
    "Kanafname": "ad",
    "CorrespondingAssociate": null,
    "Category": null,
    "Business": null,
    "Associate": null,
    "Salutation": "cupiditate",
    "ActiveInterests": 968,
    "SupportAssociate": null,
    "TicketPriority": null,
    "CustomerLanguage": null,
    "DbiAgentId": 704,
    "DbiKey": "rem",
    "DbiLastModified": "1997-07-22T15:29:21.757776+02:00",
    "DbiLastSyncronized": "1998-06-30T15:29:21.757776+02:00",
    "SentInfo": 111,
    "ShowContactTickets": 655,
    "UserInfo": null,
    "ChatEmails": [
      {
        "Value": "ut",
        "StrippedValue": "ut",
        "Description": "Virtual intangible array",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 515
          }
        }
      },
      {
        "Value": "ut",
        "StrippedValue": "ut",
        "Description": "Virtual intangible array",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 515
          }
        }
      }
    ],
    "InternetPhones": [
      {
        "Value": "rem",
        "StrippedValue": "amet",
        "Description": "Self-enabling contextually-based artificial intelligence",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 337
          }
        }
      },
      {
        "Value": "rem",
        "StrippedValue": "amet",
        "Description": "Self-enabling contextually-based artificial intelligence",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 337
          }
        }
      }
    ],
    "Source": 17,
    "ActiveErpLinks": 987,
    "ShipmentTypes": [
      {
        "Id": 127,
        "Name": "Welch, Cassin and Runte",
        "ToolTip": "Laboriosam qui porro qui eos magnam nesciunt nam.",
        "Deleted": false,
        "Rank": 40,
        "Type": "exercitationem",
        "ColorBlock": 828,
        "IconHint": "quia",
        "Selected": false,
        "LastChanged": "2018-05-24T15:29:21.758276+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "nam",
        "StyleHint": "adipisci",
        "Hidden": true,
        "FullName": "Tyrell Larkin",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 455
          }
        }
      }
    ],
    "Consents": [
      {
        "ConsentPersonId": 244,
        "Comment": "fugit",
        "Registered": "2003-12-12T15:29:21.7587764+01:00",
        "RegisteredAssociateId": 196,
        "Updated": "2008-07-06T15:29:21.7587764+02:00",
        "UpdatedAssociateId": 48,
        "LegalBaseId": 549,
        "LegalBaseKey": "tenetur",
        "LegalBaseName": "Lubowitz-Kreiger",
        "ConsentPurposeId": 502,
        "ConsentPurposeKey": "et",
        "ConsentPurposeName": "Ebert, Parisian and Yost",
        "ConsentSourceId": 121,
        "ConsentSourceKey": "officia",
        "ConsentSourceName": "Kunde, Grimes and Harris",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 274
          }
        }
      }
    ],
    "BounceEmails": [
      "fletcher.rohan@wolff.com",
      "albin_quigley@cristemmerich.name"
    ],
    "ActiveStatusMonitorId": 221,
    "UserDefinedFields": {
      "SuperOffice:1": "Raymundo Kuvalis",
      "SuperOffice:2": "360497485"
    },
    "ExtraFields": {
      "ExtraFields1": "debitis",
      "ExtraFields2": "expedita"
    },
    "CustomFields": {
      "CustomFields1": "libero",
      "CustomFields2": "et"
    },
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 780
      }
    }
  }
]
```