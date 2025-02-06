---
uid: help-no-template-variables-service
title: Malvariabler
description: Malvariabler
keywords: sak
author: SuperOffice RnD
date: 06.29.2022
topic: reference
audience: person
audience_tooltip: SuperOffice Service
language: no
---

# Malvariabler (Service)

I e-postmeldingen kan du bruke malvariabler til å sette inn informasjon som er lagret om kundene, slik at meldingen får et mer personlig preg. På denne måten kan du skreddersy innholdet til hver enkelt kunde.

I tabellene nedenfor finner du alle malvariablene for SuperOffice Service og SuperOffice Markedsføring.

Når du redigerer svarmaler og utsendelser, kan du sette inn malvariabler ved å skrive inn variabelen mellom to hakeparenteser (\[\[ \]\] ). Eksempel: **\[\[customer.name\]\]**. I HTML-redigeringsprogrammet kan du også velge de mest vanlige variablene fra menyen **Malvariabel**.

## Vedlegg (bare SuperOffice Markedsføring)

| Variabel | Beskrivelse|
|---|---|
| attachment.downloadUrl | Kobling for å laste ned vedlegget |
| attachment.name | Navn på vedleggsfil |
| attachment.openUrl | Kobling for å åpne vedlegget |
| InEmailClient | 1 hvis utsendelsesmeldingen vises i e-postklienten, ikke til stede når utsendelsesmeldingen vises på nettet i en nettleser |
| isWebPage | 1 hvis utsendelsesmeldingen vises på nettet i en nettleser |

## Lisensinfo

| Variabel | Beskrivelse|
|---|---|
| licence.admin | 1 hvis kunden har lisens til Admin, ellers 0 |
| licence.advancedfaq | 1 hvis kunden har lisens til Advanced FAQ, ellers 0 |
| licence.ajax | 1 hvis kunden har lisens til Ajax, ellers 0 |
| licence.blogic | 1 hvis kunden har lisens til bLogic, ellers 0 |
| licence.chat | 1 hvis kunden har lisens til Chat, ellers 0 |
| licence.custlang | 1 hvis kunden har lisens til CustLang, ellers 0 |
| licence.customer | 1 hvis kunden har lisens til Customer, ellers 0 |
| licence.document | 1 hvis kunden har lisens til Document, ellers 0 |
| licence.extdb | 1 hvis kunden har lisens til Extdb, ellers 0 |
| licence.help | 1 hvis kunden har lisens til Hjelp, ellers 0 |
| licence.knowledge | 1 hvis kunden har lisens til Knowledge, ellers 0 |
| licence.logout | 1 hvis kunden har lisens til Logout, ellers 0 |
| licence.macro | 1 hvis kunden har lisens til Macro, ellers 0 |
| licence.retail | 1 hvis kunden har lisens til Retail, ellers 0 |
| licence.rms | 1 hvis kunden har lisens til RMS, ellers 0 |
| licence.sms | 1 hvis kunden har lisens til SMS, ellers 0 |
| licence.soap | 1 hvis kunden har lisens til Soap, ellers 0 |
| licence.soapPublic | 1 hvis kunden har lisens til Soap Public, ellers 0 |
| licence.spm | 1 hvis kunden har lisens til SPM, ellers 0 |
| licence.standardEdition | 1 hvis kunden har lisens til Standard Edition, ellers 0 |
| licence.stat | 1 hvis kunden har lisens til Stat, ellers 0 |
| licence.ticket | 1 hvis kunden har lisens til Ticket, ellers 0 |

## Koblinger (bare SuperOffice Markedsføring)

| Variabel | Beskrivelse|
|---|---|
| Kobling for å vise melding online | URL for å vise utsendelsesmeldingen i en nettleser, f.eks. "Klikk her hvis denne meldingen ser rar ut" |
| link.subscription | Koblingen for å avslutte abonnementet |
| link.viewShipmentMessage | Koblingen for å vise utsendelsesmeldingen på nettet |

## <a id="config"></a>Vedlikehold

