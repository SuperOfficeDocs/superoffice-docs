---
uid: help-sv-template-variables-service
title: Mallvariabler
description: Mallvariabler
keywords: ärende
author: SuperOffice RnD
date: 06.29.2022
topic: reference
audience: person
audience_tooltip: SuperOffice Service
language: sv
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
| licence.sms | 1 om kunden har licens för SMS, annars 0 |
| licence.soap | 1 om kunden har licens för Soap, annars 0 |
| licence.soapPublic | 1 om kunden har licens för Soap Public, annars 0 |
| licence.spm | 1 om kunden har licens för SPM, annars 0 |
| licence.standardEdition | 1 om kunden har licens för Standard Edition, annars 0 |
| licence.stat | 1 om kunden har licens för Stat, annars 0 |
| licence.ticket | 1 om kunden har licens för Ticket, annars 0 |

## Länkar (endast SuperOffice Marketing)

| Variabel | Beskrivning|
|---|---|
| Länk för att visa meddelande online | URL för att visa utskicksmeddelandet online i en webbläsare, t.ex. "Klicka här om meddelandet ser konstigt ut" |
| link.subscription | Länk för att avsluta din prenumeration |
| link.viewShipmentMessage | Länk för att visa utskicksmeddelandet online |

## <a id="config"></a>Underhåll

| Variabel | Beskrivning|
|---|---|
| config.adminMail | E-postadress för den systemansvarige för denna installation |
| config.cgiBin | URL-suffix för de körbara programfilerna |
| config.cgiUrl | Extern bas-URL för installationen |
| config.cgiUrlInternal | Intern bas-URL för installationen |
| config.companyAddress | Ägarföretagets adress |
| config.companyName | Ägarföretagets namn |
| config.defaultMail | Standardavsändaradress för denna installation |
| config.gfxUrl | URL-suffix för GFX-filerna |
| config.mailTag | Frasen "Var god inkludera ärendets ID ..." använd som första rad i utgående e-post |
| config.panicMail | E-postadressen som felmeddelanden ska skickas till |
| config.smtpHost | Värdnamn för utgående SMTP |
| config.smtpPort | Port för utgående SMTP |
| config.tag | Prefix före ärendenumret i ämnesraden för e-post. Till exempel "ejTag:" |
| config.uniqueId | Unikt ID för denna installation |
| config.warning | Sökväg för varningsloggfilerna |
| config.wwwPath | Systemsökväg för WWW-filer |

## <a id="customer"></a>Variabler för en vald kontakt

| Variabel | Beskrivning|
|---|---|
| customer.bestName | Bästa tillgängliga namn för denna kund |
| customer.cellphone | Mobiltelefonnummer |
| customer.deleted | 1 om denna kund är borttagen |
| customer.email | E-postadress |
| customer.firstname | Förnamn |
| customer.id | Kontakts ID (dolt, unikt ID) |
| customer.language | Valt språk för kontakt |
| customer.lastname | Efternamn |
| customer.middlename | Mellannamn |
| customer.mrmrs | Mr/Ms-fält |
| customer.name | Fullständigt namn |
| customer.note | Notering |
| customer.ourContact | ID (ejuser) för den agent som är markerad som primär supportkontakt för denna kund |
| customer.password | Lösenord i SuperOffice Customer Centre |
| customer.phone | Telefonnummer |
| customer.salutation | Tilltal – fullständigt namn om det finns tillgängligt, eller e-postadress om inget namn är känt |
| customer.title | Titel |
| customer.username | Användarnamn i SuperOffice Customer Centre |
| makeSalutation(customer.id) | Hälsning |

## <a id="ticket"></a>Variabler för ärenden (endast SuperOffice Service)

