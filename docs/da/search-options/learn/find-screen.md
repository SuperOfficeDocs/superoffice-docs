---
uid: help-da-find-screen
title: Skærmbilledet Find
description: Skærmbilledet Find
keywords: søge, finde
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
topic: concept
audience: person
audience_tooltip: SuperOffice CRM
language: da
---

# Skærmbilledet Find <i class="ph ph-list-magnifying-glass" aria-label="Find icon"></i>

Hvis du vil søge efter poster og data i SuperOffice CRM, skal du bruge skærmbilledet **Find**.

Der er nærmest ingen grænser for, hvad du kan søge efter i SuperOffice CRM. I slutningen af denne sektion har vi medtaget eksempler for at give dig tips om søgning.

> [!NOTE]
> Hvis du har licens til Developer Tools, kan du søge efter produkter i eksisterende tilbud. Hvis du har licens til SuperOffice Service, kan du søge efter sager.

## Trin

1. Klik på knappen **Find** (<i class="ph ph-list-magnifying-glass" aria-hidden="true"></i>) på [toplinjen][1].

2. Klik på den posttype, du vil søge efter, eller klik på **Typiske søgninger** for at få vist en liste over foruddefinerede søgninger. Fanen **Kriterier** åbnes.

3. Skærmbilledet **Søg** indeholder foruddefinerede søgekriterier eller de søgekriterier, du brugte sidste gang. Gør ét af følgende:

    * Klik på <i class="ph ph-x-circle" aria-label="X"></i> for at fjerne de kriterier, du ikke vil bruge.
    * Klik på knappen **Tilføj** for at tilføje nye søgekriterier. Der tilføjes en ny linje til kriterielisten.

4. Vælg det felt, du vil søge efter oplysninger i, i den første liste på linjen. Du kan også [indtaste begyndelsen af navnet i det ønskede felt][2]. Der findes [forskellige felttyper][3].

    Vælg for eksempel **Person** og **Efternavn**, hvis du vil søge efter personer, eller **Projekt** og **Arrangementsdato**, hvis du vil søge efter projekter.

5. Vælg værdier for søgekriterierne i de næste felter på linjen.

6. Du kan klikke på **Tilføj** under kriterielisten igen for at angive flere søgekriterier. Derefter tilføjes det til en ny linje på kriterielisten, og du gentager trin 4 og 5.

7. Hvis du vil flytte kriterier, skal du klikke og trække <i class="ph ph-equals" aria-label="="></i>.

8. Klik på **Eller** for at tilføje et andet sæt kriterier.

9. Når du har angivet og aktiveret de søgekriterier, du ønsker, klikker du på knappen **Søg**. Fanen **Resultater** åbnes med resultaterne, der matcher søgekriterierne.

> [!TIP]
> Hvis du for eksempel vil søge efter alle firmaer, kan du bruge procenttegnet (%), når du tilføjer [søgekriterier][3] for **Firma**.

## <a id="or"></a>Udvid din søgning ved hjælp af QR-funktionen

Funktionen Find gør det muligt for dig at udføre en søgning ved at kombinere søgekriterier med værdioperatoren "ELLER" mellem dem. På denne måde kan du søge efter to sæt uafhængige data og gemme dem i ét udvalg.

Lad os se på nogle praktiske eksempler på, hvordan du kan bruge funktionen ELLER. Du kan søge efter alle kunder, der har købt "Produkt A", og kunder, der ikke har købt "Produkt B", for at øge dit krydssalg. Eller du kan søge efter alle store kunder med base i Liverpool eller Manchester, så du kan kontakte dem om et kommende arrangement i en af disse byer.

Se denne video for at få at vide, hvordan du opretter en søgning ved hjælp af funktionen ELLER:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/Z-fSLJSdp2k]

(videoens længde – 4:08)

## <a id="results"></a>Arbejde med søgeresultater

Når du har fulgt fremgangsmåden ovenover, og der vises søgeresultater nederst på fanen **Resultater**, har du flere muligheder:

* **Åbne posten:** Hvis du vil åbne en af posterne, dobbeltklikker du på den. Hvis du for eksempel dobbeltklikker på en person, vises detaljekortet **Personer** med den aktuelle person markeret.

* **Vise en post i sidepanelet:** Brug [sidepanelet][4] til hurtigt at gennemse søgeresultaterne. Hvis du har søgt efter person, skal du vælge **Personer** på listen øverst i sidepanelet. Du kan derefter klikke på hver person under fanen **Resultater** for at få dem vist.

* **Udføre opgaver i søgeresultaterne:** Knappen **Opgave** indeholder opgaver som for eksempel:

  * Sende en udsendelse og oprette aktiviteter
  * Administrere oplysningerne i dit udvalg
  * Udskrive eller eksportere dine data
  * Slette informationen i dit udvalg fra CRM-databasen

    ![En liste over mulige opgaver, du kan bruge dit søgeresultat til -screenshot][img10]

    Hvilke opgaver der vises, afhænger af, hvilken type poster der vises. [Læs mere][7]

