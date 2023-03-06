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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 874,
  "Firstname": "Rogelio",
  "MiddleName": "Dach-Langosh",
  "Lastname": "Pfannerstill",
  "Mrmrs": "nisi",
  "Title": "delectus",
  "UpdatedDate": "2017-02-08T14:19:03.7488746+01:00",
  "CreatedDate": "2010-08-18T14:19:03.7488746+02:00",
  "BirthDate": "2018-05-23T14:19:03.7488746+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "est",
      "StrippedValue": "culpa",
      "Description": "Reactive analyzing middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 755
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "culpa",
      "Description": "Reactive analyzing middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 755
        }
      }
    }
  ],
  "Description": "Face to face secondary leverage",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "et",
      "StrippedValue": "laboriosam",
      "Description": "Face to face dedicated throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 865
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "laboriosam",
      "Description": "Face to face dedicated throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 865
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "adipisci",
      "StrippedValue": "inventore",
      "Description": "Phased grid-enabled application",
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
      "Value": "adipisci",
      "StrippedValue": "inventore",
      "Description": "Phased grid-enabled application",
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
  "MobilePhones": [
    {
      "Value": "nihil",
      "StrippedValue": "porro",
      "Description": "User-centric impactful middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 855
        }
      }
    },
    {
      "Value": "nihil",
      "StrippedValue": "porro",
      "Description": "User-centric impactful middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 855
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "est",
      "StrippedValue": "illo",
      "Description": "Multi-lateral static flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 51
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "illo",
      "Description": "Multi-lateral static flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 51
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "fugit",
      "StrippedValue": "molestiae",
      "Description": "Monitored actuating moratorium",
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
      "Value": "fugit",
      "StrippedValue": "molestiae",
      "Description": "Monitored actuating moratorium",
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
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 405,
      "Name": "Yundt, Cartwright and Dach",
      "ToolTip": "Et hic consequatur iste rerum aspernatur.",
      "Deleted": false,
      "Rank": 766,
      "Type": "sequi",
      "ColorBlock": 764,
      "IconHint": "ut",
      "Selected": false,
      "LastChanged": "2001-08-27T14:19:03.7488746+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "asperiores",
      "Hidden": false,
      "FullName": "Ansel Medhurst",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 306
        }
      }
    }
  ],
  "PersonNumber": "1589902",
  "FullName": "Brian Johnson",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "ab",
      "StrippedValue": "aperiam",
      "Description": "Ergonomic value-added framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 167
        }
      }
    },
    {
      "Value": "ab",
      "StrippedValue": "aperiam",
      "Description": "Ergonomic value-added framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 167
        }
      }
    }
  ],
  "FormalName": "Block, Kutch and Bernhard",
  "Address": null,
  "Post3": "non",
  "Post2": "rerum",
  "Post1": "fuga",
  "Kanalname": "ut",
  "Kanafname": "repellendus",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "omnis",
  "ActiveInterests": 559,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 216,
  "DbiKey": "cumque",
  "DbiLastModified": "2019-11-10T14:19:03.7488746+01:00",
  "DbiLastSyncronized": "2007-05-04T14:19:03.7488746+02:00",
  "SentInfo": 765,
  "ShowContactTickets": 406,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "libero",
      "StrippedValue": "et",
      "Description": "Inverse zero defect orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 569
        }
      }
    },
    {
      "Value": "libero",
      "StrippedValue": "et",
      "Description": "Inverse zero defect orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 569
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "et",
      "StrippedValue": "quidem",
      "Description": "User-friendly cohesive workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 333
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "quidem",
      "Description": "User-friendly cohesive workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 333
        }
      }
    }
  ],
  "Source": 883,
  "ActiveErpLinks": 312,
  "ShipmentTypes": [
    {
      "Id": 292,
      "Name": "Lindgren-Lebsack",
      "ToolTip": "Voluptatem alias.",
      "Deleted": true,
      "Rank": 9,
      "Type": "ut",
      "ColorBlock": 145,
      "IconHint": "id",
      "Selected": true,
      "LastChanged": "2016-03-09T14:19:03.7488746+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quia",
      "StyleHint": "est",
      "Hidden": true,
      "FullName": "Lexie Jewess",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 308
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 39,
      "Comment": "corporis",
      "Registered": "2006-06-24T14:19:03.7488746+02:00",
      "RegisteredAssociateId": 145,
      "Updated": "2005-05-12T14:19:03.7488746+02:00",
      "UpdatedAssociateId": 429,
      "LegalBaseId": 529,
      "LegalBaseKey": "esse",
      "LegalBaseName": "Kessler-O'Conner",
      "ConsentPurposeId": 978,
      "ConsentPurposeKey": "quia",
      "ConsentPurposeName": "Harris Inc and Sons",
      "ConsentSourceId": 317,
      "ConsentSourceKey": "ducimus",
      "ConsentSourceName": "Rau-Walker",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 916
        }
      }
    }
  ],
  "BounceEmails": [
    "kelton@durgan.us",
    "giles_wiegand@tillman.co.uk"
  ],
  "ActiveStatusMonitorId": 617,
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Monica Heller",
    "SuperOffice:2": "Felicita Lynch"
  },
  "ExtraFields": {
    "ExtraFields1": "quam",
    "ExtraFields2": "velit"
  },
  "CustomFields": {
    "CustomFields1": "omnis",
    "CustomFields2": "non"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 494
    }
  }
}
```