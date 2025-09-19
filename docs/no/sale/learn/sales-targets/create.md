---
uid: help-no-sales-targets-create
title: Sett opp salgsmål
description: Hold oversikt over budsjettene dine ved å sette opp salgsmål. Dette vil hjelpe deg med å fastsette de riktige forventningene, planlegge veksten din, øke motivasjonen og spare tid.
keywords: salgsmål
author: SuperOffice Product and Engineering
date: 09.19.2025
version: 10.5
content_type: howto
license: salespremium
deployment: online
audience: person
audience_tooltip: SuperOffice CRM
language: no
---

# Sett opp salgsmål

Hold oversikt over budsjettene dine ved å sette opp salgsmål. Dette vil hjelpe deg med å fastsette de riktige forventningene, planlegge veksten din, øke motivasjonen og spare tid.

![Måldialogtabellen gir deg en oversikt over nåværende og tidligere salgsmål -screenshot][img1]

Mållisten kan inneholde følgende deler:

* Firmaets mål
* Brukergruppens mål
* Brukerens mål
* Summen av mål for alle brukere i én brukergruppe (kan ikke redigeres)

Det er valgfritt å legge til firmamålet og ha brukerspesifikke mål (gå til Målinnstillinger for å endre). Summen av alle målene i én brukergruppe kan ikke redigeres. Den viser summen for alle brukerne i en brukergruppe og er en retningslinje som skal gjøre det enklere å fastsette målet for hele brukergruppen. Du kan legge til og redigere firmamålet, fordi målet for hele firmaet ikke nødvendigvis er det samme som summen av alle brukergrupper.

## Krav

> [!NOTE]
> Kun **ONLINE**-kunder. (Ikke tilgjengelig for onsite-kunder.)

Hvis du bare har en Sales Premium-lisens, kan du legge til en gruppe for måltypen **Alle salg – beløp**. For å legge til mer enn en brukergruppe, trenger du også lisensen Unlimited sales targets.

## Før du begynner

Før du begynner å bruke salgsmål, må du konfigurere noen få ting i Innstillinger og vedlikehold:

* Som standard er salgsmålene delt inn i måneder, men du kan endre dette til kvartalsmål. I Innstillinger og vedlikehold går du til **Preferanser** > **Globale preferanser** > **Mål** for å gjøre endringer.

* Du kan bare låse og låse opp salgsmål hvis du har den funksjonelle rettigheten **Kan låse og låse opp mål**. Dette kan endres i **Roller** i Innstillinger og vedlikehold.

* Oppretting, redigering og sletting av salgsmål krever spesifikke datarettigheter. Dette kan endres i **Roller** i Innstillinger og vedlikehold.

## Legg til mål for et år

1. Klikk <i class="ph ph-list" aria-label="Hovedmeny"></i> og velg **Mål**.

    * Hvis det ikke er opprettet noen salgsmål ennå, er listen tom.

1. I bildet **Salgsmål** velger du året du vil opprette et salgsmål for, fra listen **Velg år**.

    * Hvis du har valgt et år OG foregående år inneholder salgsmål, vil du bli spurt om du vil opprette mål basert på foregående år. Du kan kopiere målene som de er, eller velge å øke målene med en gitt prosentandel.

1. Klikk på **Legg til grupper og brukere**, og bruk søkefeltet til å finne den relevante gruppen. Velg gruppen i listen. For å legge til et mål for hele firmaet, velg **Firmamål**.

    * Gruppen legges til i oversikten med månedlige/kvartalsvise mål satt til 0 i standardvalutaen (dersom du ikke har kopiert tallene fra et annet år). Alle brukere (primære gruppemedlemmer) som tilhører gruppen, står oppført under den.

1. Hvis aktuelt, endre valutaen for firmaet eller gruppen. Standardvalutaen er basisvalutaen som er angitt for firmaet ditt. Du kan ikke angi valuta for enkeltbrukere.

