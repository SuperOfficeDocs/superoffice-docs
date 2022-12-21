<!-- markdownlint-disable-file MD041 -->
## Changes from v10.1.6.812 to v10.1.6.838

### Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

#### Assembly: SoDatabase

#### Deleted Types

* `SuperOffice.Security.Principal.SoWindowsIdentity`
* `SuperOffice.Security.Principal.WindowsIdentityResolver`
* `SuperOffice.Security.Principal.WindowsIdentityValidator`
* `SuperOffice.Security.Principal.WindowsOtherIdentityResolver`
* `SuperOffice.Security.Principal.WindowsPersonIdentityResolver`

#### Modified Types

##### SuperOffice.Data.Dialect.OracleCommon is Modified

* New items
  * Method `ToSql(JsonValue)`

### Continuous Database

The following represent changes to SuperOffice database schema.
