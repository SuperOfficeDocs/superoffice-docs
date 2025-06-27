---
uid: help-de-request-create
title: Anfrage erstellen
description: Anfrage erstellen
keywords: Anfrage erstellen, neue Anfrage, Anfrage hinzufügen, Anfrageneigenschaften, Nachricht, Ticket
author: Bergfrid Dias
date: 03.11.2025
version: 10.5.3
content_type: howto
license: serviceessentials
audience: person
audience_tooltip: SuperOffice Service
language: de
---

# Anfrage erstellen

Eine Anfrage kann per E-Mail vom Kunden im System eingehen oder manuell über den Bildschirm **Neue Anfrage** registriert werden. Dies ist zum Beispiel der Fall, wenn ein Kunde eine Anfrage telefonisch stellt.

## Schritte

1. Klicken Sie in der oberen Leiste auf **Neu** und wählen Sie **Anfrage**.

    Alternativ können Sie in der Bereichsregisterkarte **Anfragen** eines Persons auf **Hinzufügen** klicken, um eine Anfrage mit dem vorausgefüllten Person zu erstellen.

1. Geben Sie im Feld **Titel** eine aussagekräftige Bezeichnung für die Anfrage ein.

1. Fügen Sie eine Person im Feld **Suche nach Person** hinzu (wenn nicht vorausgefüllt). Beginnen Sie mit der Eingabe des Namens (oder der Telefonnummer) und wählen Sie aus den Ergebnissen.
    * Optional: Sie können diesen Schritt überspringen und die Person später hinzufügen.

1. Nutzen Sie das **Eigenschaften**-Panel auf der rechten Seite, um die Anfrage zuzuweisen und zu priorisieren.

    * Wählen Sie **Anfragetyp**, **Status**, **Eigentümer**, **Kategorie**, **Priorität** und weitere Eigenschaften aus.

    > [!NOTE]
    > Der Anfragetyp beeinflusst Standardwerte sowie verfügbare Status und Prioritäten.

1. Gehen Sie zur Registerkarte **Nachrichten**, um die Mitteilung zu verfassen:

    * Geben Sie im Feld **An** die Empfänger ein. Beginnen Sie mit der Eingabe des Namens oder der E-Mail-Adresse und wählen Sie sie aus der Liste aus.
    * Optional: Klicken Sie auf **Cc/Bcc**, um weitere Empfänger hinzuzufügen.
    * Schreiben Sie die Nachricht, fügen Sie Anhänge hinzu oder verwenden Sie Antwortvorlagen.

    > [!NOTE]
    > Die Standardanfragesignatur wird der Nachricht hinzugefügt. Sie können die Signatur direkt bearbeiten oder Ihre [E-Mail-Signatur][11] anpassen.

1. Wechseln Sie zur Registerkarte **Details**, um die Anfrage optional mit einem bestehenden Verkauf oder Projekt zu verknüpfen.

1. Klicken Sie auf **Senden**, um die Anfrage zu speichern und zu versenden.

![Eigenschaften und Nachricht einer neuen Anfrage -screenshot][img1]

## <a id="fields"></a>Erklärung wichtiger Felder

<a id="message"></a><a id="details"></a>
Die folgenden Felder sind im Anfrageansicht verfügbar. Einige Felder werden automatisch ausgefüllt, während andere manuelle Eingaben erfordern.

> [!NOTE]
> Felder und Layout können basierend auf [Ansichtsdesigner][10] und anderen UI-Anpassungen variieren.

<!-- markdownlint-disable-file MD051 -->
### [Nachrichten-Registerkarte](#tab/messages)

Hier verfassen und verwalten Sie die Anfrage-Nachricht.

* Empfänger im Feld **An** hinzufügen.
  * Empfänger werden automatisch als Kontakt der Anfrage registriert. Der erste Empfänger wird zur Hauptperson.
  * Mehrere Empfänger hinzufügen und per Drag & Drop anordnen.
  * Eine E-Mail-Adresse eingeben, um jemanden zu benachrichtigen, ohne ihn als Kontakt hinzuzufügen.
  * Das Feld leer lassen, wenn keine Nachricht gesendet werden soll.
* **Cc/Bcc** verwenden, um zusätzliche Empfänger hinzuzufügen.
* Nachrichtentext, Anhänge, [Antwortvorlagen][2] oder FAQ-Einträge hinzufügen.
* **Intern/Extern** festlegen, um zu bestimmen, ob die Nachricht im Kundenzentrum sichtbar ist.
* Zeiterfassungstool zur Nachverfolgung der Bearbeitungszeit nutzen.

Der Nachrichteneditor bietet ähnliche Funktionen wie ein Textverarbeitungsprogramm. Hier sind die wichtigsten Tools:

| Symbol | Aktion | Beschreibung |
|:-:|---|---|
| <i class="ph ph-text-a-underline" aria-label="Werkzeugleiste anzeigen/ausblenden"></i> | Werkzeugleiste | Formatierungsoptionen ein- oder ausblenden. |
| <i class="ph ph-paperclip" aria-label="Anhänge"></i> | Anhänge | Dateien oder CRM-Dokumente zur Nachricht hinzufügen. |
| <i class="ph ph-article" aria-label="Einfügen"></i> | Einfügen | [Antwortvorlage][2], FAQ-Eintrag, frühere Nachricht oder Anhang einfügen. |

#### Anhänge

Dateien oder CRM-Dokumente anhängen:

