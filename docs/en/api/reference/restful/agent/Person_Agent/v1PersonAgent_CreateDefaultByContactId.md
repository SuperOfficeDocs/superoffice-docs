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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 807
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 679,
  "Firstname": "Ella",
  "MiddleName": "Crist, Hilpert and Schimmel",
  "Lastname": "Kilback",
  "Mrmrs": "molestiae",
  "Title": "consectetur",
  "UpdatedDate": "2014-05-28T23:03:56.4976253+02:00",
  "CreatedDate": "2004-04-07T23:03:56.4976253+02:00",
  "BirthDate": "2010-08-26T23:03:56.4976253+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "id",
      "StrippedValue": "natus",
      "Description": "Realigned intermediate moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 957
        }
      }
    },
    {
      "Value": "id",
      "StrippedValue": "natus",
      "Description": "Realigned intermediate moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 957
        }
      }
    }
  ],
  "Description": "User-centric secondary product",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "nihil",
      "StrippedValue": "pariatur",
      "Description": "Monitored grid-enabled alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 879
        }
      }
    },
    {
      "Value": "nihil",
      "StrippedValue": "pariatur",
      "Description": "Monitored grid-enabled alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 879
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quisquam",
      "StrippedValue": "dolorem",
      "Description": "Focused executive intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 186
        }
      }
    },
    {
      "Value": "quisquam",
      "StrippedValue": "dolorem",
      "Description": "Focused executive intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 186
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "non",
      "StrippedValue": "molestias",
      "Description": "Right-sized composite customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 499
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "molestias",
      "Description": "Right-sized composite customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 499
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "facere",
      "StrippedValue": "et",
      "Description": "Switchable cohesive synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 185
        }
      }
    },
    {
      "Value": "facere",
      "StrippedValue": "et",
      "Description": "Switchable cohesive synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 185
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "earum",
      "StrippedValue": "deleniti",
      "Description": "Upgradable client-server local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 232
        }
      }
    },
    {
      "Value": "earum",
      "StrippedValue": "deleniti",
      "Description": "Upgradable client-server local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 232
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
      "Id": 629,
      "Name": "Schumm, Murray and Ortiz",
      "ToolTip": "Et iure aspernatur quia harum.",
      "Deleted": false,
      "Rank": 302,
      "Type": "in",
      "ColorBlock": 74,
      "IconHint": "assumenda",
      "Selected": false,
      "LastChanged": "2020-09-13T23:03:56.5001218+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "in",
      "StyleHint": "omnis",
      "Hidden": false,
      "FullName": "Dr. Gail Bauch DVM",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 335
        }
      }
    }
  ],
  "PersonNumber": "871589",
  "FullName": "Loren Koepp",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "tenetur",
      "StrippedValue": "consequatur",
      "Description": "Pre-emptive executive policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 67
        }
      }
    },
    {
      "Value": "tenetur",
      "StrippedValue": "consequatur",
      "Description": "Pre-emptive executive policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 67
        }
      }
    }
  ],
  "FormalName": "McGlynn, Zulauf and Boyle",
  "Address": null,
  "Post3": "facere",
  "Post2": "et",
  "Post1": "rerum",
  "Kanalname": "illum",
  "Kanafname": "porro",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "iusto",
  "ActiveInterests": 122,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 343,
  "DbiKey": "itaque",
  "DbiLastModified": "2023-10-25T23:03:56.5036217+02:00",
  "DbiLastSyncronized": "2008-11-29T23:03:56.5036217+01:00",
  "SentInfo": 1001,
  "ShowContactTickets": 374,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "quia",
      "StrippedValue": "sit",
      "Description": "Quality-focused fault-tolerant encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 131
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "sit",
      "Description": "Quality-focused fault-tolerant encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 131
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "numquam",
      "StrippedValue": "occaecati",
      "Description": "Right-sized value-added toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 624
        }
      }
    },
    {
      "Value": "numquam",
      "StrippedValue": "occaecati",
      "Description": "Right-sized value-added toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 624
        }
      }
    }
  ],
  "Source": 828,
  "ActiveErpLinks": 227,
  "ShipmentTypes": [
    {
      "Id": 220,
      "Name": "D'Amore, McCullough and Stoltenberg",
      "ToolTip": "Vel magnam.",
      "Deleted": true,
      "Rank": 870,
      "Type": "ad",
      "ColorBlock": 471,
      "IconHint": "quisquam",
      "Selected": false,
      "LastChanged": "2012-10-17T23:03:56.5041214+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "omnis",
      "StyleHint": "sint",
      "Hidden": false,
      "FullName": "Maybelle Bogan MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 85
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 358,
      "Comment": "quaerat",
      "Registered": "2023-11-07T23:03:56.5041214+01:00",
      "RegisteredAssociateId": 8,
      "Updated": "2006-03-16T23:03:56.5041214+01:00",
      "UpdatedAssociateId": 607,
      "LegalBaseId": 482,
      "LegalBaseKey": "recusandae",
      "LegalBaseName": "Hilpert, Nienow and Cummerata",
      "ConsentPurposeId": 292,
      "ConsentPurposeKey": "qui",
      "ConsentPurposeName": "Wilderman-Fritsch",
      "ConsentSourceId": 706,
      "ConsentSourceKey": "necessitatibus",
      "ConsentSourceName": "Renner Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 379
        }
      }
    }
  ],
  "BounceEmails": [
    "lavada.funk@hagenes.ca",
    "maverick_franecki@ledner.ca"
  ],
  "ActiveStatusMonitorId": 892,
  "UserDefinedFields": {
    "SuperOffice:1": "Quinten Gleason",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "velit",
    "ExtraFields2": "laudantium"
  },
  "CustomFields": {
    "CustomFields1": "id",
    "CustomFields2": "iure"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 552
    }
  }
}
```