---
uid: help-no-find-screen
title: Søke-skjerm
description: Søke-skjerm
keywords: søk, finn
author: SuperOffice RnD
date: 01.29.2025
version: 10.5
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: no
---

# Søke-skjermen <i class="ph ph-list-magnifying-glass" aria-label="Find icon"></i>

Hvis du vil søke etter poster og data i SuperOffice CRM, bruker du **Søk**-skjermen.

Det er i praksis ingen grenser for hva du kan søke etter i SuperOffice CRM. På slutten av denne delen har vi tatt med eksempler for å gi deg tips om søking.

> [!NOTE]
> Hvis du har lisens på Developer Tools, kan du søke etter produkter i eksisterende tilbud. Hvis du har lisens på SuperOffice Service, kan du søke etter forespørsler.

## Søke etter informasjon i SuperOffice CRM

1. Klikk på **Finn**-knappen (<i class="ph ph-list-magnifying-glass" aria-hidden="true"></i>) på [toppraden][1].

2. Klikk på typen post du vil søke etter, eller klikk på **Vanlige søk** for å vise en liste over forhåndsdefinerte søk. Fanen **Kriterier** åpnes.

3. Skjermbildet **Finn** inneholder forhåndsdefinerte søkekriterier, eller søkekriteriene du brukte forrige gang. Gjør ett av følgende:

    * Klikk på <i class="ph ph-x-circle" aria-label="X"></i> for å fjerne eventuelle kriterier du ikke vil bruke.
    * Klikk **Legg til**-knappen for å legge til nye søkekriterier. En ny linje legges til i kriterielisten.

4. I den første listeboksen på linjen velger du feltet du vil søke etter informasjon i. Du kan også [skrive inn starten på navnet i det aktuelle feltet][2]. Det finnes [forskjellige typer felt][3].

    Velg for eksempel **Person** og **Etternavn** for å søke etter personer, eller **Prosjekt-** og **Arrangementsdato** for å søke etter prosjekter.

5. Velg verdier for søkekriteriene i de neste feltene på linjen.

6. Du kan klikke på **Legg til** under kriterielisten på nytt for å angi flere søkekriterier. Da legges det til en ny linje i listen over kriterier, og du kan gjenta trinn 4 og 5.

7. Hvis du vil flytte kriterier, klikk og dra <i class="ph ph-equals" aria-label="="></i>.

8. Klikk **Eller** for å legge til et annet sett med kriterier.

9. Når du har angitt og aktivert de søkekriteriene du ønsker, klikker du på **Finn**-knappen. Fanen **Resultater** åpnes med resultatene som samsvarer med søkekriteriene.

> [!TIP]
> Hvis du for eksempel vil søke etter alle firmaer, kan du bruke prosenttegnet (%) når du [angir søkekriterier][3] for **Firma**.

## <a id="or"></a>Utvide søket ved hjelp av ELLER-funksjonen

Med Finn-funksjonen kan du utføre et søk ved å kombinere søkekriterier med verdioperatoren "OR" mellom dem. Slik kan du søke etter to sett med uavhengige data og lagre dem i ett utvalg.

La oss ta en titt på noen praktiske eksempler på hvordan du kan bruke ELLER-funksjonen. Du kan søke etter alle kunder som har kjøpt "Produkt A" og kunder som ikke har kjøpt "Produkt B" for å øke kryssalg. Eller du kan søke etter alle store kunder basert i Liverpool eller Manchester, slik at du kan kontakte dem om et kommende arrangement i en av disse byene.

Se denne videoen for å lære hvordan du oppretter et søk ved hjelp av ELLER-funksjonen:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/Z-fSLJSdp2k]

(videolengde - 4:08)

## <a id="results"></a>Jobbe med søkeresultater

Når du har fulgt trinnene over, og søkeresultatene vises i fanen **Resultater** har du flere tilgjengelige alternativer:

* **Åpne posten:** Hvis du vil åpne en av postene, dobbeltklikker du på den. Hvis du for eksempel dobbeltklikker på en person, vises detaljkortet **Personer** med den aktuelle personen markert.

* **Vis en post i sidepanelet:** Bruk [sidepanelet][4] til å bla raskt gjennom søkeresultatene. Hvis du har søkt etter person, velger du **Personer** i listen øverst i sidepanelet. Deretter kan du klikke på hver enkelt person i fanen **Resultater** for å forhåndsvise dem.

* **Utfør oppgaver på søkeresultatene:** **Oppgave**-knappen inneholder oppgaver som for eksempel:

  * Send en utsendelse og opprette aktiviteter
  * Administrer informasjonen i utvalget ditt
  * Skriv ut eller eksporter dataene dine
  * Slett informasjonen du har valgt, fra CRM-databasen

    ![En liste over mulige oppgaver du kan bruke søkeresultatet til -screenshot][img10]

    Hvilke oppgaver som vises, avhenger av hvilken type poster som vises. [Les mer][7]

