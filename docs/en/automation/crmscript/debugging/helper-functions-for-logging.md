---
uid: crmscript-log-helper
title: Logging in CRMScript
description: A SearchEngine helper-method for CRMScript logging.
keywords: CRMScript, log, log_events
author: Tor Thorbergsen, Eivind Fasting
date: 29.10.2024
topic: howto
---

# Logging in CRMScript

By default, CRMScript has its own [log][1] method, which takes a String message and saves it in [log_events][2].

The table has a few more fields that can be utilized, but it requires a helper-method that inserts the data into the table, using the SearchEngine:

```crmscript
Void log( Integer id, Integer eventType, String var1, String var2, String var3, String var4, String var5 ) {
    SearchEngine se;
    se.addData( "log_events.time_of_event", getCurrentDateTime().toString() );
    se.addData( "log_events.event_type", eventType.toString() );
    se.addData( "log_events.event_group", "13" ); // GroupEjscript
    se.addData( "log_events.target_id", id.toString() );
    se.addData( "log_events.var1", var1 );
    se.addData( "log_events.var2", var2 );
    
    if( !var3.isEmpty() )
        se.addData( "log_events.var3", var3 );
    if( !var4.isEmpty() )
        se.addData( "log_events.var4", var4 );
    if( !var5.isEmpty() )
        se.addData( "log_events.var5", var5 );
    se.insert();
}

Void log( Integer id, Integer eventType, String var1, String var2, String var3, String var4 ){ log( id, eventType, var1, var2, var3, var4, "" ); }
Void log( Integer id, Integer eventType, String var1, String var2, String var3 )             { log( id, eventType, var1, var2, var3, "", "" ); }
Void log( Integer id, Integer eventType, String var1, String var2 )                          { log( id, eventType, var1, var2, "", "", "" ); }
Void log( Integer id, Integer eventType, String var1 )                                       { log( id, eventType, var1, "", "", "", "" ); }

Void log( Integer eventType, String var1, String var2, String var3, String var4, String var5 ){ log( 0, eventType, var1, var2, var3, var4, var5 ); }
Void log( Integer eventType, String var1, String var2, String var3, String var4 )             { log( 0, eventType, var1, var2, var3, var4, "" ); }
Void log( Integer eventType, String var1, String var2, String var3 )                          { log( 0, eventType, var1, var2, var3, "", "" ); }
Void log( Integer eventType, String var1, String var2 )                                       { log( 0, eventType, var1, var2, "", "", "" ); }

Void log( String var1, String var2, String var3, String var4, String var5 ){ log( 0, 0, var1, var2, var3, var4, var5 ); }
Void log( String var1, String var2, String var3, String var4 )             { log( 0, 0, var1, var2, var3, var4, "" ); }
Void log( String var1, String var2, String var3 )                          { log( 0, 0, var1, var2, var3, "", "" ); }
Void log( String var1, String var2 )                                       { log( 0, 0, var1, var2, "", "", "" ); }
```

## Event Type

| Event Type | Value |
|---|:-:|
| EventTypeEvent         | 1 |
| EventTypeNotification  | 2 |
| EventTypeWarning       | 3 |
| EventTypeError         | 4 |
| EventTypeCriticalError | 5 |

## Event Group

| Event Group | Value |
|---|:-:|
| GroupAll           | 0 |
| GroupCustomer      | 1 |
| GroupTicket        | 2 |
| GroupUser          | 3 |
| GroupSystem        | 4 |
| GroupCompany       | 5 |
| GroupPriority      | 6 |
| GroupCategory      | 7 |
| GroupReplyTemplate | 8 |
| GroupSearch        | 9 |
| GroupExtraTable    | 10 |
| GroupSoap          | 11 |
| GroupEmail         | 12 |
| GroupEjscript      | 13 |
| GroupDbi           | 14 |

## Usage

For the helper-method to be re-useable, add it as its own CRMScript.

1. Give the script it's own includeId, for instance `lib-log`.
2. Write `#include 'lib-log';` at the top of the new script.
3. Use one of the included methods, for instance `log(406, 3, "foo");`.

To view the contents of the log, go to **System design** > **Debug log**, or (for onsite) look in the database with a SQL statement:

```sql
select * from crm7.LOG_EVENTS
where target_id='1544244' and var1 like '%Request feedback%'
order by time_of_event
```

<!-- Reference links -->
[1]: log-messages.md
[2]: ../../../database/tables/log-events.md