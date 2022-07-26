<!-- markdownlint-disable-file MD041 -->
### Record Type

 | Task Type | ID |
 |---|---|
 | Appointment | 1 |
 | Document | 2 |
 | Email | 3 |
 | Fax | 4 |
 | Phone | 5 |
 | To Do | 6 |
 | Merge Draft Document | 7 |
 | Merge Final Document | 8 |
 | Report Document | 9 |
 | All | 10 |

The Record Type is used to classify the Task - The classification is used by the SAINT counter system.

Used to identify the type of record that the SAINT counter record is counting. Appointment records are classified according to the Task or DocTemplate's record-type:

When an appointment is created - if real-time SAINT is enabled - the SAINT system looks up the appointment's task's record-type.

The saint counters with the corresponding record type (and the ALL type) are updated. Accumulated counters are increased by one, date counters are set to the current date, and so on.

### Appointment direction

 | Direction | ID |
 |---|---|
 | Unknown |  0 |
 | Incoming | 1 |
 | Outcoing | 2 |
 | All | 3 |

### Sale Status

 | Sale status | ID |
 |---|---|
 | Unknown |  0 |
 | Open | 1 |
 | Sold | 2 |
 | Lost | 3 |
 | Stalled | 4 |
 | All sales | 1000 |

### Sale Done

 | Sale status | ID |
 |---|---|
 | Unknown | 0 |
 | Not done | 1 |
 | Done | 2 |

### See Also

[task Table](../task.md)
[doctmpl Table](../doctmpl.md)
[countervalue Table](../countervalue.md)
