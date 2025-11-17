---
uid: help-no-dashboard-tiles
title: Arbeide med figurer
description: Lær hvordan du legger til, tilpasser og administrerer figurer i SuperOffice-dashbordene dine.
keywords: legg til figur, ny figur, rediger figurm kopier figur, dupliser figur, fjern figur, tilpass figur, datasett, figur, dashbord
author: digitaldiina
date: 11.21.2025
version: 11.6
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: no
redirect_from:
  - /no/dashboard/learn/add-tile
  - /no/dashboard/learn/edit-tile
  - /no/dashboard/learn/remove-tile
---

# Arbeide med figurer

Lær hvordan du legger til, tilpasser og administrerer figurer i SuperOffice-dashbordene dine. Figurer er visuelle sammendrag basert på CRM-data – ideelle for å følge opp saker, salg, aktiviteter eller markedsføringsresultater.

Du kan bruke forhåndsdefinerte figurer eller lage dine egne.

## Forutsetning: gå til layoutmodus

For å administrere figurer må du først gå inn i layoutmodus:

1. Åpne dashbordet du vil tilpasse.

2. Klikk på <i class="ph ph-dots-three-circle-vertical" aria-label="Oppgave-meny"></i> i dashbordoverskriften og velg **Rediger dashbordfigurer**.

    Dashbordet åpnes i layoutmodus:
    * Sidepanelet **Rediger dashbordfigurer** vises til høyre.
    * Hver figur viser et redigeringsikon (<i class="ph ph-pencil" aria-hidden="true"></i>).
    * Du kan legge til, flytte, endre størrelse eller redigere figurer.

## <a id="add"></a>Legge til en figur

1. I sidepanelet **Rediger dashbordfigurer**, velg hvilken type data du vil bruke (for eksempel firma, salg eller sak) i listen **Vis figurer for**.

    ![Velg figurtype i redigeringspanelet -screenshot][img1]

2. Velg en figur fra enten **Bibliotek** (forhåndsdefinerte figurer) eller **Utvalg** (figurer basert på dine egne dynamiske utvalg).

    * Bruk **søkefeltet** for å finne figurer raskt.
    * Hver figur har et ikon som viser typen – for eksempel diagram, liste eller stort tall.

3. Legg til figuren i dashbordet:
    * **Dra og slipp** figuren til en ledig plass.
    * Eller klikk på <i class="ph ph-plus" aria-label="+"></i> som vises når du holder markøren over figurnavnet.

    Figuren justeres automatisk etter tilgjengelig plass og tilpasses dashbordoppsettet.

4. Endre størrelse eller flytt figuren etter behov.

5. Klikk på **Fullført** for å avslutte layoutmodus.

### Lage en figur fra bunnen av

1. Velg **Tom figur** for datatypen du ønsker å visualisere.
2. Legg den til på dashbordet.
3. I dialogboksen **Rediger figur**, skriv inn et beskrivende navn.
4. Gå til fanen **Datasett** og [angi kriteriene][4] som bestemmer hvilke data figuren skal vise.

    ![Rediger figur: datasettfanen -screenshot][img2]

    Denne fanen fungerer på samme måte som [Finn-bildet][5]. Du kan angi filtre som eier, datoperiode eller kategori.

5. Gå til fanen **Layout** for å konfigurere figurens utseende. Velg [diagramtype][3], etiketter, sortering og andre formateringsvalg.

    ![Rediger figur: layoutfanen -screenshot][img3]

6. Klikk på **Lagre**, og deretter på **Fullført** for å avslutte layoutmodus.

### <a id="selection-chart"></a>Om figurer basert på utvalg

Når du legger til en figur fra fanen **Utvalg**, kobles ikke figuren direkte til et levende utvalg. I stedet kopieres datasettet og oppsettet fra [diagrammet som er definert i utvalget][6]. Etter det er figuren og utvalget uavhengige av hverandre.

Fanen **Utvalg** viser kun:

* Dynamiske utvalg
* Utvalg som samsvarer med typen valgt i **Vis figurer for**
* Utvalg der det er lagret et diagram på fanen **Diagram**

Hvis et utvalg mangler i listen, kontroller følgende:

* Er det et statisk utvalg? Statisk utvalg støttes ikke her.
* Samsvarer posttypen (firma, salg osv.) med valgt type?
* Er det definert og lagret et diagram i fanen **Diagram**?

