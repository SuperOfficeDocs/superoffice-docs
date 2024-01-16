<!-- markdownlint-disable-file MD041 -->
### Values needed to access the appointment tables

This table must contain special values that would be difficult to guess correctly. These are listed below with a description of how to use them.

> [!NOTE]
> Booking means a group reservation where you invite several associates or resources to join.

#### Appointment Type

 | Appointment Type | ID | Comment |
 |---|---|---|
 | Undefined | 0 | The appointment type is not defined- used when initializing |
 | Appointment in Diary |  1 | Show in diary. If overdue or done today, show in checklist also |
 | Appointment in Check list | 2 | Appointment is a followup with no specific starttime |
 | Note shown as a paper clip on e.g. contacts | 3 | Paper clip on diary, expands to "post-it" note when clicked |
 | Incoming Document | 4 | Document |
 | Saved report | 5 | Saved Report (i.e., not a Report Definition but the result of an actual report run) |
 | Booking, made for diary | 6 | When accepted this will change type = 1 |
 | Booking, made for check list | 7 | When accepted this will change type = 2 |
 | Document - mail merge draft | 8 | Document is a template for mailmerge operations |
 | Document - mail merge final | 9 | Document is a result of a mailmerge operations (there are probably many documents like this!) |

#### Status type

 | Status type | ID | Comment |
 |---|---|---|
 | Appointment type is a Post-IT | 0 | Unknown / Appointment is a Post-IT, used together with ApointmentType.Note only |
 | Not started | 1 | Resources and mother appointments get this status on new appointments, implies the green mark for accepted |
 | Started | 2 | Marked when the appointment is actually started, but not completed |
 | Completed | 3 | Completed is set to avoid changes to the appointment |
 | Hidden | 4 | Appointment is hidden |
 | Booking | 5 | Appointment is a booking invitation (initial status for a booking) |
 | Booking has moved | 6 | You may have seen, declined, or accepted the booking, but it has been moved, so you will be asked again. |
 | Booking seen | 7 | You have seen the booking, but not declined or accepted it. |
 | Booking moved seen | 8 | The booking has been moved and you have seen the change, but not declined or accepted it. |
 | Booking declined | 9 | You have declined the booking. |
 | Booking deleted | 10 | Status of "child" appointment whose "mother" has been deleted (the meeting is canceled) |
 | Assignment | 11 | You are assigned this appointment (initial status, like Booking(5) ) |
 | Assignment seen | 12 | You have seen the assignment, but not accepted or declined it |
 | Assignment declined | 13 | You have declined the appointment assigned to you. |

#### Private

 | Private Type | ID | Comment |
 |---|---|---|
 | Public appointment | 0 | This appointment can be read by anyone |
 | Private appointment | 1 | This appointment can only be read/seen by the owner |
 | Private appointment | 2 | This appointment can only be read by members in my group/dept |

#### Task\_idx

Is either `template_idx` (`DocTmpl_id` in `DocTmpl`) or `task_idx` (`Task_id` in `Task`), depending on the type value.

 | Type | `Task_Idx` | Status |
 |---|---|---|
 | Appointment in diary | `task_idx` | 1 = not started, 2 = started, 3 = done |
 | Appointment in check list | `task_idx` | 1 = not started, 2 = started, 3 = done |
 | Booking, made for diary | `task_idx` | booking (`mother_id` > 0) |
 | Booking\_made for check list | `task_idx` | booking (`mother_id` > 0) |
 | Note – post it |  |  |
 | Document in | `template_idx` | 1 = not started, 2 = started, 3 = done |

#### Mother\_id

 | `mother_id` | `appointment_id` | Comment |
 |---|---|---|
 | 0 | | This is a simple appointment |
 | > 0 | `mother_id` = `appointment_id` | This is a booking, and the appointment is the master booking (the one that is inviting) |
 | > 0 | `mother_id` not like `appointment_id` | This is a booking, and the appointment is the slave booking (someone who is invited) |

Bookings share a single text record. In SuperOffice the person doing the inviting is the only one allowed to change the text of this booking (appointment).
A booking may have `associate_id = 0`, if it is an invitation to an external attendee; in that case the InvitedPersonId is the person ID of the attendee. `Person_id` is always the ID of the person the meeting is with (not of the person who is invited to it).

#### FreeBusy

 | FreeBusy Type | ID | Comment |
 |---|---|---|
 | Busy | 0 | This appointment is marked as busy in the diary |
 | Free | 1 | This appointment is marked as free in the diary |

Documents linked to an appointment are linked in the Relations table. There is no special marking in appointment so always check if the active appointment has valid entries in the Relations table. The `relationdefinition` table holds the `reldef_id` for "Link to follow-up", "Link to document", and "Link to sale". Our GUI currently only supports links to documents.

### To assign an appointment to someone

```vb
Dim apt As IAppointment = so.Database.CreateAppointment()
apt.SetDefaults()
apt.Type = 1 ' or 2
apt.Status = 11
apt.AssignedBy = mamagersId
apt.Person = so.Database.GetPerson(11)
apt.Contact = so.Database.GetContact(3)
apt.Project = so.Database.GetProject(4)
apt.Task = so.Database.GetListItem(SOTableId.enTableTask, 1)
apt.Save()
```

### Accepting an appointment

```vb
Dim apt As IAppointment = so.Database.GetAppointment(120)
apt.AcceptInvitation(EnResponse.enResponseAccept)

 ' set status from 11 to 1
 ' set assignedBy = associate-id (WARNING: This may change in the future)
```

### Rejecting an appointment

* set status = 13
* set associate-id = assigned-by

### To create an invitation to an appointment

* Create a second appointment as copy of first.
* Appnt.Mother\_id = appnt.appnt\_id
* Appnt.invitedPerson = appnt.associate-id's person-id
* Appnt2.Mother\_id = appnt.appnt\_id
* Appnt2.Associate\_id = invited user
* Appnt2.invitedPerson = invited user's
* Appnt2.type = 6 or 7
* Appnt2.status = 5

On the whole it is best to use the functions on the Appointment object to do this sort of thing:

* SoAppointment.AcceptInvitations
* SoAppointment.AddParticipant
* SoAppointment.RemoveParticipant
