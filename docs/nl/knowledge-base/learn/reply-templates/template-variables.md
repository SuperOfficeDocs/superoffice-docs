---
uid: help-nl-template-variables-service
title: Sjabloonvariabelen
description: Sjabloonvariabelen
keywords: sjabloonvariabelen
author: SuperOffice Product and Engineering
date: 06.29.2022
version: 10.5
content_type: reference
category: service
topic: knowledge base
audience: person
audience_tooltip: SuperOffice Service
language: nl
redirect_from: /nl/request/reply-templates/learn/template-variables
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
| Koppeling om bericht online weer te geven | URL om het mailingbericht online weer te geven in een browser, bijvoorbeeld "Klik hier als het bericht er vreemd uitziet" |
| link.subscription | Koppeling om uw abonnement te beëindigen |
| link.viewShipmentMessage | Koppeling om het mailingbericht online weer te geven |

## <a id="config"></a>Onderhoud

| Variabele | Beschrijving|
|---|---|
| config.adminMail | E-mailadres van de systeemadministrator voor deze installatie |
| config.cgiBin | URL-achtervoegsel voor de uitvoerbare bestanden |
| config.cgiUrl | Externe basis-URL voor de installatie |
| config.cgiUrlInternal | Interne basis-URL voor de installatie |
| config.companyAddress | Adres van de eigenaar van het bedrijf |
| config.companyName | Naam van het bedrijf dat eigenaar is |
| config.defaultMail | Standaard afzenderadres voor deze installatie |
| config.gfxUrl | URL-achtervoegsel voor GFX-bestanden |
| config.mailTag | De zin "Voeg het verzoek-ID toe ..." die wordt gebruikt als de eerste regel in uitgaande e-mails |
| config.panicMail | E-mailadres dat foutmeldingen zouden moeten krijgen |
| config.smtpHost | Hostnaam voor uitgaande SMTP |
| config.smtpPort | Poort voor uitgaande SMTP |
| config.tag | Voorvoegsel voor het verzoek-ID in het onderwerp van e-mails. Voor bijvoorbeeld "ejTag:" |
| config.uniqueId | Unieke ID voor deze installatie |
| config.warning | Pad naar de waarschuwingslogbestanden |
| config.wwwPath | Systeempad voor WWW-bestanden |

## <a id="customer"></a>Variabelen voor een geselecteerde contactpersoon

| Variabele | Beschrijving|
|---|---|
| customer.bestName | Beste beschikbare naam voor deze klant |
| customer.cellphone | Mobiel telefoonnummer |
| customer.deleted | 1 als deze klant is verwijderd |
| customer.email | E-mailadres |
| customer.firstname | Voornaam |
| customer.id | Contactpersoon-ID (verborgen, unieke ID) |
| customer.language | Gekozen taal voor contactpersoon |
| customer.lastname | Achternaam |
| customer.middlename | Tussenvoegsel |
| customer.mrmrs | Mr/Ms-veld |
| customer.name | Volledige naam |
| customer.note | Notitie |
| customer.ourContact | ID (ejuser) van de agent gemarkeerd als de primaire ondersteuningscontact voor deze klant |
| customer.password | Wachtwoord in SuperOffice Customer Centre |
| customer.phone | Telefoonnummer |
| customer.salutation | Begroeting – volledige naam indien beschikbaar, of e-mailadres als naam onbekend is |
| customer.title | Titel |
| customer.username | Gebruikersnaam in SuperOffice Customer Centre |
| makeSalutation(customer.id) | Begroeting |

## <a id="ticket"></a>Variabelen voor verzoeken (alleen SuperOffice Service)

