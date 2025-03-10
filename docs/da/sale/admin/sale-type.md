---
uid: help-da-sale-type-add
title: Tilføj en salgstype
description: Sådan tilføjer du en salgstype i SuperOffice CRM og konfigurerer faser, salgsguider og tilbudsindstillinger.
keywords: tilføj salgstype, Salg – Type Faser Tilbud, Salg – Kategori, Tilbudsvedhæftninger, Tilbudsstandarder, Tilbudsgodkendelse, salgstype, salg, tilbud
author: Bergfrid Dias
date: 03.07.2025
version: 10.5.2
topic: howto
license: salesessentials
audience: settings
audience_tooltip: Indstillinger og vedligeholdelse
language: da
---

# Salgstype

[!include[Kræver administratorrettigheder](../../learn/includes/req-admin.md)]

Feltet **Salgstype** i skærmbilledet Salg kategoriserer salg og definerer deres arbejdsgange. Disse typer er foruddefinerede i listen **Salg – Type, Faser, Tilbud**, som du kan administrere i **Indstillinger og vedligeholdelse** under **Lister**.

Hvert salg skal have en salgstype, og disse typer kan knyttes til specifikke [salgsfaser][1] og eventuelt til [salgsguider][4]. Salgsguider hjælper med at standardisere processen ved at guide salgspersonalet gennem foruddefinerede faser, opfølgninger og dokumenter.

## Tilføj en salgstype

1. Vælg <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lister** i Navigator.

1. Vælg **Salg – Type, Faser, Tilbud** fra rullemenuen. Fanen **Forekomster** viser alle eksisterende salgstyper.

1. Klik på **Tilføj** for at åbne dialogboksen **Rediger listeforekomst**.

    ![Dialogboksen Rediger listeforekomst med felter til konfiguration af salgstype -screenshot][img1]

1. Indtast et navn for salgstypen i feltet **Navn**. *(Obligatorisk)*

    Dette navn vil blive vist i feltet **Salgstype** på salgskortet.

1. Vælg den ønskede kategori for salgstypen fra listen **Salgstypekategori**.

    > [!TIP]
    > Du kan oprette nye muligheder i listen **Salg – Kategori (for salgstype)**.

1. Angiv den typiske varighed for denne salgsproces i feltet **Estimeret tid for denne salgsproces** (uger, dage eller måneder).

    Dette bestemmer den foreslåede afslutningsdato, når et salg oprettes.

1. I fanen **Faser** skal du vælge de ønskede faser i listen **Faser anvendt til denne salgstype**.

    > [!NOTE]
    > Hvis du vil knytte salgstypen til en salgsguide, skal du vælge mindst to faser.

1. (Valgfrit) Marker **Denne salgstype er knyttet til en guide**, hvis du vil tilknytte en [salgsguide][4].

1. (Valgfrit) Marker **Foreslå at flytte salget til næste fase automatisk**, hvis du ønsker, at brugere bliver bedt om at skifte fase, når alle aktiviteter for den aktuelle fase er gennemført.

1. (Valgfrit) Marker **Denne salgstype har interessenter** for at tillade tilknytning af [interessenter][5] til salg af denne type. *(Kræver SalesPremium-licens)*

1. Indtast en beskrivelse af salgstypen i feltet **Beskrivelse**, hvis nødvendigt.

