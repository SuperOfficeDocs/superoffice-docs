---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
uid: helper_functions_for_logging       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
title: Logging in CRMScript # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: Tor Thorbergsen
so.date: 01.11.2018
keywords:
so.topic: howto          # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir:            # cloud or onsite
so.client:                # online, web, win, pocket, or mobile
---

# Logging in CRMScript

Sometimes we need to log info in our scripts. Customer service has a nice table to store such information in: `LOG_EVENTS`.

There is also a log function.

The log function takes a String message, which is saved to the table. Couldn’t be easier to use.

Now, the table has a few more fields, which can be utilized by you, and I have made a few helper functions that we use to log info in our internal systems.

```crmscript
Void log( Integer id, String var1, String var2, String var3, String var4, String var5 ) {
  SearchEngine se;
  se.addData( "log_events.time_of_event", getCurrentDateTime().toString() );
  se.addData( "log_events.event_type", "2" );      // Notification
  se.addData( "log_events.event_group", "13" );    // GroupEjscrip
  se.addData( "log_events.target_id", id.toString() );
  se.addData( "log_events.var1", var1 );
  se.addData( "log_events.var2", var2 )
  if( !var3.isEmpty() )
    se.addData( "log_events.var3", var3 )
  if( !var4.isEmpty() )
    se.addData( "log_events.var4", var4 )
  if( !var5.isEmpty() )
    se.addData( "log_events.var5", var5 )
  se.insert();
}

Void log( Integer id, String var1, String var2, String var3, String var4 ){ log( id, var1, var2, var3, var4, "" ); }
Void log( Integer id, String var1, String var2, String var3 )             { log( id, var1, var2, var3, "", "" ); }
Void log( Integer id, String var1, String var2 )                          { log( id, var1, var2, "", "", "" ); }
Void log( Integer id, String var1 )                                       { log( id, var1, "", "", "", "" ); }

Void log( String var1, String var2, String var3, String var4, String var5 ){ log( 0, var1, var2, var3, var4, var5 ); }
Void log( String var1, String var2, String var3, String var4 )             { log( 0, var1, var2, var3, var4, "" ); }
Void log( String var1, String var2, String var3 )                          { log( 0, var1, var2, var3, "", "" ); }
Void log( String var1, String var2 )                                       { log( 0, var1, var2, "", "", "" ); }
```

All these functions register the record as a **Notification**. You could easily make functions for other types of events:

```crmscript
enum EventType
{
  EventTypeEvent          = 1,
  EventTypeNotification   = 2,
  EventTypeWarning        = 3,
  EventTypeError          = 4,
  EventTypeCriticalError  = 5
};


In these functions we don’t use the columns `event_id` and `source_user_desc`. You can easily change the functions to utilize these fields, if you should need to.

To watch the contents of the log, just go to **System design/Debug log**, or look in the database with a SQL statement like:

```sql
select * from crm7.LOG_EVENTS
where target_id='1544244' and var1 like '%Request feedback%'
order by time_of_event
```

Hope this is helpful for some of you. Any other suggestions?
