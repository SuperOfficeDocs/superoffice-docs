---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: pref_defaults       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Preference section Defaults # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: database
so.topic: reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Preference section Defaults

[!include[SQL](./includes/to-view-pref.md)]

```SQL
SELECT * FROM UserPreference WHERE prefsection='Defaults'
```

Default values for dialogs and checkboxes throughout the system.

| Preference | Description | Default | Control type | Access |
|---|---|---|---|---|
| DefaultAppntRememberVisibleFor | Uses the same visibility setting for new follow-ups as you used last time. |  NO | Bool|  Admin, Crm, Admin users, Wizard |
| DefaultAppointmentAppointLength | Default duration for new appointment | | Number|  Admin, Crm, Admin users, Wizard |
| DefaultAppointmentAppointTaskId | Default type for new appointment | | ListTableRef|  Admin, Crm, Admin users, Wizard |
| DefaultAppointmentAppointText | Default text for new appointment | | Text|  Admin, Crm, Admin users, Wizard |
| DefaultAppointmentPhoneLength | Default duration for new phone call | | Number|  Admin, Crm, Admin users, Wizard |
| DefaultAppointmentPhoneTaskId | Default type for new phone call | | ListTableRef|  Admin, Crm, Admin users, Wizard |
| DefaultAppointmentPhoneText | Default text for new phone call | | Text  | Admin, Crm, Admin users, Wizard |
| DefaultAppointmentToDoLength | Default duration for new task | | Number |  Admin, Crm, Admin users, Wizard |
| DefaultAppointmentToDoTaskId | Default type for new task | | ListTableRef |  Admin, Crm, Admin users, Wizard |
| DefaultAppointmentToDoText | Default text for new task | | Text |  Admin, Crm, Admin users, Wizard |
| DefaultAppointmentVisibleFor | Last visibility setting used in the follow-ups dialog | | Number|  Wizard |
| DefaultBusiness | Default business for new company | | ListTableRef| Admin, Crm, Admin users, Wizard |
| DefaultCategory | Default category for new company | | ListTableRef |  Admin, Crm, Admin users, Wizard |
| DefaultDecimalPlacesInAmount | Number of decimals displayed in user-defined amount | | Number|  Wizard |
| DefaultDocRememberVisibleFor | Uses the same visibility setting for new documents as you used last time. | NO | Bool|  Admin, Crm, Admin users, Wizard |
| DefaultDocumentType | Default outgoing document template | | ListTableRef |  Admin, Crm, Admin users, Wizard |
| DefaultDocumentVisibleFor | Last visibility setting used in the Document dialog | | Number|  Wizard |
| DefaultFaxType | Default outgoing fax template | | ListTableRef |  Admin, Crm, Admin users, Wizard |
| DefaultProjectStatus | Default status for new project | | ListTableRef|  Admin, Crm, Admin users, Wizard |
| DefaultProjectType | Default type for new project | | ListTableRef|  Admin, Crm, Admin users, Wizard |
| DefaultSaleProb | Default rating for new sale | | ListTableRef|  Admin, Crm, Admin users, Wizard |
| DefaultSelectionCategory | Default type for new  selection | | ListTableRef|  Admin, Crm, Admin users, Wizard |
| DefaultSelectionVisibleFor | Makes this value the default visibility setting when creating a new selection | | List| Admin, Crm, Admin users, Wizard |
