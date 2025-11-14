---
uid: help-sv-add-lead-status
title: Hantera leadstatusar
description: Lägg till, redigera eller ta bort leadstatusar för att spåra framstegen i leadkvalificeringsprocessen.
keywords: leadstatus, leadkvalificering, diskvalificerad, kvalificerad, potentiell kund, lista
author: digitaldiina
date: 12.11.2025
version: 11.6
content_type: howto
category: sale
topic: lead
license: salesessentials
audience: settings
audience_tooltip: Inställningar och underhåll
index: true
language: sv
---

# Hantera leadstatusar

[!include[Må vara administratör](../../learn/includes/req-admin.md)]

Listan **Kontakt – Leadstatus** definierar de kvalificeringssteg som finns tillgängliga för sälj- och marknadsföringsteam när de arbetar med leads. Varje status representerar ett specifikt steg i leadprocessen och visas i fältet **Leadstatus** på kontaktkortet när företagets kategori tillhör gruppen *Potentiell kund* med **Aktivera leadstatus** markerad.

Gruppering och filtrering efter användargrupp är inte tillgängligt för denna lista.

## Lägg till en leadstatus

1. Välj <i class="ph ph-list-bullets" aria-hidden="true"></i> **Listor** i Navigatorn.

1. Från rullgardinsmenyn väljer du **Kontakt – Leadstatus**. Fliken **Poster** visar alla befintliga statusar.

1. Klicka **Lägg till** för att öppna dialogrutan **Redigera listpost**.

1. I fältet **Namn** anger du namnet på den nya statusen. *(Obligatoriskt)*

1. *(Valfritt)* Ange en kort beskrivning för att förtydliga hur statusen ska användas.

    Beskrivningen visas som ett verktygstips när användaren för muspekaren över ett statusnamn.

1. Klicka **OK** för att spara eller **Avbryt** för att avbryta.

![Dialogrutan Redigera listelement i listan Kontakt – Leadstatus -screenshot][img1]

## Redigera eller ta bort leadstatusar

> [!NOTE]
> Granska statusens användning noggrant innan du gör ändringar.
> Att ta bort eller ändra statusar som används kan leda till inkonsekventa data.
> Statusen **Öppen** är standard för nya leads och bör inte tas bort.

1. Öppna listan **Kontakt – Leadstatus**.

1. För att redigera:

    1. Dubbelklicka en status för att öppna den.
    1. Uppdatera fälten **Namn** eller **Beskrivning**.
    1. Klicka **OK** för att spara.

1. För att ta bort:

    1. Välj statusen i listan.
    1. Klicka **Ta bort**.

## Återställ borttagna leadstatusar

1. Öppna listan **Kontakt – Leadstatus**.

1. Välj **Visa borttagna poster och rubriker**.

1. Leta upp den borttagna statusen, dubbelklicka den och klicka **Återställ**.

1. Klicka **OK**.

## Relaterat innehåll

* [Aktivera leadstatus för företagskategorier][1]
* [Företagskategori och kategorigrupp][2]
* [Översikt över leadhantering][3]

<!-- Referenced links -->
[1]: index.md
[2]: add-company-category.md
[3]: ../learn/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/lead/add-lead-status.png
