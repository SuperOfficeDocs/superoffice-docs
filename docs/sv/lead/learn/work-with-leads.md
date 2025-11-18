---
uid: help-sv-work-with-leads
title: Arbeta med leads i SuperOffice
description: Lär dig att visa, uppdatera och följa upp leads i SuperOffice CRM.
keywords: lead
author: digitaldiina
date: 11.06.2025
version: 11.6
content_type: howto
category: sale
topic: lead
license: salesessentials
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# Arbeta med leads i SuperOffice

Leads representerar personer som har visat intresse men ännu inte ingår i en aktiv säljprocess. SuperOffice hjälper dig att följa var varje lead befinner sig i kvalificeringsprocessen och att göra rätt uppföljning vid rätt tidpunkt.

Den här sidan visar hur du kan visa, uppdatera och använda leadinformation i ditt dagliga arbete.

## Visa leadinformation på en kontakt

> [!NOTE]
> Fältet **Leadstatus** visas endast när företaget tillhör en kategori i gruppen **Potentiell kund** och **Aktivera leadstatus** är markerat.

1. Öppna en kontakt.

1. Kontrollera fältet **Kategori** för att se om personen tillhör en kategori för potentiella kunder.

1. Om leadstatus är aktiverat för företagskategorin visas fältet **Leadstatus** direkt under fältet **Kategori**.

1. Håll muspekaren över statusvärdet för att visa beskrivningen.

    ![Leadstatus visas på kontaktskärmen, med en tooltip som beskriver vald status. -screenshot][img1]

## Uppdatera leadstatus

1. Klicka på <i class="ph ph-pencil-simple" aria-label="Edit"></i> längst upp till höger på kontaktkortet.

1. Välj rullgardinsmenyn **Leadstatus**.

1. Välj den status som bäst motsvarar kontaktens aktuella steg.

    * **Kontakt tas:** Du försöker nå leadden.
    * **Kvalificerad:** Leadden har rätt profil och intresse.
    * **Diskvalificerad:** Leadden är inte relevant.
    * **Återbearbetning:** Följ upp senare.

1. Klicka **Spara** för att lagra dina ändringar.

## Visa leads på detaljkortet Kontakter

1. Gå till ett företag och öppna detaljkortet [**Kontakter**][7].

1. Välj <i class="ph ph-gear" aria-label="Settings (cogwheel)"></i> för att anpassa kolumner.

1. Lägg till **Kategori**, **Kategorigrupp** och **Leadstatus**.

1. Du kan även [filtrera eller gruppera listan][8] för att fokusera på specifika leadstadier.

    ![Lägga till kolumnerna Kategori och Kategorigrupp på detaljkortet Kontakter. -screenshot][img2]

## Skapa urval

Du kan använda kategorier och leadstatus för att söka fram och segmentera kontakter och företag i SuperOffice CRM.

I **Sök**-skärmen kan du lägga till kriterier som:

* **Kontakt** > **Leadstatus** – Är en av / Är inte en av.
* **Företag** > **Kategorigrupp** – Är en av / Är inte en av.
    Använd detta för att besvara frågor som ”Lista alla mina potentiella kunder” eller ”Lista alla mina kunder”.
* **Företag** > **Lead** eller **Kontakt** > **Lead** baserat på [UTM-data][5] (kräver Marketing Premium).

![Filtrera kontakter efter Leadstatus och Kategorigrupp i Sök-kriterier. -screenshot][img3]

Du kan spara dina sökresultat som ett **urval**, som senare kan användas för riktade marknadsaktiviteter eller rapporter.

![Visa leadinformation i Sökresultat, inklusive Kategori, Leadstatus och källa. -screenshot][img4]

Dynamiska urval av företag eller kontakter kan också öppnas i [Tavlevy][6] för att visualisera progressionen. Varje kolumn representerar en leadstatus.

![Visa leads per status i tavlevy, grupperat i steg som Öppen, Kontakt tas, Diskvalificerad, Återbearbetning och Kvalificerad. -screenshot][img5]

## Tips och felsökning

* **Jag ser inte fältet Leadstatus.**

    Leadstatus visas endast på kontakter och bara när företaget tillhör gruppen **Potentiell kund**.

* **Jag kan inte välja Lead eller Marknadsföringskvalificerat lead som kategori.**

    Dessa kategorier finns endast i nya databaser.

* **Fältet Leadstatus försvann efter att jag ändrade företagskategori.**

    Leadstatus döljs när företaget flyttas till en kategori utanför **Potentiell kund**. Värdet finns kvar i databasen men kan inte redigeras.

* **Olika personer i samma företag visar olika leadstatus.**

    Leadstatus lagras på kontaktnivå.

* **En kontakt får alltid Leadstatus = Öppen när den flyttas till en kategori för potentiella kunder.**

    Detta är förväntat. Nya leads börjar alltid med statusen *Öppen*.

* **Jag kan inte ändra kategorin på en kontakt.**

    Kontakter ärver kategorin från sitt företag. För att ändra den, uppdatera kategorin på företagskortet.

## Relaterat innehåll

* [Översikt över leadhantering][1]
* [Använd dashboards för att följa upp leads][4]
* [Massuppdatera kontaktinformation][9]

<!-- Referenced links -->
[1]: index.md
[4]: ../../dashboard/learn/show-leads.md
[5]: ../../marketing/utm/learn/index.md
[6]: ../../search-options/selection/learn/board-view.md
[7]: ../../learn/section-tabs/contacts-tab.md
[8]: ../../learn/section-tabs/filter.md
[9]: ../../learn/basics/bulk-update.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/lead/contact-card-open-lead.png
[img2]: ../../../media/loc/en/lead/contact-section-tab-with-lead-info.png
[img3]: ../../../media/loc/en/lead/find-leads.png
[img4]: ../../../media/loc/en/lead/save-leads-as-selection.png
[img5]: ../../../media/loc/en/lead/filtered-lead-board.png