* **Legg til poster i et utvalg:** Klikk på knappen **Lagre som utvalg**. Se [Opprette utvalg][8].

* Merk oppføringen, høyreklikk og velg **Legg til i utvalg**. Se [Legg til medlemmer til statiske utvalg][9].

## <a id="ex1"></a>Eksempel 1: søk etter lønnsomme kunder

Som salgsavdelingsleder vil du holde en presentasjon for resten av ledelsen, som viser hva du har oppnådd etter forrige møte. Du ønsker å fokusere på lønnsomme kunder (kunder du nylig har solgt mye til).

1. Klikk på **Finn**-knappen.

2. Klikk på **Finn firma**.

3. [!include[Clear criteria](includes/clear-criteria.md)]

4. Klikk på **Legg til**.

5. [!include[Select field](includes/select-field.md)] Klikk først på **Salg** (<i class="ph ph-currency-circle-dollar" aria-hidden="true"></i>), og deretter på **Beløp**.

6. I listeboksen til høyre for **Beløp**, klikker du <i class="ph ph-caret-down" aria-label="Chevron"></i> og velger **&gt;** (større enn).

7. I det siste feltet på linjen angir du minimumsbeløpet. For eksempel "100 000".

8. Du har nå angitt at du vil søke etter firmaer med salg over beløpet du har oppgitt, men vi er ikke helt ferdige. Vi ønsker også å angi periode.

9. Klikk på **Legg til**.

10. [!include[Select field](includes/select-field.md)]. Klikk først på **Salg**, og deretter **Registreringsdato**.

11. I den andre listeboksen klikker du pilen og velger **Mellom**.

12. I den tredje listeboksen angir du startdato for ønsket periode, og i den fjerde listeboksen angir du sluttdato for ønsket periode.

13. Du har nå angitt at du vil søke etter firmaer med salg over 100 000 innenfor perioden du definerte. Men, vi ønsker også å begrense søket til salg med statusen **Solgt**.

14. Klikk på **Legg til**.

15. I listen som vises, skriver du inn "Status" for å hurtigsøke i feltet.

16. Fra listen som vises velger du **Salg** - **Status** (med salgsikonet foran den).

17. I den andre listeboksen velger du **Er en av**.

18. Klikk på feltet **Velg elementer** til høyre fore feltet **Er en av** og velg **Solgt**.

19. Du har nå angitt at du vil søke etter firmaer med salg over et bestemt beløp, innenfor et bestemt datoområde og som har statusen **Solgt**.

20. [!include[Click Find](includes/run-search.md)]

    [!include[TIP hits](includes/tip-adjust-criteria.md)]

21. [!include[Explore results](includes/use-results.md)]

<!-- markdownlint-disable-next-line MD013 -->
## <a id="ex2"></a>Eksempel 2: søk etter kunder i Danmark som du er ansvarlig for

Tenk deg at du skal på en konferanse i Danmark. Når du er der, vil du benytte anledningen til å besøke noen kunder. Du begynner planleggingen med å søke frem alle kundene i Danmark som du har ansvar for.

1. Klikk på **Finn**-knappen.

2. Klikk på **Finn firma**.

3. [!include[Clear criteria](includes/clear-criteria.md)]

4. Klikk på **Legg til**.

5. [!include[Select field](includes/select-field.md)] Klikk først på <i class="ph ph-buildings" aria-hidden="true"></i> **Firma**, og deretter på **Land**.

6. I den andre listeboksen velger du **Er en av**.

7. Klikk på feltet **Velg elementer** til høyre for feltet **Er en av** og velg **Danmark**.

8. Du har nå angitt at du vil søke etter firmaer i Danmark, men vi er ikke ferdige. Vi ønsker å begrense søket til firmaer i Danmark som du har ansvaret for.

9. Klikk på **Legg til**.

10. [!include[Select field](includes/select-field.md)] Klikk først på **Firma**, og deretter **Vår kontaktperson**.

11. I den andre listeboksen velger du **Gjeldende bruker**. Navnet ditt vises i det siste feltet på linjen.

12. Du har nå angitt at du vil søke etter firmaer i Danmark som har deg som kontaktperson.

13. [!include[Click Find](includes/run-search.md)]

    [!include[TIP hits](includes/tip-adjust-criteria.md)]

14. [!include[Explore results](includes/use-results.md)]

## <a id="ex3"></a>Eksempel 3: søk etter solgte (utførte) salg

La oss si at du er leder for et firma og vil finne ut hvilken type salg dere lykkes med, og hvorfor, slik at dere kan lære av det og lykkes med flere salg. Du begynner med å søke etter salg med statusen **Solgt**.

1. Klikk på **Finn**-knappen.

2. Klikk på **Finn salg**.

3. [!include[Clear criteria](includes/clear-criteria.md)]

4. Klikk på **Legg til**.

5. [!include[Select field](includes/select-field.md)] Klikk først på **Salg**, og deretter på **Status**.

6. I den andre listeboksen velger du **Er en av**.

