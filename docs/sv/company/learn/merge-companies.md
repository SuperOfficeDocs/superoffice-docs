---
uid: help-sv-company-merge
title: Slå ihop företag
description: För att hålla kunddatabasen organiserad och effektiv kan du slå ihop dubbletter av företag eller kombinera poster när ett företag förvärvar ett annat.
keywords: slå ihop företag, underhåll företag, slå ihop identiska kontakter, företag, dubbletter
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# Slå ihop företag

[!include[Requirement](../../learn/includes/note-req-manage-entities.md)]

För att hålla kunddatabasen organiserad och effektiv kan du slå ihop dubbletter av företag eller kombinera poster när ett företag förvärvar ett annat. Kontakter, aktiviteter, fakturor, registrerade domäner och andra detaljer flyttas eller slås ihop, och källföretaget tas bort.

## Steg

1. Klicka på knappen **Uppgift** (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) i det övre högra hörnet av företagskortet.
    Välj **Underhåll företag** > **Slå ihop företag** från menyn.
    Dialogrutan **Slå ihop företag** öppnas, med källföretaget angivet under **Från**.

2. I avsnittet **Till företag**, sök efter och välj det företag som ska uppdateras med information från källföretaget.
   Om du vill byta plats på **Från**- och **Till**-företag klickar du på pilknappen <i class="ph ph-arrows-left-right" aria-hidden="true"></i>.

    > [!CAUTION]
    > Kontrollera att du väljer rätt företag i både **Från**- och **Till**-fälten innan du fortsätter.

3. Under **Detaljinformation om företag och kontakter**, välj ett eller båda av följande alternativ:

    * **Slå ihop identiska kontakter:** Kontakter med *exakt* samma förnamn, mellannamn och efternamn slås ihop.
    * **Ersätt tomma fält med värden från källföretaget:** Tomma fält i målföretaget uppdateras med data från källföretaget.

4. Klicka på **Slå ihop**. Följande sker:

    * Kontakter (och relaterade ärenden) flyttas eller slås ihop.
    * Aktiviteter flyttas.
    * Projektmedlemskap och medlemskap i statiska urval följer målföretaget.
    * Tomma fält uppdateras om du har valt **Ersätt tomma fält...**.
    * Källföretaget tas bort.

![Dialogrutan Slå ihop företag med fält för att välja käll- och målföretag, alternativ för att slå ihop identiska kontakter, ersätta tomma fält och en sammanfattning av åtgärder som utförs. -screenshot][img4]

> [!TIP]
> Du kan också slå ihop företag i dynamiska och statiska urval.

## Relaterat innehåll

* [Slå ihop kontakter][2]

<!-- Referenced links -->
[2]: ../../contact/learn/merge-contacts.md

<!-- Referenced images -->
[img4]: ../../../media/loc/en/company/merge-companies.png
