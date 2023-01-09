---
title: GET Person/default
uid: v1PersonEntity_DefaultPersonEntity
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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

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
Last-Modified: Thu, 07 May 2020 17:37:38 G5T

{
  "PersonId": 509,
  "Firstname": "Sandy",
  "MiddleName": "Kerluke, Schiller and Cronin",
  "Lastname": "Gerhold",
  "Mrmrs": "corrupti",
  "Title": "veniam",
  "UpdatedDate": "2020-05-07T17:37:38.8418596+02:00",
  "CreatedDate": "1999-05-08T17:37:38.8418596+02:00",
  "BirthDate": "2000-12-30T17:37:38.8418596+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "temporibus",
      "StrippedValue": "neque",
      "Description": "Mandatory content-based time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 948
        }
      }
    },
    {
      "Value": "temporibus",
      "StrippedValue": "neque",
      "Description": "Mandatory content-based time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 948
        }
      }
    }
  ],
  "Description": "Integrated bifurcated artificial intelligence",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "porro",
      "StrippedValue": "eum",
      "Description": "Function-based client-driven contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 368
        }
      }
    },
    {
      "Value": "porro",
      "StrippedValue": "eum",
      "Description": "Function-based client-driven contingency",
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
  "Faxes": [
    {
      "Value": "magni",
      "StrippedValue": "illo",
      "Description": "Seamless radical core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 736
        }
      }
    },
    {
      "Value": "magni",
      "StrippedValue": "illo",
      "Description": "Seamless radical core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 736
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "quibusdam",
      "StrippedValue": "sint",
      "Description": "Upgradable fresh-thinking functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 155
        }
      }
    },
    {
      "Value": "quibusdam",
      "StrippedValue": "sint",
      "Description": "Upgradable fresh-thinking functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 155
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "porro",
      "StrippedValue": "aperiam",
      "Description": "Fundamental radical leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 508
        }
      }
    },
    {
      "Value": "porro",
      "StrippedValue": "aperiam",
      "Description": "Fundamental radical leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 508
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "illo",
      "StrippedValue": "consequatur",
      "Description": "Object-based optimizing task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 808
        }
      }
    },
    {
      "Value": "illo",
      "StrippedValue": "consequatur",
      "Description": "Object-based optimizing task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 808
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
      "Id": 447,
      "Name": "Hauck, Gislason and O'Hara",
      "ToolTip": "Voluptates doloribus illum illo similique ipsam.",
      "Deleted": false,
      "Rank": 30,
      "Type": "asperiores",
      "ColorBlock": 16,
      "IconHint": "sit",
      "Selected": false,
      "LastChanged": "2007-06-20T17:37:38.8448601+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eum",
      "StyleHint": "doloremque",
      "Hidden": true,
      "FullName": "Mr. Ena Kemmer Jr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 813
        }
      }
    }
  ],
  "PersonNumber": "1281307",
  "FullName": "Carolyn Fay",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "a",
      "StrippedValue": "dolorem",
      "Description": "Multi-tiered system-worthy alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 799
        }
      }
    },
    {
      "Value": "a",
      "StrippedValue": "dolorem",
      "Description": "Multi-tiered system-worthy alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 799
        }
      }
    }
  ],
  "FormalName": "Kuhlman-Oberbrunner",
  "Address": null,
  "Post3": "et",
  "Post2": "nesciunt",
  "Post1": "sed",
  "Kanalname": "nihil",
  "Kanafname": "saepe",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "deleniti",
  "ActiveInterests": 942,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 834,
  "DbiKey": "temporibus",
  "DbiLastModified": "2019-06-07T17:37:38.8478597+02:00",
  "DbiLastSyncronized": "2002-08-05T17:37:38.8478597+02:00",
  "SentInfo": 534,
  "ShowContactTickets": 96,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "et",
      "StrippedValue": "quisquam",
      "Description": "Automated disintermediate software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 903
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "quisquam",
      "Description": "Automated disintermediate software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 903
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "cumque",
      "StrippedValue": "quaerat",
      "Description": "Ergonomic dynamic migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 868
        }
      }
    },
    {
      "Value": "cumque",
      "StrippedValue": "quaerat",
      "Description": "Ergonomic dynamic migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 868
        }
      }
    }
  ],
  "Source": 410,
  "ActiveErpLinks": 110,
  "ShipmentTypes": [
    {
      "Id": 861,
      "Name": "Heathcote, Gorczany and Gislason",
      "ToolTip": "Tempore minus perferendis.",
      "Deleted": false,
      "Rank": 98,
      "Type": "error",
      "ColorBlock": 642,
      "IconHint": "molestiae",
      "Selected": true,
      "LastChanged": "2008-07-20T17:37:38.8478597+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ipsa",
      "StyleHint": "praesentium",
      "Hidden": false,
      "FullName": "Alexander Streich",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 656
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 647,
      "Comment": "veritatis",
      "Registered": "2016-07-29T17:37:38.8488621+02:00",
      "RegisteredAssociateId": 879,
      "Updated": "2003-11-07T17:37:38.8488621+01:00",
      "UpdatedAssociateId": 880,
      "LegalBaseId": 217,
      "LegalBaseKey": "inventore",
      "LegalBaseName": "Kohler-Medhurst",
      "ConsentPurposeId": 214,
      "ConsentPurposeKey": "id",
      "ConsentPurposeName": "Hoeger, Gaylord and Gislason",
      "ConsentSourceId": 652,
      "ConsentSourceKey": "voluptas",
      "ConsentSourceName": "Weber LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 900
        }
      }
    }
  ],
  "BounceEmails": [
    "dakota@walshbednar.biz",
    "bert.luettgen@gaylordbernhard.info"
  ],
  "ActiveStatusMonitorId": 353,
  "UserDefinedFields": {
    "SuperOffice:1": "Abby Wintheiser",
    "SuperOffice:2": "Donna Bartoletti"
  },
  "ExtraFields": {
    "ExtraFields1": "eveniet",
    "ExtraFields2": "enim"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "ad"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 791
    }
  }
}
```