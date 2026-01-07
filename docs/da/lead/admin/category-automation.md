---
uid: help-da-lead-category-automation
title: Automatiser leadkategorisering
description: Konfigurer automatiske kategoriopdateringer, når salg ændrer status, eller leadstatus opdateres for at reducere manuelt arbejde og opretholde datanøjagtighed.
keywords: leadhåndtering, kategoriautomatisering, workflow, leadkategorisering, automatisk kategoriopdatering
author: digitaldiina
date: 01.13.2026
version: 11.8
content_type: howto
category: sale
topic: lead
license: salespremium
audience: settings
audience_tooltip: Indstillinger og vedligeholdelse
index: true
language: da
---

# Automatiser leadkategorisering

[!include[Must be admin](../../learn/includes/req-admin.md)]

Automatisering af firmakategoriopdateringer hjælper med at reducere manuelt arbejde og sikrer, at dine data forbliver nøjagtige. Når status for et salg ændres, eller en leadstatus opdateres, kan det relaterede firma automatisk opdateres med den korrekte kategori.

Du kan konfigurere automatiseringen til at køre fuldt automatisk eller bede brugeren om at bekræfte ændringen, før den anvendes.

## Forudsætninger

* Du skal have administratorrettigheder for at få adgang til **Indstillinger og vedligeholdelse**.
* Firmaets aktuelle kategori skal tilhøre gruppen **Potentiel kunde** for at være berettiget til automatiske opdateringer. Se [Firmakategori og kategorigruppe][1].
* For leadstatusbaseret automatisering skal **Leadstatus** være aktiveret for firmaets aktuelle kategori.

## Konfigurer kategoriautomatiseringsregler

Du kan aktivere en eller flere af følgende automatiseringsregler:

| Automatiseringsregel | Beskrivelse |
|---|---|
| Opdater kategori, når et salg er vundet | Opdaterer automatisk firmakategorien, når et salg er markeret som **Vundet**. |
| Opdater kategori, når et salg er tabt | Opdaterer automatisk firmakategorien, når et salg er markeret som **Tabt**. |
| Opdater kategori, når et salg registreres hos firmaet | Opdaterer automatisk firmakategorien, når et nyt salg oprettes og knyttes til firmaet. |
| Opdater kategori, når en leadstatus er indstillet til | Opdaterer automatisk firmakategorien, når en kontakts leadstatus ændres til en bestemt værdi, såsom *Kvalificeret* eller *Diskvalificeret*. Kræver, at leadstatus er aktiveret for kategorien. |

### Trin

1. Åbn **Indstillinger og vedligeholdelse**.

1. Vælg <i class="ph ph-arrows-left-right" aria-hidden="true"></i> **Workflow** i navigatoren.

1. Vælg fanen **Leadkategorisering**. Denne skærm viser automatiseringsmuligheder.

    ![Admin workflow - Leadkategoriseringsfanen, der viser automatiseringstoggler -screenshot][img1]

1. Aktivér skifteren for den regel, du vil aktivere.

1. Når du aktiverer en skifte, vises yderligere muligheder:

    * **Indstil kategori til:** Vælg målkategorien fra listen. Dette er den kategori, firmaet vil blive opdateret til, når betingelsen er opfyldt.

        Du kan vælge en hvilken som helst kategori, uanset kategorigruppe.

    * **Bed om brugerbekræftelse før opdatering:** Marker dette felt, hvis du vil have, at brugeren bekræfter kategoriændringen, før den anvendes.

        Lad det være umarkeret for fuldt automatiske opdateringer.

1. Gentag for eventuelle andre regler, du vil aktivere.

1. Klik på **Gem** for at anvende dine ændringer, eller klik på **Annuller** for at kassere dem.

> [!NOTE]
> Knappen **Gem** er aktiveret først efter du har valgt en kategori i feltet **Indstil kategori til** for alle aktiverede skiftere.

## Hvornår skal brugerbekræftelse bruges

Beslut, om kategoriopdateringer skal være automatiske eller kræve brugerbekræftelse baseret på dine forretningsbehov:

* **Fuldt automatisk:** Bedst til ligetil lead-til-kunde-workflows, hvor kategoriændringer er forudsigelige og konsistente. For eksempel automatisk flytning af et lead til kategorien *Kunde*, når et salg er markeret som vundet.

* **Brugerbekræftelse:** Anbefales, når kategoriændringer kræver vurdering, eller når flere kategorier kan gælde. For eksempel, hvis du arbejder med flere kundelag (VIP, A, B, C), sikrer prompting af brugeren, at den korrekte kategori vælges.

Når **Bed om brugerbekræftelse før opdatering** er aktiveret, vil brugeren se en dialog, der foreslår kategoriændringen. De kan acceptere forslaget eller vælge en anden kategori før lagring.

## Eksempel: Automatiser lead-til-kunde-overgang

En almindelig use case er at opdatere et lead automatisk til en kundekategori, når et salg er vundet:

1. Aktivér **Opdater kategori, når et salg er vundet**.

1. Indstil **Indstil kategori til** = *Kunde*.

1. Lad **Bed om brugerbekræftelse før opdatering** være umarkeret for fuld automatisering.

1. Klik på **Gem**.

Nu, når et salg knyttet til et firma i gruppen *Potentiel kunde* markeres som vundet, vil firmakategorien automatisk ændre sig til *Kunde*.

## Relateret indhold

* [Firmakategori og kategorigruppe][1]
* [Oversigt over leadhåndtering][3]
* [Administrér leadstatusser][2]
* [Opdater et salg][4]
* [Salgsguider][5]

<!-- Referenced links -->
[1]: add-company-category.md
[2]: add-lead-status.md
[3]: ../learn/index.md
[4]: ../../sale/learn/update.md
[5]: ../../sale/learn/sales-guides.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/lead/lead-categorization.png