| Variabele | Beschrijving|
|---|---|
| ticket.activate | Wanneer het verzoek geactiveerd moet worden als het uitgesteld is |
| ticket.alertLevel | Waarschuwingsniveau |
| ticket.author | Naam van de persoon die het verzoek maakt |
| ticket.category | Hetzelfde als ticket.category.id |
| ticket.category.externalName | Categorie, externe naam |
| ticket.category.fullname | Categorie |
| ticket.category.id | Categorie-ID (verborgen, unieke ID) |
| ticket.category.name | Naam van de categorie voor het verzoek |
| ticket.closedAt | Wanneer het verzoek gesloten werd |
| ticket.closedAtRaw | Datum en tijd wanneer het verzoek gesloten werd in JJJJ-MM-DD UU |
| ticket.createdAt | Datum en tijd wanneer het verzoek werd gemaakt in gebruiker standaard formaat |
| ticket.createdAtRaw | Datum en tijd wanneer het verzoek werd gemaakt in JJJJ-MM-DD UU |
| ticket.customer | Klant-ID voor het verzoek |
| ticket.customerName | Contactpersoon van het verzoek, naam |
| ticket.customerUrl | URL om het verzoek voor de klant te benaderen |
| ticket.customerUrlEnc | URL om het verzoek voor de klant te benaderen, URL-gecodeerd |
| ticket.customerUrlOld | URL om het verzoek voor de klant te benaderen, niet-gecodeerd. Behouden voor achterwaartse compatibiliteit. |
| ticket.dbiAgentId | DBI-agent-ID indien dit verzoek is gesynchroniseerd met DBI |
| ticket.dbiKey | Externe primaire sleutel indien dit verzoek is gesynchroniseerd met DBI |
| ticket.deadline | Deadline voor het verzoek |
| ticket.id | Verzoek-ID (verborgen, unieke ID) |
| ticket.lastChanged | Datum en tijd wanneer het verzoek voor het laatst is gewijzigd in gebruiker standaard formaat |
| ticket.lastChangedRaw | Datum en tijd wanneer het verzoek voor het laatst is gewijzigd in JJJJ-MM-DD UU |
| ticket.ownerCellphone | Eigenaar van het verzoek, mobiel telefoonnummer |
| ticket.ownerFullName | Eigenaar van het verzoek, volledige naam |
| ticket.ownerUsername | Eigenaar van het verzoek, gebruikersnaam |
| ticket.priority | Prioriteit |
| ticket.readByCustomer | Datum en tijd wanneer het verzoek gelezen werd door de klant in gebruiker standaard formaat |
| ticket.readByCustomerRaw | Datum en tijd wanneer het verzoek gelezen werd door de klant in JJJJ-MM-DD UU |
| ticket.readByOwner | Datum en tijd wanneer het verzoek gelezen werd door de eigenaar in gebruiker standaard formaat |
| ticket.readByOwnerRaw | Datum en tijd wanneer het verzoek gelezen werd door de eigenaar in JJJJ-MM-DD UU |
| ticket.slevel | Toegangsniveau van het verzoek (1 = Intern, 2 = Extern) |
| ticket.status | Naam van de status (Actief, Gesloten, Uitgesteld) |
| ticket.ticketStatus | Naam van de gebruiker gedefinieerde status |
| ticket.title | Titel van het verzoek |
| ticket.url | URL om het verzoek voor gebruiker agenten te benaderen |
| ticket.urlWithSession | URL om het verzoek voor gebruiker agenten te benaderen incl. huidige gebruikerssessie |
| ticket.userUrl | URL om het verzoek voor gebruiker agenten te benaderen |

## <a id="company"></a>Variabelen voor geselecteerd bedrijf

| Variabele | Beschrijving|
|---|---|
| company.adr | Adres |
| company.department | Afdeling |
| company.domain | Domein |
| company.fax | Faxnummer |
| company.id | Bedrijfs-ID (verborgen, unieke ID) |
| company.name | Bedrijfsnaam |
| company.note | Notitie |
| company.ourContact | Hetzelfde als company.primaryContact.id |
| company.ourContact.cellphone | Ons contact, mobiel telefoonnummer |
| company.ourContact.email | Ons contact, e-mailadres |
| company.ourContact.name | Ons contact, naam |
| company.ourContact.phone | Ons contact, telefoonnummer |
| company.ourSalesContact | ID (associate) van de KAM voor het bedrijf |
| company.ourSalesContact.cellphone | Ons verkoopcontact, mobiel telefoonnummer |
| company.ourSalesContact.email | Ons verkoopcontact, e-mailadres |
| company.ourSalesContact.name | Ons verkoopcontact, naam |
| company.ourSalesContact.phone | Ons verkoopcontact, telefoonnummer |
| company.phone | Telefoonnummer |
| company.primaryContact.email | Primair contact, e-mailadres |
| company.primaryContact.id | ID (ejuser) van de agent gemarkeerd als de primaire ondersteuningscontact voor dit bedrijf |
| ourContact.email | Ons contact e-mailadres |
| ourContact.name | Ons contact |

## <a id="user"></a>Variabelen voor antwoordsjablonen (gebruiker) (alleen SuperOffice Service)

Let op: Deze variabelen werken niet voor geautomatiseerde antwoorden van het systeem, omdat zulke antwoorden niet zijn gekoppeld aan een gebruiker.

| Variabele | Beschrijving|
|---|---|
| user.access | Functionele toegang van de afzender als een bitmasker |
| user.dictionary | Standaard woordenboek taal van de gebruiker |
| user.email | E-mailadres |
| user.firstname | Voornaam |
| user.id | Primaire sleutel voor de afzender in de ejuser tabel |
| user.language | Gekozen taal van de afzender |
| user.lastname | Achternaam |
| user.loginname | Inlognaam |
| user.middlename | Tussenvoegsel |
| user.name | Volledige naam van de gebruiker-agent |
| user.signature | Handtekening van de afzender uit Voorkeuren |
| user.status | Status van de afzender (1 = normaal, 2 = niet beschikbaar, 3 = verwijderd) |
| user.username | Gebruikersnaam van de afzender, niet noodzakelijk hetzelfde als de inlognaam |

## Voorwaardelijke waarden

\[\[IF:condition="1"\]\]

Voorwaarde is een

\[\[ELSEIF:condition="2"\]\]

Voorwaarde is twee

\[\[ELSE\]\]

Voorwaarde is iets anders

\[\[ENDIF\]\]

Kies uit waarden:

\[\[DECODE:expr,"value1","return1","value2","return2","default"\]\]

Variabele instellen:

\[\[SET:name="value"\]\]

Variabele verhogen:

\[\[INC:variable\]\]

Variabele verlagen:

\[\[DEC:variable\]\]

Datum formatteren:

\[\[FORMAT-DATE:"date","YY4 MM2 DD2 HH24:MI2:SS2"\]\]

Tijd formatteren:

\[\[SEC-TO-TIME:"seconds","h:m:s"\]\]
