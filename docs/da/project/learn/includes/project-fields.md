<!-- markdownlint-disable-file MD041 -->
1. **Projektnavn:** Indtast navnet på firmaet i feltet øverst i fanen **Projekt**. ***Projektnavn*** vises med rødt for at angive, at dette er et obligatorisk felt.

    Hvis du forsøger at oprette et projekt med [samme navn som et eksisterende projekt, eller et der ligner][5], åbnes dialogboksen **Dubletter**. Den fungerer på samme måde som for firmaer.

1. **Nummer:** I dette felt indsætter SuperOffice CRM automatisk det næste ledige projektnummer. 10001 er som standard første projektnummer, og værdien øges med 1 for hvert nyt projekt. Administratorer kan ændre dette i Indstillinger og vedligeholdelse, så det behøver du ikke at tænke på.

1. **Websted:** I dette felt vises en tabel med kolonnerne **Webadresse (URL)** og **Emne**.

    Her kan du indtaste henholdsvis adressen til en side på internettet og en kort beskrivelse af, hvilken slags side det er. Hvis du ønsker det, kan du tilføje flere webadresser. Klik uden for tabellen, når du er færdig, eller tryk på **FANE**, indtil tabellen lukkes.

1. **Beskrivelsesfelt:** I den store tekstboks kan du tilføje en nærmere beskrivelse af projektet.

1. **Ansvarlig:** Her kan du angive, hvem der er ansvarlig for projektet. Hvis du klikker på pilen, åbnes en liste over brugere, brugergrupper og ressourcer i databasen.

1. **Type:** Her kan du angive, hvilken type projekt der er tale om. Hvis du klikker på pilen, åbnes en liste over foruddefinerede typer. Dette felt er obligatorisk og **skal** derfor udfyldes. [!include[SM](../../../learn/includes/are-defined-sm.md)]

    > [!NOTE]
    > Nogle projekttyper er knyttet til en [projektguide][2]. Hvis du skifter projekttype, forsvinder den tilknyttede projektguide også. Eventuelle opfølgninger og dokumenter, der er oprettet i forbindelse med projektguiden, bliver fortsat liggende på detaljekortet **Aktiviteter** i dagbogen. Hvis du eventuelt skifter tilbage til den oprindelige projekttype, gendannes tilknytningen mellem opfølgninger/dokumenter og projektguiden.

1. **Status:** Her kan du angive, hvilken status projektet har. Hvis du klikker på pilen, åbnes en liste over foruddefinerede valgmuligheder. [!include[SM](../../../learn/includes/are-defined-sm.md)]

    > [!NOTE]
    > Hvis projektet er knyttet til en [projektguide][2], vises statusserne for projektguiden i dette felt. Når du ændrer en status, for eksempel fra **Planlagt** til **Er i gang**, markeres den første status på detaljekortet **Projektguide** som udført.

1. **Slutdato:** Angiv slutdatoen for projektet i feltet **Slutdato**. Du kan ændre den foreslåede slutdato ved at klikke på pilen ved datoen og vælge en ny dato i den kalender, der vises.

1. **Næste milepæl:** Hvis projektet er tilknyttet en projektguide, viser feltet **Næste milepæl** datoen for næste milepælsopfølgning, som er knyttet til projektet. Er denne dato før dags dato, vises den med rødt. Hvis projektet ikke er knyttet til en projektguide, vises slutdatoen for projektet her. Datoen **Næste milepæl** beregnes automatisk på grundlag af aktiviteter, som er knyttet til projektet eller registreres via projektguiden. Dette er normalt datoen for næste åbne aktivitet i detaljekortet **Aktiviteter** for projektet.

1. **Brugerdefinerede felter:** [!include[3 udef](../../../learn/includes/more-udef.md)]

1. **Udført:** Dette felt angiver, om projektet er udført.

<!-- Referenced links -->
[5]: ../../../learn/basics/duplicates.md
[2]: ../project-guide/index.md

<!-- Referenced images -->
