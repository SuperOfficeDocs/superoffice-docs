<!-- markdownlint-disable-file MD041 -->
### Values needed to access the Task table

This table must contain special values that would be difficult to guess correctly. These are listed below with a description of how to use them.

#### Value for field 'direction' in table 'task'. Controls icons used in GUI

| Direction | ID | Comment |
|---|---|---|
| Unknown | 0 | Unknown - used when initializing |
| Incoming | 1 | The task is sent to SuperOffice CRM |
| Outgoing | 2 | The task is sent out from SuperOffice CRM |
| SaintAll | 3 | 'All' choice for Saint. This is NOT an acceptable value for a task definition, but is used by the Saint system for indexing all directions |

#### Value for field 'record_type' in table 'task'. Controls icons used in GUI

The Record Type is used to classify the Task - The classification is used by the SAINT counter system.

| `record_type` | ID | Comment |
|---|---|---|
| Unknown | 0 | This task is of an unknown/undecided type |
| Appointment | 1 | The task is an appointment |
| Document | 2 | The task is a document |
| Email | 3 | The task is an email |
| Fax | 4 | The task is a fax |
| Phone | 5 | The task is a phone call |
| To Do | 6 | The task is a To-do |
| MailMergeDraft | 7 | Mail merge draft document |
| MailMergeFinal | 8 | Merged result of mail merge |
| Report | 9 | Saved report run |
| SaintAll | 10 | 'All' choice for Saint, every activity is recorded under this type as well as the specific type. This is NOT an acceptable value for an individual activity |

### See also

[{CounterValue Table}](../countervalue.md))
[task Table](../task.md)
