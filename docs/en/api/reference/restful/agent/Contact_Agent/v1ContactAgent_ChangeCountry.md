---
title: POST Agents/Contact/ChangeCountry
uid: v1ContactAgent_ChangeCountry
generated: true
---

# POST Agents/Contact/ChangeCountry

```http
POST /api/v1/Agents/Contact/ChangeCountry
```

Change country regenerates the default values and localized information such as phone number and address format







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/ChangeCountry?$select=name,department,category/id
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

ContactEntity, ToCountryId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactEntity | ContactEntity | The Contact Service. The service implements all services working with the Contact object <para /> Carrier object for ContactEntity. Services for the ContactEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IContactAgent">Contact Agent</see>. |
| ToCountryId | Integer |  |

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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/ChangeCountry
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactEntity": null,
  "ToCountryId": 797
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 881,
  "Name": "Stokes, Hodkiewicz and Gislason",
  "Department": "",
  "OrgNr": "1195135",
  "Number1": "1031994",
  "Number2": "422838",
  "UpdatedDate": "2021-01-23T03:24:47.4395542+01:00",
  "CreatedDate": "2010-03-03T03:24:47.4395542+01:00",
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "beatae",
      "Description": "Cross-group holistic moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 292
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "beatae",
      "Description": "Cross-group holistic moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 292
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 106,
      "Name": "Lowe-Wuckert",
      "ToolTip": "Animi sunt voluptatibus et deserunt.",
      "Deleted": true,
      "Rank": 644,
      "Type": "non",
      "ColorBlock": 415,
      "IconHint": "est",
      "Selected": true,
      "LastChanged": "2017-05-18T03:24:47.4395542+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "qui",
      "StyleHint": "et",
      "Hidden": true,
      "FullName": "Dessie Kub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 114
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quae",
      "StrippedValue": "eligendi",
      "Description": "Extended high-level infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 331
        }
      }
    },
    {
      "Value": "quae",
      "StrippedValue": "eligendi",
      "Description": "Extended high-level infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 331
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "et",
      "StrippedValue": "et",
      "Description": "De-engineered local core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 106
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "et",
      "Description": "De-engineered local core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 106
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ratione",
      "StrippedValue": "quisquam",
      "Description": "Public-key encompassing time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 202
        }
      }
    },
    {
      "Value": "ratione",
      "StrippedValue": "quisquam",
      "Description": "Public-key encompassing time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 202
        }
      }
    }
  ],
  "Description": "Extended scalable strategy",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "omnis",
      "PersonId": 120,
      "Mrmrs": "esse",
      "Firstname": "Flavio",
      "Lastname": "Corkery",
      "MiddleName": "Lueilwitz-Collins",
      "Title": "qui",
      "Description": "Persevering system-worthy task-force",
      "Email": "cory_padberg@kubvandervort.info",
      "FullName": "Jovany Marks",
      "DirectPhone": "(094)733-0710",
      "FormalName": "Mayer, Bradtke and Paucek",
      "CountryId": 907,
      "ContactId": 40,
      "ContactName": "Haley-Cruickshank",
      "Retired": 745,
      "Rank": 910,
      "ActiveInterests": 710,
      "ContactDepartment": "",
      "ContactCountryId": 400,
      "ContactOrgNr": "979800",
      "FaxPhone": "717.440.4256 x194",
      "MobilePhone": "(747)855-6383 x27916",
      "ContactPhone": "567.721.0983 x476",
      "AssociateName": "Witting, Homenick and Rogahn",
      "AssociateId": 685,
      "UsePersonAddress": true,
      "ContactFax": "voluptatem",
      "Kanafname": "dolores",
      "Kanalname": "vero",
      "Post1": "eligendi",
      "Post2": "ea",
      "Post3": "nesciunt",
      "EmailName": "velma.gerhold@fay.biz",
      "ContactFullName": "Keven Cormier",
      "ActiveErpLinks": 50,
      "TicketPriorityId": 906,
      "SupportLanguageId": 406,
      "SupportAssociateId": 109,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 602
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "est",
  "Xstop": false,
  "ActiveInterests": 222,
  "GroupId": 133,
  "ActiveStatusMonitorId": 735,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 517,
  "DbiAgentId": 492,
  "DbiLastSyncronized": "2022-01-25T03:24:47.4395542+01:00",
  "DbiKey": "dignissimos",
  "DbiLastModified": "2016-11-25T03:24:47.4395542+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 109,
  "ActiveErpLinks": 825,
  "BounceEmails": [
    "eva_harvey@nolan.ca",
    "brycen.funk@anderson.name"
  ],
  "Domains": [
    "distinctio",
    "ratione"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "Joan Runolfsson"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "voluptate"
  },
  "CustomFields": {
    "CustomFields1": "eos",
    "CustomFields2": "est"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 306
    }
  }
}
```