1. Juster tallene manuelt ved å bruke **TAB**-tasten for å gå til neste felt. Du kan også [kopiere og lime inn tall fra Excel](#import) eller klikke <i class="ph ph-list" aria-label="Menyikon"></i> på slutten av en rad og velge **Juster tall**.

    ![Juster tall for et spesifikt mål -screenshot][img3]

1. Valgfritt: Når du har fullført en rad, kan du låse den (<i class="ph ph-lock-simple" aria-hidden="true"></i>) for å forhindre redigering. For eksempel etter at et budsjett er godkjent og ikke skal redigeres. Låste rader kan ikke fjernes, tømmes eller redigeres.

1. Hvis en bestemt gruppe eller bruker ikke skal ha et salgsmål, klikk <i class="ph ph-list" aria-label="Menyikon"></i> og velg **Tøm** for å tømme verdiene.

1. Klikk på **Lagre**.

    * Gjenta trinn 3-10 for å legge til flere grupper eller firmaer. Dette krever Sales Targets Unlimited-lisensen.

    * Gå til trinn 2 for å legge til salgsmål for et annet år, eller klikk **Lagre og lukk** for å avslutte dette bildet.

## Kopiere tall fra en annen brukers mål

For å unngå å måtte definere salgsmålene på nytt fra bunnen av for en annen bruker kan du kopiere en annen brukers salgsmål slik de er (faste tall), justere målet opp eller ned med % eller angi det årlige startbeløpet.

Alternativer:

* **Angi startbeløp:** Angi beløpet for hele året. Beløpet deles likt mellom månedene eller kvartalene på gjeldende rad.

* **Kopier fra:** Kopier verdiene fra en annen gruppe eller bruker.

* **Kopier fra i fjor:** Kopier verdier fra i fjor og øk verdiene med en bestemt prosentandel. Dette alternativet er deaktivert hvis fjoråret ikke har noen verdier.
    Klikk på **Lagre** når du er ferdig. Summene for alle brukere legges til i **Alle**-raden øverst i listen over brukere.

## Tømme eller fjerne mål

For å fjerne et firma- eller gruppemål, klikk <i class="ph ph-list" aria-label="Menyikon"></i> og velg **Fjern firmamål** eller **Fjern gruppemål**.

Hvis du har lagt til verdier som ikke er riktige, eller en bruker har sluttet i firmaet, kan du velge å fjerne verdiene. Legg merke til at du ikke kan slette en bruker i en brukergruppe hvis brukeren ikke har noen salgsmål, men du kan fjerne raden.

![Tøm tall for et spesifikt mål -screenshot][img2]

## Eksportere

Klikk på **Oppgave**-knappen (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) for å eksportere salgsmålet for det valgte året til Excel eller PDF.

## <a id="import"></a>Import

Du kan eksportere hele mållisten, redigere den i et regneark og deretter importere den tilbake til Mål.

For å gjøre dette:

1. Eksporter salgsmålet for det valgte året til Excel.

1. Rediger måldataene (beløpene) i regnearket.

1. Kopier måldataene i regnearket (kun beløp). Du kan velge hvilket som helst område.

1. Velg cellen øverst til venstre i det aktuelle området i SuperOffice, og lim inn dataene. Hvis noen av radene er låst, kan du ikke lime inn dataene.

## Låse/låse opp-funksjon

Avhengig av brukerrollen din (den funksjonelle rettigheten "Kan låse/låse opp mål") kan du låse og låse opp et salgsmål. Når salgsmålet er godkjent, kan du velge raden for å låse det, og da vil raden være deaktivert for redigering. Hvis salgsmålet er godkjent og låst, skal det ikke låses opp med mindre det er visse grunner til å endre det.

## Revisjonshistorikk

For å vise revisjonshistorikken for et salgsmål (rad), klikk <i class="ph ph-list" aria-label="Menyikon"></i> og velg **Revisjonshistorikk**. I bildet som vises, kan du vise alle endringer til gjeldende salgsmål. Dette inkluderer endrede verdier og låsing/opplåsing, når endringen ble gjort og av hvem. Bruk utvid/kollaps-knappene øverst for å vise/skjule detaljer.

## Tips

* Bruk utvid/kollaps-knappene øverst eller pilene ved siden av hver gruppe for å vise eller skjule brukere.

* Du kan sette opp mål for tidligere år, for å lage budsjettstatistikk bakover i tid.

* Standard måltype er **Alle salg - Beløp**. Hvis du har Sales Targets Unlimited-lisensen, kan du opprette flere måltyper.

* Bruk feltet **Fritekstsøk** til å finne salgsmål for bestemte grupper og brukere i et bestemt år.

* For måltyper som inkluderer undertyper, bruk **Filter**-knappen (<i class="ph ph-funnel" aria-hidden="true"></i>) for å vise eller arbeide med spesifikke elementer.

    ![Klikk på trakt-ikonet for å filtrere salgsmål etter undertype -screenshot][img4]

## Aktuelt innhold

* [Bruke salgsmål i figurer][2]

<!-- Referenced links -->
[2]: ../../../dashboard/learn/show-sales-targets.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/sale/targets-dialog-group-expanded.png
[img2]: ../../../../media/loc/en/sale/target-line-menu.png
[img3]: ../../../../media/loc/en/sale/target-adjust-number.png
[img4]: ../../../../media/loc/en/sale/filter-targets-by-dimension.png
