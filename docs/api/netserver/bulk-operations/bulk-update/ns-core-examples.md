---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: ns_core_examples       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Bulk update examples using NetServer Core API # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: Tony Yates
so.date: 06.23.2017
keywords:
so.topic: howto         # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Bulk update examples using NetServer Core API

Here are a few more examples how to use bulk update.

## Contact Change Category

[!code-csharp[example 1](includes/contact-change-category.cs)]

## Contact No Mailings Checkbox

[!code-csharp[example 1](includes/contact-no-mailings.cs)]

## Contact Add Interests

[!code-csharp[example 1](includes/contact-change-interests.cs)]

## Set Contact User-Defined Field

[!code-csharp[example 1](includes/set-contact-udef.cs)]

## Appointment: complete all project appointments

[!code-csharp[example 1](includes/complete-project-appointments.cs)]

## Example using Web Services (courtesy of Matthijs Wagemakers)

```csharp
using (var bulkAgent = new BulkUpdateAgent())
{
    FieldValueInfo[] fields = bulkAgent.GetAvailableFields("­appointment");
    FieldValueInfo filteredField = fields.Where(x => x.Key == SuperOffice.CRM.BulkUpdate.Bul­kUpdateSystem.AppointmentF­ieldValueKeys.Done)
        .FirstOrDefault();
    filteredField.IsActive = true;
    filteredField.CurrentOperation­Type = SuperOffice.CRM.BulkUpdate.Bul­kUpdateSystem.OperationTyp­es.Check;
    filteredField.Values = new[] { "1" };

    int bulkId = bulkAgent.ExecuteByEntityIds(
        new[] { filteredField },
        "appointment",
        Guid.NewGuid().ToString(),        // must be unique for concurrent jobs
        string.Join(",", new[] { 2, 10 }))
        ;
}
```