Etter at du har lagt til figuren:

* Endringer i **kriterier** eller **diagram** i utvalget påvirker **ikke** figuren.
* Endringer i **datasett** eller **layout** i figuren påvirker **ikke** utvalget.
* **Figuren holdes ikke synkronisert** med utvalget, men den oppdateres fortsatt dynamisk basert på sitt eget datasett.

Hvis du vil at figuren skal reflektere oppdateringer fra et utvalg, må du enten oppdatere figuren manuelt eller slette og legge den til på nytt fra det oppdaterte utvalget.

### Legge til en webpanelfigur

Bruk denne typen figur for å vise en nettside direkte i dashbordet:

1. Angi **Vis figurer for** til **Annet**.
2. I fanen **Bibliotek**, velg **Webpanel**.
3. Skriv inn nettadressen (URL-en) du vil vise.
4. Hvis adressen bruker HTTP (ikke HTTPS), aktiver **Tillat usikker adresse**.
5. Klikk på **Lagre**, og deretter **Fullført** for å avslutte redigeringsmodus.

### Legge til en HTML-figur

Bruk denne typen figur til å vise formatert tekst i dashbordet. For eksempel en velkomstmelding, en forklaring eller en intern oversikt.

1. Angi **Vis figurer for** til **Annet**.
2. I fanen **Bibliotek**, velg **HTML**.
3. Klikk på **Legg til** for å velge minst ett språk for innholdet.
4. Bruk den innebygde editoren til å skrive og formatere innholdet.

    Du kan bruke de samme formateringsverktøyene som i Chat og Skjemaer. Legg til innhold på flere språk for å sikre at figuren vises korrekt for alle brukere.

5. Klikk på **Lagre**, og deretter **Fullført** for å avslutte redigeringsmodus.

## Redigere en figur

1. Når du er i redigeringsmodus for dashbordet, klikker du på **Rediger**-ikonet (<i class="ph ph-pencil" aria-hidden="true"></i>) på figuren.
2. I **Datasett**-fanen justerer du filtrene etter behov.
3. I **Layout**-fanen velger du diagramtype og visuelle innstillinger.
4. Oppdater figurnavnet for å gjenspeile nye data eller layout.
5. Klikk på <i class="ph ph-translate" aria-label="Translate"></i> for å [legge til oversettelser][7] av figurens tittel og etiketter.
6. Klikk på **Lagre**.

## <a id="copy"></a>Duplisere eller kopiere en figur

Du kan gjenbruke en eksisterende figur ved å duplisere den i samme dashbord eller kopiere den til et annet. Du må ha **redigeringstilgang til måldashbordet** for å kunne kopiere figurer dit.

1. Klikk på <i class="ph ph-dots-three-vertical" aria-label="Tile task menu"></i> på figuren, og velg ønsket alternativ for duplisering eller kopiering.

| Alternativ | Hva det gjør | Neste trinn | Når skal det brukes |
|---|---|---|---|
| **Dupliser figur** | Lager en kopi i samme dashbord. Navnet får et tillegg (f.eks. *Figurnavn 2*). | Rediger den nye figuren: endre navn, datasett eller layout. | Vis samme type data med en annen layout, eller vis lignende data med samme layout. |
| **Kopier figur til dashbord** | Legger til figuren i et annet dashbord. Velg et måldashbord fra listen. Hold markøren over dashbordnavnet for forhåndsvisning. | Åpne måldashbordet og rediger figuren der om nødvendig. | Gjenbruk en nyttig figur du fant i en kollegas dashbord. Legg den til i ditt eget. |

**Kopier til dashbord** er også tilgjengelig utenfor layoutmodus (normal visning).

## <a id="move"></a>Flytte eller endre størrelse på figurer

Mens du er i redigeringsmodus for dashbordet:

* **Dra figuren fra overskriften** for å flytte den til en ny posisjon.
* **Endre størrelsen** ved å dra i nedre kant, høyre kant eller nederste høyre hjørne.

Figurene tilpasses automatisk rutenettet i dashbordet.

For å endre antall kolonner, avslutt redigeringsmodus og oppdater dashbordinnstillingene.

## <a id="remove"></a>Fjerne en figur

Du kan fjerne figurer fra et dashbord hvis du har redigeringstilgang.

