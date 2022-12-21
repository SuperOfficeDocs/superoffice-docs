<!-- markdownlint-disable-file MD041 -->
Bitmask defininig what action should be taken. This enumeration consists of flag values that can be combined.

| `action_flags` | Comment |
|---|---|
| 0 | No action |
| 1 | Set an interest on the recipient-who-is-a-person |
| 2 | Remove an interest from the recipient-who-is-a-person |
| 4 | Set an interest on the recipient-who-is-a-contact |
| 8 | Remove an interest from the recipient-who-is-a-contact |
| 16 | Add person ID of recipient to a static S&M selection |
| 32 | Remove person ID of recipient from a static S&M selection |
| 64 | Add person ID of recipient as a member of an S&M project |
| 128 | Remove person ID of recipient as a member of an S&M project |
| 254 | Add a task in an S&M diary |
| 512 | Add a request (ticket) in CS |
| 1024 | Add person to a Customer Support selection |
| 2048 | Remove person from a Customer Service selection |
| 4096 | Execute an ejScript |

Flags that control how the task is created. This enumeration consists of flag values that can be combined.

| `task_flags` | Comment |
|---|---|
| 0 | No special options, values taken from other fields |
| 1 | Assign task to contact owner |
| 2 | Use the soonest-available working time slot (after the task-creation event is triggered) |
| 4 | Create as an assignment (shown in Invitation dialog) |
