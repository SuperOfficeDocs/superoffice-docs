---
title: POST Agents/Contact/GetMyBizCard
uid: v1ContactAgent_GetMyBizCard
generated: true
---

# POST Agents/Contact/GetMyBizCard

```http
POST /api/v1/Agents/Contact/GetMyBizCard
```

Returns all data needed to display the logged on person's business card.


That is company, person, and company interest data.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetMyBizCard?$select=name,department,category/id
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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/GetMyBizCard
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 581,
  "Name": "Wolff-Beer",
  "Department": "",
  "OrgNr": "847726",
  "Number1": "1115832",
  "Number2": "1966421",
  "UpdatedDate": "2004-08-10T11:06:34.175828+02:00",
  "CreatedDate": "2018-06-17T11:06:34.175828+02:00",
  "Emails": [
    {
      "Value": "deleniti",
      "StrippedValue": "blanditiis",
      "Description": "Enterprise-wide composite internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 204
        }
      }
    },
    {
      "Value": "deleniti",
      "StrippedValue": "blanditiis",
      "Description": "Enterprise-wide composite internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 204
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 934,
      "Name": "Boehm Inc and Sons",
      "ToolTip": "Qui vitae inventore quisquam.",
      "Deleted": true,
      "Rank": 310,
      "Type": "sint",
      "ColorBlock": 290,
      "IconHint": "omnis",
      "Selected": true,
      "LastChanged": "2023-02-18T11:06:34.175828+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eius",
      "StyleHint": "atque",
      "Hidden": true,
      "FullName": "Prof. Brianne Sydnie Pouros Jr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 617
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ipsum",
      "StrippedValue": "repellat",
      "Description": "Cross-group optimal moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 882
        }
      }
    },
    {
      "Value": "ipsum",
      "StrippedValue": "repellat",
      "Description": "Cross-group optimal moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 882
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "autem",
      "StrippedValue": "eum",
      "Description": "Multi-tiered solution-oriented orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 945
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "eum",
      "Description": "Multi-tiered solution-oriented orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 945
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "libero",
      "Description": "Face to face secondary help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 304
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "libero",
      "Description": "Face to face secondary help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 304
        }
      }
    }
  ],
  "Description": "Optimized client-server algorithm",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "architecto",
      "PersonId": 602,
      "Mrmrs": "occaecati",
      "Firstname": "Orie",
      "Lastname": "Jewess",
      "MiddleName": "Hamill-Spencer",
      "Title": "quasi",
      "Description": "Progressive composite synergy",
      "Email": "nyasia@collinswilderman.co.uk",
      "FullName": "Ms. Marley Carleton Kuvalis MD",
      "DirectPhone": "708-613-9711 x772",
      "FormalName": "O'Conner Inc and Sons",
      "CountryId": 995,
      "ContactId": 134,
      "ContactName": "Strosin-Little",
      "Retired": 847,
      "Rank": 951,
      "ActiveInterests": 154,
      "ContactDepartment": "",
      "ContactCountryId": 144,
      "ContactOrgNr": "262588",
      "FaxPhone": "(251)206-6261",
      "MobilePhone": "539-849-6806 x724",
      "ContactPhone": "(135)915-1443 x29566",
      "AssociateName": "Jast LLC",
      "AssociateId": 367,
      "UsePersonAddress": false,
      "ContactFax": "et",
      "Kanafname": "nihil",
      "Kanalname": "in",
      "Post1": "ullam",
      "Post2": "ducimus",
      "Post3": "minima",
      "EmailName": "royal_kerluke@hoppe.uk",
      "ContactFullName": "Leslie Zachery Zulauf Jr.",
      "ActiveErpLinks": 395,
      "TicketPriorityId": 661,
      "SupportLanguageId": 685,
      "SupportAssociateId": 866,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 374
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "soluta",
  "Xstop": false,
  "ActiveInterests": 838,
  "GroupId": 502,
  "ActiveStatusMonitorId": 362,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 688,
  "DbiAgentId": 64,
  "DbiLastSyncronized": "2013-10-16T11:06:34.175828+02:00",
  "DbiKey": "architecto",
  "DbiLastModified": "2012-07-28T11:06:34.175828+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 641,
  "ActiveErpLinks": 348,
  "BounceEmails": [
    "breanna@marvinhudson.us",
    "lamar@beatty.com"
  ],
  "Domains": [
    "unde",
    "esse"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Mathew Waelchi",
    "SuperOffice:2": "Macy Abernathy"
  },
  "ExtraFields": {
    "ExtraFields1": "rerum",
    "ExtraFields2": "placeat"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "fuga"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 540
    }
  }
}
```