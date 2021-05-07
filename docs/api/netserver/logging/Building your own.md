---
uid: logging-building-own
title: Building your own logger
author: xt1
so.date: 2021-05-07
keywords: logging
so.topic: concept
---

To make your own logger

1. Create a DLL containing a class that implements `SuperOffice.Diagnostics.Logging.ILoggerProviderPlugin` (found in SOCORE.DLL)
2. Add the `SuperOffice.Diagnostics.Logging.ILoggerProviderPluginAttribute` to the class to mark it as a plugin.
3. Add a reference to the [Microsoft.Extensions.Logging.Abstractions package][0].
4. Return something that implements an [ILogger][1]
5. Drop the DLL and its dependencies into the `bin` folder.
6. Add binding redirects as needed if your dependencies and NetServers dependencies disagree.

## ILogger and plugins

NetServer uses the standard [ILogger][1] providers via a plug-in system. To use your own logger system, you need to make your own assembly (DLL) containing a plug-in class that implements the `ILoggerProviderPlugin` interface.

NetServer's class factory will load your plug-in, discover the ILoggerProviderPlugin implementation by finding the `\[ILoggerProviderPluginAttribute\]` on the class.

```cs
    /// <summary>
    /// Custom logger factory. Configurate and creatify ILogger instances.
    /// Remember to mark the class with <see cref="ILoggerProviderPluginAttribute"/>.
    /// </summary>
    public interface SuperOffice.Diagnostics.Logging.ILoggerProviderPlugin : IPlugin
    {
        /// <summary>
        /// Create a logger factory for us. Configure it based on a config file or ConfigFile settings.
        /// </summary>
        /// <return>
        /// Return a configured ILoggerProvider instance, or NULL if you don't feel like logging today.
        /// </return>
        Microsoft.Extensions.Logging.ILoggerProvider CreateLoggerProvider();
    }
```

NetServer's logger will call the plug-in's `CreateLoggerProvider` function to get an `ILoggerProvider`. This is Microsoft defined interface for getting `ILogger` instances. This defintion lives in the `Microsoft.Extensions.Logging.Abstractions` nuget package.

The `ILoggerProvider` that is returned is added to the log provider collection that NetServer uses to log. All the log providers are used whenever logging happens. Each log provider may be configured differently.

When NetServer wants to log something, it calls each ILogger provider with the same log message, and each provider then does whatever it wants.

The ILogProvider's CreateLogger is called with a categoryName (usually a class full name):

`ILogger CreateLogger(string categoryName)`

The `ILogger`s Log methods are called:

`Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)`

The exception may be set, or may be null.
The formatter is a function that turns the log message into a string.

```cs
    if (formatter != null && state != null)
    {
        var message = formatter(state, exception);
        if (string.IsNullOrEmpty(message))
            return;
    }
```



[0]: https://www.nuget.org/packages/Microsoft.Extensions.Logging.Abstractions/
[1]: https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.ilogger
