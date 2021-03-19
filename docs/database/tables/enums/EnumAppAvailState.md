<properties generated="1" SortOrder="990" />

# AppAvailState Enum

When should this application be available from SO: 0=always, 1=on central db, 2=on travel db,4 on satellite. The value 5 (1+4) indicates that this application is available when logged in to a central or satellite db

* Always = 0
* CentralDb = 1
* SatelliteDb = 2
* TravelDb = 4
* SalesMarketingWeb = 8
* SalesMarketingPocket = 16

## Usage
* [ExtApp](ExtApp.md).availableInState - ExtApp list table. Applications startable from SuperOffice

