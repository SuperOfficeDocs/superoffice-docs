<!-- markdownlint-disable-file MD041 -->
| Property Name | Tag | Description |
|---------------|-----|-------------|
| ActiveFeatureToggles | feat | All active feature toggle names from the config file: "AppDynamics,NewInbox" |
| Client | clie | Client type: win,web,pocket, or netserver            Needs to be provided by the client - otherwise default is "netserver" |
| ContextIdentifier | uctx | Current Context Identifier (online's customer number) |
| CSBaseURL | csbu | CS-specific tag to retrive CS' Base URL. |
| CSBlogicUrl | csbl | CS-specific tag to retrive CS' Base URL (blogic.exe). |
| CSCGIBin | csbn | CS-specific tag to retrive CS' CGI bin. |
| CSCGiUrlInternal | csiu | CS-specific tag to retrive CS' Internal CGI URL. |
| CSCustomerUrl | cscu | CS-specific tag to retrive CS' Base URL (customer.exe). |
| CSRegistryExtension | csre | CS-specific tag to retrive CS' Registry extension. |
| CSRMSUrl | csrm | CS-specific tag to retrive CS' Base URL (ajax.exe). |
| CSTicketUrl | csti | CS-specific tag to retrive CS' Base URL (ticket.exe). |
| CurrentDiaryOwnerID | diid | Current diary owner ID. Only used from WIN |
| CurrentTicketID | tiid | Current ticket ID. Only used from WIN |
| FunctionRights | ufun | Current user's function rights, comma separated: "admin-all,admin-roles,hide-inbox,allow-bulk-export" |
| IsAdmin | adm? | Is the current user a user admin? True/False. Has AdminAll or AdminUsers function right? |
| LanguageIso2Code | lani | Language 2 letter ISO code: "en" or "no" or "de" |
| LanguageIsoCode | lanc | Language ISO code: "en-US" or "nb-NO" or "de" |
| LanguageName | lang | Language native name: "English" or "Norsk" or "Deutch".            Any country-specific portion is trimmed Like "(United States)" |
| LanguageSoCode | lanx | Language SuperOffice Code: "US" or "NO" or "GE" |
| LoggedInUserEMailAddress | usem | E-mail address of logged in user |
| LoggedInUserFirstName | usfn | First name of logged in user |
| LoggedInUserId | usid | User login record id (hidden id). The associate id of the currently logged in user. Is not affected by the selected diary user, unlike alid |
| LoggedInUserLastName | usln | Last name of logged in user |
| LoggedInUserLicense | ulic | All not hidden licenses for the logged in user: "superoffice.superlicense-sales-pro,superoffice.admin-extern-user,superoffice.visible-for" |
| LoggedInUserMiddleName | usmn | Middle name of logged in user |
| LoggedInUserName | user |  |
| MailGatewayDisplayName | mgdn | Name of Gateway that stores a copy of outgoing messages on the system |
| MailGatewayMailAddress | mgma | Address of Gateway that stores a copy of outgoing messages on the system |
| NetServerSecret | usec | NetServer Base64 encoded secret. Send this as username or as the ticket to reauthenticate within 6 hours |
| OwnerCompanyName | iocn | License Info: Company name associate with license. NOTE: The database owner of <b>this</b> database can be different, if this is a satellite |
| Platform | pltf | Platform where substitution occurred: web (NetServer) or win |
| SerialNumber | ser# | SOCRM serial number: "101000006" |
| SoArcPath | ptha | SO_Arc path (from SuperOffice.ini) |
| SuperOfficeIniPath | pthi | Path to the folder where SuperOffice.ini is located |
| SuperOfficeProgPath | pthp | Path to the folder where SOCRM is installed |
| TimeZone | btzt | Time zone information: (GMT+1), (GMT+0), (GMT-4) |
| TodaysDate | btod | Today's date in UTC. Today's date, formatted yyyyMMdd |
| TodaysTime | btot | Current time now, formatted HHmmss |
| TodaysTime2 | ltim | Current time now, in long format |
| VersionFile | verf | Netserver File version: 7.1.2010.300 |
| VersionName | vern | Netserver version (full name): "SuperOffice NetServer 7.1 Release (Build: 7.1.200.300.TEST)" |
| VersionNumber | ver# | Netserver assembly version: 7.1.1000.0 |
