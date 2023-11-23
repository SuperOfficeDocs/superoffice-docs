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
Last-Modified: Tue, 02 Apr 2013 13:38:17 G4T

{
  "PersonId": 791,
  "Firstname": "Morgan",
  "MiddleName": "Heathcote, Medhurst and Kassulke",
  "Lastname": "Thiel",
  "Mrmrs": "delectus",
  "Title": "non",
  "UpdatedDate": "2013-04-02T13:38:17.4524494+02:00",
  "CreatedDate": "2006-04-02T13:38:17.4524494+02:00",
  "BirthDate": "2008-07-29T13:38:17.4524494+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "explicabo",
      "StrippedValue": "vel",
      "Description": "Reduced systemic matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 491
        }
      }
    },
    {
      "Value": "explicabo",
      "StrippedValue": "vel",
      "Description": "Reduced systemic matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 491
        }
      }
    }
  ],
  "Description": "Triple-buffered non-volatile core",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "molestias",
      "StrippedValue": "esse",
      "Description": "Networked mission-critical approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 914
        }
      }
    },
    {
      "Value": "molestias",
      "StrippedValue": "esse",
      "Description": "Networked mission-critical approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 914
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "voluptatem",
      "StrippedValue": "quia",
      "Description": "Optimized multi-tasking extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 699
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "quia",
      "Description": "Optimized multi-tasking extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 699
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "repudiandae",
      "StrippedValue": "ducimus",
      "Description": "Visionary intangible flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 78
        }
      }
    },
    {
      "Value": "repudiandae",
      "StrippedValue": "ducimus",
      "Description": "Visionary intangible flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 78
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "inventore",
      "StrippedValue": "consectetur",
      "Description": "Progressive 24/7 model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 270
        }
      }
    },
    {
      "Value": "inventore",
      "StrippedValue": "consectetur",
      "Description": "Progressive 24/7 model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 270
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "cum",
      "StrippedValue": "similique",
      "Description": "Managed uniform standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 67
        }
      }
    },
    {
      "Value": "cum",
      "StrippedValue": "similique",
      "Description": "Managed uniform standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 67
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
      "Id": 514,
      "Name": "Koch-Harber",
      "ToolTip": "Debitis magni.",
      "Deleted": true,
      "Rank": 655,
      "Type": "non",
      "ColorBlock": 987,
      "IconHint": "architecto",
      "Selected": false,
      "LastChanged": "2019-01-10T13:38:17.4524494+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "qui",
      "Hidden": false,
      "FullName": "Prof. David Aufderhar Jr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 908
        }
      }
    }
  ],
  "PersonNumber": "1174854",
  "FullName": "Ed Lakin",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "iusto",
      "Description": "Distributed non-volatile capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 402
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "iusto",
      "Description": "Distributed non-volatile capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 402
        }
      }
    }
  ],
  "FormalName": "Gislason-Windler",
  "Address": null,
  "Post3": "nam",
  "Post2": "laboriosam",
  "Post1": "esse",
  "Kanalname": "eos",
  "Kanafname": "veniam",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "dolorem",
  "ActiveInterests": 373,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 814,
  "DbiKey": "qui",
  "DbiLastModified": "2014-06-04T13:38:17.4524494+02:00",
  "DbiLastSyncronized": "2014-07-27T13:38:17.4524494+02:00",
  "SentInfo": 641,
  "ShowContactTickets": 739,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "eos",
      "StrippedValue": "cupiditate",
      "Description": "Managed logistical benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 484
        }
      }
    },
    {
      "Value": "eos",
      "StrippedValue": "cupiditate",
      "Description": "Managed logistical benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 484
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "nulla",
      "StrippedValue": "neque",
      "Description": "Advanced dynamic encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 107
        }
      }
    },
    {
      "Value": "nulla",
      "StrippedValue": "neque",
      "Description": "Advanced dynamic encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 107
        }
      }
    }
  ],
  "Source": 534,
  "ActiveErpLinks": 244,
  "ShipmentTypes": [
    {
      "Id": 608,
      "Name": "Grimes-Nikolaus",
      "ToolTip": "Modi molestiae.",
      "Deleted": true,
      "Rank": 530,
      "Type": "hic",
      "ColorBlock": 833,
      "IconHint": "harum",
      "Selected": false,
      "LastChanged": "2005-03-02T13:38:17.4680694+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "repellat",
      "Hidden": false,
      "FullName": "Dr. April Verner Brown DVM",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 794
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 542,
      "Comment": "et",
      "Registered": "2005-04-17T13:38:17.4680694+02:00",
      "RegisteredAssociateId": 906,
      "Updated": "2009-03-07T13:38:17.4680694+01:00",
      "UpdatedAssociateId": 321,
      "LegalBaseId": 280,
      "LegalBaseKey": "voluptatem",
      "LegalBaseName": "Thompson, Paucek and Daniel",
      "ConsentPurposeId": 243,
      "ConsentPurposeKey": "quae",
      "ConsentPurposeName": "Larkin Inc and Sons",
      "ConsentSourceId": 433,
      "ConsentSourceKey": "non",
      "ConsentSourceName": "Doyle Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 863
        }
      }
    }
  ],
  "BounceEmails": [
    "christy_ohara@doylewolf.co.uk",
    "marlon@hills.uk"
  ],
  "ActiveStatusMonitorId": 914,
  "UserDefinedFields": {
    "SuperOffice:1": "Eldora Zemlak",
    "SuperOffice:2": "2142250673"
  },
  "ExtraFields": {
    "ExtraFields1": "est",
    "ExtraFields2": "ea"
  },
  "CustomFields": {
    "CustomFields1": "quam",
    "CustomFields2": "autem"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 660
    }
  }
}
```