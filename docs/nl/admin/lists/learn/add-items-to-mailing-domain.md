---
uid: help-nl-add-items-to-mailing-domain
title: Items toevoegen aan mailingdomein
description: Items toevoegen aan mailingdomeinlijst
author: Hanne Gunnarsson
date: 03.14.2023
keywords: mailing, domein, SPF
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: nl
---

# Items toevoegen aan mailingdomeinlijst

Wanneer de algemene voorkeur **Alleen goedgekeurde domeinen voor het verzenden van e-mail gebruiken** is ingesteld op **Ja**, kunnen gebruikers alleen e-mails verzenden vanuit domeinen die aan deze lijst zijn toegevoegd in SuperOffice CRM.  Het is daarom belangrijk om goedgekeurde domeinen met een geldige [SPF-record (Sender Policy Framework)][1] aan deze lijst toe te voegen.

> [!NOTE]
> De algemene voorkeur **Alleen goedgekeurde e-mailverzendingsdomeinen gebruiken** in de groep **Marketing** moet zijn ingesteld op **Ja** om de lijst Mailing-domein te kunnen gebruiken.

## Stappen

1. Klik in **Instellingen en onderhoud** op **Lijsten** en selecteer **Mailing-domeinen**.

1. Klik op **Toevoegen** om een nieuw goedgekeurd domein toe te voegen.

1. Voeg de domeinnaam toe en klik op **Opslaan**. Het systeem voert een SPF-zoekopdracht uit om te controleren of het domein een geldige SPF-record heeft. Als dit niet het geval is, verschijnt er een waarschuwing dat een geldige SPF-record vereist is voor mailingdomeinen. Klik op **OK** en probeer een ander domein.

1. Als het domein de SPF-zoekopdracht doorstaat, wordt het toegevoegd aan de lijst met goedgekeurde domeinen en kunnen gebruikers mailings verzenden vanuit dit domein.

> [!NOTE]
> U kunt een SPF-record instellen voor uw domein om ervoor te zorgen dat uw organisatie mailings kan verzenden met een betere afleverbaarheid (ALLEEN ONLINE). Als uw omgeving LOKAAL is, wordt er geen SPF-zoekopdracht uitgevoerd. Maar u kunt de lijst nog steeds gebruiken om uw gebruikers vooraf ingestelde domeinen te bieden voor **Van** en **Antwoorden aan**-adressen.

<!-- Referenced links -->
[1]: ../../../../en/email/mailgun/spf/index.md

<!-- Referenced images -->
