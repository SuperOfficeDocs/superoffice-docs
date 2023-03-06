---
title: POST Agents/Person/CreateDefaultFromCredential
uid: v1PersonAgent_CreateDefaultFromCredential
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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Person/CreateDefaultFromCredential
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 677,
  "CredentialType": "velit",
  "CredentialValue": "omnis",
  "CredentialDisplayValue": "velit"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 722,
  "Firstname": "Tatyana",
  "MiddleName": "Jacobi-Kub",
  "Lastname": "Ortiz",
  "Mrmrs": "in",
  "Title": "voluptatem",
  "UpdatedDate": "2020-05-19T14:19:03.8426256+02:00",
  "CreatedDate": "1999-06-12T14:19:03.8426256+02:00",
  "BirthDate": "1996-10-21T14:19:03.8426256+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "accusantium",
      "StrippedValue": "rerum",
      "Description": "Switchable empowering implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 24
        }
      }
    },
    {
      "Value": "accusantium",
      "StrippedValue": "rerum",
      "Description": "Switchable empowering implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 24
        }
      }
    }
  ],
  "Description": "Implemented non-volatile archive",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "quaerat",
      "StrippedValue": "qui",
      "Description": "Re-engineered secondary model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 170
        }
      }
    },
    {
      "Value": "quaerat",
      "StrippedValue": "qui",
      "Description": "Re-engineered secondary model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 170
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "molestias",
      "Description": "Universal scalable help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 24
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "molestias",
      "Description": "Universal scalable help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 24
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "cupiditate",
      "StrippedValue": "voluptas",
      "Description": "Expanded secondary customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 853
        }
      }
    },
    {
      "Value": "cupiditate",
      "StrippedValue": "voluptas",
      "Description": "Expanded secondary customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 853
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "sunt",
      "StrippedValue": "non",
      "Description": "Decentralized clear-thinking function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 600
        }
      }
    },
    {
      "Value": "sunt",
      "StrippedValue": "non",
      "Description": "Decentralized clear-thinking function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 600
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "numquam",
      "StrippedValue": "sed",
      "Description": "Expanded stable frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 327
        }
      }
    },
    {
      "Value": "numquam",
      "StrippedValue": "sed",
      "Description": "Expanded stable frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 327
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
      "Id": 5,
      "Name": "Harvey-Ankunding",
      "ToolTip": "Recusandae et earum.",
      "Deleted": true,
      "Rank": 659,
      "Type": "ut",
      "ColorBlock": 990,
      "IconHint": "a",
      "Selected": true,
      "LastChanged": "2014-02-23T14:19:03.8426256+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ipsa",
      "StyleHint": "sed",
      "Hidden": false,
      "FullName": "Liana Auer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 29
        }
      }
    }
  ],
  "PersonNumber": "1102633",
  "FullName": "Ms. Rupert Lesch DVM",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "commodi",
      "StrippedValue": "repellat",
      "Description": "Operative 24 hour function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 38
        }
      }
    },
    {
      "Value": "commodi",
      "StrippedValue": "repellat",
      "Description": "Operative 24 hour function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 38
        }
      }
    }
  ],
  "FormalName": "Torp-O'Connell",
  "Address": null,
  "Post3": "hic",
  "Post2": "quidem",
  "Post1": "repellendus",
  "Kanalname": "vel",
  "Kanafname": "numquam",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "voluptatem",
  "ActiveInterests": 303,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 228,
  "DbiKey": "qui",
  "DbiLastModified": "2017-07-25T14:19:03.8426256+02:00",
  "DbiLastSyncronized": "2022-11-25T14:19:03.8426256+01:00",
  "SentInfo": 566,
  "ShowContactTickets": 259,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "asperiores",
      "StrippedValue": "earum",
      "Description": "Vision-oriented national functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 438
        }
      }
    },
    {
      "Value": "asperiores",
      "StrippedValue": "earum",
      "Description": "Vision-oriented national functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 438
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "architecto",
      "StrippedValue": "cum",
      "Description": "Devolved systemic ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 252
        }
      }
    },
    {
      "Value": "architecto",
      "StrippedValue": "cum",
      "Description": "Devolved systemic ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 252
        }
      }
    }
  ],
  "Source": 183,
  "ActiveErpLinks": 485,
  "ShipmentTypes": [
    {
      "Id": 741,
      "Name": "Haley, Jacobs and Stehr",
      "ToolTip": "Id repellendus unde odit consequatur.",
      "Deleted": false,
      "Rank": 915,
      "Type": "aspernatur",
      "ColorBlock": 176,
      "IconHint": "ut",
      "Selected": true,
      "LastChanged": "2013-10-24T14:19:03.8426256+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quia",
      "StyleHint": "ullam",
      "Hidden": false,
      "FullName": "Nico Rutherford",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 944
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 62,
      "Comment": "recusandae",
      "Registered": "2005-11-03T14:19:03.8426256+01:00",
      "RegisteredAssociateId": 584,
      "Updated": "2021-07-24T14:19:03.8426256+02:00",
      "UpdatedAssociateId": 697,
      "LegalBaseId": 790,
      "LegalBaseKey": "optio",
      "LegalBaseName": "Fisher, Emard and Willms",
      "ConsentPurposeId": 680,
      "ConsentPurposeKey": "voluptatem",
      "ConsentPurposeName": "Kovacek-Hirthe",
      "ConsentSourceId": 484,
      "ConsentSourceKey": "at",
      "ConsentSourceName": "Bins Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 101
        }
      }
    }
  ],
  "BounceEmails": [
    "eloisa@granthowe.info",
    "vladimir@rosenbaumprice.name"
  ],
  "ActiveStatusMonitorId": 116,
  "UserDefinedFields": {
    "SuperOffice:1": "Makayla Botsford",
    "SuperOffice:2": "339388386"
  },
  "ExtraFields": {
    "ExtraFields1": "rem",
    "ExtraFields2": "quisquam"
  },
  "CustomFields": {
    "CustomFields1": "est",
    "CustomFields2": "non"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 241
    }
  }
}
```