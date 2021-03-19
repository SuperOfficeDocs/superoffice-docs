<properties generated="1" SortOrder="990" />

# AppointmentPrivate Enum

Obsolete, but still maintained field for appointment privacy; denormalization of visiblefor status

* Public = 0
* PrivateUser = 1
* PrivateGroup = 2

## Usage
* [appointment](appointment.md).private - Tasks, appointments, followups, phone calls; and documents (document_id != 0). An appointment always has a corresponding record in VisibleFor specifying who may see this. 

