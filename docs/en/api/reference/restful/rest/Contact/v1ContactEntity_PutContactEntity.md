---
title: PUT Contact/{id}
uid: v1ContactEntity_PutContactEntity
generated: true
content_type: reference
---

# PUT Contact/{id}

```http
PUT /api/v1/Contact/{id}
```

Updates the existing ContactEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ContactEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Contact/{id}?$select=name,department,category/id
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

## Request Body: entity 

The ContactEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer | Primary key |
| Name | String | Contact name |
| Department | String | Department |
| OrgNr | String | VAT number or similar |
| Number1 | String | Alphanumeric user field |
| Number2 | String | Alphanumeric user field |
| UpdatedDate | String | Date last updated  in UTC. |
| CreatedDate | String | Date registered  in UTC. |
| Emails | Array | The contact's email |
| Interests | Array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | Array | The contact's internet adresses |
| Phones | Array | The contact's phone numbers |
| Faxes | Array | The contact's fax numbers |
| Description | String | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | Array | The persons belonging to the contact. |
| NoMailing | Boolean | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | String | Contact kana name, used in Japanese versions only |
| Xstop | Boolean | STOP flag |
| ActiveInterests | Integer | The number of active interests. |
| GroupId | Integer | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | Integer | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | Integer | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | Integer | Integration agent (eJournal) |
| DbiLastSyncronized | String | Last external syncronization. |
| DbiKey | String | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | String | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | Integer | How did we get this contact? For future integration needs |
| ActiveErpLinks | Integer | The number of active erp links |
| BounceEmails | Array | Email addresses with a positive bounce counter. |
| Domains | Array | Web domains for this contact, ordered in array by rank |
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

## Response:

ContactEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | ContactEntity updated. |
| 412 | Update stopped because ContactEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