7. Klikk på feltet **Velg elementer** til høyre for feltet **Er en av**, og velg **Solgt**. Nå har du angitt at du vil søke etter fullførte salg.

8. [!include[Click Find](includes/run-search.md)]

9. [!include[Explore results](includes/use-results.md)]

<!-- markdownlint-disable-next-line MD013 -->
## <a id="ex4"></a>Eksempel 4: søk etter prosjekter du har deltatt i under det siste året

La oss si at det nærmer seg lønnsforhandlinger, og at du mener du fortjener å få bedre betalt for innsatsen din. For å vise sjefen din hvor iherdig og allsidig du er, vil du snakke om prosjektene du har vært involvert i det siste året.

1. Klikk på **Finn**-knappen.

2. Klikk på **Finn salg**.

3. [!include[Clear criteria](includes/clear-criteria.md)]

4. Klikk på **Legg til**.

5. [!include[Select field](includes/select-field.md)] Klikk først på <i class="ph ph-user-circle" aria-hidden="true"></i> **Person**, og deretter på **Etternavn**.

6. I den andre listeboksen velger du **Er lik**.

7. I det tredje feltet skriver du inn etternavnet ditt.

8. Du har nå angitt at du vil søke etter prosjekter du har deltatt på, men vi er ikke helt ferdige. Vi ønsker også å angi periode.

9. Klikk på **Legg til**.

10. [!include[Select field](includes/select-field.md)] Klikk først på <i class="ph ph-clipboard-text" aria-hidden="true"></i> **Prosjekt**, og deretter på **Fra-dato**.

11. I den andre listeboksen velger du **Etter**.

12. I den tredje listeboksen angir du startdato for ønsket periode.

13. Nå har du angitt at du vil søke etter prosjekter du har deltatt i fra en gitt dato og frem til i dag.

14. [!include[Click Find](includes/run-search.md)]

    [!include[TIP hits](includes/tip-adjust-criteria.md)]

15. [!include[Explore results](includes/use-results.md)]

## <a id="ex5"></a>Eksempel 5: søk etter gjennomførte markedsføringsinitiativer

La oss si at du er leder for en markedsavdeling, og at dere skal ha en idédugnad om fremtidige markedsføringstiltak. Som utgangspunkt for dette vil du gjerne ha en oversikt over hvilke oppfølginger knyttet til markedsføring du gjennomførte i forrige kvartal.

1. Klikk på **Finn**-knappen.

2. Klikk på **Finn salg**.

3. [!include[Clear criteria](includes/clear-criteria.md)]

4. Klikk på **Legg til**.

5. [!include[Select field](includes/select-field.md)] Klikk først på <i class="ph ph-calendar-blank" aria-hidden="true"></i> **Oppfølging**, og deretter på **Hensikt**.

6. I den andre listeboksen velger du **Er en av**.

7. Klikk på feltet **Velg elementer** til høyre for feltet **Er en av**, og velg **Markedsføring**.

8. Du har nå angitt at du vil søke etter oppfølginger knyttet til markedsføring, men vi er ikke helt ferdige. Vi ønsker også å angi periode.

9. Klikk på **Legg til**.

10. [!include[Select field](includes/select-field.md)] Klikk først på **Oppfølging**, og deretter på **Sluttdato**.

11. I den andre listeboksen velger du **Forrige**.

12. I den tredje listeboksen angir du 1.

13. I den fjerde listeboksen velger du **Kvartal**.

14. Du har nå angitt at du vil søke etter oppfølginger med markedsføring som hensikt i forrige kvartal, men vi er ennå ikke helt ferdige. Vi ønsker også å begrense søket til utførte oppfølginger.

15. Klikk på **Legg til**.

16. [!include[Select field](includes/select-field.md)] Klikk først på **Oppfølgingen**, og deretter på **Utført**.

17. Merk av for **Ja**. Du har nå angitt at du vil søke etter oppfølginger som er satt til **Utført**.

18. [!include[Click Find](includes/run-search.md)]

    [!include[TIP hits](includes/tip-adjust-criteria.md)]

19. [!include[Explore results](includes/use-results.md)]

## Hva vil du gjøre nå?

* [Utfør oppgaver][7]
* [Bruk fritekstsøk][5]
* [Bruk hurtigsøk][2]
* [Bruke historikklisten][6]
* [Bruk søkekriterier][3]

<!-- Referenced links -->
[1]: ../../learn/getting-started/main-screen/buttons-in-menu-bar.md
[4]: ../../learn/getting-started/main-screen/side-panel.md
[2]: index.md#fastsearcher
[3]: search-criteria.md
[5]: freetext-search.md
[6]: ../../learn/basics/history.md
[7]: ../selection/learn/howto/index.md
[8]: ../selection/learn/create/index.md
[9]: ../selection/learn/update/add-remove-members-static.md

<!-- Referenced images -->

[img10]: ../../../media/loc/en/search-options/task-menu.png
