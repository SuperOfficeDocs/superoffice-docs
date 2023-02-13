---
title: POST Agents/Contact/GetContactEntity
uid: v1ContactAgent_GetContactEntity
---

# POST Agents/Contact/GetContactEntity

```http
POST /api/v1/Agents/Contact/GetContactEntity
```

Gets a ContactEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| contactEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=670
POST /api/v1/Agents/Contact/GetContactEntity?$select=name,department,category/id
```


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
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Contact/GetContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 565,
  "Name": "Nolan-Champlin",
  "Department": "",
  "OrgNr": "1213265",
  "Number1": "129029",
  "Number2": "772169",
  "UpdatedDate": "1998-01-17T11:22:37.664863+01:00",
  "CreatedDate": "2020-11-20T11:22:37.664863+01:00",
  "Emails": [
    {
      "Value": "repudiandae",
      "StrippedValue": "explicabo",
      "Description": "Optimized transitional core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 905
        }
      }
    },
    {
      "Value": "repudiandae",
      "StrippedValue": "explicabo",
      "Description": "Optimized transitional core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 905
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 888,
      "Name": "Farrell, Ernser and Krajcik",
      "ToolTip": "Nihil modi quos reiciendis.",
      "Deleted": true,
      "Rank": 487,
      "Type": "dolorum",
      "ColorBlock": 712,
      "IconHint": "atque",
      "Selected": true,
      "LastChanged": "2019-12-01T11:22:37.664863+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "rerum",
      "StyleHint": "excepturi",
      "Hidden": false,
      "FullName": "Halle Hermiston II",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 700
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "nemo",
      "StrippedValue": "fugiat",
      "Description": "Switchable fault-tolerant array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 463
        }
      }
    },
    {
      "Value": "nemo",
      "StrippedValue": "fugiat",
      "Description": "Switchable fault-tolerant array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 463
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "in",
      "StrippedValue": "odio",
      "Description": "Right-sized multimedia circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 665
        }
      }
    },
    {
      "Value": "in",
      "StrippedValue": "odio",
      "Description": "Right-sized multimedia circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 665
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quia",
      "StrippedValue": "eos",
      "Description": "Progressive executive projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 45
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "eos",
      "Description": "Progressive executive projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 45
        }
      }
    }
  ],
  "Description": "Progressive homogeneous productivity",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "magnam",
      "PersonId": 133,
      "Mrmrs": "libero",
      "Firstname": "Tia",
      "Lastname": "Fahey",
      "MiddleName": "Zemlak, Torp and Weissnat",
      "Title": "expedita",
      "Description": "Multi-channelled multi-state extranet",
      "Email": "brain@buckridgetreutel.com",
      "FullName": "Bessie Reynold Jewess MD",
      "DirectPhone": "1-225-694-8387 x4308",
      "FormalName": "Moen-Runte",
      "CountryId": 527,
      "ContactId": 84,
      "ContactName": "Osinski Group",
      "Retired": 714,
      "Rank": 901,
      "ActiveInterests": 212,
      "ContactDepartment": "",
      "ContactCountryId": 597,
      "ContactOrgNr": "1019019",
      "FaxPhone": "(203)138-8472 x12827",
      "MobilePhone": "154-347-9378 x1252",
      "ContactPhone": "027-292-9774",
      "AssociateName": "Hauck-Boyle",
      "AssociateId": 847,
      "UsePersonAddress": true,
      "ContactFax": "eum",
      "Kanafname": "quam",
      "Kanalname": "placeat",
      "Post1": "dicta",
      "Post2": "veritatis",
      "Post3": "illum",
      "EmailName": "merle_pollich@gradymclaughlin.uk",
      "ContactFullName": "Kayli Klocko",
      "ActiveErpLinks": 425,
      "TicketPriorityId": 371,
      "SupportLanguageId": 229,
      "SupportAssociateId": 232,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 227
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "incidunt",
  "Xstop": false,
  "ActiveInterests": 554,
  "GroupId": 217,
  "ActiveStatusMonitorId": 857,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 883,
  "DbiAgentId": 285,
  "DbiLastSyncronized": "2019-03-12T11:22:37.664863+01:00",
  "DbiKey": "corrupti",
  "DbiLastModified": "2001-09-09T11:22:37.664863+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 993,
  "ActiveErpLinks": 218,
  "BounceEmails": [
    "cornell.collier@lednerdicki.info",
    "nona@starkluettgen.us"
  ],
  "Domains": [
    "qui",
    "sequi"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Tony Romaguera",
    "SuperOffice:2": "Jon Beatty"
  },
  "ExtraFields": {
    "ExtraFields1": "asperiores",
    "ExtraFields2": "occaecati"
  },
  "CustomFields": {
    "CustomFields1": "error",
    "CustomFields2": "id"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 562
    }
  }
}
```