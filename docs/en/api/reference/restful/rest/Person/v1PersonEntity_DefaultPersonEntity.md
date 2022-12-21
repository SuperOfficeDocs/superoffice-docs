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
GET /api/v1/Person/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Sat, 12 Apr 2008 02:49:51 G4T

{
  "PersonId": 796,
  "Firstname": "Chadrick",
  "MiddleName": "Cummerata Group",
  "Lastname": "Weimann",
  "Mrmrs": "neque",
  "Title": "ut",
  "UpdatedDate": "2008-04-12T02:49:51.0109136+02:00",
  "CreatedDate": "2004-04-09T02:49:51.0109136+02:00",
  "BirthDate": "1996-02-07T02:49:51.0109136+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "ducimus",
      "StrippedValue": "dolor",
      "Description": "Up-sized user-facing capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 249
        }
      }
    },
    {
      "Value": "ducimus",
      "StrippedValue": "dolor",
      "Description": "Up-sized user-facing capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 249
        }
      }
    }
  ],
  "Description": "Vision-oriented analyzing policy",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "rem",
      "StrippedValue": "nisi",
      "Description": "Customizable uniform frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 726
        }
      }
    },
    {
      "Value": "rem",
      "StrippedValue": "nisi",
      "Description": "Customizable uniform frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 726
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "omnis",
      "StrippedValue": "nihil",
      "Description": "User-friendly well-modulated success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 69
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "nihil",
      "Description": "User-friendly well-modulated success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 69
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "error",
      "StrippedValue": "officiis",
      "Description": "Persevering tangible knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 641
        }
      }
    },
    {
      "Value": "error",
      "StrippedValue": "officiis",
      "Description": "Persevering tangible knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 641
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "non",
      "StrippedValue": "quam",
      "Description": "Persevering modular service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 206
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "quam",
      "Description": "Persevering modular service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 206
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "accusamus",
      "StrippedValue": "alias",
      "Description": "Sharable background circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 8
        }
      }
    },
    {
      "Value": "accusamus",
      "StrippedValue": "alias",
      "Description": "Sharable background circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 8
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
      "Id": 893,
      "Name": "Reynolds Inc and Sons",
      "ToolTip": "Ut aut qui alias.",
      "Deleted": true,
      "Rank": 195,
      "Type": "omnis",
      "ColorBlock": 234,
      "IconHint": "earum",
      "Selected": true,
      "LastChanged": "2003-11-19T02:49:51.0109136+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "blanditiis",
      "StyleHint": "eos",
      "Hidden": true,
      "FullName": "Mrs. Jonas Vidal Windler",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 197
        }
      }
    }
  ],
  "PersonNumber": "830933",
  "FullName": "Laurine Donnelly",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "magnam",
      "StrippedValue": "repellat",
      "Description": "Progressive hybrid extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 623
        }
      }
    },
    {
      "Value": "magnam",
      "StrippedValue": "repellat",
      "Description": "Progressive hybrid extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 623
        }
      }
    }
  ],
  "FormalName": "Feest, Mohr and Harris",
  "Address": null,
  "Post3": "temporibus",
  "Post2": "quia",
  "Post1": "alias",
  "Kanalname": "ut",
  "Kanafname": "aut",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "eius",
  "ActiveInterests": 700,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 280,
  "DbiKey": "omnis",
  "DbiLastModified": "2009-06-01T02:49:51.0109136+02:00",
  "DbiLastSyncronized": "1997-02-07T02:49:51.0109136+01:00",
  "SentInfo": 122,
  "ShowContactTickets": 151,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "explicabo",
      "StrippedValue": "assumenda",
      "Description": "Seamless multi-tasking portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 134
        }
      }
    },
    {
      "Value": "explicabo",
      "StrippedValue": "assumenda",
      "Description": "Seamless multi-tasking portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 134
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "laborum",
      "StrippedValue": "veniam",
      "Description": "Reduced mobile parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 228
        }
      }
    },
    {
      "Value": "laborum",
      "StrippedValue": "veniam",
      "Description": "Reduced mobile parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 228
        }
      }
    }
  ],
  "Source": 422,
  "ActiveErpLinks": 80,
  "ShipmentTypes": [
    {
      "Id": 777,
      "Name": "Friesen, Hirthe and Kuvalis",
      "ToolTip": "Ullam iusto dolore modi et vero suscipit.",
      "Deleted": false,
      "Rank": 527,
      "Type": "omnis",
      "ColorBlock": 511,
      "IconHint": "et",
      "Selected": true,
      "LastChanged": "2020-09-26T02:49:51.0109136+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aut",
      "StyleHint": "quia",
      "Hidden": false,
      "FullName": "Nelda Effertz",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 336
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 80,
      "Comment": "id",
      "Registered": "2021-03-23T02:49:51.0109136+01:00",
      "RegisteredAssociateId": 188,
      "Updated": "2020-11-06T02:49:51.0109136+01:00",
      "UpdatedAssociateId": 70,
      "LegalBaseId": 475,
      "LegalBaseKey": "quas",
      "LegalBaseName": "Wyman, Pollich and Heaney",
      "ConsentPurposeId": 314,
      "ConsentPurposeKey": "et",
      "ConsentPurposeName": "Brown LLC",
      "ConsentSourceId": 853,
      "ConsentSourceKey": "in",
      "ConsentSourceName": "Rippin LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 415
        }
      }
    }
  ],
  "BounceEmails": [
    "amara@sanfordgrant.uk",
    "jordi_ferry@starkoconnell.biz"
  ],
  "ActiveStatusMonitorId": 964,
  "UserDefinedFields": {
    "SuperOffice:1": "Spencer Rozella Pacocha PhD",
    "SuperOffice:2": "545359096"
  },
  "ExtraFields": {
    "ExtraFields1": "totam",
    "ExtraFields2": "sapiente"
  },
  "CustomFields": {
    "CustomFields1": "aspernatur",
    "CustomFields2": "ut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 660
    }
  }
}
```