1. Mens du er i redigeringsmodus, klikker du på <i class="ph ph-dots-three-vertical" aria-label="Tile task menu"></i> på figuren.
2. Velg **Fjern figur**.
3. Bekreft ved å klikke **OK**.

> [!CAUTION]
> Egendefinerte figurer, som HTML, webpanel og figurer basert på utvalg, slettes permanent når de fjernes. Bare forhåndsdefinerte figurer fra biblioteket kan trygt legges til igjen senere.

## <a id="export"></a>Eksportere figurer

### Last ned eller skriv ut figurrapporten

Klikk på <i class="ph ph-dots-three-vertical" aria-label="Task menu"></i> i overskriften til en figur for å få tilgang til følgende alternativer:

* **Last ned PDF-dokument** / **Last ned PNG-dokument**: Last ned figuren i PDF- eller PNG-format. Eksportfilene lastes ned til nettleseren (**Nedlastinger**-mappen).

    For andre formater (**SVG, CSV og XLS**), velg **Vis i fullskjerm** fra menyen.

* **Skriv ut**: Åpne figuren i utskriftsdialogboksen.

> [!TIP]
> Hvis du vil skjule bestemte data før eksport eller utskrift, klikker du på dataetikettene (forklaring) ved siden av eller under figuren.

### Eksportér ALLE rader i et datasett til Excel

1. Klikk på et datapunkt i figuren for å vise tilhørende data.

    Et nytt vindu åpnes med relaterte oppføringer.

1. Klikk på <i class="ph ph-download-simple" aria-label="Download"></i> **Eksportér** under listen.

1. Klikk på **Ja** for å bekrefte.

    Denne handlingen kan ta litt tid. Du kan fortsette å jobbe i SuperOffice mens du venter. Du blir varslet når eksporten er fullført.

## Tips

* **Skjul valutabetegnelser:** For å spare plass i figurer som viser beløp, kan du angi **Valuta** til **Skjul** i Layout-fanen.

* **Sammenlign med mål:** I salgstabeller kan du aktivere **Sammenlign med mål** i Layout-fanen for å visualisere fremdriften mot salgsbudsjettene. Dette alternativet avhenger av diagramtype og datasettoppsett.

* **Bruk korte tall for bedre lesbarhet:** For figurer med store verdier kan du aktivere formatet **Kort tall** for å vise verdier i millioner (for eksempel *1,2M*).

* **Figurer med store tall:** Bruk disse for viktige nøkkeltall, som omsetning eller åpne saker. Hold figurnavnet kort, slik at tallet fremheves tydelig.

* **Vis varighet i oppfølgingsfigurer:** Når du bruker oppfølgingsfigurer, kan du angi **Mål** til **Varighet** for bedre oversikt over tidsbruk.

## Feilsøking

* **Jeg ser ikke redigeringsikonet på figuren**
  * Er dashbordet i layoutmodus?

* **Jeg finner ikke alternativet jeg leter etter i Oppgave-menyen**
  * Klikket du på riktig Oppgave-knapp? (dashbord vs. figur)
  * Er dashbordet i layoutmodus?

* **Jeg har ikke tilgang til Layout-fanen eller felt**
  * Du har kanskje ikke nødvendige funksjonelle rettigheter. Kontakt systemansvarlig.

* **Et utvalg mangler på fanen Utvalg**
  * Se [Om figurer basert på utvalg](#selection-chart)

* **Jeg fjernet ved et uhell en egendefinert figur**
  * Disse figurene kan ikke gjenopprettes. For å unngå dette kan du kopiere dem til et privat dashbord (for eksempel «Arkiverte figurer») før du sletter dem.

## Relatert innhold

* [Legge til et nytt dashbord][1]
* [Bruke dashbord til å administrere salgspipelinen din][2]

<!-- Referenced links -->
[1]: create.md
[2]: show-sales-targets.md
[3]: index.md#charts
[4]: ../../search-options/learn/search-criteria.md
[5]: ../../search-options/learn/find-screen.md
[6]: ../../search-options/selection/learn/howto/display-as-charts.md
[7]: ../../localization/learn/translate-fields.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/dashboard/edit-dashboard-tiles-sidebar.png
[img2]: ../../../media/loc/en/dashboard/edit-tile-dataset.png
[img3]: ../../../media/loc/en/dashboard/edit-tile-layout.png
