---
title: POST Agents/Person/SavePersonEntity
uid: v1PersonAgent_SavePersonEntity
generated: true
---

# POST Agents/Person/SavePersonEntity

```http
POST /api/v1/Agents/Person/SavePersonEntity
```

Updates the existing PersonEntity or creates a new PersonEntity if the id parameter is empty








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

## Request Body: entity 

The PersonEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | Integer | Primary key |
| Firstname | String | First name |
| MiddleName | String | Middle name or 'van' etc. |
| Lastname | String | Last name |
| Mrmrs | String | e.g. Mrs   sex_title  <para>Use MDO List name "mrmrs" to get list items.</para> |
| Title | String | Title |
| UpdatedDate | String | Last updated date  in UTC. |
| CreatedDate | String | Registered date  in UTC. |
| BirthDate | String | The Person birth date as UTC Date. Year 1 = Null. Year 2 = unknown year. |
| CreatedBy | Associate | The user that created the person object |
| Emails | Array | A collection of the person's emails |
| Description | String | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| IsAssociate | Boolean | Checks if the person object is an associate. The property is read-only. |
| PrivatePhones | Array | Returns a collection of phone numbers that belong to the contact person. |
| Faxes | Array | Returns a collection of fax numbers that belong to the contact person. |
| MobilePhones | Array | Returns a collection of mobile phone numbers that belong to the contact person. |
| OfficePhones | Array | Returns a collection of office phone numbers that belong to the contact person. |
| OtherPhones | Array | Returns a collection of pagers that belong to the contact person. |
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  <para>Use MDO List name "perspos" to get list items.</para> |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  <para>Use MDO List name "contact_new" to get list items.</para> |
| Country | Country | The country this contact person is located in.  <para>Use MDO List name "country" to get list items.</para> |
| Interests | Array | The person's available and selected interests.  <para>Use MDO List name "persint" to get list items.</para> |
| PersonNumber | String | Alphanumeric user field |
| FullName | String | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| NoMailing | Boolean | Spam filter. Indicates if this person should retrieve advertising. |
| UsePersonAddress | Boolean | True if the person's address should be used as mailing address, instead of the contact's address. |
| Retired | Boolean | True if the user is retired and should have no rights, not appear in lists, etc. |
| Urls | Array | The urls related to this person. |
| FormalName | String | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| Address | Address | Structure holding formatted address data. The layout of the array structure indicates the layout of the localized address. |
| Post3 | String | Postal address, used in Japanese versions only |
| Post2 | String | Postal address, used in Japanese versions only |
| Post1 | String | Postal address, used in Japanese versions only |
| Kanalname | String | Kana last name, used in Japanese versions only |
| Kanafname | String | Kana first name, used in Japanese versions only |
| CorrespondingAssociate | Associate | The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user). |
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "category" to get list items.</para> |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "business" to get list items.</para> |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  <para>Use MDO List name "associate" to get list items.</para> |
| Salutation | String | Academic title, populated from Salutation list but can be overwritten with anything at all  <para>Use MDO List name "salutation" to get list items.</para> |
| ActiveInterests | Integer | The number of active interests. |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | <para>Use MDO List name "customerlanguage" to get list items.</para> |
| DbiAgentId | Integer | Integration agent (eJournal) |
| DbiKey | String | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | String | When the entry was last modified. |
| DbiLastSyncronized | String | Last external syncronization. |
| SentInfo | Integer | Has information on username/password been sent (ejournal) |
| ShowContactTickets | Integer | Should tickets related to the company be shown to this person |
| UserInfo | UserInfo | Information about the user if this person is a user.  If IsAssociate (e.g. is user is true) the UserInfo will be provided. |
| ChatEmails | Array |  |
| InternetPhones | Array |  |
| Source | Integer | How did we get this person? For future integration needs |
| ActiveErpLinks | Integer | How many active ERP links are there for this person? |
| ShipmentTypes | Array | The person's available and selected shipment types. |
| Consents | Array | The person's available consent information. Missing consents are not deleted. To remove a consent, mark its legalbase as 'WITHDRAWN' |
| BounceEmails | Array | Email addresses with a positive bounce counter. |
| ActiveStatusMonitorId | Integer | Active status monitor identity with the lowest rank for person |
| CreatedByFormId | Integer | The form id of the form that created the person |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

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
| Mrmrs | string | e.g. Mrs   sex_title  Use MDO List name "mrmrs" to get list items. |
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
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  Use MDO List name "perspos" to get list items. |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  Use MDO List name "contact_new" to get list items. |
| Country | Country | The country this contact person is located in.  Use MDO List name "country" to get list items. |
| Interests | array | The person's available and selected interests.  Use MDO List name "persint" to get list items. |
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
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  Use MDO List name "category" to get list items. |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  Use MDO List name "business" to get list items. |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  Use MDO List name "associate" to get list items. |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  Use MDO List name "salutation" to get list items. |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | Use MDO List name "customerlanguage" to get list items. |
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
| CreatedByFormId | int32 | The form id of the form that created the person |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Person/SavePersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 413,
  "Firstname": "Elissa",
  "MiddleName": "Rippin Inc and Sons",
  "Lastname": "Kozey",
  "Mrmrs": "fugiat",
  "Title": "nostrum",
  "UpdatedDate": "2007-10-31T14:13:40.6096835+01:00",
  "CreatedDate": "2023-06-06T14:13:40.6096835+02:00",
  "BirthDate": "2005-05-24T14:13:40.6096835+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "porro",
      "StrippedValue": "nisi",
      "Description": "Focused needs-based core"
    },
    {
      "Value": "porro",
      "StrippedValue": "nisi",
      "Description": "Focused needs-based core"
    }
  ],
  "Description": "Multi-channelled solution-oriented migration",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "beatae",
      "StrippedValue": "eos",
      "Description": "Digitized human-resource approach"
    },
    {
      "Value": "beatae",
      "StrippedValue": "eos",
      "Description": "Digitized human-resource approach"
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "doloribus",
      "Description": "Streamlined upward-trending website"
    },
    {
      "Value": "et",
      "StrippedValue": "doloribus",
      "Description": "Streamlined upward-trending website"
    }
  ],
  "MobilePhones": [
    {
      "Value": "neque",
      "StrippedValue": "quis",
      "Description": "Assimilated dynamic attitude"
    },
    {
      "Value": "neque",
      "StrippedValue": "quis",
      "Description": "Assimilated dynamic attitude"
    }
  ],
  "OfficePhones": [
    {
      "Value": "corrupti",
      "StrippedValue": "ut",
      "Description": "Persistent global interface"
    },
    {
      "Value": "corrupti",
      "StrippedValue": "ut",
      "Description": "Persistent global interface"
    }
  ],
  "OtherPhones": [
    {
      "Value": "neque",
      "StrippedValue": "libero",
      "Description": "Distributed incremental superstructure"
    },
    {
      "Value": "neque",
      "StrippedValue": "libero",
      "Description": "Distributed incremental superstructure"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 128,
      "Name": "O'Keefe Inc and Sons",
      "ToolTip": "Quos doloremque pariatur voluptatem.",
      "Deleted": true,
      "Rank": 585,
      "Type": "expedita",
      "ColorBlock": 934,
      "IconHint": "ipsam",
      "Selected": false,
      "LastChanged": "2021-05-23T14:13:40.625305+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "laborum",
      "StyleHint": "totam",
      "Hidden": true,
      "FullName": "Miss Maximus Alberta Balistreri MD"
    }
  ],
  "PersonNumber": "1178759",
  "FullName": "Haylee McGlynn I",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "temporibus",
      "StrippedValue": "quisquam",
      "Description": "Public-key responsive orchestration"
    },
    {
      "Value": "temporibus",
      "StrippedValue": "quisquam",
      "Description": "Public-key responsive orchestration"
    }
  ],
  "FormalName": "Rempel-Halvorson",
  "Address": null,
  "Post3": "voluptas",
  "Post2": "reprehenderit",
  "Post1": "velit",
  "Kanalname": "ullam",
  "Kanafname": "atque",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "eius",
  "ActiveInterests": 718,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 400,
  "DbiKey": "modi",
  "DbiLastModified": "2004-01-24T14:13:40.625305+01:00",
  "DbiLastSyncronized": "2018-06-03T14:13:40.625305+02:00",
  "SentInfo": 918,
  "ShowContactTickets": 709,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "vitae",
      "StrippedValue": "ab",
      "Description": "Synergistic national artificial intelligence"
    },
    {
      "Value": "vitae",
      "StrippedValue": "ab",
      "Description": "Synergistic national artificial intelligence"
    }
  ],
  "InternetPhones": [
    {
      "Value": "quaerat",
      "StrippedValue": "qui",
      "Description": "Proactive encompassing infrastructure"
    },
    {
      "Value": "quaerat",
      "StrippedValue": "qui",
      "Description": "Proactive encompassing infrastructure"
    }
  ],
  "Source": 276,
  "ActiveErpLinks": 686,
  "ShipmentTypes": [
    {
      "Id": 867,
      "Name": "Heller, Howe and Cormier",
      "ToolTip": "Rerum temporibus.",
      "Deleted": false,
      "Rank": 274,
      "Type": "rerum",
      "ColorBlock": 835,
      "IconHint": "asperiores",
      "Selected": true,
      "LastChanged": "2002-08-25T14:13:40.625305+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatem",
      "StyleHint": "quos",
      "Hidden": false,
      "FullName": "Treva Hackett"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 72,
      "Comment": "nihil",
      "Registered": "2006-01-25T14:13:40.625305+01:00",
      "RegisteredAssociateId": 468,
      "Updated": "2003-12-11T14:13:40.625305+01:00",
      "UpdatedAssociateId": 831,
      "LegalBaseId": 105,
      "LegalBaseKey": "soluta",
      "LegalBaseName": "Jenkins, Johns and Gibson",
      "ConsentPurposeId": 912,
      "ConsentPurposeKey": "magni",
      "ConsentPurposeName": "McGlynn-Christiansen",
      "ConsentSourceId": 961,
      "ConsentSourceKey": "a",
      "ConsentSourceName": "Orn-Cruickshank"
    }
  ],
  "BounceEmails": [
    "heidi@romaguerawelch.ca",
    "ahmed@hillsrussel.info"
  ],
  "ActiveStatusMonitorId": 261,
  "CreatedByFormId": 293,
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Joannie Leanne Watsica",
    "SuperOffice:2": "Deron Douglas Jr."
  },
  "ExtraFields": {
    "ExtraFields1": "provident",
    "ExtraFields2": "magni"
  },
  "CustomFields": {
    "CustomFields1": "optio",
    "CustomFields2": "tempora"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 281,
  "Firstname": "Bradley",
  "MiddleName": "Reilly Inc and Sons",
  "Lastname": "Ernser",
  "Mrmrs": "unde",
  "Title": "atque",
  "UpdatedDate": "2014-08-25T14:13:40.625305+02:00",
  "CreatedDate": "2008-12-24T14:13:40.625305+01:00",
  "BirthDate": "2020-12-31T14:13:40.625305+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "sapiente",
      "StrippedValue": "officiis",
      "Description": "Progressive next generation conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 251
        }
      }
    },
    {
      "Value": "sapiente",
      "StrippedValue": "officiis",
      "Description": "Progressive next generation conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 251
        }
      }
    }
  ],
  "Description": "Mandatory intermediate challenge",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "accusamus",
      "StrippedValue": "neque",
      "Description": "Public-key local process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 126
        }
      }
    },
    {
      "Value": "accusamus",
      "StrippedValue": "neque",
      "Description": "Public-key local process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 126
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "eveniet",
      "StrippedValue": "aut",
      "Description": "Public-key multimedia frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 714
        }
      }
    },
    {
      "Value": "eveniet",
      "StrippedValue": "aut",
      "Description": "Public-key multimedia frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 714
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "harum",
      "StrippedValue": "voluptas",
      "Description": "Extended real-time initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 669
        }
      }
    },
    {
      "Value": "harum",
      "StrippedValue": "voluptas",
      "Description": "Extended real-time initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 669
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "asperiores",
      "StrippedValue": "nisi",
      "Description": "Versatile upward-trending application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 907
        }
      }
    },
    {
      "Value": "asperiores",
      "StrippedValue": "nisi",
      "Description": "Versatile upward-trending application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 907
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "quo",
      "StrippedValue": "quibusdam",
      "Description": "Horizontal global toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 831
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "quibusdam",
      "Description": "Horizontal global toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 831
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
      "Id": 685,
      "Name": "Lehner Inc and Sons",
      "ToolTip": "Corrupti quod nobis molestiae facere.",
      "Deleted": true,
      "Rank": 209,
      "Type": "accusamus",
      "ColorBlock": 765,
      "IconHint": "assumenda",
      "Selected": true,
      "LastChanged": "2012-04-13T14:13:40.625305+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "qui",
      "StyleHint": "reprehenderit",
      "Hidden": false,
      "FullName": "Mr. Jevon Desmond Glover Jr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 187
        }
      }
    }
  ],
  "PersonNumber": "1111889",
  "FullName": "Mr. Marlee Schuster Sr.",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "eos",
      "StrippedValue": "expedita",
      "Description": "Automated methodical instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 1001
        }
      }
    },
    {
      "Value": "eos",
      "StrippedValue": "expedita",
      "Description": "Automated methodical instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 1001
        }
      }
    }
  ],
  "FormalName": "King Inc and Sons",
  "Address": null,
  "Post3": "at",
  "Post2": "repudiandae",
  "Post1": "error",
  "Kanalname": "et",
  "Kanafname": "temporibus",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "velit",
  "ActiveInterests": 589,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 140,
  "DbiKey": "nesciunt",
  "DbiLastModified": "2018-05-16T14:13:40.6409266+02:00",
  "DbiLastSyncronized": "2009-11-01T14:13:40.6409266+01:00",
  "SentInfo": 118,
  "ShowContactTickets": 686,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "et",
      "StrippedValue": "soluta",
      "Description": "Persevering empowering workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 445
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "soluta",
      "Description": "Persevering empowering workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 445
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "eos",
      "StrippedValue": "molestias",
      "Description": "Streamlined client-driven success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 474
        }
      }
    },
    {
      "Value": "eos",
      "StrippedValue": "molestias",
      "Description": "Streamlined client-driven success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 474
        }
      }
    }
  ],
  "Source": 2,
  "ActiveErpLinks": 375,
  "ShipmentTypes": [
    {
      "Id": 71,
      "Name": "Witting Group",
      "ToolTip": "Est aut.",
      "Deleted": false,
      "Rank": 395,
      "Type": "facilis",
      "ColorBlock": 405,
      "IconHint": "aspernatur",
      "Selected": false,
      "LastChanged": "2006-05-12T14:13:40.6409266+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "optio",
      "StyleHint": "in",
      "Hidden": false,
      "FullName": "Alysson Lueilwitz",
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
  "Consents": [
    {
      "ConsentPersonId": 643,
      "Comment": "et",
      "Registered": "2023-01-14T14:13:40.6409266+01:00",
      "RegisteredAssociateId": 54,
      "Updated": "2006-07-31T14:13:40.6409266+02:00",
      "UpdatedAssociateId": 544,
      "LegalBaseId": 439,
      "LegalBaseKey": "nesciunt",
      "LegalBaseName": "Willms-Monahan",
      "ConsentPurposeId": 32,
      "ConsentPurposeKey": "voluptatum",
      "ConsentPurposeName": "Champlin, Gleichner and Cummerata",
      "ConsentSourceId": 864,
      "ConsentSourceKey": "perspiciatis",
      "ConsentSourceName": "Brakus, Hills and O'Conner",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 767
        }
      }
    }
  ],
  "BounceEmails": [
    "aimee@hilperttreutel.biz",
    "fausto_davis@breitenberg.co.uk"
  ],
  "ActiveStatusMonitorId": 41,
  "CreatedByFormId": 471,
  "UserDefinedFields": {
    "SuperOffice:1": "1169279273",
    "SuperOffice:2": "1434131668"
  },
  "ExtraFields": {
    "ExtraFields1": "vel",
    "ExtraFields2": "facere"
  },
  "CustomFields": {
    "CustomFields1": "aliquam",
    "CustomFields2": "placeat"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 707
    }
  }
}
```