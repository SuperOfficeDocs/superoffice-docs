---
uid: help-da-email-filter-create
title: Oprettelse af e-mail-filtre
description: Oprettelse af e-mail-filtre
keywords: e-mail, e-mail-filter, filtrer
author: SuperOffice RnD
date: 07.17.2024
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Oprettelse af e-mail-filter

1. [!include[Go to email](../includes/goto-email.md)]

1. Vælg fanen **E-mail-filtre**.

1. Klik på **Nyt e-mail-filter**. Skærmbilledet **Egenskaber for e-mail-filter** vises.

1. På fanen **Filtrer** kan du angive, hvilke e-mail-meddelelser der skal filtreres, ved at angive følgende oplysninger:

    * **Beskrivelse**: Indtast en kort beskrivelse af e-mail-filteret.
    * **Prioritet**: På listen vælger du filterets prioritet. Værdien 100 er højeste prioritet, og 1 er den laveste.
    * **Script**: Her kan du vælge et [script eller en makro][1], der skal køres af dette filter.

1. Vælg, hvad filteret gælder for:

    * **Al indgående e-mail**: Hvis du vælger denne valgmulighed, anvendes e-mail-filteret på alle indgående e-mail-meddelelser.
    * **E-mail, der indeholder**: Hvis du vælger denne valgmulighed, vil e-mail-meddelelser, der indeholder det faste udtryk (regexp), der er angivet i felterne til højre, aktivere e-mail-filteret. Du kan vælge mellem e-mail-overskriften og / eller e-mail-brødteksten.

1. På fanen **Find faste udtryk** kan du definere faste udtryk, der finder tekst i e-mail-meddelelser og gemmer den som variabler. Hvis du vil tilføje værdien fra et fast udtryk i en variabel, der hedder minVariabel, skal du anvende følgende format: minVariabel = &lt;regexp&gt;.

1. På fanen **Angiv tilknytninger** kan du angive, hvordan indgående e-mail-meddelelser skal kobles til en sag og/eller en person baseret på indholdet i e-mail-meddelelsen:
    * **Knyt til kunde hvor**: Hvis du vil knytte den genererede sag til en person ud fra oplysninger fra e-mail-meddelelsen, skal du vælge et af felterne for person fra listen og derefter tilføje et fast udtryk, der returnerer den værdi, som identificerer personen.
    * **Knyt til sag hvor**: Hér kan du knytte e-mail-meddelelsen til en eksisterende sag ud fra et fast udtryk, der henter oplysninger fra e-mail-meddelelsen.

1. På fanen **Angiv værdier** kan du tilføje eller erstatte værdier for personer, firmaer og sager, baseret på indholdet i e-mail-meddelelsen:
    1. I rullemenuen til venstre skal du vælge det ønskede felt for personen, firmaet eller sagen.

    2. Indtast et af følgende i feltet til højre:
        * det regulære udtryk, der finder den værdi, der skal angives
        * en fast værdi (skal have et præfiks med =)

    3. Hvis du markerer **Overskriv**, erstatter den værdi, der evt. bliver fundet, en eksisterende værdi.

    4. Klik på **Tilføj** for at tilføje værdien.

        > [!TIP]
        > Du kan slette værdier igen ved at markere den ønskede værdi og derefter klikke på <i class="ph ph-x-circle" aria-label="Remove icon"></i>.

1. På fanen **Angiv egenskaber** kan du angive bestemte egenskaber for sager, der registreres fra e-mails, som matcher det aktuelle filter:

1. På fanen **E-mail-svar** kan du oprette forskellige e-mail-meddelelser, som skal sendes, når dette filter aktiveres. Hér kan du angive følgende oplysninger:
    * **Send svarskabelon**: Her kan du vælge, hvilken [svarskabelon][2] der skal sendes, hvis filteret udløses.
    * **... til person**: Hvis du markerer denne valgmulighed, sendes den valgte svarskabelon tilbage til personen.
    * **... til**: Hvis du markerer denne valgmulighed, sendes den valgte svarskabelon til den e-mail-adresse, der er angivet i feltet til højre.
    * **Foreslå FAQ-poster fra**: Hvis du markerer denne valgmulighed, [foreslår systemet FAQ-poster ud fra teksten][3] i indgående e-mail-meddelelser. De foreslåede poster er tilgængelige som skabelonvariabler og kan derfor gentages i den valgte svarskabelon. Du kan også angive, hvilken gren af FAQ-træet der skal søges i, ved at angive den ønskede mappe.
    * **Send ikke automatisk svar**: Hvis du markerer denne valgmulighed, sender systemet ikke automatisk svar tilbage for denne e-mail-meddelelse.

1. På fanen **E-mail-konti** kan du vælge, hvilke e-mail-konti dette filter gælder for.

1. Klik på **OK**. E-mail-filteret oprettes.

<!-- Referenced links -->
[1]: ../../../../automation/crmscript/learn/index.md
[2]: ../../../../request/reply-templates/learn/index.md
[3]: ../../../../request/reply-templates/learn/create.md#faq