* **Føje poster til et udvalg:** Klik på knappen **Gem som udvalg**. Se [Oprettelse af udvalg][8].

* Vælg en eller flere poster, højreklik og vælg **Tilføj til udvalg**. Se [Tilføjelse af medlemmer til statiske udvalg][9].

## <a id="ex1"></a>Eksempel 1: søgning efter indbringende kunder

Som leder af salgsafdelingen vil du gerne holde en præsentation for resten af ledelsen for at vise, hvad salgsafdelingen har opnået siden sidste møde. Du vil gerne fokusere på indbringende kunder (dvs. kunder, du har solgt meget til i den seneste tid).

1. Klik på knappen **Søg**.

2. Klik på **Find firma**.

3. [!include[Clear criteria](includes/clear-criteria.md)]

4. Klik på **Tilføj**.

5. [!include[Select field](includes/select-field.md)]. Klik først på **Salg** (<i class="ph ph-currency-circle-dollar" aria-hidden="true"></i>) og derefter på **Beløb**.

6. I rullemenuen til højre for **Beløb** skal du klikke på <i class="ph ph-caret-down" aria-label="Chevron"></i> og vælge **>** (større end).

7. I det sidste felt på linjen skal du indtaster du minimumsbeløbet. For eksempel "100.000".

8. Du har nu angivet, at du vil søge efter firmaer med salg over 100.000 kr., men vi er ikke færdige. Vi vil også angive en periode.

9. Klik på **Tilføj**.

10. [!include[Select field](includes/select-field.md)], som vises. Klik først på **Salg** og derefter på **Registreret dato**.

11. I den anden rullemenu skal du klikke på pilen og derefter vælge **Mellem**.

12. I den tredje rullemenu angiver du startdatoen for den ønskede periode, og i den fjerde rullemenu angiver du slutdatoen for den ønskede periode.

13. Du har nu angivet, at du vil søge efter firmaer med salg over 100.000 inden for den periode, du definerede. Men vi er ikke færdige endnu. Vi vil også begrænse søgningen til salg med statussen **Solgt**.

14. Klik på **Tilføj**.

15. På den liste, der vises, skal du indtaste "Status" for at foretage en hurtigsøgning i feltet.

16. På den liste, der vises, skal du vælge **Salg** - **Status** (med salgsikonet foran).

17. I den anden liste vælger du **Er en af**.

18. Klik i feltet **Vælg elementer** til højre for feltet **Er en af**, og vælg **Solgt**.

19. Du har nu angivet, at du vil søge efter firmaer med salg over et bestemt beløb, inden for et bestemt datointerval og med statussen **Solgt**.

20. [!include[Click Find](includes/run-search.md)]

    [!include[TIP hits](includes/tip-adjust-criteria.md)]

21. [!include[Explore results](includes/use-results.md)]

<!-- markdownlint-disable-next-line MD013 -->
## <a id="ex2"></a>Eksempel 2: søgning efter kunder i Danmark, som du har ansvaret for

Lad os sige, at du skal på en konference i Norge. Når du alligevel er der, vil du benytte lejligheden til at besøge nogle kunder samtidig. Du starter planlægningen med at finde alle de kunder i Norge, som du har ansvaret for.

1. Klik på knappen **Søg**.

2. Klik på **Find firma**.

3. [!include[Clear criteria](includes/clear-criteria.md)]

4. Klik på **Tilføj**.

5. [!include[Select field](includes/select-field.md)]: Klik først på **Firma** (<i class="ph ph-buildings" aria-hidden="true"></i>) og derefter på **Land**.

6. I den anden liste vælger du **Er en af**.

7. Klik i feltet **Vælg elementer** til højre for feltet **Er en af**, og vælg **Norge**.

8. Du har nu angivet, at du vil søge efter firmaer i Norge, men vi er ikke færdige. Vi vil begrænse søgningen til de firmaer i Norge, som du har ansvaret for.

9. Klik på **Tilføj**.

10. [!include[Select field](includes/select-field.md)]: Klik først på **Firma** og derefter på **Vores kontakt**.

11. I den anden rullemenu vælger du **Aktuel bruger**. Dit navn vises i det sidste felt på linjen.

12. Du har nu angivet, at du vil søge efter de firmaer i Norge, der har dig som person.

13. [!include[Click Find](includes/run-search.md)]

    [!include[TIP hits](includes/tip-adjust-criteria.md)]

14. [!include[Explore results](includes/use-results.md)]

## <a id="ex3"></a>Eksempel 3: søgning efter gennemførte salg

Lad os sige, at du er leder af en virksomhed, og du vil finde ud af, hvilken type salg, du har succes med og hvorfor, så du kan lære af det og få succes med mere salg. Du begynder med at søge efter salg med statussen **Solgt**.

1. Klik på knappen **Søg**.

2. Klik på **Find salg**.

3. [!include[Clear criteria](includes/clear-criteria.md)]

4. Klik på **Tilføj**.

