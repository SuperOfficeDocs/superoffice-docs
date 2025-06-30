---
uid: help-nl-template-variables-service
title: Sjabloonvariabelen
description: Sjabloonvariabelen
keywords: verzoek
author: SuperOffice RnD
date: 06.29.2022
content_type: reference
audience: person
audience_tooltip: SuperOffice Service
language: nl
---

# Sjabloonvariabelen (Service)

In het e-mailbericht kunt u sjabloonvariabelen gebruiken om klantspecifieke informatie in te voegen om het bericht een persoonlijke benadering te geven. Op deze manier kunt u de inhoud voor elke afzonderlijke klant aanpassen.

In de onderstaande tabellen vindt u alle sjabloonvariabelen voor SuperOffice Service en SuperOffice Marketing.

Bij het bewerken van antwoordsjablonen en mailings kunt u sjabloonvariabelen invoegen door de variabele in te typen tussen twee vierkante haakjes (\[\[ \]\] ). Bijvoorbeeld: **\[\[customer.name\]\]**. In de HTML-editor kunt u ook de meest voorkomende variabelen uit het menu **Sjabloonvariabele** kiezen.

## Bijlagen (alleen SuperOffice Marketing)

| Variabele | Beschrijving|
|---|---|
| attachment.downloadUrl | Koppeling om de bijlage te downloaden |
| attachment.name | Bestandsnaam bijlage |
| attachment.openUrl | Koppeling om de bijlage te openen |
| InEmailClient | 1 Als het mailingbericht wordt weergegeven in de e-mailclient, niet aanwezig wanneer het mailingbericht online wordt weergegeven in een browser |
| isWebPage | 1 als het mailingbericht online in een browser wordt weergegeven |

## Licentie info

| Variabele | Beschrijving|
|---|---|
| licence.admin | 1 als de klant een licentie heeft voor Admin, anders 0 |
| licence.advancedfaq | 1 als de klant een licentie heeft voor Geavanceerde Veelgestelde vragen, anders 0 |
| licence.ajax | 1 als de klant een licentie heeft voor Ajax, anders 0 |
| licence.blogic | 1 als de klant een licentie heeft voor blogic, anders 0 |
| licence.chat | 1 als de klant een licentie heeft voor Chat, anders 0 |
| licence.custlang | 1 als de klant een licentie heeft voor CustLang, anders 0 |
| licence.customer | 1 als de klant een licentie heeft voor Customer, anders 0 |
| licence.document | 1 als de klant een licentie heeft voor Document, anders 0 |
| licence.extdb | 1 als de klant een licentie heeft voor Extdb, anders 0 |
| licence.help | 1 als de klant een licentie heeft voor Help, anders 0 |
| licence.knowledge | 1 als de klant een licentie heeft voor Knowledge, anders 0 |
| licence.logout | 1 als de klant een licentie heeft voor Logout, anders 0 |
| licence.macro | 1 als de klant een licentie heeft voor Macro, anders 0 |
| licence.retail | 1 als de klant een licentie heeft voor Retail, anders 0 |
| licence.rms | 1 als de klant een licentie heeft voor RMS, anders 0 |
| licence.sms | 1 als de klant een licentie heeft voor SMS, anders 0 |
| licence.soap | 1 als de klant een licentie heeft voor Soap, anders 0 |
| licence.soapPublic | 1 als de klant een licentie heeft voor Soap Public, anders 0 |
| licence.spm | 1 als de klant een licentie heeft voor SPM, anders 0 |
| licence.standardEdition | 1 als de klant een licentie heeft voor Standard Edition, anders 0 |
| licence.stat | 1 als de klant een licentie heeft voor Stat, anders 0 |
| licence.ticket | 1 als de klant een licentie heeft voor Ticket, anders 0 |

## Koppelingen (alleen SuperOffice Marketing)

| Variabele | Beschrijving|
|---|---|
| Koppeling voor online weergave van bericht | URL voor het tonen van het mailingbericht online in een browser, bijvoorbeeld 'Klik hier als dit bericht er vreemd uitziet' |
| link.subscription | De koppeling om uw abonnement te annuleren |
| link.viewShipmentMessage | De koppeling voor de online weergave van bericht |

## <a id="config"></a>Onderhoud

