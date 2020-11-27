This requirement applies to:

* All client computers that will run our **Windows client**
* All servers running our web-based software (**Sales & Marketing Web, NetServer, Service**)
* The server hosting SuperOffice CRM Server (ServerSetup) to be able to run ServerSetup and *DBSetup.exe*

SuperOffice WebTools (Web Extensions and MailLink) will not have this requirement yet. They will continue to run on .Net 4.5.1. This means that our CRM Online customers are not affected by this change for now.

There are two main reasons for this change:

* Security patches are no longer shipped by Microsoft on .NET 4.5.x.
* New versions of our developing tools needs this to enable us to be more productive.

Please note:

* .NET 4.7.1 has already been pushed with Windows Update for a while and is preinstalled from Windows 10 Fall Creators Update (version 1709) and newer.
* .NET 4.7.1 is supported by Windows 7 SP1 or newer as Client OS, except Windows 8.0. Windows 8.0 is no longer supported by Microsoft. Windows 10 is supported from Windows 10 Anniversary Update (version 1607).
* .NET 4.7.1 is supported by Windows Server 2008 R2 SP1 or newer as Server OS.

See: [.Net system requirements][1]

<!-- Referenced links -->
[1]: https://docs.microsoft.com/en-us/dotnet/framework/get-started/system-requirements