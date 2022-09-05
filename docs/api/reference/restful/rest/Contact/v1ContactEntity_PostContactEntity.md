---
title: POST Contact
uid: v1ContactEntity_PostContactEntity
---

# POST Contact

```http
POST /api/v1/Contact
```

Creates a new ContactEntity


Calls the Contact agent service SaveContactEntity.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Contact?$select=name,department,category/id
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

## Request Body: newEntity  

The ContactEntity to be saved. 

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
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy |  | The user that last updated the contact |
| CreatedBy |  | The user that created the contact |
| Associate |  | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business |  | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category |  | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country |  | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson |  | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address |  | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

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
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy |  | The user that last updated the contact |
| CreatedBy |  | The user that created the contact |
| Associate |  | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business |  | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category |  | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country |  | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson |  | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address |  | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Contact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 387,
  "Name": "Langworth, Hamill and Hackett",
  "Department": "",
  "OrgNr": "1647023",
  "Number1": "512760",
  "Number2": "795816",
  "UpdatedDate": "2006-05-27T11:10:52.6301745+02:00",
  "CreatedDate": "1998-12-17T11:10:52.6301745+01:00",
  "Emails": [
    {
      "Value": "sit",
      "StrippedValue": "porro",
      "Description": "Balanced systematic paradigm"
    },
    {
      "Value": "sit",
      "StrippedValue": "porro",
      "Description": "Balanced systematic paradigm"
    }
  ],
  "Interests": [
    {
      "Id": 786,
      "Name": "Johnson-Ruecker",
      "ToolTip": "Autem nihil impedit.",
      "Deleted": true,
      "Rank": 240,
      "Type": "tempora",
      "ColorBlock": 136,
      "IconHint": "reprehenderit",
      "Selected": true,
      "LastChanged": "2016-03-02T11:10:52.6301745+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "est",
      "Hidden": false,
      "FullName": "Leanna Crooks"
    }
  ],
  "Urls": [
    {
      "Value": "dolores",
      "StrippedValue": "amet",
      "Description": "Persistent interactive neural-net"
    },
    {
      "Value": "dolores",
      "StrippedValue": "amet",
      "Description": "Persistent interactive neural-net"
    }
  ],
  "Phones": [
    {
      "Value": "est",
      "StrippedValue": "animi",
      "Description": "Vision-oriented mission-critical access"
    },
    {
      "Value": "est",
      "StrippedValue": "animi",
      "Description": "Vision-oriented mission-critical access"
    }
  ],
  "Faxes": [
    {
      "Value": "dolorem",
      "StrippedValue": "magni",
      "Description": "Diverse modular superstructure"
    },
    {
      "Value": "dolorem",
      "StrippedValue": "magni",
      "Description": "Diverse modular superstructure"
    }
  ],
  "Description": "Cross-group tangible productivity",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "voluptatem",
      "PersonId": 870,
      "Mrmrs": "nisi",
      "Firstname": "Carey",
      "Lastname": "Kuhic",
      "MiddleName": "Johnson LLC",
      "Title": "exercitationem",
      "Description": "Extended multi-tasking middleware",
      "Email": "anna@yost.uk",
      "FullName": "Miss Josefa Kautzer IV",
      "DirectPhone": "924-652-7621 x45539",
      "FormalName": "Bergstrom-Kreiger",
      "CountryId": 27,
      "ContactId": 837,
      "ContactName": "Simonis LLC",
      "Retired": 160,
      "Rank": 317,
      "ActiveInterests": 784,
      "ContactDepartment": "",
      "ContactCountryId": 353,
      "ContactOrgNr": "1048540",
      "FaxPhone": "(255)493-5922 x997",
      "MobilePhone": "1-164-790-6456 x23149",
      "ContactPhone": "445.501.6558 x399",
      "AssociateName": "Lehner, Wehner and Halvorson",
      "AssociateId": 708,
      "UsePersonAddress": true,
      "ContactFax": "quos",
      "Kanafname": "iste",
      "Kanalname": "animi",
      "Post1": "explicabo",
      "Post2": "veniam",
      "Post3": "animi",
      "EmailName": "abigail.harber@rathbeier.co.uk",
      "ContactFullName": "Jensen Satterfield",
      "ActiveErpLinks": 902,
      "TicketPriorityId": 454,
      "SupportLanguageId": 443,
      "SupportAssociateId": 614,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "est",
  "Xstop": false,
  "ActiveInterests": 983,
  "GroupId": 546,
  "ActiveStatusMonitorId": 763,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 425,
  "DbiAgentId": 988,
  "DbiLastSyncronized": "2010-09-25T11:10:52.6341747+02:00",
  "DbiKey": "hic",
  "DbiLastModified": "2008-09-23T11:10:52.6341747+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 162,
  "ActiveErpLinks": 818,
  "BounceEmails": [
    "hiram.leffler@boyer.com",
    "delilah_abbott@hagenes.ca"
  ],
  "Domains": [
    "nemo",
    "enim"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1906900588",
    "SuperOffice:2": "364454205"
  },
  "ExtraFields": {
    "ExtraFields1": "fugiat",
    "ExtraFields2": "sunt"
  },
  "CustomFields": {
    "CustomFields1": "beatae",
    "CustomFields2": "quibusdam"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 864,
  "Name": "Mayer-Will",
  "Department": "",
  "OrgNr": "1122350",
  "Number1": "1481615",
  "Number2": "570775",
  "UpdatedDate": "2009-07-20T11:10:52.6431709+02:00",
  "CreatedDate": "2008-10-10T11:10:52.6431709+02:00",
  "Emails": [
    {
      "Value": "laboriosam",
      "StrippedValue": "fuga",
      "Description": "User-centric radical function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 843
        }
      }
    },
    {
      "Value": "laboriosam",
      "StrippedValue": "fuga",
      "Description": "User-centric radical function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 843
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 471,
      "Name": "Graham-Runolfsdottir",
      "ToolTip": "Eum ut aspernatur natus.",
      "Deleted": false,
      "Rank": 164,
      "Type": "cumque",
      "ColorBlock": 844,
      "IconHint": "dolor",
      "Selected": false,
      "LastChanged": "2007-12-21T11:10:52.6431709+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ipsa",
      "StyleHint": "saepe",
      "Hidden": false,
      "FullName": "Miss Chad Hermann DVM",
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
  "Urls": [
    {
      "Value": "enim",
      "StrippedValue": "voluptas",
      "Description": "Business-focused mobile standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 419
        }
      }
    },
    {
      "Value": "enim",
      "StrippedValue": "voluptas",
      "Description": "Business-focused mobile standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 419
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "nobis",
      "StrippedValue": "neque",
      "Description": "Re-engineered systematic interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 741
        }
      }
    },
    {
      "Value": "nobis",
      "StrippedValue": "neque",
      "Description": "Re-engineered systematic interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 741
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "impedit",
      "StrippedValue": "ut",
      "Description": "Up-sized responsive intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 722
        }
      }
    },
    {
      "Value": "impedit",
      "StrippedValue": "ut",
      "Description": "Up-sized responsive intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 722
        }
      }
    }
  ],
  "Description": "Quality-focused mobile time-frame",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "rerum",
      "PersonId": 426,
      "Mrmrs": "similique",
      "Firstname": "Vinnie",
      "Lastname": "Jacobs",
      "MiddleName": "Adams Inc and Sons",
      "Title": "est",
      "Description": "Proactive foreground local area network",
      "Email": "mariela@lehnerkuhic.com",
      "FullName": "Werner Haley Tillman IV",
      "DirectPhone": "1-415-288-7405 x8797",
      "FormalName": "Keebler Group",
      "CountryId": 492,
      "ContactId": 495,
      "ContactName": "Brown, Stroman and Marquardt",
      "Retired": 703,
      "Rank": 808,
      "ActiveInterests": 777,
      "ContactDepartment": "",
      "ContactCountryId": 365,
      "ContactOrgNr": "493781",
      "FaxPhone": "435.264.7341 x463",
      "MobilePhone": "138.281.8703",
      "ContactPhone": "960-699-0080",
      "AssociateName": "Rolfson, Greenholt and Jewess",
      "AssociateId": 549,
      "UsePersonAddress": false,
      "ContactFax": "esse",
      "Kanafname": "nisi",
      "Kanalname": "corporis",
      "Post1": "id",
      "Post2": "in",
      "Post3": "quibusdam",
      "EmailName": "werner_kemmer@cristtremblay.info",
      "ContactFullName": "Jaron Marquardt",
      "ActiveErpLinks": 971,
      "TicketPriorityId": 506,
      "SupportLanguageId": 558,
      "SupportAssociateId": 921,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 638
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "delectus",
  "Xstop": true,
  "ActiveInterests": 110,
  "GroupId": 306,
  "ActiveStatusMonitorId": 8,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 478,
  "DbiAgentId": 81,
  "DbiLastSyncronized": "2002-05-01T11:10:52.6471738+02:00",
  "DbiKey": "asperiores",
  "DbiLastModified": "2017-03-25T11:10:52.6471738+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 329,
  "ActiveErpLinks": 249,
  "BounceEmails": [
    "kody@stromanmann.ca",
    "giuseppe.brekke@nienowkuhlman.co.uk"
  ],
  "Domains": [
    "ut",
    "rerum"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Billy Boehm",
    "SuperOffice:2": "Joe Kunze"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "iste"
  },
  "CustomFields": {
    "CustomFields1": "dolore",
    "CustomFields2": "occaecati"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 169
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```