5. [!include[Select field](includes/select-field.md)]: Klik først på **Salg** og derefter på **Status**.

6. I den anden liste vælger du **Er en af**.

7. Klik i feltet **Vælg elementer** til højre for feltet **Er en af**, og vælg **Solgt**. Du har nu angivet, at du vil søge efter fuldførte salg.

8. [!include[Click Find](includes/run-search.md)]

9. [!include[Explore results](includes/use-results.md)]

<!-- markdownlint-disable-next-line MD013 -->
## <a id="ex4"></a>Eksempel 4: søgning efter projekter, som du har deltaget i det seneste år

Lad os sige, at lønforhandlingerne nærmer sig, og at du synes, du fortjener en bedre betaling for din indsats. For at vise din chef, hvor ihærdig og alsidig du er, vil du gerne fortælle ham lidt om de projekter, du har deltaget i det seneste år.

1. Klik på knappen **Søg**.

2. Klik på **Find salg**.

3. [!include[Clear criteria](includes/clear-criteria.md)]

4. Klik på **Tilføj**.

5. [!include[Select field](includes/select-field.md)]: Klik først på <i class="ph ph-user-circle" aria-hidden="true"></i> **Person** og derefter på **Efternavn**.

6. I den anden rullemenu vælger du **Er lig med**.

7. I det tredje felt indtaster du dit efternavn.

8. Du har nu angivet, at du vil søge efter projekter, du har deltaget i, men vi er ikke færdige. Vi vil også angive en periode.

9. Klik på **Tilføj**.

10. [!include[Select field](includes/select-field.md)]: Klik først på <i class="ph ph-clipboard-text" aria-hidden="true"></i> **Projekt** og derefter på **Fra dato**.

11. I den anden rullemenu vælger du **Efter**.

12. I den tredje rullemenu angiver du startdatoen for den ønskede periode.

13. Du har nu angivet, at du vil søge efter de projekter, du har deltaget i fra en bestemt dato og frem til i dag.

14. [!include[Click Find](includes/run-search.md)]

    [!include[TIP hits](includes/tip-adjust-criteria.md)]

15. [!include[Explore results](includes/use-results.md)]

## <a id="ex5"></a>Eksempel 5: søgning efter gennemførte markedsføringstiltag

Lad os sige, at du er leder af markedsafdelingen, og at I skal have et idéudviklingsmøde om fremtidige markedsføringstiltag. For at have et udgangspunkt vil du gerne skaffe dig et overblik over, hvilke markedsføringsopfølgninger, I har gennemført i forrige kvartal.

1. Klik på knappen **Søg**.

2. Klik på **Find salg**.

3. [!include[Clear criteria](includes/clear-criteria.md)]

4. Klik på **Tilføj**.

5. [!include[Select field](includes/select-field.md)]: Klik først på <i class="ph ph-calendar-blank" aria-hidden="true"></i> **Opfølgning** og derefter på **Hensigt**.

6. I den anden liste vælger du **Er en af**.

7. Klik i feltet **Vælg elementer** til højre for feltet **Er en af**, og vælg **Markedsføring**.

8. Du har nu angivet, at du vil søge opfølgninger knyttet til markedsføring, men vi er ikke færdige. Vi vil også angive en periode.

9. Klik på **Tilføj**.

10. [!include[Select field](includes/select-field.md)]. Klik først på **Opfølgning** og derefter på **Slutdato**.

11. I den anden liste vælger du **Forrige**.

12. I den tredje liste skal du skrive 1.

13. Vælg **Kvartal(er)** på den fjerde liste.

14. Du har nu angivet, at du vil søge efter opfølgninger med markedsføring som hensigt i forrige kvartal, men vi er ikke færdige endnu. Vi vil også begrænse søgningen til udførte opfølgninger.

15. Klik på **Tilføj**.

16. [!include[Select field](includes/select-field.md)]. Klik først på **Opfølgning** og derefter på **Udført**.

17. Marker indstillingen **Ja**. Du har nu angivet, at du vil søge efter opfølgninger, der er sat til **Udført**.

18. [!include[Click Find](includes/run-search.md)]

    [!include[TIP hits](includes/tip-adjust-criteria.md)]

19. [!include[Explore results](includes/use-results.md)]

## Relateret indhold

* [Udføre opgaver][7]
* [Brug af fritekstsøgning][5]
* [Brug af hurtigsøgning][2]
* [Brug af historiklisten][6]
* [Brug af søgekriterier][3]

<!-- Referenced links -->
[1]: ../../learn/getting-started/main-screen/buttons-in-menu-bar.md
[4]: ../../learn/getting-started/main-screen/side-panel.md
[2]: in-navigator.md
[3]: search-criteria.md
[5]: freetext-search.md
[6]: ../../learn/basics/history.md
[7]: ../selection/learn/howto/index.md
[8]: ../selection/learn/create/index.md
[9]: ../selection/learn/update/add-remove-members-static.md

<!-- Referenced images -->
[img10]: ../../../media/loc/en/search-options/task-menu.png
