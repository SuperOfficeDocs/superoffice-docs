---
uid: help-da-request-category-create
title: Opret sagskategori
description: Opret sagskategori
keywords: sag, kategori
author: Bergfrid Dias
date: 03.07.2025
version: 10.5.2
topic: concept
license: serviceessentials
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Opret sagskategori

1. I Indstillinger og vedligeholdelse, klik på knappen **Sager** i navigatoren og vælg fanen **Kategorier**.

1. Klik på knappen **Tilføj**.

1. Indtast et beskrivende navn til kategorien i feltet **Kategorinavn** over fanerne.

1. På fanen **Egenskaber** kan du angive følgende oplysninger:

    * **Internt eller eksternt**: Hvis du markerer **Internt**, vil kategorien ikke være synlig i SuperOffice Customer Centre.

    * **Eksternt navn**: Hér skal du angive det kategorinavn, der vises over for kunden. Dette felt er obligatorisk, medmindre kategorien er intern.

    * **Underkategori af**: Hvis dette skal være en underkategori af en anden kategori, skal du vælge den overordnede kategori, du ønsker.

    * **Kategoriansvarlig**: Vælg, hvem der skal have ansvar for sager i denne kategori. På fanen **Fordelingsmetode** kan du angive, at sager skal tildeles den kategoriansvarlige, hvis ingen andre medlemmer af kategorien er tilgængelige. Det er normalt en afdelingschef, der bør have rollen som kategoriansvarlig.

        * **Vis kategori i statusbillede**: Hvis du markerer kategorien, vises den under **Status** på **Dashboardet**.
        * **Kun tilgængelig for medlemmer**: Hvis du markerer kategorien, er den kun tilgængelig for medlemmer af kategorien.
        * **Send underretning til medlemmer om ny sag**: Hvis du markerer alle medlemmer af kategorien, får de besked om nye sager i denne kategori.

    * **Send underretning om ny sag til e-mailadresse**: Indtast en e-mailadresse.

    * **Tag ejerskab ved besvarelse**: Hvis du markerer denne indstilling, vil den bruger, der svarer på en sag i denne kategori, blive angivet som ejer af sagen.

    * **Standardstatus for ny sag**: Hér vælger du, hvilken status der skal være standard i skærmbilledet **Sag**. Denne indstilling tilsidesætter [brugerpræferencer][1], medmindre du vælger **Brugerdefineret**.

    * **Standardstatus for ny meddelelse**: Her vælger du den standardstatus, der skal vises i en ny meddelelse. Denne indstilling tilsidesætter [brugerpræferencer][1], medmindre du vælger **Brugerdefineret**.

    * **Flet udgående e-mails for denne kategori med svarskabelon**: Vælg den svarskabelon, der skal bruges i meddelelser, som sendes ud til kunder og andre personer for sager, der tilhører denne kategori. Dette kan være en svarskabelon specielt oprettet til denne kategori for at give alle svar fra en kategori (f.eks. support eller regnskab) et ensartet udseende.

        * Marker **Gælder for underkategorier**, hvis du ønsker, at den valgte svarskabelon også skal bruges på eventuelle underkategorier. Dette forudsætter imidlertid, at dette ikke tilsidesættes af de indstillinger, der er foretaget i underkategorierne.

1. På fanen **Medlemmer** skal du angive, hvem der skal være medlem af kategorien. Vælg en bruger på listen **Bruger** nederst, og klik på **Tilføj**.

    > [!TIP]
    > Hvis **Vægtet fordeling** er valgt som fordelingsmetode for sagerne i denne kategori, kan du anvende vægtningen for hver enkelt bruger til at bestemme fordelingen af nye sager. Brugerne med den højeste vægtning får tildelt de fleste sager. Du kan ikke bruge vægtet tildeling til medlemmer af kategori fra brugergrupper.

1. På fanen **Fordelingsmetode** kan du angive følgende oplysninger:

    * Vælg en fordelingstype:

        * **Jævn**: Fordeler sagerne ligeligt blandt medlemmerne af kategorien.
        * **Vægtet**: Fordeler sagerne ud fra de vægtede tal, der er angivet for medlemmerne af kategorien.

           Eksempel: Hvis person A har vægt 1, person B har vægt 2, og person C har vægt 5, vil hver af disse kontakter i løbet af otte sager få fordelt lige så mange sager, som deres vægtede tal angiver.

        * **Til sagsbehandleren med færrest aktive sager**: Fordeler nye sager til det kategorimedlem, der har færrest aktive sager.
        * **Fordel ikke**: Fordeler ikke sager til bestemte brugere, men sætter som standard alle sager i kø. Enten under **Sager** > **Ikke-tildelte sager** (standard) eller i køsystemet **Få næste sag i køen**.

    * **Fordel kun til sagsbehandlere, der er logget ind**: Fordeler kun sager til brugere, der er logget ind i SuperOffice Service.

    * **Fordel til kategoriansvarlig, hvis ingen er tilgængelige**: Fordeler sager til den kategoriansvarlige, hvis ingen andre brugere er tilgængelige.

    * **Fordel sag igen ved ny meddelelse om sagsbehandler ikke tilgængelig**: Fordeler sager igen, når der kommer en ny meddelelse i en sag om, at brugeren ikke er tilgængelig.

    * **Tildel til vores serviceperson, hvis vedkommende er tilgængelig**: Hvis gældende firma eller person har en sagsbehandler angivet som **Vores kontakt**, og hvis denne bruger er tilgængelig, tildeles sagen til denne bruger. Hvis **Vores person** ikke er angivet, eller brugeren ikke er tilgængelig, fordeles sagen efter de almindelige fordelingsregler.

    * **Fordelingskarantæne**: Angiv det antal minutter, du ønsker at tilsidesætte fordelingen og tildele alle sager fra samme kunde til én bruger. På denne måde kan du sikre dig, at når kunder sender to sager i træk til den samme e-mailadresse, går sagerne til den samme sagsbehandler. Hvis du angiver -1, deaktiveres denne funktionalitet, og alle sager vil blive fordelt i henhold til de almindelige fordelingsregler.

1. Klik på **Gem**. Kategorien oprettes.

## Relateret indhold

* [Sådan konfigurerer du Hent næste sag i køen][3]

<!-- Referenced links -->
[1]: ../../../admin/preferences/learn/index.md
[3]: ../next-in-queue.md
