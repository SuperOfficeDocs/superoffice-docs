---
uid: help-nl-document-lock
title: Documenten aan/afmelden
description: Documenten aan/afmelden
keywords: document
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
content_type: howto
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: nl
---

# Documenten aan/afmelden

In SuperOffice CRM worden door veel verschillende mensen en op verschillende momenten documenten gemaakt, bewerkt en gelezen. Als meerdere gebruikers tegelijkertijd hetzelfde document bewerken, lopen ze het risico dat ze elkaars gegevens overschrijven. Ter voorkoming hiervan vergrendelt SuperOffice CRM een document wanneer het wordt bewerkt door een andere gebruiker. Andere gebruikers kunnen het document dan alleen in leesmodus openen. (Als uw organisatie een documentbibliotheek zoals SharePoint gebruikt, kunnen meerdere mensen tegelijkertijd een document bewerken.)

## Bewerkingsmodus en leesmodus

* Bewerkingsmodus: Het document is geopend voor bewerking. Het document kan niet worden bewerkt door andere gebruikers tot u het document hebt opgeslagen en gesloten, waardoor het document automatisch wordt aangemeld.

    Als u niet wilt dat een document automatisch wordt aangemeld wanneer u het opslaat en sluit, kunt u de optie **Aanmelding voorstellen na voltooiing bewerking** activeren in **Voorkeuren** in SuperOffice Web Tools.

* Leesmodus: Het document is geopend voor lezen. Als u wijzigingen aanbrengt, worden deze niet opgeslagen. Als u [de wijzigingen in uw document wilt opslaan][1], moet u een nieuw document maken in SuperOffice CRM en het bestand met uw wijzigingen uploaden.

Een document wordt standaard in de bewerkingsmodus geopend. Als u liever de leesmodus of bewerkingsmodus selecteert wanneer u een document opent, gaat u naar <i class="ph ph-user-circle" aria-hidden="true"></i> **Persoonlijke instellingen** > **Voorkeuren** > **Functies** en stelt u **Vragen om te bewerken of te lezen** in op **Ja**.

## Hoe weet ik wanneer een document is afgemeld?

In het dialoogvenster **Document** toont een afgemeld document een banner die aangeeft wie het bewerkt.

<i class="ph ph-warning-circle" aria-label="Warning icon"></i> **Jij** bewerkt dit document.

<i class="ph ph-warning-circle" aria-label="Warning icon"></i> Je kunt dit document niet bewerken omdat het is vergrendeld door **NN**.

## Een document afmelden voor bewerking

Open een document en selecteer de optie om [het document te bewerken][1]. Het document is afgemeld voor bewerking door uzelf. Andere gebruikers kunnen het document alleen in leesmodus openen.

## Een document aanmelden na bewerking

In de meeste gevallen kunt u [het document opslaan en sluiten][1] binnen de toepassing en wordt het document automatisch aangemeld.

## Een afmelding annuleren (opgeslagen versie gebruiken)

U hebt speciale bevoegdheden nodig om toegang te krijgen tot deze optie. U hebt ook schrijftoegang nodig voor het document.

> [!CAUTION]
> Als een andere gebruiker een document heeft afgemeld, moet u altijd contact opnemen met die gebruiker voordat u deze procedure uitvoert. Anders loopt u het risico dat u de wijzigingen van een ander overschrijft of dat de andere gebruiker uw wijzigingen overschrijft wanneer het document weer wordt aangemeld
>
> De beste optie zou kunnen zijn dat u een kopie maakt van het document en de kopie bewerkt.

Als u of iemand anders een document heeft uitgecheckt en u het document wilt bewerken, kunt u het afmelden annuleren:

1. Klik met de rechtermuisknop op het document en selecteer **Document**.
2. Klik in het dialoogvenster Document op <i class="ph ph-dots-three-circle-vertical" aria-label="Opgave-knappen"></i> en selecteer **Opgeslagen versie gebruiken**.

<!-- Referenced links -->
[1]: edit.md
