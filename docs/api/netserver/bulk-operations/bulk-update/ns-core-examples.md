---
title: Bulk update examples using NetServer Core API
uid: ns_core_examples
description: Bulk update examples using NetServer Core API
author: Tony Yates
so.date: 06.23.2017
keywords:
so.topic: howto
so.envir: cloud
so.client: online
---

# Bulk update examples using NetServer Core API

Here are a few more examples of how to use bulk update.

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
