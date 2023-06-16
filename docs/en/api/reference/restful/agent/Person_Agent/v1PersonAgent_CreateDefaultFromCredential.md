---
title: POST Agents/Person/CreateDefaultFromCredential
uid: v1PersonAgent_CreateDefaultFromCredential
generated: true
---

# POST Agents/Person/CreateDefaultFromCredential

```http
POST /api/v1/Agents/Person/CreateDefaultFromCredential
```

Creates a PersonEntity with default values based on the contactId and credentials.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/CreateDefaultFromCredential?$select=name,department,category/id
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

ContactId, CredentialType, CredentialValue, CredentialDisplayValue 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |
| CredentialType | String |  |
| CredentialValue | String |  |
| CredentialDisplayValue | String |  |

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
POST /api/v1/Agents/Person/CreateDefaultFromCredential
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 616,
  "CredentialType": "ab",
  "CredentialValue": "consequatur",
  "CredentialDisplayValue": "sunt"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 485,
  "Firstname": "Josue",
  "MiddleName": "Auer-Heathcote",
  "Lastname": "Hoppe",
  "Mrmrs": "in",
  "Title": "quidem",
  "UpdatedDate": "2007-07-05T16:00:41.4300927+02:00",
  "CreatedDate": "2021-12-18T16:00:41.4300927+01:00",
  "BirthDate": "2021-02-12T16:00:41.4300927+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "ut",
      "StrippedValue": "eaque",
      "Description": "Switchable dedicated paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 13
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "eaque",
      "Description": "Switchable dedicated paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 13
        }
      }
    }
  ],
  "Description": "Customer-focused solution-oriented standardization",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "dolorem",
      "StrippedValue": "voluptas",
      "Description": "Implemented tertiary structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 370
        }
      }
    },
    {
      "Value": "dolorem",
      "StrippedValue": "voluptas",
      "Description": "Implemented tertiary structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 370
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ullam",
      "StrippedValue": "ex",
      "Description": "Persevering client-server model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 722
        }
      }
    },
    {
      "Value": "ullam",
      "StrippedValue": "ex",
      "Description": "Persevering client-server model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 722
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "dolorem",
      "StrippedValue": "fugiat",
      "Description": "Vision-oriented bottom-line throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 423
        }
      }
    },
    {
      "Value": "dolorem",
      "StrippedValue": "fugiat",
      "Description": "Vision-oriented bottom-line throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 423
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "ut",
      "StrippedValue": "quasi",
      "Description": "Centralized transitional infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 384
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "quasi",
      "Description": "Centralized transitional infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 384
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "reprehenderit",
      "StrippedValue": "non",
      "Description": "Ergonomic radical structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 584
        }
      }
    },
    {
      "Value": "reprehenderit",
      "StrippedValue": "non",
      "Description": "Ergonomic radical structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 584
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
      "Id": 369,
      "Name": "Hermiston-Frami",
      "ToolTip": "Autem sed sit.",
      "Deleted": false,
      "Rank": 176,
      "Type": "consequuntur",
      "ColorBlock": 804,
      "IconHint": "sit",
      "Selected": false,
      "LastChanged": "2005-08-24T16:00:41.4300927+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nemo",
      "StyleHint": "ipsam",
      "Hidden": true,
      "FullName": "Marc Lesch",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 470
        }
      }
    }
  ],
  "PersonNumber": "853788",
  "FullName": "Nicola Ledner",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "vel",
      "StrippedValue": "tempora",
      "Description": "Extended maximized system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 823
        }
      }
    },
    {
      "Value": "vel",
      "StrippedValue": "tempora",
      "Description": "Extended maximized system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 823
        }
      }
    }
  ],
  "FormalName": "Schumm Inc and Sons",
  "Address": null,
  "Post3": "ut",
  "Post2": "rem",
  "Post1": "consequatur",
  "Kanalname": "consequatur",
  "Kanafname": "reiciendis",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "accusantium",
  "ActiveInterests": 337,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 958,
  "DbiKey": "rerum",
  "DbiLastModified": "2000-11-20T16:00:41.4300927+01:00",
  "DbiLastSyncronized": "2010-12-17T16:00:41.4300927+01:00",
  "SentInfo": 261,
  "ShowContactTickets": 49,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "aut",
      "StrippedValue": "qui",
      "Description": "Horizontal neutral monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 375
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "qui",
      "Description": "Horizontal neutral monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 375
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "dolorem",
      "StrippedValue": "officia",
      "Description": "Persevering regional initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 898
        }
      }
    },
    {
      "Value": "dolorem",
      "StrippedValue": "officia",
      "Description": "Persevering regional initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 898
        }
      }
    }
  ],
  "Source": 545,
  "ActiveErpLinks": 1001,
  "ShipmentTypes": [
    {
      "Id": 656,
      "Name": "Predovic, Herzog and Bernier",
      "ToolTip": "Laboriosam atque magni ut.",
      "Deleted": false,
      "Rank": 313,
      "Type": "neque",
      "ColorBlock": 882,
      "IconHint": "veritatis",
      "Selected": false,
      "LastChanged": "2010-04-25T16:00:41.4300927+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "magni",
      "StyleHint": "reiciendis",
      "Hidden": true,
      "FullName": "Prof. Earline Daphnee Pagac III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 225
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 742,
      "Comment": "aut",
      "Registered": "2015-09-01T16:00:41.4300927+02:00",
      "RegisteredAssociateId": 542,
      "Updated": "1996-05-08T16:00:41.4300927+02:00",
      "UpdatedAssociateId": 768,
      "LegalBaseId": 181,
      "LegalBaseKey": "qui",
      "LegalBaseName": "Schamberger-Prosacco",
      "ConsentPurposeId": 264,
      "ConsentPurposeKey": "quae",
      "ConsentPurposeName": "White-Zboncak",
      "ConsentSourceId": 329,
      "ConsentSourceKey": "numquam",
      "ConsentSourceName": "O'Reilly Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 728
        }
      }
    }
  ],
  "BounceEmails": [
    "germaine.considine@rau.com",
    "grayce_kub@nicolas.co.uk"
  ],
  "ActiveStatusMonitorId": 846,
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Marge Damon Blanda",
    "SuperOffice:2": "Prof. Jolie Rath II"
  },
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "at"
  },
  "CustomFields": {
    "CustomFields1": "amet",
    "CustomFields2": "excepturi"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 117
    }
  }
}
```