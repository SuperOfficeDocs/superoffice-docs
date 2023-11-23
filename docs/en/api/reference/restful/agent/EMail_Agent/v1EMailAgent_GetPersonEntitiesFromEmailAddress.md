---
title: POST Agents/EMail/GetPersonEntitiesFromEmailAddress
uid: v1EMailAgent_GetPersonEntitiesFromEmailAddress
generated: true
---

# POST Agents/EMail/GetPersonEntitiesFromEmailAddress

```http
POST /api/v1/Agents/EMail/GetPersonEntitiesFromEmailAddress
```

Get all persons and contacts with the given email address


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetPersonEntitiesFromEmailAddress?$select=name,department,category/id
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

EmailAddress 

| Property Name | Type |  Description |
|----------------|------|--------------|
| EmailAddress | String |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

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
POST /api/v1/Agents/EMail/GetPersonEntitiesFromEmailAddress
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "EmailAddress": "maximillian@gibson.info"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "PersonId": 773,
    "Firstname": "Jimmy",
    "MiddleName": "Glover-Ebert",
    "Lastname": "Pfannerstill",
    "Mrmrs": "voluptate",
    "Title": "eum",
    "UpdatedDate": "2000-02-17T13:38:13.5458695+01:00",
    "CreatedDate": "2011-05-16T13:38:13.5458695+02:00",
    "BirthDate": "2009-11-25T13:38:13.5458695+01:00",
    "CreatedBy": null,
    "Emails": [
      {
        "Value": "assumenda",
        "StrippedValue": "cum",
        "Description": "Proactive cohesive frame",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 425
          }
        }
      },
      {
        "Value": "assumenda",
        "StrippedValue": "cum",
        "Description": "Proactive cohesive frame",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 425
          }
        }
      }
    ],
    "Description": "Visionary tangible moderator",
    "IsAssociate": false,
    "PrivatePhones": [
      {
        "Value": "ducimus",
        "StrippedValue": "voluptas",
        "Description": "Fully-configurable holistic matrices",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 98
          }
        }
      },
      {
        "Value": "ducimus",
        "StrippedValue": "voluptas",
        "Description": "Fully-configurable holistic matrices",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 98
          }
        }
      }
    ],
    "Faxes": [
      {
        "Value": "quisquam",
        "StrippedValue": "tenetur",
        "Description": "Expanded bi-directional utilisation",
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
        "Value": "quisquam",
        "StrippedValue": "tenetur",
        "Description": "Expanded bi-directional utilisation",
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
    "MobilePhones": [
      {
        "Value": "officia",
        "StrippedValue": "eos",
        "Description": "Horizontal 4th generation interface",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 479
          }
        }
      },
      {
        "Value": "officia",
        "StrippedValue": "eos",
        "Description": "Horizontal 4th generation interface",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 479
          }
        }
      }
    ],
    "OfficePhones": [
      {
        "Value": "voluptate",
        "StrippedValue": "qui",
        "Description": "Persevering systemic protocol",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 536
          }
        }
      },
      {
        "Value": "voluptate",
        "StrippedValue": "qui",
        "Description": "Persevering systemic protocol",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 536
          }
        }
      }
    ],
    "OtherPhones": [
      {
        "Value": "sed",
        "StrippedValue": "mollitia",
        "Description": "Expanded 24 hour artificial intelligence",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 452
          }
        }
      },
      {
        "Value": "sed",
        "StrippedValue": "mollitia",
        "Description": "Expanded 24 hour artificial intelligence",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 452
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
        "Id": 323,
        "Name": "Gibson-Mitchell",
        "ToolTip": "Qui sint et sed est laudantium.",
        "Deleted": false,
        "Rank": 642,
        "Type": "aut",
        "ColorBlock": 355,
        "IconHint": "similique",
        "Selected": false,
        "LastChanged": "2014-07-30T13:38:13.5614895+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quae",
        "StyleHint": "qui",
        "Hidden": true,
        "FullName": "Zachary Stroman",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 438
          }
        }
      }
    ],
    "PersonNumber": "438273",
    "FullName": "Dr. Jada Runolfsdottir",
    "NoMailing": false,
    "UsePersonAddress": true,
    "Retired": false,
    "Urls": [
      {
        "Value": "tempora",
        "StrippedValue": "nulla",
        "Description": "Up-sized grid-enabled installation",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 411
          }
        }
      },
      {
        "Value": "tempora",
        "StrippedValue": "nulla",
        "Description": "Up-sized grid-enabled installation",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 411
          }
        }
      }
    ],
    "FormalName": "Bernier Group",
    "Address": null,
    "Post3": "placeat",
    "Post2": "provident",
    "Post1": "iusto",
    "Kanalname": "eos",
    "Kanafname": "sit",
    "CorrespondingAssociate": null,
    "Category": null,
    "Business": null,
    "Associate": null,
    "Salutation": "odio",
    "ActiveInterests": 979,
    "SupportAssociate": null,
    "TicketPriority": null,
    "CustomerLanguage": null,
    "DbiAgentId": 24,
    "DbiKey": "iste",
    "DbiLastModified": "2018-11-26T13:38:13.5614895+01:00",
    "DbiLastSyncronized": "2018-09-21T13:38:13.5614895+02:00",
    "SentInfo": 281,
    "ShowContactTickets": 441,
    "UserInfo": null,
    "ChatEmails": [
      {
        "Value": "atque",
        "StrippedValue": "est",
        "Description": "Reverse-engineered bi-directional application",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 886
          }
        }
      },
      {
        "Value": "atque",
        "StrippedValue": "est",
        "Description": "Reverse-engineered bi-directional application",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 886
          }
        }
      }
    ],
    "InternetPhones": [
      {
        "Value": "odit",
        "StrippedValue": "natus",
        "Description": "Implemented zero defect access",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 759
          }
        }
      },
      {
        "Value": "odit",
        "StrippedValue": "natus",
        "Description": "Implemented zero defect access",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 759
          }
        }
      }
    ],
    "Source": 971,
    "ActiveErpLinks": 822,
    "ShipmentTypes": [
      {
        "Id": 770,
        "Name": "Rutherford-Walsh",
        "ToolTip": "Dolores consequatur quos aliquam.",
        "Deleted": false,
        "Rank": 901,
        "Type": "et",
        "ColorBlock": 610,
        "IconHint": "aut",
        "Selected": false,
        "LastChanged": "2018-11-29T13:38:13.5614895+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "maiores",
        "StyleHint": "perspiciatis",
        "Hidden": false,
        "FullName": "Baby Schiller",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 854
          }
        }
      }
    ],
    "Consents": [
      {
        "ConsentPersonId": 632,
        "Comment": "officia",
        "Registered": "2021-01-31T13:38:13.5614895+01:00",
        "RegisteredAssociateId": 546,
        "Updated": "2013-03-21T13:38:13.5614895+01:00",
        "UpdatedAssociateId": 753,
        "LegalBaseId": 843,
        "LegalBaseKey": "tempora",
        "LegalBaseName": "Gutmann LLC",
        "ConsentPurposeId": 273,
        "ConsentPurposeKey": "est",
        "ConsentPurposeName": "Osinski Group",
        "ConsentSourceId": 702,
        "ConsentSourceKey": "dicta",
        "ConsentSourceName": "Casper, Deckow and Kihn",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 231
          }
        }
      }
    ],
    "BounceEmails": [
      "lorna@considine.ca",
      "lillie@johnsonmraz.co.uk"
    ],
    "ActiveStatusMonitorId": 741,
    "UserDefinedFields": {
      "SuperOffice:1": "Miss Antwan Carlotta Abshire IV",
      "SuperOffice:2": "False"
    },
    "ExtraFields": {
      "ExtraFields1": "itaque",
      "ExtraFields2": "aliquid"
    },
    "CustomFields": {
      "CustomFields1": "fugit",
      "CustomFields2": "id"
    },
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 101
      }
    }
  }
]
```