| Variabele | Beschrijving|
|---|---|
| config.adminMail | Het e-mailadres van de systeembeheerder voor deze installatie |
| config.cgiBin | Het URL-voorvoegsel voor de uitvoerbare programmabestanden |
| config.cgiUrl | De externe basis-URL voor de installatie |
| config.cgiUrlInternal | De interne basis-URL voor de installatie |
| config.companyAddress | Het adres van het bedrijf dat eigenaar is |
| config.companyName | De naam van het bedrijf dat eigenaar is |
| config.defaultMail | Het standaard mail-van-adres voor deze installatie |
| config.gfxUrl | Het URL-voorvoegsel voor de GFX-bestanden |
| config.mailTag | De zin 'Gelieve de ticket-ID in te voeren...' gebruikt als eerste lijn in uitgaande e-mails |
| config.panicMail | Het e-mailadres waarnaar foutmeldingen moeten worden verzonden |
| config.smtpHost | De hostnaam voor de uitgaande SMTP |
| config.smtpPort | De poort voor de uitgaande SMTP |
| config.tag | Het voorvoegsel voor het verzoeknummer in de onderwerpregel van e-mails. Bijvoorbeeld: "geen Label:" |
| config.uniqueId | De unieke id voor deze installatie |
| config.warning | Het pad voor de waarschuwingslogbestanden |
| config.wwwPath | Het systeempad voor WWW-bestanden |

## <a id="customer"></a>Variabelen voor een geselecteerde contactpersoon

| Variabele | Beschrijving|
|---|---|
| customer.bestName | De beste beschikbare naam voor deze klant |
| customer.cellphone | Mobiel telefoonnummer |
| customer.deleted | 1 als deze klant is verwijderd |
| customer.email | E-mailadres |
| customer.firstname | Voornaam |
| customer.id | Persoon-ID (verborgen, unieke ID) |
| customer.language | De geselecteerde taal voor de persoon |
| customer.lastname | Achternaam |
| customer.middlename | Voorvoegsel |
| customer.mrmrs | Veld Mr/Mv |
| customer.name | Volledige naam |
| customer.note | Opmerking |
| customer.ourContact | De id (ejuser) van de agent wordt aangeduid als primair ondersteuningscontact voor deze klant |
| customer.password | Wachtwoord in SuperOffice Customer Centre |
| customer.phone | Telefoonnummer |
| customer.salutation | Begroeting - de volledige naam, indien beschikbaar, of het e-mailadres als geen naam bekend is |
| customer.title | Titel |
| customer.username | Gebruikersnaam in SuperOffice Customer Centre |
| makeSalutation(customer.id) | Aanhef |

## <a id="ticket"></a>Variabelen voor aanvragen (alleen SuperOffice Service)

| Variabele | Beschrijving|
|---|---|
| ticket.activate | Wanneer het verzoek geactiveerd moet worden, als dit in de uitgestelde staat is |
| ticket.alertLevel | Waarschuwingsniveau |
| ticket.author | De naam van de persoon die het verzoek aangemaakt heeft |
| ticket.category | Zelfde als ticket.category.id |
| ticket.category.externalName | Categorie, externe naam |
| ticket.category.fullname | Categorie |
| ticket.category.id | Categorie-id (verborgen, unieke id) |
| ticket.category.name | De naam van de categorie voor het ticket |
| ticket.closedAt | Wanneer het verzoek werd gesloten |
| ticket.closedAtRaw | De datum en tijd waarop het verzoek werd gesloten in JJJJ-MM-DD UU |
| ticket.createdAt | De datum en tijd waarop het verzoek werd gemaakt in de standaardindeling van de gebruiker |
| ticket.createdAtRaw | De datum en tijd waarop het verzoek werd gemaakt in JJJJ-MM-DD UU |
| ticket.customer | De id van de klant voor het verzoek |
| ticket.customerName | De persoon, naam van het verzoek |
| ticket.customerUrl | De URL voor toegang tot het klantverzoek |
| ticket.customerUrlEnc | De URL voor toegang tot het klantverzoek, URL-gecodeerd |
| ticket.customerUrlOld | De URL voor toegang tot het klantverzoek, niet gecodeerd. Wordt bijgehouden voor achterwaartse compatibiliteit. |
| ticket.dbiAgentId | De ID van de DBI-agent, indien dit verzoek werd gesynchroniseerd met behulp van DBI |
| ticket.dbiKey | De externe primaire sleutel, indien dit verzoek werd gesynchroniseerd met behulp van DBI |
| ticket.deadline | De deadline van het verzoek |
| ticket.id | Verzoek-id (verborgen, unieke id) |
| ticket.lastChanged | De datum en tijd waarop het verzoek het laatst werd aangepast in de standaardindeling van de gebruiker |
| ticket.lastChangedRaw | De datum en tijd waarop het verzoek het laatst werd aangepast in JJJJ-MM-DD UU |
| ticket.ownerCellphone | Het mobiele telefoonnummer van de eigenaar van het verzoek |
| ticket.ownerFullName | Volledige naam van de eigenaar van het verzoek |
| ticket.ownerUsername | Gebruikersnaam van de eigenaar van het verzoek |
| ticket.priority | Prioriteit |
| ticket.readByCustomer | De datum en tijd waarop het verzoek door de klant werd gelezen in de standaardindeling van de gebruiker |
| ticket.readByCustomerRaw | De datum en tijd waarop het verzoek door de klant werd gelezen in JJJJ-MM-DD UU |
| ticket.readByOwner | De datum en tijd waarop het verzoek door de eigenaar werd gelezen in de standaardindeling van de gebruiker |
| ticket.readByOwnerRaw | De datum en tijd waarop het verzoek door de eigenaar werd gelezen in JJJJ-MM-DD UU |
| ticket.slevel | Het toegangsniveau van het ticket (1 = intern, 2 = extern) |
| ticket.status | De naam van de status (open, gesloten, uitgesteld) |
| ticket.ticketStatus | De naam van de door de gebruiker gedefinieerde status |
| ticket.title | Verzoektitel |
| ticket.url | De URL voor toegang tot het verzoek voor gebruikersagenten |
| ticket.urlWithSession | De URL voor toegang tot het verzoek voor gebruikersagenten met de huidige gebruikerssessie |
| ticket.userUrl | De URL voor toegang tot het verzoek voor gebruikersagenten |

