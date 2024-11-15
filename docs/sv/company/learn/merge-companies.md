---
uid: help-sv-company-merge
title: Slå ihop företag
description: För att du ska kunna vara effektiv när du arbetar med kunder och kontakter är det viktigt att du har en välorganiserad och 'skräpfri' miljö. Det innebär att företag och kontakter som inte används tas bort och att dubbletter av företag och kontakter slås ihop.
keywords: företag
author: SuperOffice
date: 08.27.2024
version: 10.3.8
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# Slå ihop företag

[!include[Requirement](../../learn/includes/note-req-manage-entities.md)]

Du kan slå ihop dubbletter av företag i databasen. Kontakter och aktiviteter flyttas till målföretaget och källföretaget tas bort.

Om två företag i din kunddatabas har beslutat sig för att gå samman, eller om ett av företagen har köpt det andra företaget, kan du slå ihop företagen till ett företag. Kontakter (och relaterade ärenden), fakturor och registrerade domäner behålls för båda företagen.

## Steg

[!include[Go to company](../../learn/includes/goto-company.md)]

1. Välj **Underhåll företag** under ![ikon][img3] knappen **Uppgift** och klicka på **Slå ihop företag**.
    Dialogrutan **Slå ihop företag** öppnas. Källföretaget finns under **Från**.

1. Under **Till företag** väljer du det företag som ska uppdateras med information från källföretaget. Börja skriva i fältet för att söka efter ett företag. Om du vill byta plats på **Från**- och **Till**-företag klickar du på pilknappen

    > [!CAUTION]
    > Kontrollera att du väljer rätt företag i Från-fältet OCH Till-fältet i dialogrutan Slå ihop företag.

1. Under **Detaljinformation om företag och kontakter** kan du markera följande:

    * Slå ihop identiska kontakter. Om du väljer det här alternativet slås kontakter med identiska namn ihop.

        Namnen måste vara HELT identiska (förnamn, mellannamn och efternamn) för att programmet ska slå ihop dem.

    * **Ersätt tomma fält för \[target company\] med värden från \[source company\]**. Om du väljer det här alternativet uppdateras tomma datafält för **Till**-företaget med data från **Från**-företaget.

1. Klicka på **Slå ihop**. Följande sker:

    * Företagen slås ihop.
    * Kontakter flyttas eller slås ihop.
    * Alla aktiviteter flyttas.
    * Projektmedlemskap och medlemskap i statiska urval följer företaget.
    * Alla detaljer slås ihop om du har valt **Ersätt tomma fält på &lt;target company&gt; med värden från &lt;source company&gt;**.
    * Källföretaget tas bort.

![Dialogrutan Slå ihop företag -screenshot][img4]

> [!TIP]
> Du kan också slå ihop företag i dynamiska och statiska urval.

## Relaterade ämnen

* [Slå ihop kontakter][2]

<!-- Referenced links -->
[2]: ../../contact/learn/merge-contacts.md

<!-- Referenced images -->
[img3]: ../../../media/icons/btn-menu.png
[img4]: ../../../media/loc/en/company/merge-companies.png
