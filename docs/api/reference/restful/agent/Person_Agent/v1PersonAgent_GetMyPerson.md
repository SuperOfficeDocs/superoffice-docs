---
title: POST Agents/Person/GetMyPerson
uid: v1PersonAgent_GetMyPerson
---

# POST Agents/Person/GetMyPerson

```http
POST /api/v1/Agents/Person/GetMyPerson
```

Gets the person info belonging to the currently logged on user.

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetMyPerson?$select=name,department,category/id
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

## Response

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body:

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
| CreatedBy |  | The user that created the person object |
| Emails | array | A collection of the person's emails |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| IsAssociate | bool | Checks if the person object is an associate. The property is read-only. |
| PrivatePhones | array | Returns a collection of phone numbers that belong to the contact person. |
| Faxes | array | Returns a collection of fax numbers that belong to the contact person. |
| MobilePhones | array | Returns a collection of mobile phone numbers that belong to the contact person. |
| OfficePhones | array | Returns a collection of office phone numbers that belong to the contact person. |
| OtherPhones | array | Returns a collection of pagers that belong to the contact person. |
| Position |  | The position. This is a predefined SuperOffice value, different from Title  <para>Use MDO List name "perspos" to get list items.</para> |
| UpdatedBy |  | The person that last updated the person object |
| Contact |  | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  <para>Use MDO List name "contact_new" to get list items.</para> |
| Country |  | The country this contact person is located in.  <para>Use MDO List name "country" to get list items.</para> |
| Interests | array | The person's available and selected interests.  <para>Use MDO List name "persint" to get list items.</para> |
| PersonNumber | string | Alphanumeric user field |
| FullName | string | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| NoMailing | bool | Spam filter. Indicates if this person should retrieve advertising. |
| UsePersonAddress | bool | True if the person's address should be used as mailing address, instead of the contact's address. |
| Retired | bool | True if the user is retired and should have no rights, not appear in lists, etc. |
| Urls | array | The urls related to this person. |
| FormalName | string | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| Address |  | Structure holding formatted address data. The layout of the array structure indicates the layout of the localized address. |
| Post3 | string | Postal address, used in Japanese versions only |
| Post2 | string | Postal address, used in Japanese versions only |
| Post1 | string | Postal address, used in Japanese versions only |
| Kanalname | string | Kana last name, used in Japanese versions only |
| Kanafname | string | Kana first name, used in Japanese versions only |
| CorrespondingAssociate |  | The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user). |
| Category |  | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "category" to get list items.</para> |
| Business |  | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "business" to get list items.</para> |
| Associate |  | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  <para>Use MDO List name "associate" to get list items.</para> |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  <para>Use MDO List name "salutation" to get list items.</para> |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | <para>Use MDO List name "customerlanguage" to get list items.</para> |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| DbiLastSyncronized | date-time | Last external syncronization. |
| SentInfo | int32 | Has information on username/password been sent (ejournal) |
| ShowContactTickets | int32 | Should tickets related to the company be shown to this person |
| UserInfo |  | Information about the user if this person is a user.  If IsAssociate (e.g. is user is true) the UserInfo will be provided. |
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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Person/GetMyPerson
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 326,
  "Firstname": "Rachael",
  "MiddleName": "O'Keefe, Bartell and Grimes",
  "Lastname": "Blick",
  "Mrmrs": "nihil",
  "Title": "omnis",
  "UpdatedDate": "2019-01-04T11:10:27.3944252+01:00",
  "CreatedDate": "2015-11-27T11:10:27.3944252+01:00",
  "BirthDate": "2019-09-23T11:10:27.3944252+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "architecto",
      "StrippedValue": "harum",
      "Description": "Multi-lateral scalable strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 534
        }
      }
    },
    {
      "Value": "architecto",
      "StrippedValue": "harum",
      "Description": "Multi-lateral scalable strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 534
        }
      }
    }
  ],
  "Description": "Customer-focused demand-driven access",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "esse",
      "StrippedValue": "architecto",
      "Description": "Reverse-engineered web-enabled time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 382
        }
      }
    },
    {
      "Value": "esse",
      "StrippedValue": "architecto",
      "Description": "Reverse-engineered web-enabled time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 382
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sit",
      "StrippedValue": "ea",
      "Description": "Customer-focused multimedia model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 585
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "ea",
      "Description": "Customer-focused multimedia model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 585
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "eum",
      "StrippedValue": "delectus",
      "Description": "Assimilated bottom-line approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 577
        }
      }
    },
    {
      "Value": "eum",
      "StrippedValue": "delectus",
      "Description": "Assimilated bottom-line approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 577
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "a",
      "StrippedValue": "necessitatibus",
      "Description": "Persistent zero tolerance workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 725
        }
      }
    },
    {
      "Value": "a",
      "StrippedValue": "necessitatibus",
      "Description": "Persistent zero tolerance workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 725
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "atque",
      "StrippedValue": "recusandae",
      "Description": "Quality-focused national moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 837
        }
      }
    },
    {
      "Value": "atque",
      "StrippedValue": "recusandae",
      "Description": "Quality-focused national moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 837
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
      "Id": 502,
      "Name": "Schulist LLC",
      "ToolTip": "At quod sit.",
      "Deleted": false,
      "Rank": 25,
      "Type": "veritatis",
      "ColorBlock": 706,
      "IconHint": "fugit",
      "Selected": true,
      "LastChanged": "2011-06-17T11:10:27.3964249+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "illum",
      "StyleHint": "velit",
      "Hidden": true,
      "FullName": "Evalyn Cummerata",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 368
        }
      }
    }
  ],
  "PersonNumber": "1785880",
  "FullName": "Mrs. Thad Pearlie Grimes MD",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "sit",
      "StrippedValue": "sint",
      "Description": "Adaptive content-based alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 409
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "sint",
      "Description": "Adaptive content-based alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 409
        }
      }
    }
  ],
  "FormalName": "Sauer-Fahey",
  "Address": null,
  "Post3": "modi",
  "Post2": "officiis",
  "Post1": "ipsa",
  "Kanalname": "in",
  "Kanafname": "odio",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "fugiat",
  "ActiveInterests": 208,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 553,
  "DbiKey": "ipsum",
  "DbiLastModified": "2001-10-01T11:10:27.400425+02:00",
  "DbiLastSyncronized": "2009-12-09T11:10:27.400425+01:00",
  "SentInfo": 191,
  "ShowContactTickets": 925,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "tempore",
      "StrippedValue": "distinctio",
      "Description": "Fundamental 24/7 data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 665
        }
      }
    },
    {
      "Value": "tempore",
      "StrippedValue": "distinctio",
      "Description": "Fundamental 24/7 data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 665
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "sed",
      "StrippedValue": "velit",
      "Description": "Visionary clear-thinking service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 838
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "velit",
      "Description": "Visionary clear-thinking service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 838
        }
      }
    }
  ],
  "Source": 282,
  "ActiveErpLinks": 421,
  "ShipmentTypes": [
    {
      "Id": 912,
      "Name": "Hamill-Schmeler",
      "ToolTip": "Minus doloribus nulla exercitationem ut.",
      "Deleted": true,
      "Rank": 820,
      "Type": "voluptates",
      "ColorBlock": 571,
      "IconHint": "expedita",
      "Selected": false,
      "LastChanged": "2013-02-23T11:10:27.400425+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "culpa",
      "StyleHint": "est",
      "Hidden": false,
      "FullName": "Dwight Huels",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 715
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 29,
      "Comment": "ullam",
      "Registered": "2007-11-28T11:10:27.4014253+01:00",
      "RegisteredAssociateId": 522,
      "Updated": "1997-08-29T11:10:27.4014253+02:00",
      "UpdatedAssociateId": 240,
      "LegalBaseId": 334,
      "LegalBaseKey": "veniam",
      "LegalBaseName": "Rosenbaum, Gerhold and Rippin",
      "ConsentPurposeId": 713,
      "ConsentPurposeKey": "qui",
      "ConsentPurposeName": "Kshlerin, Reinger and Raynor",
      "ConsentSourceId": 611,
      "ConsentSourceKey": "qui",
      "ConsentSourceName": "Bruen, Jast and Smith",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 323
        }
      }
    }
  ],
  "BounceEmails": [
    "geraldine@boehm.uk",
    "rey@marquardt.name"
  ],
  "ActiveStatusMonitorId": 612,
  "UserDefinedFields": {
    "SuperOffice:1": "Raleigh Gusikowski",
    "SuperOffice:2": "Baylee Jacobs"
  },
  "ExtraFields": {
    "ExtraFields1": "pariatur",
    "ExtraFields2": "exercitationem"
  },
  "CustomFields": {
    "CustomFields1": "nam",
    "CustomFields2": "animi"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 292
    }
  }
}
```
