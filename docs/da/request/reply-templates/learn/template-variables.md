---
uid: help-da-template-variables-service
title: Skabelonvariabler
description: Skabelonvariabler
keywords: sag
author: SuperOffice RnD
date: 06.29.2022
topic: reference
audience: person
audience_tooltip: SuperOffice Service
language: da
---

# Skabelonvariabler (Service)

I e-mailmeddelelsen kan du bruge skabelonvariabler til at indsætte kundespecifikke oplysninger for at give meddelelsen et mere personligt præg. På denne måde kan du skræddersy indholdet til hver enkelt kunde.

I tabellerne nedenunder kan du finde alle skabelonvariabler for SuperOffice Service og SuperOffice Marketing.

Når du redigerer svarskabeloner og udsendelser, kan du indsætte skabelonvariabler ved at indtaste variablen mellem to firkantede parenteser (\[\[ \]\] ). Eksempel: **\[\[customer.name\]\]**. I HTML-editoren kan du også vælge de mest almindelige variabler fra menuen **Skabelonvariabel**.

## Vedhæftninger (kun SuperOffice Markedsføring)

| Variabel | Beskrivelse|
|---|---|
| attachment.downloadUrl | Link til download af vedhæftningen |
| attachment.name | Navn på vedhæftning |
| attachment.openUrl | Link til at åbne vedhæftningen |
| InEmailClient | 1 hvis udsendelsesmeddelelsen vises inde i e-mailklienten, findes ikke, når udsendelsesmeddelelsen vises online i en browser |
| isWebPage | 1 hvis udsendelsesmeddelelsen vises online i en browser |

## Info om licens

| Variabel | Beskrivelse|
|---|---|
| licence.admin | 1 hvis kunden har licens til Admin, ellers 0 |
| licence.advancedfaq | 1 hvis kunden har licens til Advanced FAQ, ellers 0 |
| licence.ajax | 1 hvis kunden har licens til Ajax, ellers 0 |
| licence.blogic | 1 hvis kunden har licens til bLogic, ellers 0 |
| licence.chat | 1 hvis kunden har licens til Chat, ellers 0 |
| licence.custlang | 1 hvis kunden har licens til CustLang, ellers 0 |
| licence.customer | 1 hvis kunden har licens til Customer, ellers 0 |
| licence.document | 1 hvis kunden har licens til Document, ellers 0 |
| licence.extdb | 1 hvis kunden har licens til Extdb, ellers 0 |
| licence.help | 1 hvis kunden har licens til Help, ellers 0 |
| licence.knowledge | 1 hvis kunden har licens til Knowledge, ellers 0 |
| licence.logout | 1 hvis kunden har licens til Logout, ellers 0 |
| licence.macro | 1 hvis kunden har licens til Macro, ellers 0 |
| licence.retail | 1 hvis kunden har licens til Retail, ellers 0 |
| licence.rms | 1 hvis kunden har licens til RMS, ellers 0 |
| licence.sms | 1 hvis kunden har licens til SMS, ellers 0 |
| licence.soap | 1 hvis kunden har licens til Soap, ellers 0 |
| licence.soapPublic | 1 hvis kunden har licens til Soap Public, ellers 0 |
| licence.spm | 1 hvis kunden har licens til SPM, ellers 0 |
| licence.standardEdition | 1 hvis kunden har licens til Standard Edition, ellers 0 |
| licence.stat | 1 hvis kunden har licens til Stat, ellers 0 |
| licence.ticket | 1 hvis kunden har licens til Ticket, ellers 0 |

## Links (kun SuperOffice Markedsføring)

| Variabel | Beskrivelse|
|---|---|
| Link til onlinevisning af meddelelse | URL til visning af udsendelsesmeddelelsen online i en browser, f.eks. 'Klik her, hvis denne meddelelse ser mærkelig ud' |
| link.subscription | Linket til at annullere dit abonnement |
| link.viewShipmentMessage | Linket til at vise udsendelsesmeddelelsen online |

## <a id="config"></a>Vedligeholdelse