| Variabel | Beskrivelse|
|---|---|
| config.adminMail | E-postadressen til systemadministrator for denne installasjonen |
| config.cgiBin | URL-suffikset for de kjørbare programfilene |
| config.cgiUrl | Den eksterne base-URL-en for installasjonen |
| config.cgiUrlInternal | Den interne base-URL-en for installasjonen |
| config.companyAddress | Adressen til eierfirmaet |
| config.companyName | Navnet på eierfirmaet |
| config.defaultMail | Standard avsenderadresse for denne installasjonen |
| config.gfxUrl | URL-suffikset for GFX-filene |
| config.mailTag | Frasen "Inkluder saksnummer ..." som brukes i den første linjen i utgående e-postmeldinger |
| config.panicMail | E-postadressen feilmeldinger sendes til |
| config.smtpHost | Vertsnavnet for utgående SMTP |
| config.smtpPort | Porten for utgående SMTP |
| config.tag | Prefikset før saksnummeret i emnelinjen i e-postmeldinger. For eksempel "ejTag:" |
| config.uniqueId | Den unike ID-en for denne installasjonen |
| config.warning | Banen til loggfilene |
| config.wwwPath | Systembanen for WWW-filer |

## <a id="customer"></a>Variabler for en valgt person

| Variabel | Beskrivelse|
|---|---|
| customer.bestName | Det beste tilgjengelige navnet for denne kunden |
| customer.cellphone | Mobiltelefonnummer |
| customer.deleted | 1 hvis denne kunden er slettet |
| customer.email | E-postadresse |
| customer.firstname | Fornavn |
| customer.id | Person-ID (skjult, unik ID) |
| customer.language | Velg språk på person |
| customer.lastname | Etternavn |
| customer.middlename | Mellomnavn |
| customer.mrmrs | Hr/Fr-felt |
| customer.name | Fullt navn |
| customer.note | Merk |
| customer.ourContact | ID-en (ejuser) for agenten som er merket som den primære brukerstøttekontakten for denne kunden |
| customer.password | Passord i SuperOffice Kundesenter |
| customer.phone | Telefonnummer |
| customer.salutation | Åpning – hele navnet hvis tilgjengelig, eller e-postadressen hvis navnet ikke er kjent |
| customer.title | Tittel |
| customer.username | Brukernavn i SuperOffice Kundesenter |
| makeSalutation(customer.id) | Åpning |

## <a id="ticket"></a>Variabler for saker (bare SuperOffice Service)

| Variabel | Beskrivelse|
|---|---|
| ticket.activate | Når saken skal aktiveres, hvis den er i en utsatt tilstand |
| ticket.alertLevel | Alarmnivå |
| ticket.author | Navnet på personen som oppretter saken |
| ticket.category | Samme som ticket.category.id |
| ticket.category.externalName | Kategori, eksternt navn |
| ticket.category.fullname | Kategori |
| ticket.category.id | Kategori-ID (skjult, unik ID) |
| ticket.category.name | Navnet på kategorien for saken |
| ticket.closedAt | Da saken ble avsluttet |
| ticket.closedAtRaw | Datotiden da saken ble avsluttet i ÅÅÅÅ-MM-DD TT |
| ticket.createdAt | Datotiden da saken ble opprettet i brukerens standardformat |
| ticket.createdAtRaw | Datotiden da saken ble opprettet i ÅÅÅÅ-MM-DD TT |
| ticket.customer | IDen på kunden for saken |
| ticket.customerName | Sakens person, navn |
| ticket.customerUrl | URL-en for å få tilgang til saken for kunden |
| ticket.customerUrlEnc | URL-en for å få tilgang til saken for kunden, URL-kodet |
| ticket.customerUrlOld | URL-en for å få tilgang til saken for kunden, ikke kodet. Beholdes for kompatibilitet bakover. |
| ticket.dbiAgentId | ID-en for DBI-agent hvis denne saken er synkronisert med DBI |
| ticket.dbiKey | Den eksterne primære nøkkelen hvis denne saken er synkronisert med DBI |
| ticket.deadline | Tidsfristen for saken |
| ticket.id | Saks-ID (skjult, unik ID) |
| ticket.lastChanged | Datotiden da saken sist ble endret i brukerens standardformat |
| ticket.lastChangedRaw | Datotiden da saken sist ble endret i ÅÅÅÅ-MM-DD TT |
| ticket.ownerCellphone | Sakens eier, mobiltelefonnummer |
| ticket.ownerFullName | Sakens eier, fullt navn |
| ticket.ownerUsername | Sakens eier, brukernavn |
| ticket.priority | Prioritet |
| ticket.readByCustomer | Datoen/klokkeslettet da saken sist ble lest av kunden i brukerens standardformat |
| ticket.readByCustomerRaw | Datoen/klokkeslettet da saken ble lest av kunden i ÅÅÅÅ-MM-DD TT |
| ticket.readByOwner | Datoen/klokkeslettet da saken ble lest av eieren i brukerens standardformat |
| ticket.readByOwnerRaw | Datoen/klokkeslettet da saken ble lest av eieren i ÅÅÅÅ-MM-DD TT |
| ticket.slevel | Tilgangsnivået for saken (1 = Intern, 2 = Ekstern) |
| ticket.status | Navnet på statusen (Åpen, Avsluttet, Utsatt) |
| ticket.ticketStatus | Navnet på brukerdefinert status |
| ticket.title | Sakstittel |
| ticket.url | URL-en for å få tilgang til saken for agentene |
| ticket.urlWithSession | URL-en for å få tilgang til saken for agenter som inneholder gjeldende brukersesjon |
| ticket.userUrl | URL-en for å få tilgang til saken for agentene |

