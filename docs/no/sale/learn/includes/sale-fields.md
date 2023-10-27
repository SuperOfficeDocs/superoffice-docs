<!-- markdownlint-disable-file MD041 -->
1. Angi salgsbeløpet.

2. Velg salgsvaluta (hvis dette alternativet er aktivert).

3. I feltet **Firma** angir du firmaet salget skal knyttes til.

4. Angi eventuell person for firmaet i feltet **Person**.

5. Angi eventuelt prosjekt som du vil knytte til salget, i feltet **Prosjekt**.

6. I den store tekstboksen til venstre kan du legge inn en nærmere beskrivelse av salget.

7. Oppe til høyre i **Salg**-fanen kan du angi et estimert salgsbeløp.

8. I feltet **Eier** vises automatisk pålogget bruker. Du kan velge en annen bruker her hvis du ønsker det.

9. Angi salgstypen i feltet **Salgstype**. Klikk på pilen for å vise en liste over tilgjengelige salgstyper. [!include[SM](../../../learn/includes/are-defined-sm.md)]

    > [!NOTE]
    > Noen salgstyper er tilknyttet en [salgsguide][1]. Hvis du bytter salgstype, forsvinner også den tilknyttede salgsguiden. Eventuelle oppfølginger og dokumenter opprettet i forbindelse med salgsguiden blir fortsatt liggende på detaljkortet **Aktiviteter** i dagboken. Hvis du eventuelt bytter tilbake til den opprinnelige salgstypen, gjenopprettes tilknytningen mellom oppfølginger/dokumenter og salgsguiden.

10. I feltet **Fase** angir du gjeldende fase for salget:

    * Hvis salgstypen for salget ikke har tilknyttede faser, har salget status som **Åpent**. Hvis du klikker på pilen, kan du sette salget til **Solgt** eller **Tapt**. Da endres også feltene nedenfor, slik at du kan angi dato, konkurrent og årsak for det [solgte/tapte salget][2].

    * Hvis salgstypen for salget har tilknyttede faser, kan du klikke på pilen for å velge en salgsfase. En salgstype med forskjellige salgsfaser kan være knyttet til en [salgsguide][1] og er forhåndsdefinert i Innstillinger og vedlikehold.

    > [!NOTE]
    > Når du endrer en fase, for eksempel fra **Første møte** til **Tilbud**, merkes den første fasen i detaljkortet **Salgsguide**som utført, med en hake.

11. Til høyre for **Fase**-feltet vises det et prosenttall som angir sannsynligheten for at salget skal lykkes i denne fasen. Dette er knyttet til fasen og er angitt i Innstillinger og vedlikehold. Du kan imidlertid endre det manuelt i SuperOffice CRM, hvis du vil.

12. I avmerkingsboksen **Utsatt** kan du merke av for om salget er [utsatt][2]. For eksempel hvis kunden bestemmer seg for å vente til neste år med å kjøpe.

    > [!NOTE]
    > Feltene nedenfor endrer seg hvis du merker av for **Utsatt**. **Neste aktivitet** endres til **Gjenåpningsdato**, der du kan angi en dato for når salget gjenåpnes, og **Kilde** endres til **Årsak (utsatt)**, der du kan angi årsaken til utsettelsen. Hvis du merker salget som utsatt, vises dialogboksen **Oppfølging** når du klikker på **Lagre**. Her kan du sette opp fremtidige møter eller samtaler for å følge opp det utsatte salget.

13. Angi antatt salgsdato i feltet **Salgsdato**. Hvis du vil endre den antatte salgsdatoen, klikker du på pilen ved datoen og velger en ny dato i kalenderen som vises.

14. Feltet **Neste aktivitet** viser datoen for neste oppfølging som er tilknyttet salget (den eldste oppfølgingen som ikke er utført ennå). Er denne datoen før dagens dato, vises den med rødt.

15. Angi kilden for salget i feltet **Kilde**. Hvis du klikker på pilen, vises en liste over de tilgjengelige valgene.

16. Hvis du klikker i feltet **Synlig for**, vises det en liste der du kan velge om utvalget skal være synlig for alle, være privat (bare være synlig for den som er definert som eier) eller være synlig for alle i en av gruppene som eieren er medlem av.

17. Hvis salget har statusen **Solgt** eller **Tapt**, kan du merke av i boksen **Utført**.

18. Hvis du merker av i boksen **Publiser**, vises salget for eksterne brukere i Audience (krever egen lisens).

<!-- Referenced links -->
[1]: ../sales-guide/index.md
[2]: ../stages.md
