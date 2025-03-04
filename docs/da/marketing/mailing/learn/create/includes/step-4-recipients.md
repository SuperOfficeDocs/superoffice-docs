<!-- markdownlint-disable-file MD041 MD034-->
Når du opretter en mail, skal du vælge modtagerne af udsendelsen. Du kan tilføje modtagere fra flere kilder. Du kan også konfigurere forskellige indstillinger for din udsendelse, og du kan se en forhåndsvisning af den.

Din målliste er den gruppe personer, du tror vil reagere bedst på dit budskab. Hvis du skræddersyr dit marketingbudskab specifikt til den gruppe, får du en bedre chance for succes og undgår at spilde tid og kræfter på folk, der ikke er interesseret.

Du kan bruge udvalg eller projekter og tilføje individuelle kontakter i SuperOffice CRM.

På grund af GDPR-lovgivningen er det kun de kontakter, der har givet samtykke til lovligt at blive gemt i SuperOffice CRM-databasen og modtage oplysninger, der kan tilføjes som modtagere.

![Du kan enten tilføje modtagerne fra et udvalg, et projekt, en individuel kontakt eller fra en ekstern liste, du importerer -screenshot][img3]

## Tilføj modtagere fra udvalg eller projekter

Du kan tilføje modtagere fra udvalg (i både SuperOffice CRM og SuperOffice Service) og fra projekter (i SuperOffice CRM).

1. Under **Tilføj modtagere** skal du klikke på **Udvalg** eller **Projekt**.

2. Klik i feltet nedenfor, og begynd at skrive navnet på udvalget eller projektet, som du ønsker at tilføje. Mens du skriver, vises forekomsterne på en dynamisk liste.

3. Klik på et udvalg eller projekt på listen.

4. Klik på **+**. Udvalget eller projektet tilføjes til listen **Modtagerkilder**, og listen **Modtagere** opdateres.

5. Gentag trin 1-4 for at tilføje flere udvalg eller projekter.

> [!NOTE]
> Hvis du har markeret et udvalg under **Arkivere udsendelser** i **Opsætning** (trin 1), er udvalget listet under **Modtagerkilder**. Du kan om nødvendigt slette dette udvalg.

## Tilføje personer fra SuperOffice

Du kan tilføje individuelle kontakter fra SuperOffice.

1. Under **Tilføj modtagere**, klik på **Person**.

2. Klik i feltet nedenfor, og begynd at skrive navnet på den person, du vil tilføje, i feltet nedenfor. Du kan også angive et firmanavn for at få vist alle personer for et firma.

3. Vælg den ønskede person på den liste, der vises.

4. Klik på **+**. Personen tilføjes på listen **Modtagerkilder**, og listen **Modtagere** opdateres.

5. Gentag trin 2-5 for at tilføje flere personer. Yderligere kontakter vil blive tilføjet den samme række på listen **Modtagerkilder**, og antallet af personer vil blive vist i kolonnen **Navn**.

## Importere en list med modtagere (personer) fra en ekstern fil

Du kan tilføje modtagere af en udsendelse ved at importere dem fra en ekstern  komma-separeret fil (for eksempel en .txt-fil oprettet i Notepad eller en .csv-fil oprettet i Excel).

Når du importerer en liste over navne og e-mailadresser, forsøger SuperOffice Marketing at finde de importerede modtagere i databasen i SuperOffice. Hvis der er et match, vil modtagernes virksomheder blive oplistet i kolonnen **Virksomhed** på listen over **Modtagere**. Navne/e-mailadresser, der **ikke** findes i SuperOfffice, filtreres fra og indgår ikke i mailudsendelsen. Det skyldes GDPR-regler.

### Trin

1. Klik på **Vælg fil**.

2. Lokaliser den relevante fil (.txt, .csv eller lignende tekstformat).

3. Klik på **+**. Listen tilføjes på listen **Modtagerkilder**, og listen **Modtagere** opdateres.

4. Gentag trin 2-4 for at tilføje flere modtagere. Supplerende modtagere vil blive tilføjet til den samme række i listen **Modtagerkilder**. Det samlede antal modtagere vil blive vist i kolonnen **Navn**.

> [!NOTE]
Denne valgmulighed er ikke tilgængelig for dokumentudsendelser.

### Importere filformat

* De enkelte modtagere skal stå på hver deres linje (række).

* Hver enkelt modtager(række) består af det fulde navn og e-mailadressen.

    Eksempel: "John Smith, john@company.com"

    > [!NOTE]
    > Du kan også nøjes med at angive e-mailadressen. I så fald vil navnet ikke være tilgængeligt som skabelonvariabel.