1. For tilbudshåndtering kan du konfigurere indstillinger i fanerne **Tilbudsvedhæftninger**, **Tilbudsstandarder** og **Tilbudsgodkendelse** som beskrevet i [Tilbudsfelter forklaret](#quote-fields) nedenfor. *(Kræver SalesPremium-licens)* Disse indstillinger giver mulighed for at tilpasse tilbudsprocessen til virksomhedens behov.

1. Klik på **Gem** for at anvende ændringerne eller **Afbryd** for at kassere dem.

1. I listen **Faser anvendt til denne salgstype** skal du markere de faser, du vil inkludere for salgstypen. Dette trin er valgfrit, men hvis du vil knytte salgstypen til en salgsguide, skal du vælge mindst to faser.

## <a id="quote-fields"></a>Tilbudsfelter forklaret

Et tilbud tilhører et salg, og alle salg har en salgstype. For hver salgstype kan du definere forskellige tilbudsegenskaber, såsom vedhæftninger, standarder for godkendelse, brug af alternative tilbud og skabeloner.

<!-- markdownlint-disable MD051 -->
### [Fanen Tilbudsvedhæftninger](#tab/quote-attachment)

I fanen **Tilbudsvedhæftninger** kan du tilføje dokumenter, der sendes sammen med et tilbud, såsom produktspecifikationer eller brochurer.

> [!NOTE]
> Dokumenterne skal først tilføjes som dokumentskabeloner i SuperOffice.

#### Tilføj tilbudsvedhæftninger

1. Klik på **Tilføj**.
1. I dialogboksen **Find** skal du [søge efter de dokumenter, du vil tilføje][7].
1. Vælg et eller flere dokumenter, og klik på **OK**. Dokumenterne vises nu i fanen **Tilbudsvedhæftninger**.
1. Marker de dokumenter, der skal inkluderes i tilbuddet, i kolonnen **Inkluder**.

Når et tilbud oprettes med denne salgstype, vil de valgte dokumenter blive vedhæftet. De vil dog ikke være synlige i detaljekortet **Aktiviteter** for salget.

### [Fanen Tilbudsstandarder](#tab/quote-defaults)

I fanen **Tilbudsstandarder** kan du konfigurere følgende:

* **Tillad alternativer i tilbud:** Marker denne boks for at tillade flere tilbudsvarianter i ét tilbud.
* **Standard antal dage et tilbud er gyldigt:** Indstil hvor længe et tilbud er gyldigt. Denne værdi kan ændres, når tilbuddet sendes.
* **Tilbudsskabelon:** Vælg den skabelon, der skal bruges til tilbuddet.
* **Ordrebekræftelsesskabelon:** Vælg den skabelon, der skal bruges til ordrebekræftelsen.

### [Fanen Tilbudsgodkendelse](#tab/quote-approval)

I fanen **Tilbudsgodkendelse** kan du angive, om godkendelse kræves for tilbud under visse betingelser:

* **Ingen godkendelse nødvendig:** Ingen begrænsninger. Tilbuddet kræver ikke godkendelse.
* **Samlet rabat overstiger grænse:** Indtast en procentgrænse for rabatter, der kræver godkendelse.
* **Samlede indtjening er under grænse:** Indtast en procentgrænse for indtjening, der kræver godkendelse.

***
<!-- markdownlint-enable MD051 -->

## Rediger eller slet en salgstype

1. Følg trin 1–2 i **Tilføj en salgstype** for at få adgang til listen **Salg – Type, Faser, Tilbud**.

1. For at redigere:
   * Dobbeltklik på den ønskede salgstype for at åbne dialogboksen **Rediger listeforekomst**.
   * Opdater felterne efter behov, og klik på **Gem**.

1. For at slette:
   * Vælg salgstypen på listen, og klik på **Slet**.

    > [!CAUTION]
    > Sletning af en salgstype fjerner også dens tilknytning til faser og salgsguider. Sørg for, at den ikke er i aktiv brug, før du fortsætter.

## <a id="restore"></a>Gendan en slettet salgstype

Hvis en salgstype er blevet slettet, kan du gendanne den fra listen **Salg – Type, Faser, Tilbud**. Bemærk dog, at gendannelse ikke automatisk genopretter eventuelle links til salgsfaser eller salgsguider. Disse forbindelser skal genskabes manuelt.

1. Gå til listen **Salg – Type, Faser, Tilbud**.

1. Marker **Vis slettede elementer og overskrifter** i bunden af skærmen. Slettede elementer vises med gennemstregning i fanen **Forekomster**.

1. Dobbeltklik på det slettede element, du vil gendanne. Dialogboksen **Rediger listeforekomst** åbnes.

1. Klik på **Gendan**.

1. Opdater de nødvendige felter, og klik på **Gem**. Elementet er nu aktivt og vil blive vist i fanen **Forekomster**.

## Relateret indhold

* [Tilføj en salgsfase][1]
* [Opret en salgsguide][2]
* [Rediger en salgsguide][3]
* [Tilbudsskabeloner][6]

<!-- Referenced links -->
[1]: sale-stage.md
[2]: create-sales-guide.md
[3]: edit-sales-guide.md
[4]: ../learn/sales-guides.md
[5]: ../learn/stakeholders/index.md
[6]: ../../document/templates/learn/quote-templates.md
[7]: ../../search-options/learn/search-criteria.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/sale/edit-sale-type.png
