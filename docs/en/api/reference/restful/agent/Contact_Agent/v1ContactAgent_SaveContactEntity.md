---
title: POST Agents/Contact/SaveContactEntity
uid: v1ContactAgent_SaveContactEntity
generated: true
---

# POST Agents/Contact/SaveContactEntity

```http
POST /api/v1/Agents/Contact/SaveContactEntity
```

Updates the existing ContactEntity or creates a new ContactEntity if the id parameter is empty








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
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ContactEntity

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
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/SaveContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 420,
  "Name": "Stehr-Murphy",
  "Department": "",
  "OrgNr": "673645",
  "Number1": "1441229",
  "Number2": "627677",
  "UpdatedDate": "2024-10-04T14:28:21.6022855+02:00",
  "CreatedDate": "2024-10-15T14:28:21.6022855+02:00",
  "Emails": [
    {
      "Value": "eos",
      "StrippedValue": "enim",
      "Description": "Devolved upward-trending focus group"
    },
    {
      "Value": "eos",
      "StrippedValue": "enim",
      "Description": "Devolved upward-trending focus group"
    }
  ],
  "Interests": [
    {
      "Id": 897,
      "Name": "Shanahan-Okuneva",
      "ToolTip": "Quidem fugiat sit error consectetur maxime eaque.",
      "Deleted": false,
      "Rank": 956,
      "Type": "est",
      "ColorBlock": 946,
      "IconHint": "necessitatibus",
      "Selected": false,
      "LastChanged": "2005-09-11T14:28:21.6022855+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "exercitationem",
      "StyleHint": "ut",
      "Hidden": false,
      "FullName": "Abagail Simonis"
    }
  ],
  "Urls": [
    {
      "Value": "perferendis",
      "StrippedValue": "eveniet",
      "Description": "Programmable optimizing support"
    },
    {
      "Value": "perferendis",
      "StrippedValue": "eveniet",
      "Description": "Programmable optimizing support"
    }
  ],
  "Phones": [
    {
      "Value": "et",
      "StrippedValue": "cum",
      "Description": "Enhanced systemic frame"
    },
    {
      "Value": "et",
      "StrippedValue": "cum",
      "Description": "Enhanced systemic frame"
    }
  ],
  "Faxes": [
    {
      "Value": "est",
      "StrippedValue": "dicta",
      "Description": "Universal asynchronous extranet"
    },
    {
      "Value": "est",
      "StrippedValue": "dicta",
      "Description": "Universal asynchronous extranet"
    }
  ],
  "Description": "Switchable background forecast",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "qui",
      "PersonId": 812,
      "Mrmrs": "id",
      "Firstname": "Brigitte",
      "Lastname": "Mayer",
      "MiddleName": "Pollich LLC",
      "Title": "et",
      "Description": "Implemented tertiary data-warehouse",
      "Email": "lilyan_grady@connelly.us",
      "FullName": "Melyssa Prosacco",
      "DirectPhone": "1-563-449-6898",
      "FormalName": "Baumbach, Moen and McGlynn",
      "CountryId": 667,
      "ContactId": 670,
      "ContactName": "Sipes, Stark and Connelly",
      "Retired": 232,
      "Rank": 348,
      "ActiveInterests": 845,
      "ContactDepartment": "",
      "ContactCountryId": 527,
      "ContactOrgNr": "1285083",
      "FaxPhone": "(726)980-2454 x16192",
      "MobilePhone": "(025)949-9268",
      "ContactPhone": "1-620-425-8186 x49844",
      "AssociateName": "McClure, Hermiston and Welch",
      "AssociateId": 669,
      "UsePersonAddress": true,
      "ContactFax": "eius",
      "Kanafname": "dolorum",
      "Kanalname": "unde",
      "Post1": "quis",
      "Post2": "eos",
      "Post3": "voluptas",
      "EmailName": "mike@olson.biz",
      "ContactFullName": "Aurelia Schaden",
      "ActiveErpLinks": 816,
      "TicketPriorityId": 56,
      "SupportLanguageId": 521,
      "SupportAssociateId": 779,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1382098"
    }
  ],
  "NoMailing": false,
  "Kananame": "et",
  "Xstop": false,
  "ActiveInterests": 772,
  "GroupId": 956,
  "ActiveStatusMonitorId": 670,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 873,
  "DbiAgentId": 471,
  "DbiLastSyncronized": "2021-10-06T14:28:21.6022855+02:00",
  "DbiKey": "recusandae",
  "DbiLastModified": "2011-05-23T14:28:21.6022855+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 112,
  "ActiveErpLinks": 698,
  "BounceEmails": [
    "joey@ziemebatz.uk",
    "preston@collins.name"
  ],
  "Domains": [
    "non",
    "nemo"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Mr. Kara Hand",
    "SuperOffice:2": "Ignatius Conroy"
  },
  "ExtraFields": {
    "ExtraFields1": "consequatur",
    "ExtraFields2": "ipsa"
  },
  "CustomFields": {
    "CustomFields1": "autem",
    "CustomFields2": "qui"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 465,
  "Name": "Greenholt-Schmidt",
  "Department": "",
  "OrgNr": "580293",
  "Number1": "851436",
  "Number2": "1120891",
  "UpdatedDate": "2009-03-30T14:28:21.6022855+02:00",
  "CreatedDate": "2007-07-09T14:28:21.6022855+02:00",
  "Emails": [
    {
      "Value": "ut",
      "StrippedValue": "eius",
      "Description": "Re-engineered clear-thinking local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 353
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "eius",
      "Description": "Re-engineered clear-thinking local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 353
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 187,
      "Name": "Feest-Christiansen",
      "ToolTip": "Nostrum voluptatibus asperiores quam et omnis quasi nulla.",
      "Deleted": false,
      "Rank": 110,
      "Type": "tenetur",
      "ColorBlock": 2,
      "IconHint": "id",
      "Selected": false,
      "LastChanged": "2019-12-03T14:28:21.6022855+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nostrum",
      "StyleHint": "alias",
      "Hidden": false,
      "FullName": "Estella Legros",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 362
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "harum",
      "StrippedValue": "doloremque",
      "Description": "Synergized non-volatile budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 842
        }
      }
    },
    {
      "Value": "harum",
      "StrippedValue": "doloremque",
      "Description": "Synergized non-volatile budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 842
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "architecto",
      "StrippedValue": "porro",
      "Description": "Cloned regional support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 262
        }
      }
    },
    {
      "Value": "architecto",
      "StrippedValue": "porro",
      "Description": "Cloned regional support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 262
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quia",
      "StrippedValue": "temporibus",
      "Description": "Organized discrete productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 110
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "temporibus",
      "Description": "Organized discrete productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 110
        }
      }
    }
  ],
  "Description": "Re-engineered leading edge productivity",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "vel",
      "PersonId": 19,
      "Mrmrs": "et",
      "Firstname": "Bertrand",
      "Lastname": "Stehr",
      "MiddleName": "Parker-Kerluke",
      "Title": "suscipit",
      "Description": "Assimilated encompassing superstructure",
      "Email": "laney_jast@pagacthiel.com",
      "FullName": "Glenna Brekke",
      "DirectPhone": "(012)857-7719 x133",
      "FormalName": "Nienow Inc and Sons",
      "CountryId": 660,
      "ContactId": 529,
      "ContactName": "Wuckert-Romaguera",
      "Retired": 342,
      "Rank": 457,
      "ActiveInterests": 925,
      "ContactDepartment": "",
      "ContactCountryId": 904,
      "ContactOrgNr": "1632155",
      "FaxPhone": "601.860.7653 x75768",
      "MobilePhone": "501-357-4049",
      "ContactPhone": "503-923-8533",
      "AssociateName": "Fisher-Jast",
      "AssociateId": 269,
      "UsePersonAddress": false,
      "ContactFax": "eum",
      "Kanafname": "rerum",
      "Kanalname": "ea",
      "Post1": "cum",
      "Post2": "quibusdam",
      "Post3": "repellat",
      "EmailName": "chase.kautzer@durgancorwin.com",
      "ContactFullName": "Ludwig Brice Barrows MD",
      "ActiveErpLinks": 623,
      "TicketPriorityId": 302,
      "SupportLanguageId": 535,
      "SupportAssociateId": 769,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1202123",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 81
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "a",
  "Xstop": false,
  "ActiveInterests": 367,
  "GroupId": 256,
  "ActiveStatusMonitorId": 772,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 601,
  "DbiAgentId": 896,
  "DbiLastSyncronized": "2023-11-22T14:28:21.6022855+01:00",
  "DbiKey": "culpa",
  "DbiLastModified": "2012-11-04T14:28:21.6022855+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 155,
  "ActiveErpLinks": 310,
  "BounceEmails": [
    "rubye@dibbert.co.uk",
    "isaac_ebert@dickens.ca"
  ],
  "Domains": [
    "voluptatibus",
    "esse"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Fabian Corwin"
  },
  "ExtraFields": {
    "ExtraFields1": "amet",
    "ExtraFields2": "totam"
  },
  "CustomFields": {
    "CustomFields1": "deleniti",
    "CustomFields2": "quas"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 76
    }
  }
}
```