| Variabel | Beskrivelse|
|---|---|
| config.adminMail | E-mailadressen på den systemansvarlige for denne installation |
| config.cgiBin | URL-suffiks for eksekverbare programfiler |
| config.cgiUrl | Den eksterne basis-URL for installationen |
| config.cgiUrlInternal | Den interne basis-URL for installationen |
| config.companyAddress | Adressen på ejerfirmaet |
| config.companyName | Navnet på ejerfirmaet |
| config.defaultMail | Standard mail fra-adressen for denne installation |
| config.gfxUrl | URL-suffiks for GFX-filer |
| config.mailTag | Sætningen "Medtag sagsnummer ..." bruges som første linje i udgående e-mails |
| config.panicMail | Den mailadresse, der skal sendes fejlmeddelelser til |
| config.smtpHost | Værtsnavnet for den udgående SMTP |
| config.smtpPort | Porten for den udgående SMTP |
| config.tag | Præfikset før sagsnummeret i emnelinjen til e-mails. For eksempel "ejTag:" |
| config.uniqueId | Det unikke ID for denne installation |
| config.warning | Stien for advarselslogfiler |
| config.wwwPath | Systemstien for WWW-filer |

## <a id="customer"></a> Variabler for en valgt person

| Variabel | Beskrivelse|
|---|---|
| customer.bestName | Det bedste tilgængelige navn for denne kunde |
| customer.cellphone | Mobiltelefonnummer |
| customer.deleted | 1 Hvis denne kunde er slettet |
| customer.email | E-mailadresse |
| customer.firstname | Fornavn |
| customer.id | Person-id (skjult, entydigt ID) |
| customer.language | Valgt sprog for person |
| customer.lastname | Efternavn |
| customer.middlename | Mellemnavn |
| customer.mrmrs | Hr./Fr.-felt |
| customer.name | Fuldt navn |
| customer.note | Bemærk |
| customer.ourContact | Id'et (ejuser) for agenten, som er markeret som den primære supportkontakt for denne kunde |
| customer.password | Adgangskode i SuperOffice Kundecenter |
| customer.phone | Telefonnummer |
| customer.salutation | Hilsen – fulde navn hvis tilgængelig, eller e-mailadresse, hvis navnet ikke er kendt |
| customer.title | Titel |
| customer.username | Brugernavn i SuperOffice Kundecenter |
| makeSalutation(customer.id) | Tiltale |

## <a id="ticket"></a>Variabler for sager (kun SuperOffice Service)

| Variabel | Beskrivelse|
|---|---|
| ticket.activate | Hvornår sagen skal aktiveres,hvis den er i tilstanden Udsat |
| ticket.alertLevel | Advarselsniveau |
| ticket.author | Navnet på den person, som opretter sagen |
| ticket.category | Samme som ticket.category.id |
| ticket.category.externalName | Kategori, eksternt navn |
| ticket.category.fullname | Kategori |
| ticket.category.id | Kategori-ID (skjult, entydigt ID) |
| ticket.category.name | Navnet på kategorien for sagen |
| ticket.closedAt | Da sagen blev afsluttet |
| ticket.closedAtRaw | Dato/klokkeslæt hvor sagen blev afsluttet, i formatet ÅÅÅÅ-MM-DD TT |
| ticket.createdAt | Dato/klokkeslæt hvor sagen blev oprettet, i brugerens standardformat |
| ticket.createdAtRaw | Dato/klokkeslæt hvor sagen blev oprettet, i formatet ÅÅÅÅ-MM-DD TT |
| ticket.customer | ID'et for sagens kunde |
| ticket.customerName | Sagens person, navn |
| ticket.customerUrl | URL'en for adgang til sagen for kunden |
| ticket.customerUrlEnc | URL'en for adgang til sagen for kunden, URL-kodet |
| ticket.customerUrlOld | URL'en for adgang til sagen for kunden, ikke kodet. Beholdes af hensyn til bagudkompatibilitet. |
| ticket.dbiAgentId | DBI-agentens ID, hvis denne sag er synkroniseret ved hjælp af DBI |
| ticket.dbiKey | Den eksterne primære nøgle, hvis denne sag er synkroniseret ved hjælp af DBI |
| ticket.deadline | Tidsfristen for sagen |
| ticket.id | Sagsnummer (skjult, entydigt nummer) |
| ticket.lastChanged | Dato/klokkeslæt hvor sagen sidst blev ændret, i brugerens standardformat |
| ticket.lastChangedRaw | Dato/klokkeslæt hvor sagen sidst blev ændret, i formatet ÅÅÅÅ-MM-DD TT |
| ticket.ownerCellphone | Sagens ejer, mobilnummer |
| ticket.ownerFullName | Sagens ejer, fuldt navn |
| ticket.ownerUsername | Sagens ejer, brugernavn |
| ticket.priority | Prioritet |
| ticket.readByCustomer | Dato/klokkeslæt hvor sagen sidst blev læst af kunden, i brugerens standardformat |
| ticket.readByCustomerRaw | Dato/klokkeslæt hvor sagen sidst blev læst af kunden, i formatet ÅÅÅÅ-MM-DD TT |
| ticket.readByOwner | Dato/klokkeslæt hvor sagen sidst blev læst af ejeren, i brugerens standardformat |
| ticket.readByOwnerRaw | Dato/klokkeslæt hvor sagen sidst blev læst af ejeren, i formatet ÅÅÅÅ-MM-DD TT |
| ticket.slevel | Adgangsniveauet for sagen (1 = intern, 2 = ekstern) |
| ticket.status | Navnet på status (Aktiv, Afsluttet, Udsat) |
| ticket.ticketStatus | Navnet på den brugerdefinerede status |
| ticket.title | Sagstitel |
| ticket.url | URL'en for adgang til sagen for brugeragenter |
| ticket.urlWithSession | URL'en for adgang til sagen for brugeragenter, indeholdende den aktuelle brugersession |
| ticket.userUrl | URL'en for adgang til sagen for brugeragenter |

