---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: appointmentmatrix  # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: AppointmentMatrix # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: entity
so.topic: sample              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# AppointmentMatrix

The `AppointmentMatrix` is used to manage complex appointments: invitations and recurrences.

```csharp
using SuperOffice.CRM.Entities;

// Let the participant accept this one
using (SoSession.Authenticate("tje3", "tje3"))
{
  int appointmentId = 123;
  Appointment appointment = Appointment.GetFromIdxAppointmentId( appointmentId );
  AppointmentMatrix matrix = new AppointmentMatrix(appointment, RecurrenceUpdateMode.ThisAndForward);

  // Get participant information for user to assign-to
  AssociateCache  associateCache  = AssociateCache.GetCurrent();
  AssociateRow    jimbo           = associateCache.GetAssociate(associateCache.GetAssociateId("jimbo"));
  ParticipantInfo jimboParticipant= new ParticipantInfo(jimbo.AssociateId, jimbo.PersonId, 2, 0, false);
  matrix.AssignTo( jimboParticipant );
  matrix.Save();
}
```

```csharp
using SuperOffice.CRM.Entities;

// Let the participant accept this one
using (SoSession.Authenticate("tje3", "tje3"))
{
  int assignedAppointmentId = 123;
  assignAccept = new AppointmentMatrix(assignedAppointmentId, RecurrenceUpdateMode.ThisAndForward);
  RecurrenceDate firstDate = assignAccept.InnerMatrix.GetRowKey(0);
  assignAccept.Accept();
  assignAccept.Save();
}
```