### Response body: ContactEntityWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 | Primary key |
| Name | string | Contact name |
| Department | string | Department |
| OrgNr | string | VAT number or similar |
| Number1 | string | Alphanumeric user field |
| Number2 | string | Alphanumeric user field |
| UpdatedDate | date-time | Date last updated  in UTC. |
| CreatedDate | date-time | Date registered  in UTC. |
| Emails | array | The contact's email |
| Interests | array | The contact's available and selected interests.  Use MDO List name "contint" to get list items. |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  Use MDO List name "associate" to get list items. |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  Use MDO List name "business" to get list items. |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  Use MDO List name "category" to get list items. |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  Use MDO List name "country" to get list items. |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the Person Agent. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered.  Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 973,
  "Name": "Zieme, Jast and Kihn",
  "Department": "",
  "OrgNr": "1252093",
  "Number1": "905155",
  "Number2": "1149504",
  "UpdatedDate": "2020-07-28T03:41:58.5899065+02:00",
  "CreatedDate": "2003-05-14T03:41:58.5899065+02:00",
  "Emails": [
    {
      "Value": "magni",
      "StrippedValue": "ut",
      "Description": "Adaptive multimedia secured line"
    },
    {
      "Value": "magni",
      "StrippedValue": "ut",
      "Description": "Adaptive multimedia secured line"
    }
  ],
  "Interests": [
    {
      "Id": 702,
      "Name": "Emard-West",
      "ToolTip": "Voluptatibus illum voluptates officia voluptatem aliquam quidem voluptatem.",
      "Deleted": false,
      "Rank": 79,
      "Type": "quibusdam",
      "ColorBlock": 721,
      "IconHint": "quia",
      "Selected": false,
      "LastChanged": "2022-05-11T03:41:58.5899065+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nemo",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Dr. Anais Schimmel"
    }
  ],
  "Urls": [
    {
      "Value": "nihil",
      "StrippedValue": "fuga",
      "Description": "Switchable fault-tolerant portal"
    },
    {
      "Value": "nihil",
      "StrippedValue": "fuga",
      "Description": "Switchable fault-tolerant portal"
    }
  ],
  "Phones": [
    {
      "Value": "ea",
      "StrippedValue": "velit",
      "Description": "Reactive tangible hierarchy"
    },
    {
      "Value": "ea",
      "StrippedValue": "velit",
      "Description": "Reactive tangible hierarchy"
    }
  ],
  "Faxes": [
    {
      "Value": "rem",
      "StrippedValue": "eveniet",
      "Description": "Reverse-engineered 5th generation concept"
    },
    {
      "Value": "rem",
      "StrippedValue": "eveniet",
      "Description": "Reverse-engineered 5th generation concept"
    }
  ],
  "Description": "Optional optimal concept",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quidem",
      "PersonId": 85,
      "Mrmrs": "nulla",
      "Firstname": "Kirstin",
      "Lastname": "Runolfsdottir",
      "MiddleName": "Nienow-Schinner",
      "Title": "inventore",
      "Description": "Distributed value-added encryption",
      "Email": "brigitte@schneiderwatsica.uk",
      "FullName": "Keagan Jewess",
      "DirectPhone": "(046)385-3087 x335",
      "FormalName": "Wolf Group",
      "CountryId": 370,
      "ContactId": 623,
      "ContactName": "Stanton Inc and Sons",
      "Retired": 84,
      "Rank": 610,
      "ActiveInterests": 941,
      "ContactDepartment": "",
      "ContactCountryId": 398,
      "ContactOrgNr": "1297533",
      "FaxPhone": "(696)266-0709 x493",
      "MobilePhone": "107-080-1986 x057",
      "ContactPhone": "1-386-860-4267",
      "AssociateName": "Koss-Schuster",
      "AssociateId": 372,
      "UsePersonAddress": true,
      "ContactFax": "voluptas",
      "Kanafname": "modi",
      "Kanalname": "aut",
      "Post1": "iure",
      "Post2": "tenetur",
      "Post3": "officiis",
      "EmailName": "tanya@franeckirolfson.ca",
      "ContactFullName": "Marcella Jast",
      "ActiveErpLinks": 277,
      "TicketPriorityId": 557,
      "SupportLanguageId": 875,
      "SupportAssociateId": 770,
      "CategoryName": "VIP Customer",
      "PersonNumber": "636910"
    }
  ],
  "NoMailing": true,
  "Kananame": "iusto",
  "Xstop": false,
  "ActiveInterests": 324,
  "GroupId": 409,
  "ActiveStatusMonitorId": 390,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 378,
  "DbiAgentId": 515,
  "DbiLastSyncronized": "2002-06-09T03:41:58.5899065+02:00",
  "DbiKey": "dolorum",
  "DbiLastModified": "2005-03-06T03:41:58.5899065+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 769,
  "ActiveErpLinks": 426,
  "BounceEmails": [
    "alexandrine.kshlerin@mcclureconsidine.name",
    "deshawn_kreiger@botsford.name"
  ],
  "Domains": [
    "rerum",
    "accusantium"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Gerald Schowalter",
    "SuperOffice:2": "Amparo Parisian"
  },
  "ExtraFields": {
    "ExtraFields1": "vel",
    "ExtraFields2": "blanditiis"
  },
  "CustomFields": {
    "CustomFields1": "enim",
    "CustomFields2": "sed"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 310,
  "Name": "Swaniawski, Heidenreich and Beatty",
  "Department": "",
  "OrgNr": "1487222",
  "Number1": "285097",
  "Number2": "1841649",
  "UpdatedDate": "2012-03-20T03:41:58.5899065+01:00",
  "CreatedDate": "1998-07-11T03:41:58.5899065+02:00",
  "Emails": [
    {
      "Value": "fuga",
      "StrippedValue": "tempora",
      "Description": "Business-focused demand-driven project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 629
        }
      }
    },
    {
      "Value": "fuga",
      "StrippedValue": "tempora",
      "Description": "Business-focused demand-driven project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 629
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 867,
      "Name": "Mohr Group",
      "ToolTip": "Quisquam unde aperiam ipsum omnis.",
      "Deleted": true,
      "Rank": 455,
      "Type": "officia",
      "ColorBlock": 258,
      "IconHint": "eos",
      "Selected": false,
      "LastChanged": "2016-05-31T03:41:58.5899065+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "non",
      "StyleHint": "deserunt",
      "Hidden": true,
      "FullName": "Crawford Mayer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 579
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "molestiae",
      "StrippedValue": "perspiciatis",
      "Description": "Synchronised exuding functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 36
        }
      }
    },
    {
      "Value": "molestiae",
      "StrippedValue": "perspiciatis",
      "Description": "Synchronised exuding functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 36
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "explicabo",
      "StrippedValue": "nostrum",
      "Description": "Synergized hybrid service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 540
        }
      }
    },
    {
      "Value": "explicabo",
      "StrippedValue": "nostrum",
      "Description": "Synergized hybrid service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 540
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "non",
      "StrippedValue": "consequuntur",
      "Description": "Automated object-oriented installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 686
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "consequuntur",
      "Description": "Automated object-oriented installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 686
        }
      }
    }
  ],
  "Description": "Vision-oriented mobile flexibility",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "aut",
      "PersonId": 746,
      "Mrmrs": "assumenda",
      "Firstname": "Chanelle",
      "Lastname": "Brekke",
      "MiddleName": "Steuber Inc and Sons",
      "Title": "voluptatem",
      "Description": "Right-sized next generation ability",
      "Email": "paula.dietrich@klingjerde.name",
      "FullName": "Jarod Cruz Strosin II",
      "DirectPhone": "589-619-7695",
      "FormalName": "Macejkovic-Gutkowski",
      "CountryId": 858,
      "ContactId": 590,
      "ContactName": "Effertz, Herman and Langosh",
      "Retired": 316,
      "Rank": 861,
      "ActiveInterests": 358,
      "ContactDepartment": "",
      "ContactCountryId": 810,
      "ContactOrgNr": "659527",
      "FaxPhone": "579.831.5927",
      "MobilePhone": "097-952-0273 x12183",
      "ContactPhone": "065-272-2835 x449",
      "AssociateName": "Schoen Inc and Sons",
      "AssociateId": 581,
      "UsePersonAddress": false,
      "ContactFax": "provident",
      "Kanafname": "cum",
      "Kanalname": "odio",
      "Post1": "quo",
      "Post2": "amet",
      "Post3": "voluptatem",
      "EmailName": "arlene_spencer@hansenyundt.co.uk",
      "ContactFullName": "Everette Robel",
      "ActiveErpLinks": 205,
      "TicketPriorityId": 1002,
      "SupportLanguageId": 321,
      "SupportAssociateId": 562,
      "CategoryName": "VIP Customer",
      "PersonNumber": "821008",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 411
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "quis",
  "Xstop": false,
  "ActiveInterests": 62,
  "GroupId": 579,
  "ActiveStatusMonitorId": 288,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 894,
  "DbiAgentId": 951,
  "DbiLastSyncronized": "2007-10-23T03:41:58.6055208+02:00",
  "DbiKey": "quibusdam",
  "DbiLastModified": "2010-10-17T03:41:58.6055208+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 666,
  "ActiveErpLinks": 381,
  "BounceEmails": [
    "fabiola.weimann@koss.biz",
    "hermann_ankunding@wehner.co.uk"
  ],
  "Domains": [
    "vel",
    "quia"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "563026891",
    "SuperOffice:2": "Citlalli Turcotte"
  },
  "ExtraFields": {
    "ExtraFields1": "quia",
    "ExtraFields2": "non"
  },
  "CustomFields": {
    "CustomFields1": "unde",
    "CustomFields2": "omnis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 608
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```