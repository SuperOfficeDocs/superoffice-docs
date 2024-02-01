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
Last-Modified: Fri, 12 Jul 2019 23:04:04 G7T

{
  "PersonId": 736,
  "Firstname": "Lizeth",
  "MiddleName": "Walter, Zieme and Schaden",
  "Lastname": "Hintz",
  "Mrmrs": "corrupti",
  "Title": "a",
  "UpdatedDate": "2019-07-12T23:04:04.2510167+02:00",
  "CreatedDate": "2003-09-08T23:04:04.2510167+02:00",
  "BirthDate": "2009-03-24T23:04:04.2510167+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "hic",
      "StrippedValue": "ipsum",
      "Description": "Future-proofed secondary pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 893
        }
      }
    },
    {
      "Value": "hic",
      "StrippedValue": "ipsum",
      "Description": "Future-proofed secondary pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 893
        }
      }
    }
  ],
  "Description": "Cross-group interactive service-desk",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "et",
      "StrippedValue": "nihil",
      "Description": "Upgradable cohesive structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 746
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "nihil",
      "Description": "Upgradable cohesive structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 746
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ratione",
      "StrippedValue": "earum",
      "Description": "Networked coherent conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 723
        }
      }
    },
    {
      "Value": "ratione",
      "StrippedValue": "earum",
      "Description": "Networked coherent conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 723
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "iusto",
      "StrippedValue": "dolores",
      "Description": "Right-sized system-worthy challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 442
        }
      }
    },
    {
      "Value": "iusto",
      "StrippedValue": "dolores",
      "Description": "Right-sized system-worthy challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 442
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "voluptate",
      "StrippedValue": "est",
      "Description": "Operative bi-directional strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 240
        }
      }
    },
    {
      "Value": "voluptate",
      "StrippedValue": "est",
      "Description": "Operative bi-directional strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 240
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "voluptas",
      "StrippedValue": "saepe",
      "Description": "Fully-configurable even-keeled knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 216
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "saepe",
      "Description": "Fully-configurable even-keeled knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 216
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
      "Id": 276,
      "Name": "Feest Inc and Sons",
      "ToolTip": "Doloremque corporis consequatur vel iusto.",
      "Deleted": false,
      "Rank": 24,
      "Type": "facilis",
      "ColorBlock": 237,
      "IconHint": "nemo",
      "Selected": false,
      "LastChanged": "2021-04-22T23:04:04.2530166+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "magnam",
      "StyleHint": "enim",
      "Hidden": false,
      "FullName": "Thalia Hahn IV",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 169
        }
      }
    }
  ],
  "PersonNumber": "1662094",
  "FullName": "Nina Hansen PhD",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "sed",
      "StrippedValue": "id",
      "Description": "User-friendly secondary circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 127
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "id",
      "Description": "User-friendly secondary circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 127
        }
      }
    }
  ],
  "FormalName": "Klocko, Jewess and Haley",
  "Address": null,
  "Post3": "ipsum",
  "Post2": "voluptatem",
  "Post1": "odio",
  "Kanalname": "vel",
  "Kanafname": "dolores",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "accusantium",
  "ActiveInterests": 104,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 726,
  "DbiKey": "eos",
  "DbiLastModified": "2016-08-20T23:04:04.2560159+02:00",
  "DbiLastSyncronized": "2021-10-22T23:04:04.2560159+02:00",
  "SentInfo": 30,
  "ShowContactTickets": 503,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "cupiditate",
      "StrippedValue": "libero",
      "Description": "Adaptive bandwidth-monitored extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 878
        }
      }
    },
    {
      "Value": "cupiditate",
      "StrippedValue": "libero",
      "Description": "Adaptive bandwidth-monitored extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 878
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "minus",
      "StrippedValue": "illo",
      "Description": "Persevering multimedia moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 364
        }
      }
    },
    {
      "Value": "minus",
      "StrippedValue": "illo",
      "Description": "Persevering multimedia moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 364
        }
      }
    }
  ],
  "Source": 819,
  "ActiveErpLinks": 635,
  "ShipmentTypes": [
    {
      "Id": 206,
      "Name": "Schroeder, Stiedemann and Price",
      "ToolTip": "Quod est.",
      "Deleted": false,
      "Rank": 554,
      "Type": "nulla",
      "ColorBlock": 695,
      "IconHint": "sed",
      "Selected": false,
      "LastChanged": "2015-04-27T23:04:04.2565181+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quia",
      "StyleHint": "culpa",
      "Hidden": true,
      "FullName": "Henry Cummerata",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 840
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 535,
      "Comment": "nihil",
      "Registered": "2003-12-20T23:04:04.2570176+01:00",
      "RegisteredAssociateId": 928,
      "Updated": "2004-07-25T23:04:04.2570176+02:00",
      "UpdatedAssociateId": 920,
      "LegalBaseId": 849,
      "LegalBaseKey": "laborum",
      "LegalBaseName": "Tremblay Inc and Sons",
      "ConsentPurposeId": 638,
      "ConsentPurposeKey": "est",
      "ConsentPurposeName": "Wehner, Rolfson and Frami",
      "ConsentSourceId": 541,
      "ConsentSourceKey": "distinctio",
      "ConsentSourceName": "Hyatt Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 905
        }
      }
    }
  ],
  "BounceEmails": [
    "amir@stehr.com",
    "zola.bashirian@zulauf.ca"
  ],
  "ActiveStatusMonitorId": 313,
  "UserDefinedFields": {
    "SuperOffice:1": "2017908608",
    "SuperOffice:2": "Ezequiel Moen"
  },
  "ExtraFields": {
    "ExtraFields1": "reprehenderit",
    "ExtraFields2": "delectus"
  },
  "CustomFields": {
    "CustomFields1": "omnis",
    "CustomFields2": "repellat"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 984
    }
  }
}
```