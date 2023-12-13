<!-- markdownlint-disable-file MD041 -->
1. Angiv salgsbeløbet.

2. Vælg salgsvalutaen (hvis denne indstilling er aktiveret).

3. I feltet **Firma** skal du angive det firma, som salget skal knyttes til.

4. Angiv evt. person for firmaet i feltet **Person**.

5. Angiv evt. et projekt, som du vil knytte til salget, i feltet **Projekt**.

6. I den store tekstboks til venstre kan du tilføje en nærmere beskrivelse af salget.

7. I øverste hjørne af fanen **Salg** kan du angive estimeret beløb for salget.

8. I feltet **Ejer** vises den bruger, der er logget på, automatisk. Du kan vælge en anden bruger efter behov.

9. Angiv salgstypen i feltet **Salgstype**. Klik på pilen for at få vist en liste over tilgængelige salgstyper. [!include[SM](../../../learn/includes/are-defined-sm.md)]

    > [!NOTE]
    > Visse salgstyper er tilknyttet en [Salgsguide][1]. Hvis du skifter salgstype, forsvinder den tilknyttede salgsguide også. Eventuelle opfølgninger og dokumenter, der er oprettet i forbindelse med salgsguiden, bliver fortsat liggende på detaljekortet **Aktiviteter** i dagbogen. Hvis du eventuelt skifter tilbage til den oprindelige salgstype, genoprettes tilknytningen mellem opfølgninger/dokumenter og salgsguiden.

10. I feltet **Fase** skal du angive den gældende fase for salget:

    * Hvis salgstypen for salget ikke har tilknyttede faser, har salget status som **Åbent**. Hvis du klikker på pilen, kan du markere salget som **Solgt** eller **Tabt**. Felterne nedenunder ændres i så fald også, så du kan angive dato, konkurrent og årsagen til det [solgte/mistede salg][2].

    * Hvis salgstypen for salget har tilknyttede faser, kan du klikke på pilen for at vælge en salgsfase. En salgstype med forskellige salgsfaser kan være knyttet til en [salgsguide][1] og er foruddefineret i Indstillinger og vedligeholdelse.

    > [!NOTE]
    > Når du ændrer en fase fra for eksempel **Første møde** til **Tilbud**, markeres den første fase på detaljekortet **Salgsguide** som fuldført, med et flueben.

11. Til højre for feltet **Fase** vises et procenttal, der angiver sandsynligheden for, at salget lykkes i denne fase. Det tal er knyttet til fasen og er angivet i Indstillinger og vedligeholdelse. Det kan dog ændres manuelt i SuperOffice CRM, hvis du ønsker det.

12. Du kan vælge afkrydsningsfeltet **Udsat** for at indikere, at salget er blevet [udsat][2]. For eksempel hvis kunden beslutter at vente til næste år med at købe.

    > [!NOTE]
    > Felterne nedenunder ændrer sig, hvis du vælger **Udsat**. **Næste aktivitet** ændres til **Genåbningsdato**, hvor du kan angive en dato for, hvornår salget genåbnes, og **Kilde** ændres til **Årsag (udsat)**, hvor du kan angive årsagen til udsættelsen. Hvis du markerer salget som udsat, vises dialogboksen **Opfølging**, når du klikker på **Gem**. Du kan oprette fremtidige møder eller samtaler for at følge op det udsatte salg.

13. Angiv den sandsynlige salgsdato i feltet **Salgsdato**. For at ændre den foreslåede salgsdato skal du klikke på pilen ud for datoen og vælge en ny dato i den kalender, der vises.

14. Feltet **Næste aktivitet** viser datoen for næste opfølgning, der er tilknyttet salget (den ældste opfølgning, der endnu ikke er udført). Er denne dato før dags dato, vises den med rødt.

15. Angiv salgets kilde i feltet **Kilde**. Hvis du klikker på pilen, vises en liste over de tilgængelige valg.

16. Hvis du klikker i feltet **Synlig for**, vises der en liste, hvor du kan vælge, om salget skal være synligt for alle brugere, være privat (dvs. kun synligt for den bruger, som er defineret som ejer) eller synligt for alle brugere i den brugergruppe, som ejeren tilhører.

17. Hvis salget har statussen **Solgt** eller **Tabt**, kan du markere afkrydsningsfeltet **Udført**.

18. Hvis du markerer afkrydsningsfeltet **Udgiv**, vises salget for eksterne brugere i Audience (kræver egen licens).

<!-- Referenced links -->
[1]: ../sales-guide/index.md
[2]: ../stages.md