* Onsite: Den enkelte modtager(række) kan også indeholde et mobiltelefonnummer (efter e-mailadressen), hvis du opsætter sms-udsendelser. For eksempel: "John Smith, john@company.com, 99999999". Kræver licens til Marketing SMS.

> [!NOTE]
Hvis du kun har mobiltelefonnummeret og skal sende en SMS, kan du angive følgende:

## Indstillinger for modtager

Under **Valgmuligheder** kan du i den nederste del af skærmbilledet **Modtagere** vælge indstillinger for udsendelsen alt efter dens type.

**Muligheder for de enkelte udsendelsestyper:**

| Mulighed | Dokument | E-mail | SMS |
|---|:-:|:-:|:-:|
| Tilsidesætte samtykke og abonnement | x | x | x |
| Kun én meddelelse pr. e-mailadresse | | x | x |
| Opdatere modtagerliste ved afsendelse | | x | x |
| Medtage virksomheder | x | x | |
| Foretrukken virksomhed | x | x | |

* **Tilsidesætte samtykke og abonnement**: Vælg denne valgmulighed for at sende udsendelsen til personer, som ikke har givet deres samtykke til at modtage e-markedsføring, eller som ikke abonnerer på denne udsendelsestype. Disse personer vises med status **Intet samtykke** på listen **Modtagere**.

* **Kun én meddelelse pr. e-mailadresse**: Vælg denne indstilling for at fjerne dubletter af e-mailadresser i modtagerlisten (angivet i kolonnnen **Dublet** i kolonnen **Status**). Dette opdaterer listen **Modtagere**.

* **Opdatere modtagerliste ved afsendelse**: Vælg denne valgmulighed for automatisk opdatering af modtagerlisten før afsendelse af udsendelsen. Se **Opdater modtagerliste** nedenfor.

* **Medtage virksomheder**: Vælg denne indstilling for at medtage firmaer som modtagere.

    > [!NOTE]
    Hvis et firma ikke har nogen e-mailadresse, sendes udsendelsen i stedet til alle relaterede personer på modtagerlisten.

* **Foretrukken virksomhed**: Vælg denne indstilling for kun at sende udsendelsen til firmaerne på modtagerlisten (og ikke de relaterede personer). Hvert firma modtager kun én udsendelse. Personer, der ikke tilhører et firma, vil stadig modtage udsendelsen.

    > [!NOTE]
    > Indstillingen**Fortrukken virksomhed** er kun tilgængelig, hvis du har valgt **Medtag virksomheder** ovenfor.

## Se forhåndsvisning af udsendelsen

Når du har tilføjet modtagere til listen **Modtagere**, kan du se en forhåndsvisning af udsendelsen, som den vil se ud for modtagerne. Denne valgmulighed er ikke tilgængelig for dokumentudsendelser.

> [!NOTE]
> En forhåndsvisning af udsendelsen indebærer **ikke**, at den bliver afsendt til modtageren.

1. Klik på en modtager i listen **Modtagere**.

2. Klik på knappen **Forudvisning**. Vinduet **Forhåndsvisning** viser udsendelsen, som den vil se ud for den pågældende modtager. Alle skabelonvariabler er blevet erstattet af de faktiske kontaktdata (navn, firma etc).

3. Klik på alle links for at kontrollere om de virker, men husk at nulstille dem, hvis de er sporbare.

4. Klik på X for at lukke vinduet **Forhåndsvisning**.

## Gennemgå og opdatere modtagerlisten

Når du tilføjer udvalg, projekter, kontakter og importerer lister, opdateres listen **Modtagere** automatisk. Hvis du har valgt **Opdater modtagerliste ved afsendelse**, kontrolleres dine projekter og valg, inden udsendelsen afsendes, hvis der er tilføjet, fjernet eller redigeret kontakter.

Du kan også klikke på knappen **Opdater liste** nedenfor listen **Modtagere** for at opdatere listen manuelt. Nogle af kontakterne på listen kan have ændret deres samtykke, efter du har tilføjet dem.

> [!NOTE]
> Listen viser kun de første 50 modtagere. Klik på **Indlæs alle** nederst på listen for at få vist alle modtagere.

Klik på **Næste** for at gå til Trin 5: Bekræft. Du kan stadig gå tilbage til trinnet **Modtagere** for at redigere i modtagerlisten.

<!-- Referenced images -->
[img3]: ../../../../../../media/loc/en/marketing/add-target-list.png
