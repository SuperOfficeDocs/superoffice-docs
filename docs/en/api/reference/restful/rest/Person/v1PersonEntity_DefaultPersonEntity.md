---
title: GET Person/default
uid: v1PersonEntity_DefaultPersonEntity
generated: true
---

# GET Person/default

```http
GET /api/v1/Person/default
```

Set default values into a new PersonEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Person agent service CreateDefaultPersonEntity.







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
GET /api/v1/Person/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Wed, 24 Nov 1999 11:06:41 G11T

{
  "PersonId": 592,
  "Firstname": "Nico",
  "MiddleName": "Wilderman-Hauck",
  "Lastname": "McKenzie",
  "Mrmrs": "voluptas",
  "Title": "et",
  "UpdatedDate": "1999-11-24T11:06:41.9103479+01:00",
  "CreatedDate": "2012-09-04T11:06:41.9103479+02:00",
  "BirthDate": "2022-02-28T11:06:41.9103479+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "recusandae",
      "StrippedValue": "labore",
      "Description": "Function-based well-modulated methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 568
        }
      }
    },
    {
      "Value": "recusandae",
      "StrippedValue": "labore",
      "Description": "Function-based well-modulated methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 568
        }
      }
    }
  ],
  "Description": "Customizable actuating workforce",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "distinctio",
      "StrippedValue": "eos",
      "Description": "Quality-focused bi-directional framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 178
        }
      }
    },
    {
      "Value": "distinctio",
      "StrippedValue": "eos",
      "Description": "Quality-focused bi-directional framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 178
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "vel",
      "StrippedValue": "perferendis",
      "Description": "Right-sized client-driven model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 663
        }
      }
    },
    {
      "Value": "vel",
      "StrippedValue": "perferendis",
      "Description": "Right-sized client-driven model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 663
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "nam",
      "StrippedValue": "excepturi",
      "Description": "Fully-configurable zero administration infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 541
        }
      }
    },
    {
      "Value": "nam",
      "StrippedValue": "excepturi",
      "Description": "Fully-configurable zero administration infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 541
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "beatae",
      "StrippedValue": "ipsum",
      "Description": "Seamless disintermediate architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 701
        }
      }
    },
    {
      "Value": "beatae",
      "StrippedValue": "ipsum",
      "Description": "Seamless disintermediate architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 701
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "aut",
      "StrippedValue": "optio",
      "Description": "Advanced tangible open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 146
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "optio",
      "Description": "Advanced tangible open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 146
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
      "Id": 367,
      "Name": "Treutel Group",
      "ToolTip": "Quas molestiae.",
      "Deleted": true,
      "Rank": 355,
      "Type": "culpa",
      "ColorBlock": 854,
      "IconHint": "et",
      "Selected": false,
      "LastChanged": "2014-11-21T11:06:41.9103479+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "expedita",
      "StyleHint": "vel",
      "Hidden": true,
      "FullName": "Emely Olson",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 203
        }
      }
    }
  ],
  "PersonNumber": "1020520",
  "FullName": "Parker Moore",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "praesentium",
      "StrippedValue": "sint",
      "Description": "Up-sized homogeneous forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 397
        }
      }
    },
    {
      "Value": "praesentium",
      "StrippedValue": "sint",
      "Description": "Up-sized homogeneous forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 397
        }
      }
    }
  ],
  "FormalName": "Gislason, Bartell and Borer",
  "Address": null,
  "Post3": "odit",
  "Post2": "incidunt",
  "Post1": "quis",
  "Kanalname": "optio",
  "Kanafname": "in",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "est",
  "ActiveInterests": 942,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 41,
  "DbiKey": "eaque",
  "DbiLastModified": "2002-06-10T11:06:41.9103479+02:00",
  "DbiLastSyncronized": "2012-04-04T11:06:41.9103479+02:00",
  "SentInfo": 400,
  "ShowContactTickets": 7,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "repudiandae",
      "StrippedValue": "quas",
      "Description": "Phased national solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 588
        }
      }
    },
    {
      "Value": "repudiandae",
      "StrippedValue": "quas",
      "Description": "Phased national solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 588
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "maxime",
      "StrippedValue": "excepturi",
      "Description": "Enhanced empowering throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 45
        }
      }
    },
    {
      "Value": "maxime",
      "StrippedValue": "excepturi",
      "Description": "Enhanced empowering throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 45
        }
      }
    }
  ],
  "Source": 340,
  "ActiveErpLinks": 590,
  "ShipmentTypes": [
    {
      "Id": 579,
      "Name": "Bartell, Rice and McKenzie",
      "ToolTip": "Cumque rem ex accusamus.",
      "Deleted": false,
      "Rank": 569,
      "Type": "nesciunt",
      "ColorBlock": 111,
      "IconHint": "quibusdam",
      "Selected": false,
      "LastChanged": "2019-06-06T11:06:41.9259729+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "id",
      "StyleHint": "eveniet",
      "Hidden": false,
      "FullName": "Dr. Rudy Heathcote",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 212
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 847,
      "Comment": "accusamus",
      "Registered": "2012-08-05T11:06:41.9259729+02:00",
      "RegisteredAssociateId": 624,
      "Updated": "1996-08-08T11:06:41.9259729+02:00",
      "UpdatedAssociateId": 227,
      "LegalBaseId": 693,
      "LegalBaseKey": "aut",
      "LegalBaseName": "Gislason-Cole",
      "ConsentPurposeId": 750,
      "ConsentPurposeKey": "sint",
      "ConsentPurposeName": "Murphy-Schamberger",
      "ConsentSourceId": 763,
      "ConsentSourceKey": "id",
      "ConsentSourceName": "Bosco-Swift",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 12
        }
      }
    }
  ],
  "BounceEmails": [
    "hollie@leuschke.ca",
    "kaelyn@hermiston.ca"
  ],
  "ActiveStatusMonitorId": 928,
  "UserDefinedFields": {
    "SuperOffice:1": "2137659943",
    "SuperOffice:2": "Cathryn O'Hara"
  },
  "ExtraFields": {
    "ExtraFields1": "recusandae",
    "ExtraFields2": "quia"
  },
  "CustomFields": {
    "CustomFields1": "beatae",
    "CustomFields2": "corrupti"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 168
    }
  }
}
```