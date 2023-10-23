<!-- markdownlint-disable-file MD041 -->
When flush is appended to the browser's URL, it triggers a procedure that initially verifies if you hold the General Admin status.
If confirmed as an admin, the system executes the DiagnosticsAgent FlushCaches, which purges the caches for:

QuoteConnectionManager
SoEventManager
LicenseCache
UserGroupCache
CountryCache
FunctionRightCache
ExtraFieldsCache
ArchiveProviderFactory
RestrictionCriteriaStorage
FreetextIndexerProcessor
FreetextIncrementalIndexer
RelationsSearchListProvider
SoListProviderFactory
ListItemLookupHelper
QuoteConnections
DatabaseConnection
SystemInfo

Additionally, layouts are reconstructed through the ConfigurationAgent ClearConfigurationCache and RebuildUdefDeltas methods.

The process also:
Clears the SuperState for all current sessions.
Removes all items from HttpContext.Cache.
Refreshes all language resources.