## <a id="company"></a>Variabelen voor geselecteerd bedrijf

| Variabele | Beschrijving|
|---|---|
| company.adr | Adres |
| company.department | Afdeling |
| company.domain | Domein |
| company.fax | Faxnummer |
| company.id | Bedrijfs-id (verborgen, unieke id) |
| company.name | Bedrijfsnaam |
| company.note | Opmerking |
| company.ourContact | Zelfde als company.primaryContact.id |
| company.ourContact.cellphone | Onze contactpersoon, mobiel nummer |
| company.ourContact.email | Onze contactpersoon, e-mailadres |
| company.ourContact.name | Onze contactpersoon, naam |
| company.ourContact.phone | Onze contactpersoon, telefoonnummer |
| company.ourSalesContact | De id (medewerker) van de KAM van het bedrijf |
| company.ourSalesContact.cellphone | Onze verkoopscontactpersoon, mobiel nummer |
| company.ourSalesContact.email | Onze verkooprelatie, e-mailadres |
| company.ourSalesContact.name | Onze verkoopscontactpersoon, naam |
| company.ourSalesContact.phone | Onze verkoopscontactpersoon, telefoonnummer |
| company.phone | Telefoonnummer |
| company.primaryContact.email | Onze hoofdcontactpersoon, e-mailadres |
| company.primaryContact.id | De id (ejuser) van de agent die is aangeduid als primair ondersteuningscontactpersoon voor dit bedrijf |
| ourContact.email | E-mailadressen van onze personen |
| ourContact.name | Onze contactpersoon |

<!-- markdownlint-disable-file MD013 -->
## <a id="user"></a>Variabelen voor antwoordsjablonen (gebruiker) (alleen SuperOffice Service)

Houd er rekening mee dat deze variabelen niet werken voor geautomatiseerde antwoorden verzonden door het systeem, omdat dergelijke antwoorden niet gekoppeld zijn aan een gebruiker.

| Variabele | Beschrijving|
|---|---|
| user.access | De functionele toegang van de afzender als een bitmask |
| user.dictionary | De standaardtaal van het gebruikerswoordenboek |
| user.email | E-mailadres |
| user.firstname | Voornaam |
| user.id | De primaire sleutel van de afzender in de ejuser-tabel |
| user.language | De geselecteerde taal van de afzender |
| user.lastname | Achternaam |
| user.loginname | Aanmeldingsnaam |
| user.middlename | Voorvoegsel |
| user.name | De volledige naam van de gebruikersagent |
| user.signature | Handtekening afzender van Instellingen |
| user.status | De status van de afzender (1 = normaal, 2 = niet beschikbaar, 3 = verwijderd) |
| user.username | Gebruikersnaam van de afzender, niet per se hetzelfde als loginnaam |

## Voorwaardelijke waarden

\[\[IF:condition="1"\]\]

Voorwaarde is een

\[\[ELSEIF:condition="2"\]\]

Voorwaarde is twee

\[\[ELSE\]\]

Voorwaarde is iets anders

\[\[ENDIF\]\]

Kiezen uit waarden:

\[\[DECODE:expr,"value1","return1","value2","return2","default"\]\]

Variabele instellen:

\[\[SET:name="value"\]\]

Variabele verhogen:

\[\[INC:variable\]\]

Variabele verlagen:

\[\[DEC:variable\]\]

Datum opmaken:

\[\[FORMAT-DATE:"date","YY4 MM2 DD2 HH24:MI2:SS2"\]\]

Tijd opmaken:

\[\[SEC-TO-TIME:"seconds","h:m:s"\]\]

<!-- Referenced links -->

<!-- Referenced images -->
