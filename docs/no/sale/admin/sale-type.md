---
uid: help-no-sale-type-add
title: Legge til salgstype
description: Legge til salgstype
keywords: legge til salgstype, Salg - Type Faser Tilbud, Salg - Kategori, tilbudsvedlegg, standardverdi for tilbud, Tilbudsgodkjenning, fanen Faser, Faser-fanen, salgstype, salg, tilbud
author: Bergfrid Dias
date: 02.03.2025
version: 10.5.2
topic: howto
license: salesessentials
audience: settings
audience_tooltip: Innstillinger og vedlikehold
language: no
---

# Salgstype

[!include[Må være administrator](../../learn/includes/req-admin.md)]

Feltet **Salgstype** i Salg-bildet kategoriserer salg og definerer arbeidsflyten. Disse typene er forhåndsdefinert i listen **Salg – Type, Faser, Tilbud**, som du kan administrere under **Lister** i **Innstillinger og vedlikehold**.

Alle salg må ha en salgstype, og disse typene kan knyttes til spesifikke [salgsfaser][1] og eventuelt til [salgsguider][4]. Salgsguider forenkler prosessen ved å lede selgerne gjennom forhåndsdefinerte faser, oppfølginger og dokumenter.

## Legge til en salgstype

1. Velg <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lister** i navigatoren.

1. Velg **Salg – Type, Faser, Tilbud** fra rullegardinmenyen. Fanen **Elementer** viser alle eksisterende salgstyper.

1. Klikk på **Legg til** for å åpne dialogboksen **Rediger listeelement**.

    ![Dialogboksen Rediger listeelement som viser felt for salgstypekonfigurasjon -screenshot][img1]

1. Skriv inn et navn for salgstypen i feltet **Navn**. *(Obligatorisk)*

    Dette navnet vil vises i feltet **Salgstype** i Salg-bildet.

1. Velg ønsket kategori for salgstypen fra listen **Kategori for salgstype**.

    > [!TIP]
    > Du kan opprette nye alternativer i listen **Salg – Kategori (for salgstype)**.

1. Angi estimert varighet for denne salgsprosessen i feltet **Anslått tid for denne salgstypen** (antall uker, dager eller måneder).

    Dette fastsetter standard sluttdato når du oppretter et salg.

1. Gå til fanen **Faser**, og velg fasene som skal brukes i salgstypen i listen **Aktive faser for denne salgstypen**.

    > [!NOTE]
    > For å koble salgstypen til en salgsguide må du velge minst to faser.

1. *(Valgfritt)* Merk av for **Denne salgstypen er tilknyttet en guide** for å koble salgstypen til en [salgsguide][4].

1. *(Valgfritt)* Merk av for **Foreslå automatisk flytting av salget til neste fase** for å be brukere om å gå til neste fase når alle aktiviteter for gjeldende fase er utført.

1. *(Valgfritt)* Merk av for **Denne salgstypen har interessenter** for å tillate knytning av [interessenter][5] til salg med denne typen. *(Krever SalesPremium-lisens)*

1. Legg til en beskrivelse av salgstypen i feltet **Beskrivelse**, om ønskelig.