## <a id="company"></a>Variabler for valgt firma

| Variabel | Beskrivelse|
|---|---|
| company.adr | Adresser |
| company.department | Afdeling |
| company.domain | Domæne |
| company.fax | Faxnummer |
| company.id | Firma-ID (skjult, entydigt ID) |
| company.name | Firmanavn |
| company.note | Bemærk |
| company.ourContact | Samme som company.primaryContact.id |
| company.ourContact.cellphone | Vores kontakt, mobilnummer |
| company.ourContact.email | Vores kontakt, e-mailadresse |
| company.ourContact.name | Vores kontakt, navn |
| company.ourContact.phone | Vores kontakt, telefonnummer |
| company.ourSalesContact | ID'et (medarbejder) for firmaets KAM |
| company.ourSalesContact.cellphone | Vores salgskontakt, mobilnummer |
| company.ourSalesContact.email | Vores salgskontakt, e-mailadresse |
| company.ourSalesContact.name | Vores salgskontakt, navn |
| company.ourSalesContact.phone | Vores salgskontakt, telefonnummer |
| company.phone | Telefonnummer |
| company.primaryContact.email | Primær person, e-mailadresse |
| company.primaryContact.id | Id'et (ejuser) for agenten, som er markeret som det primære supportperson for dette firma |
| ourContact.email | Vores persons e-mailadresse |
| ourContact.name | Vores kontaktperson |

## <a id="user"></a>Variabler for svarskabeloner (bruger) (kun SuperOffice Service)

Bemærk, at disse variabler ikke fungerer for automatiske svar, der sendes af systemet, da sådanne svar ikke er knyttet til en bruger.

| Variabel | Beskrivelse|
|---|---|
| user.access | Afsenderens funktionelle adgang som bitmaske |
| user.dictionary | Brugernes standard-stavekontrolsprog |
| user.email | E-mailadresse |
| user.firstname | Fornavn |
| user.id | Den primære nøgle for afsenderen i ejuser-tabellen |
| user.language | Afsenderens valgte sprog |
| user.lastname | Efternavn |
| user.loginname | Loginnavn |
| user.middlename | Mellemnavn |
| user.name | Fulde navn for brugeragenten |
| user.signature | Afsenderens signatur fra Indstillinger |
| user.status | Afsenderens status (1 = normal, 2 = ikke tilgængelig, 3 = slettet) |
| user.username | Afsenderens brugernavn, ikke nødvendigvis det samme som loginnavn |

## Betingede værdier

\[\[IF:condition="1"\]\]

Betingelse er ét

\[\[ELSEIF:condition="2"\]\]

Betingelse er to

\[\[ELSE\]\]

Betingelse er noget andet

\[\[ENDIF\]\]

Vælg fra værdier:

\[\[DECODE:expr,"value1","return1","value2","return2","default"\]\]

Angiv variabel:

\[\[SET:name="value"\]\]

Forhøj værdien på variabel:

\[\[INC:variable\]\]

Reducer værdien på variabel:

\[\[DEC:variable\]\]

Formater dato:

\[\[FORMAT-DATE:"date","YY4 MM2 DD2 HH24:MI2:SS2"\]\]

Formater klokkeslæt:

\[\[SEC-TO-TIME:"seconds","h:m:s"\]\]
