---
uid: help-no-quote-add-products
title: Legg til produkter i tilbud
description: Legg til produkter i tilbud
author: SuperOffice RnD
date: 07.04.2022
keywords: tilbud
topic: howto
language: no
---

# Legg til produkter

I dialogboksen **Legg til / rediger produkt** kan du legge til et produkt, angi antall, rabatter og annen informasjon for produktet.

## Legg til ett produkt

1. Åpne et tilbud og klikk på **Legg til** nederst i fanen **Produkter** (eller et eventuelt alternativ du har opprettet).

1. Dobbeltklikk på et produkt i et tilbud.

1. Du søker i en bestemt prisliste ved å velge den i listen ved siden av feltet **Produktsøk**.

1. Begynn å skrive inn navnet på produktet eller produktkoden i feltet **Produktsøk**. Trefflisten oppdateres automatisk. Du kan søke på hele eller deler av både produktnavn og -kode.

    > [!TIP]
    >Hvis det er støtte for avanserte søk, kan du klikke på <i class="ph ph-magnifying-glass" aria-label="Search icon"></i> i feltet **Produktsøk** for å søke etter og [legge til flere produkter samtidig](#add-multiple).

1. Klikk på ønsket produkt i listen. Dialogboksen oppdateres med produktinformasjon.

1. Rediger antall for produktet og eventuelt rabatt og totalpris. Se detaljer nedenfor.

1. Les og rediger eventuelt produktinformasjonen i fanene **Beskrivelse** og **Detaljer**.

1. Klikk på **Lagre + ny** for å lagre dette produktet og legge til et produkt til
    eller
    Klikk på **Lagre** for å lagre og gå tilbake til tilbudet.

## <a id="add-multiple"></a>Legge til flere produkter i et tilbud

1. Klikk på **Legg til** nederst i fanen **Produkter** i dialogboksen **Rediger tilbud**.

2. Begynn å skrive inn et produktnavn i feltet**Produktsøk** for å søke etter et produkt. Klikk på <i class="ph ph-magnifying-glass" aria-label="Search icon"></i> for å søke etter produkter ved hjelp av en rekke forskjellige kriterier, for eksempel etter produktsortiment, produktgrupper/kategorier, navn, varekoder osv. Søket inneholder alle aktive prislister med gjeldende valuta.

3. Når du har funnet produktene du vil legge til i tilbudet, merker du dem (**Ctrl+klikk**), og klikker på **OK**. Produktene vises i fanen **Produkter** (eller i fanen for alternativet du har opprettet).

4. Dobbeltklikk et produkt for å endre antall, rabatter og så videre.

## Redigere antall, rabatter og priser for et produkt

I området til venstre i dialogboksen **Legg til / rediger produkt** vises produktnavnet/-koden, og det er her du angir antall og eventuelle rabatter for det valgte produktet.

> [!TIP]
> Du kan vise mer informasjon om de ulike feltene (feltnavn, redigerbare felt og utregninger) ved å holde musepekeren over det aktuelle feltet.

* Tall som vises i sort skrift, kan redigeres.
* Totalbeløp og rabatter oppdateres fortløpende når du redigerer de ulike feltene.
* Rabatt kan angis enten som en prosentsats, et rabattbeløp eller som et totalbeløp.
  * Rabattfeltet du redigerte, vises med *understreking*.
  * De andre feltene oppdateres for å samsvare med den rabatten du definerte.
  * Hold musepekeren over et rabattfelt for å vise eventuelle systemrabatter (for eksempel kvantumsrabatter som legges til automatisk).
* Hvis du anga rabatter som ikke er tillatt av systemet, vises det et varsel eller en annen melding.

## Fanen Bilde

Her vises et bilde av produktet, hvis dette er definert i Innstillinger og vedlikehold.

## Fanen Beskrivelse

Her vises det detaljert produktinformasjon, hvis dette er definert i Innstillinger og vedlikehold.

## Fanen Detaljer

Her vises detaljerte prisberegninger. Innholdet på denne fanen defineres i Innstillinger og vedlikehold.

## <a id="warning"></a>Advarsler og hvordan de skal håndteres

I Innstillinger og vedlikehold kan det defineres ulike regler for hva som er tillatt og ikke tillatt når du legger til produkter i et tilbud. Avhengig av hvordan disse reglene er definert, kan det hende at det vises ulike ikoner/varsler når du legger til produkter i et tilbud. I noen tilfeller må tilbudet godkjennes [før sending][1].

> [!NOTE]
> Du kan lagre og legge til produkter i et tilbud selv om det vises varsler og andre meldinger, men du kan ikke sende tilbudet når det inneholder feil og varsler. Du må enten rette feilen eller få tilbudet godkjent.

[!include[Table showing quote icons](includes/table-quote-icons.md)]

### Hvor vises slike varsler og meldinger?

* I dialogboksen **Legg til / Rediger produkt**
* I dialogboksen **Rediger tilbud for**
* På produktlinjer i detaljkortet **Tilbud** og fanen **Produkter** (og alternativer) i et tilbud

### Hva skyldes slike varsler og meldinger?

Varsler og meldinger kan for eksempel gjelde følgende:

* Produkter som ikke finnes i sortimentet
* Inaktive prislister
* Produktpris er under minstepris eller kostpris
* Totalpris er null eller negativ
* Total rabatt er for høy
* Total fortjeneste er for lav

<!-- Referenced links -->
[1]: approve.md
