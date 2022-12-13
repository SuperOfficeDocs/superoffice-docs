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
| ContactId | int32 |  |
| CredentialType | string |  |
| CredentialValue | string |  |
| CredentialDisplayValue | string |  |


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
POST /api/v1/Agents/Person/CreateDefaultFromCredential
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 591,
  "CredentialType": "consequuntur",
  "CredentialValue": "ut",
  "CredentialDisplayValue": "temporibus"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 197,
  "Firstname": "Juwan",
  "MiddleName": "Ryan Group",
  "Lastname": "Kirlin",
  "Mrmrs": "nemo",
  "Title": "facere",
  "UpdatedDate": "2001-11-21T02:49:44.8590895+01:00",
  "CreatedDate": "2014-07-28T02:49:44.8590895+02:00",
  "BirthDate": "2010-07-26T02:49:44.8590895+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "ullam",
      "StrippedValue": "voluptates",
      "Description": "Multi-layered homogeneous data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 14
        }
      }
    },
    {
      "Value": "ullam",
      "StrippedValue": "voluptates",
      "Description": "Multi-layered homogeneous data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 14
        }
      }
    }
  ],
  "Description": "Seamless radical framework",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "deserunt",
      "StrippedValue": "molestiae",
      "Description": "Adaptive web-enabled algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 419
        }
      }
    },
    {
      "Value": "deserunt",
      "StrippedValue": "molestiae",
      "Description": "Adaptive web-enabled algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 419
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "voluptates",
      "StrippedValue": "esse",
      "Description": "Seamless assymetric attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 608
        }
      }
    },
    {
      "Value": "voluptates",
      "StrippedValue": "esse",
      "Description": "Seamless assymetric attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 608
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "hic",
      "StrippedValue": "et",
      "Description": "Secured attitude-oriented orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 615
        }
      }
    },
    {
      "Value": "hic",
      "StrippedValue": "et",
      "Description": "Secured attitude-oriented orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 615
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "doloribus",
      "StrippedValue": "eveniet",
      "Description": "Fundamental clear-thinking methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 161
        }
      }
    },
    {
      "Value": "doloribus",
      "StrippedValue": "eveniet",
      "Description": "Fundamental clear-thinking methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 161
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "in",
      "StrippedValue": "occaecati",
      "Description": "Fundamental bandwidth-monitored alliance",
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
      "Value": "in",
      "StrippedValue": "occaecati",
      "Description": "Fundamental bandwidth-monitored alliance",
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
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 353,
      "Name": "White LLC",
      "ToolTip": "Aut illum nihil in nihil hic consequatur.",
      "Deleted": false,
      "Rank": 56,
      "Type": "et",
      "ColorBlock": 821,
      "IconHint": "aut",
      "Selected": true,
      "LastChanged": "2020-06-15T02:49:44.8590895+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "in",
      "StyleHint": "atque",
      "Hidden": true,
      "FullName": "Anna Schaden",
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
  "PersonNumber": "1097949",
  "FullName": "Miss Carson Dach IV",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "quo",
      "StrippedValue": "esse",
      "Description": "Integrated asynchronous architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 846
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "esse",
      "Description": "Integrated asynchronous architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 846
        }
      }
    }
  ],
  "FormalName": "Mueller LLC",
  "Address": null,
  "Post3": "pariatur",
  "Post2": "iste",
  "Post1": "repellat",
  "Kanalname": "ad",
  "Kanafname": "dolorem",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "possimus",
  "ActiveInterests": 46,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 70,
  "DbiKey": "excepturi",
  "DbiLastModified": "1997-03-26T02:49:44.8590895+01:00",
  "DbiLastSyncronized": "2020-03-19T02:49:44.8590895+01:00",
  "SentInfo": 526,
  "ShowContactTickets": 631,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "autem",
      "StrippedValue": "doloribus",
      "Description": "Organized demand-driven workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 366
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "doloribus",
      "Description": "Organized demand-driven workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 366
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "voluptatum",
      "StrippedValue": "consequuntur",
      "Description": "Down-sized client-driven artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 802
        }
      }
    },
    {
      "Value": "voluptatum",
      "StrippedValue": "consequuntur",
      "Description": "Down-sized client-driven artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 802
        }
      }
    }
  ],
  "Source": 786,
  "ActiveErpLinks": 924,
  "ShipmentTypes": [
    {
      "Id": 799,
      "Name": "Braun-Grant",
      "ToolTip": "Voluptatem voluptatibus repudiandae rerum quae odio voluptas quos.",
      "Deleted": true,
      "Rank": 329,
      "Type": "incidunt",
      "ColorBlock": 759,
      "IconHint": "soluta",
      "Selected": false,
      "LastChanged": "2000-01-10T02:49:44.8590895+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "fugiat",
      "StyleHint": "optio",
      "Hidden": true,
      "FullName": "Kailey Heaney II",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 132
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 614,
      "Comment": "mollitia",
      "Registered": "2000-05-14T02:49:44.8590895+02:00",
      "RegisteredAssociateId": 609,
      "Updated": "2001-02-28T02:49:44.8590895+01:00",
      "UpdatedAssociateId": 33,
      "LegalBaseId": 91,
      "LegalBaseKey": "repellendus",
      "LegalBaseName": "Lesch-Hansen",
      "ConsentPurposeId": 543,
      "ConsentPurposeKey": "et",
      "ConsentPurposeName": "Konopelski-Keebler",
      "ConsentSourceId": 912,
      "ConsentSourceKey": "et",
      "ConsentSourceName": "Goldner Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 318
        }
      }
    }
  ],
  "BounceEmails": [
    "edyth@yost.uk",
    "zane@connwilliamson.co.uk"
  ],
  "ActiveStatusMonitorId": 71,
  "UserDefinedFields": {
    "SuperOffice:1": "Lelia Will",
    "SuperOffice:2": "Mrs. Eudora Satterfield"
  },
  "ExtraFields": {
    "ExtraFields1": "excepturi",
    "ExtraFields2": "odio"
  },
  "CustomFields": {
    "CustomFields1": "nostrum",
    "CustomFields2": "sit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 575
    }
  }
}
```