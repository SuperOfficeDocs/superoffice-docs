## Dependency injection

Since version 10, SuperOffice uses dependency injection to establish configuration options and parameters.

There are many ways to orchestrate the configuration of the NetServer Core API. The most common way is to use the `Startup` class, which is a convention used in ASP.NET Core applications. However, this explanation will not make any assumptions about the type of application you are building and will instead explicitly add an IStartup interface for demonstration purposes.

### Session Mode

SuperOffice requires a context provider to be specified when configuring the NetServer Core API. The context provider is responsible for providing the principal context for the current user. There are several default implementations of ISoContextProvider located in SoCore.

* ThreadContextProvider
* ContextContextProvider
* ProcessContextProvider

Another is HttpContextProvider, located in SuperOffice.DCFWeb, used be the SuperOffice web client.
