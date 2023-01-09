---
title: POST Agents/Person/CreateDefaultPersonEntity
uid: v1PersonAgent_CreateDefaultPersonEntity
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
| TableRight | TableRight |  |
| FieldProperties | object |  |

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
  "PersonId": 897,
  "Firstname": "Werner",
  "MiddleName": "Auer-Reynolds",
  "Lastname": "Hegmann",
  "Mrmrs": "omnis",
  "Title": "similique",
  "UpdatedDate": "2007-12-31T17:37:18.3652412+01:00",
  "CreatedDate": "2012-12-14T17:37:18.3652412+01:00",
  "BirthDate": "2008-07-01T17:37:18.3652412+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "ullam",
      "StrippedValue": "quibusdam",
      "Description": "Visionary impactful infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 1001
        }
      }
    },
    {
      "Value": "ullam",
      "StrippedValue": "quibusdam",
      "Description": "Visionary impactful infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 1001
        }
      }
    }
  ],
  "Description": "Mandatory value-added implementation",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "et",
      "StrippedValue": "explicabo",
      "Description": "Future-proofed directional methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 123
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "explicabo",
      "Description": "Future-proofed directional methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 123
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "autem",
      "StrippedValue": "placeat",
      "Description": "Integrated high-level framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 983
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "placeat",
      "Description": "Integrated high-level framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 983
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "quam",
      "StrippedValue": "dolorem",
      "Description": "Object-based composite matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 637
        }
      }
    },
    {
      "Value": "quam",
      "StrippedValue": "dolorem",
      "Description": "Object-based composite matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 637
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "repellendus",
      "StrippedValue": "et",
      "Description": "Fundamental exuding help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 880
        }
      }
    },
    {
      "Value": "repellendus",
      "StrippedValue": "et",
      "Description": "Fundamental exuding help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 880
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "ullam",
      "StrippedValue": "quod",
      "Description": "Inverse needs-based portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 277
        }
      }
    },
    {
      "Value": "ullam",
      "StrippedValue": "quod",
      "Description": "Inverse needs-based portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 277
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
      "Id": 923,
      "Name": "Denesik-Rath",
      "ToolTip": "Ipsa eos.",
      "Deleted": false,
      "Rank": 186,
      "Type": "vel",
      "ColorBlock": 289,
      "IconHint": "aspernatur",
      "Selected": false,
      "LastChanged": "2016-06-22T17:37:18.3682411+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "incidunt",
      "StyleHint": "possimus",
      "Hidden": false,
      "FullName": "Ms. Moises Cheyenne Lehner",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 525
        }
      }
    }
  ],
  "PersonNumber": "949968",
  "FullName": "Gino Jerde",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "repellendus",
      "StrippedValue": "molestias",
      "Description": "Exclusive exuding archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 531
        }
      }
    },
    {
      "Value": "repellendus",
      "StrippedValue": "molestias",
      "Description": "Exclusive exuding archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 531
        }
      }
    }
  ],
  "FormalName": "Abshire, Mohr and Tillman",
  "Address": null,
  "Post3": "fugiat",
  "Post2": "quia",
  "Post1": "nobis",
  "Kanalname": "autem",
  "Kanafname": "voluptate",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "id",
  "ActiveInterests": 113,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 717,
  "DbiKey": "ut",
  "DbiLastModified": "2013-07-28T17:37:18.3702409+02:00",
  "DbiLastSyncronized": "2013-12-14T17:37:18.3702409+01:00",
  "SentInfo": 946,
  "ShowContactTickets": 234,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "qui",
      "StrippedValue": "ex",
      "Description": "Devolved demand-driven frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 31
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "ex",
      "Description": "Devolved demand-driven frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 31
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "optio",
      "Description": "User-friendly well-modulated firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 209
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "optio",
      "Description": "User-friendly well-modulated firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 209
        }
      }
    }
  ],
  "Source": 227,
  "ActiveErpLinks": 268,
  "ShipmentTypes": [
    {
      "Id": 42,
      "Name": "Witting, Vandervort and Mante",
      "ToolTip": "Illo ut et commodi veniam itaque itaque.",
      "Deleted": false,
      "Rank": 271,
      "Type": "placeat",
      "ColorBlock": 440,
      "IconHint": "praesentium",
      "Selected": false,
      "LastChanged": "2002-01-05T17:37:18.3712429+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aliquid",
      "StyleHint": "est",
      "Hidden": false,
      "FullName": "Mazie Yost",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 745
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 53,
      "Comment": "ut",
      "Registered": "2015-10-17T17:37:18.3712429+02:00",
      "RegisteredAssociateId": 618,
      "Updated": "1997-12-03T17:37:18.3712429+01:00",
      "UpdatedAssociateId": 711,
      "LegalBaseId": 189,
      "LegalBaseKey": "quasi",
      "LegalBaseName": "Farrell-Quigley",
      "ConsentPurposeId": 71,
      "ConsentPurposeKey": "veniam",
      "ConsentPurposeName": "Rath, Legros and Runte",
      "ConsentSourceId": 810,
      "ConsentSourceKey": "est",
      "ConsentSourceName": "Wuckert, VonRueden and Harvey",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 320
        }
      }
    }
  ],
  "BounceEmails": [
    "adolph@grimespfeffer.ca",
    "viva@fay.us"
  ],
  "ActiveStatusMonitorId": 404,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "repudiandae",
    "ExtraFields2": "labore"
  },
  "CustomFields": {
    "CustomFields1": "repellat",
    "CustomFields2": "tenetur"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 24
    }
  }
}
```