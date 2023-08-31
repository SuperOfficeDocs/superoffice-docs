---
title: POST Agents/Person/CreateDefaultPersonEntity
uid: v1PersonAgent_CreateDefaultPersonEntity
generated: true
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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Person/CreateDefaultPersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 641,
  "Firstname": "Damion",
  "MiddleName": "Larson Group",
  "Lastname": "Mayer",
  "Mrmrs": "omnis",
  "Title": "doloribus",
  "UpdatedDate": "2023-02-20T03:31:26.7925262+01:00",
  "CreatedDate": "2004-01-25T03:31:26.7925262+01:00",
  "BirthDate": "2021-06-12T03:31:26.7925262+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "voluptatem",
      "StrippedValue": "ab",
      "Description": "Total dynamic structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 188
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "ab",
      "Description": "Total dynamic structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 188
        }
      }
    }
  ],
  "Description": "Assimilated next generation service-desk",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "dolores",
      "StrippedValue": "repudiandae",
      "Description": "Versatile impactful flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 345
        }
      }
    },
    {
      "Value": "dolores",
      "StrippedValue": "repudiandae",
      "Description": "Versatile impactful flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 345
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "laudantium",
      "StrippedValue": "officia",
      "Description": "Reverse-engineered static protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 698
        }
      }
    },
    {
      "Value": "laudantium",
      "StrippedValue": "officia",
      "Description": "Reverse-engineered static protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 698
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "ut",
      "StrippedValue": "sed",
      "Description": "De-engineered dynamic benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 11
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "sed",
      "Description": "De-engineered dynamic benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 11
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "voluptates",
      "StrippedValue": "suscipit",
      "Description": "Streamlined client-server algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 666
        }
      }
    },
    {
      "Value": "voluptates",
      "StrippedValue": "suscipit",
      "Description": "Streamlined client-server algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 666
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "recusandae",
      "StrippedValue": "fugit",
      "Description": "Re-contextualized actuating complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 601
        }
      }
    },
    {
      "Value": "recusandae",
      "StrippedValue": "fugit",
      "Description": "Re-contextualized actuating complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 601
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
      "Id": 172,
      "Name": "Connelly, Langosh and Turcotte",
      "ToolTip": "Numquam minus laudantium numquam est voluptas.",
      "Deleted": true,
      "Rank": 767,
      "Type": "non",
      "ColorBlock": 623,
      "IconHint": "aut",
      "Selected": false,
      "LastChanged": "1999-04-11T03:31:26.7925262+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "possimus",
      "StyleHint": "autem",
      "Hidden": false,
      "FullName": "Orlando Labadie Sr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 707
        }
      }
    }
  ],
  "PersonNumber": "733578",
  "FullName": "Victor Herzog DDS",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "eum",
      "StrippedValue": "sint",
      "Description": "Function-based object-oriented strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 748
        }
      }
    },
    {
      "Value": "eum",
      "StrippedValue": "sint",
      "Description": "Function-based object-oriented strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 748
        }
      }
    }
  ],
  "FormalName": "Feest-Botsford",
  "Address": null,
  "Post3": "odit",
  "Post2": "qui",
  "Post1": "deserunt",
  "Kanalname": "voluptas",
  "Kanafname": "ea",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "suscipit",
  "ActiveInterests": 991,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 557,
  "DbiKey": "aliquid",
  "DbiLastModified": "2017-12-05T03:31:26.7925262+01:00",
  "DbiLastSyncronized": "2006-03-24T03:31:26.7925262+01:00",
  "SentInfo": 989,
  "ShowContactTickets": 550,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "rerum",
      "StrippedValue": "facilis",
      "Description": "Assimilated regional collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 812
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "facilis",
      "Description": "Assimilated regional collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 812
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "omnis",
      "StrippedValue": "qui",
      "Description": "Team-oriented heuristic local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 422
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "qui",
      "Description": "Team-oriented heuristic local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 422
        }
      }
    }
  ],
  "Source": 171,
  "ActiveErpLinks": 776,
  "ShipmentTypes": [
    {
      "Id": 864,
      "Name": "Schimmel Group",
      "ToolTip": "Tenetur asperiores nesciunt itaque expedita exercitationem doloribus.",
      "Deleted": false,
      "Rank": 9,
      "Type": "sapiente",
      "ColorBlock": 357,
      "IconHint": "iure",
      "Selected": true,
      "LastChanged": "2022-06-23T03:31:26.7925262+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "at",
      "StyleHint": "nesciunt",
      "Hidden": false,
      "FullName": "Miss Chris Dibbert V",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 127
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 718,
      "Comment": "similique",
      "Registered": "2008-01-24T03:31:26.7925262+01:00",
      "RegisteredAssociateId": 666,
      "Updated": "2021-01-13T03:31:26.7925262+01:00",
      "UpdatedAssociateId": 330,
      "LegalBaseId": 991,
      "LegalBaseKey": "mollitia",
      "LegalBaseName": "Fay, Leannon and Hilll",
      "ConsentPurposeId": 447,
      "ConsentPurposeKey": "aperiam",
      "ConsentPurposeName": "Kessler Inc and Sons",
      "ConsentSourceId": 660,
      "ConsentSourceKey": "officia",
      "ConsentSourceName": "Wiza, Orn and Nader",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 625
        }
      }
    }
  ],
  "BounceEmails": [
    "sigmund_stoltenberg@mclaughlin.info",
    "alfonso@murazik.com"
  ],
  "ActiveStatusMonitorId": 340,
  "UserDefinedFields": {
    "SuperOffice:1": "Ernesto Carroll",
    "SuperOffice:2": "Justyn Connelly"
  },
  "ExtraFields": {
    "ExtraFields1": "laboriosam",
    "ExtraFields2": "quas"
  },
  "CustomFields": {
    "CustomFields1": "facere",
    "CustomFields2": "sed"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 138
    }
  }
}
```