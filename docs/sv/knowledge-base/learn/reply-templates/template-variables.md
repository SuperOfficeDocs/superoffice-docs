---
uid: help-sv-template-variables-service
title: Mallvariabler
description: Mallvariabler
keywords: mallvariabler
author: SuperOffice Product and Engineering
date: 06.29.2022
version: 10.5
content_type: reference
category: service
topic: knowledge base
audience: person
audience_tooltip: SuperOffice Service
language: sv
redirect_from: /sv/request/reply-templates/learn/template-variables
---

# Mallvariabler (Service)

I e-postmeddelandet kan du använda mallvariabler för att infoga kundspecifika uppgifter och ge meddelandet en mer personlig prägel. På så sätt kan du anpassa innehållet efter varje enskild kund.

I tabellerna nedan hittar du alla mallvariabler för SuperOffice Service och SuperOffice Marketing.

När du redigerar svarsmallar och utskick kan du infoga mallvariabler genom att skriva variabeln mellan två hakparenteser (\[\[ \]\]). Exempel: **\[\[customer.name\]\]**. I HTML-redigeraren kan du även välja de vanligaste variablerna i menyn **Mallvariabel**.

## Bilagor (endast SuperOffice Marknadsföring)

| Variabel | Beskrivning|
|---|---|
| attachment.downloadUrl | Länk för att hämta bilagan |
| attachment.name | Bilagans filnamn |
| attachment.openUrl | Länk för att öppna bilagan |
| InEmailClient | 1 om utskicksmeddelandet visas inuti e-postklienten; inte närvarande när utskicksmeddelandet visas online i en webbläsare |
| isWebPage | 1 om utskicksmeddelandet visas online i en webbläsare |

## Licensinformation

| Variabel | Beskrivning|
|---|---|
| licence.admin | 1 om kunden har licens för Admin, annars 0 |
| licence.advancedfaq | 1 om kunden har licens för Advanced FAQ, annars 0 |
| licence.ajax | 1 om kunden har licens för Ajax, annars 0 |
| licence.blogic | 1 om kunden har licens för bLogic, annars 0 |
| licence.chat | 1 om kunden har licens för Chat, annars 0 |
| licence.custlang | 1 om kunden har licens för CustLang, annars 0 |
| licence.customer | 1 om kunden har licens för Customer, annars 0 |
| licence.document | 1 om kunden har licens för Document, annars 0 |
| licence.extdb | 1 om kunden har licens för Extdb, annars 0 |
| licence.help | 1 om kunden har licens för Help, annars 0 |
| licence.knowledge | 1 om kunden har licens för Knowledge, annars 0 |
| licence.logout | 1 om kunden har licens för Logout, annars 0 |
| licence.macro | 1 om kunden har licens för Macro, annars 0 |
| licence.retail | 1 om kunden har licens för Retail, annars 0 |
| licence.rms | 1 om kunden har licens för RMS, annars 0 |
| licence.soapbox | 1 om kunden har licens för Soapbox, annars 0 |
| licence.spm | 1 om kunden har licens för SPM, annars 0 |
| licence.standardfaq | 1 om kunden har licens för Standard FAQ, annars 0 |
| licence.stat | 1 om kunden har licens för Stat, annars 0 |
| licence.ticket | 1 om kunden har licens för Ticket, annars 0 |

## Kontaktinformation

| Variabel | Beskrivning|
|---|---|
| contact.department | Kontaktens avdelning |
| contact.email | Kontaktens e-postadress |
| contact.fax | Kontaktens faxnummer |
| contact.id | Kontaktens ID (dold, unikt) |
| contact.name | Kontaktens namn |
| contact.note | Kommentar till kontakten |
| contact.phone | Kontaktens telefonnummer |
| contact.url | Kontaktens webbadress |

## Företagsinformation

| Variabel | Beskrivning|
|---|---|
| company.adr | Företagets adress |
| company.department | Företagets avdelning |
| company.email | Företagets e-postadress |
| company.fax | Företagets faxnummer |
| company.id | Företagets ID (dold, unikt) |
| company.name | Företagets namn |
| company.note | Kommentar till företaget |
| company.phone | Företagets telefonnummer |

## Kundinformation

| Variabel | Beskrivning|
|---|---|
| customer.bestName | Bästa namn för kunden (företag eller förnamn + efternamn) |
| customer.cellphone | Kundens mobilnummer |
| customer.email | Kundens e-postadress |
| customer.firstname | Kundens förnamn |
| customer.id | Kundens ID (dold, unikt) |
| customer.lastname | Kundens efternamn |
| customer.middlename | Kundens mellannamn |
| customer.name | Kundens namn |
| customer.note | Kommentar till kunden |
| customer.ourcontact | Vår kontakt |
| customer.phone | Kundens telefonnummer |
| customer.salutation | Kundens tilltal |
| customer.username | Kundens användarnamn |

## Ärendeinformation

| Variabel | Beskrivning|
|---|---|
| ticket.activate | Ärendets aktiveringstid |
| ticket.category | Ärendets kategori |
| ticket.closedAt | Ärendets stängningstid |
| ticket.closedBy | Vem som stängde ärendet |
| ticket.createdAt | Ärendets skapandetid |
| ticket.createdBy | Vem som skapade ärendet |
| ticket.customer | Kund som ärendet hör till |
| ticket.deadline | Tidsfrist för ärendet |
| ticket.id | Ärendets ID (dold, unikt) |
| ticket.lastChanged | Senast ändrat |
| ticket.level | Ärendets nivå |
| ticket.origin | Ärendets ursprung |
| ticket.owned_by | Ärendets handläggare |
| ticket.priority | Ärendets prioritet |
| ticket.slevel | Ärendets säkerhetsnivå |
| ticket.status | Ärendets status |
| ticket.title | Ärendets rubrik |
| ticket.url | Direktlänk till ärendet (endast för intern användning) |

## Användarinformation

| Variabel | Beskrivning|
|---|---|
| user.email | Användarens e-postadress |
| user.firstname | Användarens förnamn |
| user.id | Användarens ID (dold, unikt) |
| user.lastname | Användarens efternamn |
| user.middlename | Användarens mellannamn |
| user.name | Användarens namn |
| user.signature | Användarens signatur |
| user.username | Användarens användarnamn |

## Konfiguration

| Variabel | Beskrivning|
|---|---|
| config.adminMail | Administratörens e-postadress |
| config.baseUrl | Systemets bas-URL |
| config.cgiBin | Sökväg till CGI-skript |
| config.cgiUrl | URL till CGI-skript |
| config.cgiUrlInternal | Intern URL till CGI-skript |
| config.companyAddress | Företagets adress |
| config.companyName | Företagets namn |
| config.customerUrl | Kundens URL |
| config.defaultMail | Standardmeddelande |
| config.gfxPath | Sökväg till grafik |
| config.mailAddress | E-postadress |
| config.panicMail | Panikmeddelande |
| config.smtpHost | SMTP-värd |
| config.smtpPort | SMTP-port |
| config.systemName | Systemets namn |
| config.uniqueId | Unikt ID |
| config.warning | Varning |
| config.wwwPath | Sökväg till webben |

## Datum- och tidsvariabler

| Variabel | Beskrivning|
|---|---|
| date.now | Aktuellt datum |
| date.weekday | Veckodag |
| date.year | År |
| date.month | Månad |
| date.day | Dag |
| time.now | Aktuell tid |
| time.hour | Timme |
| time.minute | Minut |
| time.second | Sekund |