## <a id="company"></a>Variabler for valgt firma

| Variabel | Beskrivelse|
|---|---|
| company.adr | Adresse |
| company.department | Avdeling |
| company.domain | Domene |
| company.fax | Faksnummer |
| company.id | Firma-ID (skjult, unik ID) |
| company.name | Firmanavn |
| company.note | Merk |
| company.ourContact | Samme som company.primaryContact.id |
| company.ourContact.cellphone | Vår kontakt, mobiltelefonnummer |
| company.ourContact.email | Vår kontakt, e-postadresse |
| company.ourContact.name | Vår kontakt, navn |
| company.ourContact.phone | Vår kontakt, telefonnummer |
| company.ourSalesContact | ID (medarbeider) for firmaets kundeansvarlig |
| company.ourSalesContact.cellphone | Vår salgskontakt, mobiltelefonnummer |
| company.ourSalesContact.email | Vår salgskontakt, e-postadresse |
| company.ourSalesContact.name | Vår salgskontakt, navn |
| company.ourSalesContact.phone | Vår salgskontakt, telefonnummer |
| company.phone | Telefonnummer |
| company.primaryContact.email | Primærkontakt, e-postadresse |
| company.primaryContact.id | ID-en (ejuser) for agenten som er merket som den primære brukerstøttekontakten for dette firmaet |
| ourContact.email | Våre kontakter e-postadresse |
| ourContact.name | Vår kontakt |

## <a id="user"></a>Variabler for svarmaler (bruker) (bare SuperOffice Service)

Vær oppmerksom på at disse variablene ikke fungerer for automatiserte svar sendt av systemet, fordi slike svar ikke er knyttet til en bruker.

| Variabel | Beskrivelse|
|---|---|
| user.access | Avsenderens funksjonelle tilgang som en bitmask |
| user.dictionary | Brukerens standard stavekontrollspråk |
| user.email | E-postadresse |
| user.firstname | Fornavn |
| user.id | Primærnøkkelen for avsenderen i ejuser-tabellen |
| user.language | Avsenders valgte språk |
| user.lastname | Etternavn |
| user.loginname | Påloggingsnavn |
| user.middlename | Mellomnavn |
| user.name | Fullt navn på agenten |
| user.signature | Avsenders signatur fra Innstillinger |
| user.status | Avsenders status (1 = normal, 2 = ikke tilgjengelig, 3 = slettet) |
| user.username | Avsenderens brukernavn, ikke nødvendigvis det samme som innloggingsnavn |

## Betingede verdier

[[IF:condition="1"]]

Betingelse er én

[[ELSEIF:condition="2"]]

Betingelse er to

[[ELSE]]

Betingelse er noe annet

[[ENDIF]]

Velg mellom verdier:

[[DECODE:expr,"value1","return1","value2","return2","default"]]

Angi variabel:

[[SET:name="value"]]

Økningsvariabel:

[[INC:variable]]

Reduksjonsvariabel:

[[DEC:variable]]

Formater dato:

[[FORMAT-DATE:"date","YY4 MM2 DD2 HH24:MI2:SS2"]]

Formater klokkeslett:

[[SEC-TO-TIME:"seconds","h:m:s"]]