1. Klicken Sie auf <i class="ph ph-paperclip" aria-label="Anhänge"></i>. Ein **Anhänge**-Feld erscheint unter **An**.
1. Anhänge hinzufügen:
    * Klicken Sie auf **Dateien hochladen (oder hier ziehen)**, um eine Datei auszuwählen.
    * Dateien per Drag & Drop ins **Anhänge**-Feld ziehen.
    * **Ein CRM-Dokument auswählen**, um eine Datei aus SuperOffice CRM hinzuzufügen.

#### Einfügen

Zusätzlichen Inhalt in die Nachricht aufnehmen:

1. Klicken Sie auf <i class="ph ph-article" aria-label="Einfügen"></i>.
1. Wählen Sie aus:
    * **Antwortvorlage**: Vorgefertigten Text einfügen.
    * **FAQ-Eintrag**: Einen Wissensdatenbankartikel hinzufügen.
    * **Frühere Nachricht**: Text aus vorheriger Kommunikation übernehmen.
    * **Anhang**: Direkt eine Datei anhängen.
1. Falls Antwortvorlagen in mehreren Sprachen verfügbar sind, kann die gewünschte Sprache ausgewählt werden.

#### Aufgewendete Zeit

Die Zeitmessung startet automatisch bei der Erstellung der Anfrage. Zum Stoppen auf <i class="ph ph-pause" aria-label="Pause"></i> klicken, zum Fortsetzen auf <i class="ph ph-play" aria-label="Start"></i>. Weitere Informationen zur Zeiterfassung finden Sie unter [Zeiterfassung][3].

### [Details-Registerkarte](#tab/details)

Die **Details**-Registerkarte enthält zusätzliche Informationen zur Anfrage. Hier finden Sie automatisch aktualisierte Angaben wie Erstellungsdatum, letzte Änderung, Schließung oder letzte Antwort. Einige Felder können beim Erstellen der Anfrage bearbeitet werden:

* **Beziehung:** Verknüpft die Anfrage mit einer anderen Anfrage.
* **Zugriffsebene:** Steuert die Sichtbarkeit der Anfrage. Änderungen hier wirken sich automatisch auf das **Eigenschaften**-Panel aus.
* **Verkauf/Projekt:** Verknüpft die Anfrage mit einem bestehenden Verkauf oder Projekt.
* **Zusätzliche Felder:** [Benutzerdefinierte Felder][16], die speziell für Ihr Unternehmen konfiguriert wurden.

### [Eigenschaften-Panel](#tab/properties)

Hier werden Kategorie, Priorität und weitere Attribute der Anfrage festgelegt.

* **Anfragetyp:** Legt Standardwerte und verfügbare Statusoptionen fest.
* **Status:** Auf **Offen**, **Geschlossen** oder **Auf Termin gelegt** setzen.
* **Eigentümer:** Sich selbst oder einen anderen Benutzer als Bearbeiter zuweisen.
  * **(Automatisch zugewiesen):** System weist Anfrage basierend auf Regeln zu.
  * **(Nicht zugeordnet):** Kategorienmitglieder teilen sich die Bearbeitung.
* **Kategorie:** Die passende Kategorie für die Anfrage auswählen.
* **Priorität:** **Niedrig**, **Mittel** oder **Hoch** zuweisen oder vom System bestimmen lassen.
* **Zugriffsebene:** **Extern** (sichtbar für den Kontakt) oder **Intern** (nicht sichtbar).
* **Tags:** [Relevante Tags][4] hinzufügen, um die Organisation und Suche zu erleichtern.

***

## Automatische Speicherung

Wenn Sie an einer Anfrage arbeiten und plötzlich eine dringendere Anfrage eingeht, können Sie nicht weiter an der ersten Anfrage arbeiten und kümmern sich um die vorrangige Anfrage.

Mit der automatischen Speicherung werden Ihre Änderungen automatisch gespeichert, bis Sie auf **Senden** klicken, um die Änderungen an der Anfrage zu senden, oder die Änderungen verwerfen.
Automatisch gespeicherte Informationen befinden sich im lokalen Speicher des Browsers, sodass die Daten sogar bei Browser-Absturz, Neustart, Ab- und Anmeldung bestehen bleiben.

Die automatische Speicherung wird standardmäßig aktiviert, wenn Sie Anfragen ansehen und bearbeiten und beantworten/alle beantworten.

### Einschränkungen

* Automatisch gespeicherte Daten werden nicht von einem Computer auf einen anderen übertragen. Das heißt, Sie können nicht im Büro an der Antwort auf eine Anfrage arbeiten und dann zuhause fortfahren.
* Automatisch gespeicherte Daten werden zwischen zwei verschiedenen Browsern nicht weitergegeben.
* Die automatische Speicherung ist sehr nützlich, kann aber das ordnungsgemäße Speichern Ihrer Arbeit nicht ersetzen.

## Verwandte Inhalte

* [E-Mail-Signatur bearbeiten][11]
* [Verwenden von Tags in Anfragen][4]
* [Antwortvorlagen-Variablen][18]
* [Antwortvorlage erstellen][19]

<!-- Referenced links -->
[2]: reply.md#reply-templ
[3]: reply.md#time-spent
[4]: tags.md
[10]: ../../ui/screen-designer/learn/index.md
[11]: ../../learn/getting-started/edit-email-signature.md
[16]: ../../custom-objects/admin/create-extra-field.md
[18]: ../reply-templates/learn/template-variables.md
[19]: ../reply-templates/learn/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/request/create-request.png