| Variabel | Beskrivning|
|---|---|
| ticket.activate | När ärendet ska aktiveras, om det är i uppskjutet läge |
| ticket.alertLevel | Aviseringsnivå |
| ticket.author | Namn på den person som skapar ärendet |
| ticket.category | Samma som ticket.category.id |
| ticket.category.externalName | Kategori, externt namn |
| ticket.category.fullname | Kategori |
| ticket.category.id | Kategori-ID (dolt, unikt ID) |
| ticket.category.name | Namn på kategorin för ärendet |
| ticket.closedAt | When the request was closed |
| ticket.closedAtRaw | Datum och tid när ärendet avslutades i ÅÅÅÅ-MM-DD HH |
| ticket.createdAt | Datum och tid när ärendet skapades i användarens standardformat |
| ticket.createdAtRaw | Datum och tid när ärendet skapades i ÅÅÅÅ-MM-DD HH |
| ticket.customer | Kundens ID för ärendet |
| ticket.customerName | Ärendets kontakt, namn |
| ticket.customerUrl | URL för att komma åt ärendet för kunden |
| ticket.customerUrlEnc | URL för att komma åt ärendet för kunden, URL-kodad |
| ticket.customerUrlOld | URL för att komma åt ärendet för kunden, ej kodad Behålls för bakåtkompatibilitet. |
| ticket.dbiAgentId | DBI-agentens ID om detta ärende har synkroniserats med DBI |
| ticket.dbiKey | Extern primärnyckel om detta ärende synkroniserades med DBI |
| ticket.deadline | Tidsfrist för ärendet |
| ticket.id | Ärendets ID (dolt, unikt ID) |
| ticket.lastChanged | Datum och tid när ärendet senast ändrades i användarens standardformat |
| ticket.lastChangedRaw | Datum och tid när ärendet senast ändrades i ÅÅÅÅ-MM-DD HH |
| ticket.ownerCellphone | Ärendets ägare, mobiltelefonnummer |
| ticket.ownerFullName | Ärendets ägare, fullständigt namn |
| ticket.ownerUsername | Ärendets ägare, användarnamn |
| ticket.priority | Prioritet |
| ticket.readByCustomer | Datum och tid när ärendet lästes av kunden i användarens standardformat |
| ticket.readByCustomerRaw | Datum och tid när ärendet lästes av kunden i ÅÅÅÅ-MM-DD HH |
| ticket.readByOwner | Datum och tid när ärendet lästes av ägaren i användarens standardformat |
| ticket.readByOwnerRaw | Datum och tid när ärendet lästes av ägaren i ÅÅÅÅ-MM-DD HH |
| ticket.slevel | Ärendets åtkomstnivå (1 = Internt, 2 = Externt) |
| ticket.status | Statusens namn (Aktivt, Avslutat, Uppskjutet) |
| ticket.ticketStatus | Namn på den användardefinierade statusen |
| ticket.title | Ärendets titel |
| ticket.url | URL för att komma åt ärendet för användaragenter |
| ticket.urlWithSession | URL för att komma åt ärendet för användaragenter inkl. den aktuella användarsessionen |
| ticket.userUrl | URL för att komma åt ärendet för användaragenter |

## <a id="company"></a>Variabler för valt företag

| Variabel | Beskrivning|
|---|---|
| company.adr | Adress |
| company.department | Avdelning |
| company.domain | Domän |
| company.fax | Faxnummer |
| company.id | Företagets ID (dolt, unikt ID) |
| company.name | Företagsnamn |
| company.note | Notering |
| company.ourContact | Samma som company.primaryContact.id |
| company.ourContact.cellphone | Vår kontakt, mobiltelefonnummer |
| company.ourContact.email | Vår kontakt, e-postadress |
| company.ourContact.name | Vår kontakt, namn |
| company.ourContact.phone | Vårt kontakt, telefonnummer |
| company.ourSalesContact | ID (associerat) för företagets KAM |
| company.ourSalesContact.cellphone | Vår försäljningskontakt, mobiltelefonnummer |
| company.ourSalesContact.email | Vår säljkontakt, e-postadress |
| company.ourSalesContact.name | Vår försäljningskontakt, namn |
| company.ourSalesContact.phone | Vår försäljningskontakt, telefonnummer |
| company.phone | Telefonnummer |
| company.primaryContact.email | Huvudkontakt, e-postadress |
| company.primaryContact.id | ID (ejuser) för den agent som är markerad som primär supportkontakt för detta företag |
| ourContact.email | Våra kontakter e-postadress |
| ourContact.name | Vår kontakt |

## <a id="user"></a>Variabler för svarsmallar (användare) (endast SuperOffice Service)

Observera att dessa variabler inte fungerar för automatiska svar från systemet eftersom sådana svar inte är kopplade till någon användare.

| Variabel | Beskrivning|
|---|---|
| user.access | Avsändarens funktionella åtkomst som en bitmask |
| user.dictionary | Användarens standardordlistespråk |
| user.email | E-postadress |
| user.firstname | Förnamn |
| user.id | Primärnyckel för avsändaren i ejuser-tabellen |
| user.language | Avsändarens valda språk |
| user.lastname | Efternamn |
| user.loginname | Inloggningsnamn |
| user.middlename | Mellannamn |
| user.name | Användaragentens fullständiga namn |
| user.signature | Avsändarens signatur från Inställningar |
| user.status | Avsändarens status (1 = normal, 2 = inte tillgänglig, 3 = borttagen) |
| user.username | Avsändarens användarnamn, inte nödvändigtvis samma som inloggningsnamnet |

## Villkorliga värden

\[\[IF:condition="1"\]\]

Villkoret är ett

\[\[ELSEIF:condition="2"\]\]

Villkoret är två

\[\[ELSE\]\]

Villkoret är något annat

\[\[ENDIF\]\]

Välja från värden:

\[\[DECODE:expr,"value1","return1","value2","return2","default"\]\]

Sätta variabel:

\[\[SET:name="value"\]\]

Öka variabel:

\[\[INC:variable\]\]

Minska variabel:

\[\[DEC:variable\]\]

Formatera datum:

\[\[FORMAT-DATE:"date","YY4 MM2 DD2 HH24:MI2:SS2"\]\]

Formatera tid:

\[\[SEC-TO-TIME:"seconds","h:m:s"\]\]
