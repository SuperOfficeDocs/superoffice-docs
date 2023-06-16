---
title: POST Agents/Person/CreateDefaultByContactId
uid: v1PersonAgent_CreateDefaultByContactId
generated: true
---

# POST Agents/Person/CreateDefaultByContactId

```http
POST /api/v1/Agents/Person/CreateDefaultByContactId
```

Creates a PersonEntity with default values based on the contactId.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/CreateDefaultByContactId?$select=name,department,category/id
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

ContactId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |

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
POST /api/v1/Agents/Person/CreateDefaultByContactId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 161
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 43,
  "Firstname": "Xzavier",
  "MiddleName": "Mann-Crooks",
  "Lastname": "Ziemann",
  "Mrmrs": "enim",
  "Title": "illum",
  "UpdatedDate": "2010-07-21T16:00:41.398849+02:00",
  "CreatedDate": "2016-08-19T16:00:41.398849+02:00",
  "BirthDate": "2001-12-16T16:00:41.398849+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "eveniet",
      "StrippedValue": "voluptatum",
      "Description": "Re-engineered high-level time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 433
        }
      }
    },
    {
      "Value": "eveniet",
      "StrippedValue": "voluptatum",
      "Description": "Re-engineered high-level time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 433
        }
      }
    }
  ],
  "Description": "Focused systematic model",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "omnis",
      "StrippedValue": "perferendis",
      "Description": "Vision-oriented context-sensitive intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 911
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "perferendis",
      "Description": "Vision-oriented context-sensitive intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 911
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "laborum",
      "StrippedValue": "sed",
      "Description": "Organized bi-directional open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 708
        }
      }
    },
    {
      "Value": "laborum",
      "StrippedValue": "sed",
      "Description": "Organized bi-directional open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 708
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "quia",
      "StrippedValue": "iste",
      "Description": "Compatible motivating access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 125
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "iste",
      "Description": "Compatible motivating access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 125
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "mollitia",
      "StrippedValue": "quod",
      "Description": "Quality-focused 4th generation interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 610
        }
      }
    },
    {
      "Value": "mollitia",
      "StrippedValue": "quod",
      "Description": "Quality-focused 4th generation interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 610
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "aut",
      "StrippedValue": "qui",
      "Description": "Cross-group modular info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 734
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "qui",
      "Description": "Cross-group modular info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 734
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
      "Id": 908,
      "Name": "Douglas Inc and Sons",
      "ToolTip": "Nihil et perferendis maiores.",
      "Deleted": true,
      "Rank": 807,
      "Type": "non",
      "ColorBlock": 63,
      "IconHint": "ad",
      "Selected": false,
      "LastChanged": "2015-12-09T16:00:41.4144676+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "officia",
      "StyleHint": "et",
      "Hidden": true,
      "FullName": "Dr. Jeffery Spencer MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 432
        }
      }
    }
  ],
  "PersonNumber": "1698576",
  "FullName": "Ms. Jonathon Clark Lesch PhD",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "porro",
      "StrippedValue": "ea",
      "Description": "Synchronised zero tolerance software",
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
      "Value": "porro",
      "StrippedValue": "ea",
      "Description": "Synchronised zero tolerance software",
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
  "FormalName": "Marks Group",
  "Address": null,
  "Post3": "voluptates",
  "Post2": "ut",
  "Post1": "veritatis",
  "Kanalname": "voluptas",
  "Kanafname": "doloremque",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "aut",
  "ActiveInterests": 451,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 268,
  "DbiKey": "enim",
  "DbiLastModified": "2020-02-26T16:00:41.4144676+01:00",
  "DbiLastSyncronized": "2011-12-28T16:00:41.4144676+01:00",
  "SentInfo": 326,
  "ShowContactTickets": 417,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "perferendis",
      "StrippedValue": "voluptas",
      "Description": "Public-key directional alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 288
        }
      }
    },
    {
      "Value": "perferendis",
      "StrippedValue": "voluptas",
      "Description": "Public-key directional alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 288
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "eligendi",
      "StrippedValue": "dicta",
      "Description": "Exclusive scalable concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 41
        }
      }
    },
    {
      "Value": "eligendi",
      "StrippedValue": "dicta",
      "Description": "Exclusive scalable concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 41
        }
      }
    }
  ],
  "Source": 78,
  "ActiveErpLinks": 797,
  "ShipmentTypes": [
    {
      "Id": 245,
      "Name": "Wiza, Kilback and Wintheiser",
      "ToolTip": "Iure accusamus ipsum dolor.",
      "Deleted": false,
      "Rank": 329,
      "Type": "ut",
      "ColorBlock": 120,
      "IconHint": "fuga",
      "Selected": false,
      "LastChanged": "2021-06-30T16:00:41.4144676+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "itaque",
      "StyleHint": "ducimus",
      "Hidden": false,
      "FullName": "Mrs. Aliyah Yost MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 369
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 352,
      "Comment": "similique",
      "Registered": "2019-06-03T16:00:41.4144676+02:00",
      "RegisteredAssociateId": 802,
      "Updated": "2014-11-23T16:00:41.4144676+01:00",
      "UpdatedAssociateId": 305,
      "LegalBaseId": 119,
      "LegalBaseKey": "facere",
      "LegalBaseName": "O'Keefe Inc and Sons",
      "ConsentPurposeId": 859,
      "ConsentPurposeKey": "dignissimos",
      "ConsentPurposeName": "Schaden-Lehner",
      "ConsentSourceId": 754,
      "ConsentSourceKey": "eos",
      "ConsentSourceName": "Connelly LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 493
        }
      }
    }
  ],
  "BounceEmails": [
    "zakary_cummings@mayer.biz",
    "mervin.mckenzie@armstrong.com"
  ],
  "ActiveStatusMonitorId": 39,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Miss Genoveva Ralph Crona"
  },
  "ExtraFields": {
    "ExtraFields1": "recusandae",
    "ExtraFields2": "sunt"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "accusantium"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 548
    }
  }
}
```