1. For tilbudshåndtering konfigurerer du feltene i fanene **Vedlegg**, **Standardverdier** og **Godkjenning**, som beskrevet i [Forklaring av tilbudsfelt](#quote-fields) nedenfor. *(Krever SalesPremium-lisens)*. Disse innstillingene lar deg tilpasse tilbud slik at de samsvarer med organisasjonens behov og prosesser.

1. Klikk på **Lagre** for å lagre endringene eller **Avbryt** for å forkaste dem.

## <a id="quote-fields"></a>Forklaring av tilbudsfelt

Et tilbud tilhører et salg, og alle salg har en salgstype. I hver salgstype kan du definere flere egenskaper for tilbud, slik som vedlegg, godkjenningsregler, bruk av alternativer og maler.

<!-- markdownlint-disable MD051 -->
### [Fanen  Vedlegg](#tab/quote-attachment)

I fanen **Vedlegg** kan du legge til dokumenter som skal sendes til kunden sammen med et tilbud, for eksempel produktspesifikasjoner eller brosjyrer.

> [!NOTE]
> Dokumentene må først legges til som dokumentmaler i SuperOffice.

#### Legge til tilbudsvedlegg

1. Klikk på **Legg til**.
1. I **Finn**-dialogen, [søk etter dokumentene du vil legge til][7].
1. Velg ett eller flere dokumenter og klikk på **OK**. Dokumentene vises i **Vedlegg**-fanen.
1. Merk av for dokumentene du vil inkludere i kolonnen **Inkluder**.

Når du oppretter et tilbud med denne salgstypen, legges de valgte dokumentene automatisk ved tilbudet. De vil imidlertid ikke vises i detaljkortet **Aktiviteter** for salget.

### [Fanen Standardverdier](#tab/quote-defaults)

I fanen **Standardverdier** kan du konfigurere følgende:

* **Tillat bruk av alternativer i tilbud:** Merk av for å tillate flere alternativer i et enkelt tilbud.
* **Antall dager et tilbud er gyldig:** Angi hvor lenge et tilbud skal være gyldig. Denne verdien kan endres ved sending.
* **Mal for tilbudsformat:** Velg hvilken mal som skal brukes for tilbudet.
* **Mal for ordrebekreftelse:** Velg hvilken mal som skal brukes for ordrebekreftelser.

### [Fanen Godkjenning](#tab/quote-approval)

I fanen **Godkjenning** kan du angi om tilbud må godkjennes under visse betingelser:

* **Ingen godkjenning kreves:** Ingen begrensninger. Tilbudet trenger ikke godkjenning.
* **Totalrabatt er over grensen:** Angi en prosentgrense for rabatt som krever godkjenning.
* **Total fortjeneste er under grensen:** Angi en prosentgrense for fortjeneste som krever godkjenning.

***
<!-- markdownlint-enable MD051 -->

## Redigere eller slette en salgstype

1. Følg trinn 1–2 i **Legge til en salgstype** for å åpne listen **Salg – Type, Faser, Tilbud**.

1. For å redigere:
   * Dobbeltklikk på ønsket salgstype for å åpne dialogboksen **Rediger listeelement**.
   * Oppdater feltene etter behov, og klikk **Lagre**.

1. For å slette:
   * Velg salgstypen i listen og klikk **Slett**.

    > [!CAUTION]
    > Hvis du sletter en salgstype, fjernes også koblingene til faser og salgsguider. Sørg for at den ikke er i aktiv bruk før du fortsetter.

## <a id="restore"></a>Gjenopprette en slettet salgstype

Hvis en salgstype har blitt slettet, kan du gjenopprette den fra listen **Salg – Type, Faser, Tilbud**. Merk at gjenoppretting ikke automatisk gjenoppretter koblinger til relaterte salgsfaser eller guider. Disse må settes opp manuelt om nødvendig.

1. Gå til listen **Salg – Type, Faser, Tilbud**.

1. Merk av for **Vis slettede elementer og overskrifter** nederst. Slettede elementer vises gjennomstreket i fanen **Elementer**.

1. Dobbeltklikk på det slettede elementet du vil gjenopprette. Dialogboksen **Rediger listeelement** åpnes.

1. Klikk på **Gjenopprett**.

1. Oppdater eventuelle nødvendige felt, og klikk **Lagre**. Elementet er nå aktivt og vil vises i fanen **Elementer**.

## Relatert innhold

* [Legge til en salgsfase][1]
* [Opprette en salgsguide][2]
* [Redigere en salgsguide][3]
* [Tilbudsmaler][6]

<!-- Refererte lenker -->
[1]: sale-stage.md
[2]: create-sales-guide.md
[3]: edit-sales-guide.md
[4]: ../learn/sales-guides.md
[5]: ../learn/stakeholders/index.md
[6]: ../../document/templates/learn/quote-templates.md
[7]: ../../search-options/learn/find-screen.md

<!-- Refererte bilder -->
[img1]: ../../../media/loc/en/sale/edit-sale-type.png
